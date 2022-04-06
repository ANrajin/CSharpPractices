using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EventsInCsharp
    {
        //step-01: define a delegate for event
        public delegate void Receiver(string name, string message);

        //step-02: define an event by the delegate variable
        //public event Receiver Subscriber;
        public Action<string, string>? Subscriber;

        public void Run()
        {
            Subscriber += SMSSubscriber;
            Subscriber += EmailSubscriber;
            Subscriber += MMSSubscriber;

            Subscriber.Invoke("Rajin", "This is a test message");

            Console.WriteLine("-------------------------------");

            Subscriber -= EmailSubscriber;
            Subscriber.Invoke("Ahmad", "This is test message for you");
        }

        private void SMSSubscriber(string name, string message)
        {
            Console.WriteLine($"SMS: Hello {name}, {message}");
        } 

        private void EmailSubscriber(string name, string message)
        {
            Console.WriteLine($"Email: Hello {name}, {message}");
        }
        
        private void MMSSubscriber(string name, string message)
        {
            Console.WriteLine($"MMS: Hello {name}, {message}");
        }
    }
}
