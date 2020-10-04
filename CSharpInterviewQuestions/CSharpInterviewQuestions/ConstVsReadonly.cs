using System;

namespace CSharpInterviewQuestions
{
    class ConstVsReadonly
    {
        public static void Run()
        {
            var bobsGreeter = new Greeter("Bob");
            Console.WriteLine(bobsGreeter.Greet());


            var johnsGreeter = new Greeter("John");
            Console.WriteLine(johnsGreeter.Greet());
        }

        class Greeter
        {
            const string Greeting = "Hello";
            readonly string Name;

            public Greeter(string name)
            {
                Name = name;
            }

            public string Greet()
            {
                return $"{Greeting}, {Name}";
            }
        }

        class MathUtils
        {
            const float Pi = 3.14f;
            //const float Pi { get; } not working, can't have const property
            //const float Pi2; //does not compile. The error is " A const field requires a value to be provided"

            const float PiDoubled = 2 * Pi;
            readonly float E = 2.71f;

            float GetTripledPiTimesE()
            {
                const float multiplier = 3;
                return Pi * multiplier * E;
            }
        }
    }
}
