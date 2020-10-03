using System;

namespace CSharpInterviewQuestions
{
    class ClassVsStruct
    {
        public static void Run()
        {
            var personStruct = new PersonStruct { Age = 20 };
            var personClass = new PersonClass { Age = 20 };

            AddAge(personStruct);
            AddAge(personClass);

            Console.WriteLine($"The person from the struct is {personStruct.Age} years old.");
            Console.WriteLine($"The person from the class is {personClass.Age} years old.");
            Console.ReadKey();
        }

        static void AddAge(PersonStruct person)
        {
            person.Age += 10;
        }

        static void AddAge(PersonClass person)
        {
            person.Age += 10;
        }

        struct PersonStruct
        {
            public PersonStruct(int age) 
            {
                Age = age;
            }

            public int Age;

            //public PersonStruct() //does not compile! The error is "Structs cannot contain explicit parameterless constructors"
            //{
            //  Age = 0;
            //}

            //public PersonStruct(int age) //does not compile! The error is "Field 'ClassVsStruct.PersonStruct.Age' must be fully assigned before control is returned to the caller"
            //{
            //}
        }

        class PersonClass
        {
            public PersonClass()
            {
                Age = 0;
            }

            public int Age;
        }
    }
}
