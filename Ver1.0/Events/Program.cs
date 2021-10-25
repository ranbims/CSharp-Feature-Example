using System;

namespace Events
{
    class Program
    {
        public class CustomEventArgs : EventArgs
        {
            public string Message { get; }

            public CustomEventArgs(string message)
            {
                Message = message;
            }
        }

        public static event EventHandler<CustomEventArgs> EventHandler;

        static void Main(string[] args)
        {
            EventHandler += Program_EventHandler_1;
            EventHandler += Program_EventHandler_1;
            EventHandler += Program_EventHandler_3;
            EventHandler += Program_EventHandler_2;
            EventHandler?.Invoke(new object(), new CustomEventArgs("Hello apple"));

            EventHandler -= Program_EventHandler_1;
            EventHandler -= Program_EventHandler_2;
            EventHandler?.Invoke(new object(), new CustomEventArgs("Hello bear"));

            EventHandler -= Program_EventHandler_1;
            EventHandler -= Program_EventHandler_3;
            EventHandler?.Invoke(new object(), new CustomEventArgs("Hello car"));
        }

        private static void Program_EventHandler_1(object sender, CustomEventArgs e)
        {
            Console.WriteLine("This is event hanlder 1, message: " + e.Message);
        }

        private static void Program_EventHandler_2(object sender, CustomEventArgs e)
        {
            Console.WriteLine("This is event hanlder 2, message: " + e.Message);
        }

        private static void Program_EventHandler_3(object sender, CustomEventArgs e)
        {
            Console.WriteLine("This is event hanlder 3, message: " + e.Message);
        }
    }
}
