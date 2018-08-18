using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public static class UI
    {
        public static int GetUserIntegerInput(string question)
        {
            Console.WriteLine(question);

            int response;
            while (!int.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Please enter an integer. " + question);
            }

            return response;
        }
    }
}
