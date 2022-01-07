using System;

namespace Interfacing_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //we can use an interface to make instances of its implemented classes

            //IContainer a = new Bottle();
            //IColorable b = new Bottle();
            //ICloseable c = new Bottle();

            //a.AddContent(3);
            //a.RemoveContent(2);
            //var capacity = a.Capacity;

            //var color = b.Color;

            //c.Open();
            //c.Close();

            Bottle btl = new CorneredBottle();
            //btl.Open();

            
            CorneredBottle cb = new CorneredBottle();
            cb.Open();

            /*
             * IEnumerable make an object enumerable, so that the object itself can iterable
             */
            ShoppingCart cart = new ShoppingCart();

            foreach(var item in cart)
            {

            }

            /*
             * IClonable help us to copy an object into an other object
             */
            ShoppingCart cartTwo = (ShoppingCart)cart.Clone();


            /*
             *IDisposable
             *using keyword will automatically call the dispose() method
             *when the object will go outside of its scope
             */
            using ShoppingCart cart3 = new ShoppingCart();
        }
    }
}
