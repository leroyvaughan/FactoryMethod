using System;
using TargetPractice.Bubbles;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets make some bubbles!\r\n");

            Console.WriteLine("These will be made using the Template Method");
            Console.WriteLine("----------------------------------------\r\n");
            BlueBubble BlueBubble = new BlueBubble();
            GreenBubble GreenBubble = new GreenBubble();
            RedBubble RedBubble = new RedBubble();

            Console.WriteLine("\r\nNow let's use the Factory Method!");
            Console.WriteLine("----------------------------------------\r\n");

            //This is where the Factory is setup and then used to create the bubbles.
            BubbleFactory MyFactory = new BubbleFactory();
            MyFactory.CreateBubble(1);
            MyFactory.CreateBubble(2);
            MyFactory.CreateBubble(3);

            Console.ReadKey();
        }
    }
}
