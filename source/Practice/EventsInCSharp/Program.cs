using System;

namespace EventsInCSharp
{
    class Program
    {
        //step 01: Declare a delegate
        public delegate void Receive(string receipent, string message);

        //step 02: Declare an event
        public static event Receive Subscribe;

        //Event declare with built in Delegate
        public static event Action<string, string> Subscribe2;

        static void Main(string[] args)
        {
            //Subscribe += SMSSubscribe;
            //Subscribe += EmailSubscribe;

            //Subscribe.Invoke("Rajin", "Hello from C#");

            //Console.WriteLine();

            //Subscribe += MMSSubscribe;
            //Subscribe.Invoke("Rajin", "Hello Dolly");

            //Console.WriteLine();

            //Subscribe += VoiceSubscriber;
            //Subscribe -= EmailSubscribe;

            ////if Subscribe is not null then call delegate
            //Subscribe?.Invoke("kalam", "Hello from Visual Studio");

            MyEvent mev = new MyEvent();
            mev.Run();
        }

        private static void VoiceSubscriber(string receipent, string message)
        {
            Console.WriteLine($"Sending Voice mail to: {receipent}, message: {message}");
        }

        private static void MMSSubscribe(string receipent, string message)
        {
            Console.WriteLine($"Sending MMS to: {receipent}, message: {message}");
        }

        private static void EmailSubscribe(string receipent, string message)
        {
            Console.WriteLine($"Sending Email to: {receipent}, message: {message}");
        }

        private static void SMSSubscribe(string receipent, string message)
        {
            Console.WriteLine($"Sending SMS to: {receipent}, message: {message}");
        }
    }
}
