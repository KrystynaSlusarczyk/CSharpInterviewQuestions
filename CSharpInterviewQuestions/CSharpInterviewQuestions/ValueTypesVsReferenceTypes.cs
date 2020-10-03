using System;

namespace CSharpInterviewQuestions
{
    class ValueTypesVsReferenceTypes
    {
        public static void Run()
        {
            int number = 5;
            int otherNumber = number;
            number++;

            Console.WriteLine($"The number is {number}");
            Console.WriteLine($"The otherNumber is {otherNumber}");

            var person = new Person { Age = 20 };
            var person2 = person; //should be rather called "otherReferenceToTheSamePerson"
            person2.Age = 30;

            Console.WriteLine($"The age of the person is {person.Age}, but it was 20 before.");

            Console.ReadKey();
        }

        class Person
        {
            public int Age;
        }
    }
}
