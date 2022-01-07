using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsInCSharp
{
    public class MyEvent
    {
        public delegate void Receive(string receipant, string message);

        public static event Receive Subscribe;

        public static event Action Call;
        
        public void Run()
        {
            Subscribe += EmailSubscriber;
            Subscribe += SmsSubscriber;

            Subscribe.Invoke("Rajin", "Hello world");

            Call += MmsSubscriber;
            Call.Invoke();
        }

        private static void EmailSubscriber(string receipant, string message)
        {
            Console.WriteLine($"Sending Email to {receipant}, Message: {message}");
        }

        private static void SmsSubscriber(string receipant, string message)
        {
            Console.WriteLine($"Sending sms to {receipant}, Message: {message}");
        }

        private static void MmsSubscriber()
        {
            Console.WriteLine("Hello From parameterless event");
        }
    }
}
