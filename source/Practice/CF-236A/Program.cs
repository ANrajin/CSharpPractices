using System;

namespace CF_236A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-236A : Boy or Girl
            string name = Console.ReadLine();

            for (var i = 0; i < name.Length; i++)
            {
                string newName = name.Remove(name.IndexOf(name[i]), 1);

                for (var j = 0; j < newName.Length; j++)
                {
                    if (name[i] == newName[j])
                    {
                        int lastIndex = name.LastIndexOf(newName[j].ToString());
                        name = name.Remove(lastIndex, 1);
                    }
                }
            }

            if ((name.Length % 2) == 1)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }

        }
    }
}