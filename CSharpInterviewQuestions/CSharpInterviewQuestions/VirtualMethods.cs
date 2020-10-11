using System;

namespace CSharpInterviewQuestions
{
    class VirtualMethods
    {
        public static void Run()
        {
            var user = new User(1, "user@gmail.com", false);
            Console.WriteLine(user);

            var dog = new Dog();
            var duck = new Duck();

            Console.WriteLine(dog.Describe());
            Console.WriteLine(duck.Describe());

            Console.WriteLine(dog.Move());
            Console.WriteLine(duck.Move());
        }

        class User
        {
            public int Id { get; }
            public string Email { get; }
            public bool IsActive { get; }

            public User(int id, string email, bool isActive = false)
            {
                Id = id;
                Email = email;
                IsActive = isActive;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Email: {Email} ({(IsActive ? "Active" : "Not active")})";
            }
        }

        abstract class Animal
        {
            protected int _legsCount;

            public virtual string Describe()
            {
                return $"I'm an animal with {_legsCount} legs.";
            }

            public abstract string Move();
        }

        class Dog : Animal
        {
            public Dog()
            {
                _legsCount = 4;
            }

            public override string Move()
            {
                return "Running only, sometimes swimming.";
            }
        }

        class Duck : Animal
        {
            public Duck()
            {
                _legsCount = 2;
            }

            public override string Describe()
            {
                return $"I'm an animal with {_legsCount} legs and 2 wings. Quack, quack, I'm a duck.";
            }

            public override string Move()
            {
                return "Walking, swimming, diving, flying. I can do it all... B-)";
            }
        }
    }
}
