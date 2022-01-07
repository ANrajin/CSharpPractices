using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Reflections
{
    class Program
    {
        const string informationAttributeTypeName = "UTILITYFUNCTIONS.INFORMATIONATTRIBUTE";

        static void Main(string[] args)
        {
            string TargerAssemblyFileName = "UtilityFunctions.dll";
            string TargetNamespace = "UtilityFunctions";

            //load the Assembly form the current Appdomain(from the Solution)
            Assembly assembly = Assembly.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TargerAssemblyFileName));

            //get the class who has Custom Attribute from the loaded assembly and Make a list
            List<Type> classes = assembly.GetTypes().Where(t => t.Namespace == TargetNamespace && HasInformationAttribute(t)).ToList();

            WritePromptMessage("Please press the number key associated with the class you wish to test");

            //Display the classess of that library
            DisplayProgramElementList<Type>(classes);

            //Get the class choice by user
            Type classChoice = ReturnProgramElementReferenceFromList(classes);

            //Create the instance of choosen class
            
            object classInstance = Activator.CreateInstance(classChoice, null);
            Console.Clear();

            //We can pass Type as argument for MemberInfo as The type class inherite from MemberInfo class
            DisplayElementDescription(ReturnCustomAttributeDescription(classChoice));
            WriteHeadingToScreen($"Class: {classChoice}");

            //Fetch the methods of choosen class
            WritePromptMessage("Please enter the number associated with the method you wish to test");
            List<MethodInfo> methods = classChoice.GetMethods().Where(m => HasInformationAttribute(m)).ToList();

            //Display the methods available in choosen class
            DisplayProgramElementList<MethodInfo>(methods);

            //Let the use choose the method
            MethodInfo choosedMethod = ReturnProgramElementReferenceFromList<MethodInfo>(methods);

            if(choosedMethod is not null)
            {
                Console.Clear();
                DisplayElementDescription(ReturnCustomAttributeDescription(choosedMethod));
                WriteHeadingToScreen($"Class: '{classChoice}' - Method: {choosedMethod.Name}");

                //Fetch the parameters of the choosen method
                ParameterInfo[] parameterInfos = choosedMethod.GetParameters().ToArray();

                object result = GetResult(classInstance, choosedMethod, parameterInfos);

                DisplayResultToScreen(result);
            }

        }

        private static void DisplayElementDescription(string des)
        {
            if(des is not null)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(des);
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        private static string ReturnCustomAttributeDescription(MemberInfo memberInfo)
        {
            string _result = default;
            const string CustomAttributeDisplayPropertyName = "Description";

            foreach(Attribute attribute in memberInfo.GetCustomAttributes())
            {
                Type type = attribute.GetType();

                if(type.ToString().ToUpper() == informationAttributeTypeName)
                {
                    PropertyInfo propertyInfo = type.GetRuntimeProperty(CustomAttributeDisplayPropertyName);

                    if(propertyInfo is not null && propertyInfo.GetValue(attribute, null) is not null)
                    {
                        return propertyInfo.GetValue(attribute, null).ToString();
                    }
                }
            }

            return _result;
        }

        private static bool HasInformationAttribute(MemberInfo memberInfo)
        {
            foreach(Attribute attribute in memberInfo.GetCustomAttributes())
            {
                //get the type of the attribute
                Type type = attribute.GetType();
                return type.ToString().ToUpper().Equals(informationAttributeTypeName);
            }

            return false;
        }

        public static void DisplayResultToScreen(object result)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Result: {result}");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static object GetResult(Object classInstance, MethodInfo methodInfo, ParameterInfo[] parameterInfos)
        {
            object result = default;

            //if the method doesnot require any parameter then invoke it
            if(parameterInfos.Length == 0)
            {
                result = methodInfo.Invoke(classInstance, null);
            }
            //If the method requires parameter
            else
            {
                object[] parametersValue = GetParameterValueInputsAsObjectOfArray(parameterInfos);
                result = methodInfo.Invoke(classInstance, parametersValue);
            }

            return result;
        }

        private static object[] GetParameterValueInputsAsObjectOfArray(ParameterInfo[] parameterInfos)
        {
            object[] paramValues = new object[parameterInfos.Length];

            int index = 0;

            foreach(ParameterInfo parameterInfo in parameterInfos)
            {
                WritePromptMessage($"Please provide me the value for '{parameterInfo.Name}' parameter:");

                if (parameterInfo.ParameterType == typeof(string))
                {
                    paramValues[index] = Console.ReadLine();
                }
                else if(parameterInfo.ParameterType == typeof(int))
                {
                    paramValues[index] = int.Parse(Console.ReadLine());
                }
                else if(parameterInfo.ParameterType == typeof(double))
                {
                    paramValues[index] = double.Parse(Console.ReadLine());
                }

                index++;
            }

            return paramValues;
        }

        private static void DisplayProgramElementList<T>(List<T> items)
        {
            int index = 0;

            foreach (T classItem in items)
            {
                Console.WriteLine($"{++index}. {classItem}");
            }
        }

        private static T ReturnProgramElementReferenceFromList<T>(List<T> items)
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey)
            {
                case ConsoleKey.D1:
                    return items[0];
                case ConsoleKey.NumPad1:
                    return items[0];

                case ConsoleKey.D2:
                    return items[1];
                case ConsoleKey.NumPad2:
                    return items[1];

                case ConsoleKey.D3:
                    return items[2];
                case ConsoleKey.NumPad3:
                    return items[2];

                case ConsoleKey.D4:
                    return items[3];
                case ConsoleKey.NumPad4:
                    return items[3];
            }

            return default;
        }

        private static void WriteHeadingToScreen(string heading)
        {
            Console.WriteLine(heading);
            Console.WriteLine(new string('-', heading.Length));
            Console.WriteLine();
        }

        private static void WritePromptMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
