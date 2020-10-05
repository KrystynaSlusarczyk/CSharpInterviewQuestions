using System;
using System.Collections.Generic;

namespace CSharpInterviewQuestions
{
    class IsVsAs
    {
        public static void Run()
        {
            object text = "abc";
            bool isString = text is string;
            Console.WriteLine($"{text} {(isString ? "is" : "is not")} a string");

            string asString = text as string;
            if (asString != null)
            {
                Console.WriteLine($"{text} was successfully cast to a string");
            }

            List<string> listOfStrings = text as List<string>; 
            if(listOfStrings == null)
            {
                Console.WriteLine($"{text} could not be cast to a list of strings, it gave a null value");
            }

            try
            {
                List<string> listOfStringsClassicCast = (List<string>)text;
            }
            catch(InvalidCastException)
            {
                Console.WriteLine($"Classic casting of {text} to a list of strings caused an exception");
            }
        }
    }
}
