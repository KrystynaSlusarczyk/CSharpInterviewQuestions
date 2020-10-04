using System;

namespace CSharpInterviewQuestions
{
    class RefAndOut
    {
        public static void Run()
        {
            int number = 5;

            ModifyWithoutRef(number);
            Console.WriteLine($"Number after ModifyWithoutRef: {number}"); 

            ModifyWithRef(ref number);
            Console.WriteLine($"Number after ModifyWithRef: {number}");

            int nonInitializedNumber;
            //ModifyWithRef(ref nonInitializedNumber); //does not compile. The error is "Use of unassigned local variable 'nonInitializedNumber'"

            SetValueWithOut(out nonInitializedNumber);
            Console.WriteLine($"nonInitializedNumber after SetValueWithOut: {number}");
            SetValueWithOut(out number);
            Console.WriteLine($"Number after SetValueWithOut: {number}");

            string numberAsString = "1";
            int parsedNumber;
            bool wasParsingSuccessful = int.TryParse(numberAsString, out parsedNumber);
            Console.WriteLine($"The parsing {(wasParsingSuccessful ? "was" : "was not")} successful, the parsed number is {parsedNumber}");
        }

        static void ModifyWithoutRef(int number)
        {
            ++number;
        }

        static void ModifyWithRef(ref int number)
        {
            ++number;
        }
        static void SetValueWithOut(out int nonInitializedNumber)
        {
            nonInitializedNumber = 10;
        }

        //static void SetValueWithOut(out int nonInitializedNumber) //does not compile. The error is "The out parameter 'nonInitializedNumber' must be assigned to before control leaves the current method"
        //{           
        //}
    }
}
