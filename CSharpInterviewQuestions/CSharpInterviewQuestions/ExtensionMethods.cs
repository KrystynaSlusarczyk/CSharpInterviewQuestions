using System;
using System.Linq;

namespace CSharpInterviewQuestions
{
    public class ExtensionMethods
    {
        public static void Run()
        {
            string word = "abracadabra";
            Console.WriteLine($"In the \"{word}\" word there are {word.CountHowManyLettersA()} letters A");

            DateTime date = DateTime.Today;
            Console.WriteLine($"Today {(date.IsDayOfWeek(DayOfWeek.Monday) ? "is" : "is not")} Monday");

            var dog = new Dog();
            Console.WriteLine(dog.MakeSoundThreeTimes());
            Console.WriteLine(DogExtensions.MakeSoundThreeTimes(dog));

            Console.WriteLine(dog.Play()); 
        }
    }

    public static class StringExtensions
    {
        public static int CountHowManyLettersA(this string input)
        {
            return input.Count(letter => letter == 'A' || letter == 'a');
        }
    }

    public static class DateTimeExtensions
    {
        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }

    public class Dog
    {
        public string MakeSound()
        {
            return "Woof";
        }

        public string Play()
        {
            return "Fetching a stick";
        }
    }

    public static class DogExtensions
    {
        public static string MakeSoundThreeTimes(this Dog dog)
        {
            return string.Join(",", Enumerable.Repeat(0, 3).Select(_ => dog.MakeSound()));
        }

        public static string Play(this Dog dog)
        {
            return "Chasing a ball";
        }
    }
}
