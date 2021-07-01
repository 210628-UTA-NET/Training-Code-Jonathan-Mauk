using System;

namespace Delegate
{

    class Delegate
    {
        //This is creating a delegate method
        public delegate void Del(string message);

        // this is a simple method that takes a string and writes it to the console
        public static void WriteMessage(string message) 
        {
            System.Console.WriteLine(message);
        }
        // This is a method that writes a message to the console in ALL CAPS
        public static void WriteMessageCaps(string message)
        {
            System.Console.WriteLine(message.ToUpper());
        }
        // This is a method that writes a message with a space between each character
        public static void WriteMessageSpace(string message)
        {
            char[] ch = message.ToCharArray();
            foreach (char c in ch)
            {
                Console.Write(c);
                Console.Write(" ");
            }
             Console.Write("\n");
        }
        
        public static void readMessage(Del callback)
        {
            Console.WriteLine("Input message: ");
            string message = Console.ReadLine();
            callback(message);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Assign the WriteMessage method to a Del variable named handler
            Del handler1 = WriteMessage;
            Del handler2 = WriteMessageCaps;
            Del handler3 = WriteMessageSpace;  
            // Add all of the delegates together
            Del handlerall = handler1 + handler2 + handler3;
            // Output how many methods are in the handlerall invocation list
            Console.WriteLine(handlerall.GetInvocationList().GetLength(0));
            // Call the readMessage method using the delegate handlerall as the parameter
            readMessage(handlerall);

            handlerall -= handler1; // handlerall = handlerall - handler1
            // Output how many methods are in the handlerall invocation list
            Console.WriteLine(handlerall.GetInvocationList().GetLength(0));
            // Call the readMessage method using the delegate handlerall as the parameter
            readMessage(handlerall);

        }
    }
}
