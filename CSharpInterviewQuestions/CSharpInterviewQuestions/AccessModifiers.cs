using System;

namespace CSharpInterviewQuestions
{
    public class MainClass
    {
        public const int PublicInt = 1;
        internal const int InternalInt = 2;
        protected const int ProtectedInt = 3;
        protected internal const int ProtectedInternalInt = 4;
        private protected const int PrivateProtectedInt = 5;
        private const int PrivateInt = 6;

        void Run()
        {
            Console.WriteLine(MainClass.PublicInt);
            Console.WriteLine(MainClass.InternalInt);
            Console.WriteLine(MainClass.ProtectedInt);
            Console.WriteLine(MainClass.ProtectedInternalInt);
            Console.WriteLine(MainClass.PrivateProtectedInt);
            Console.WriteLine(MainClass.PrivateInt);
        }
    }

    //see ClassesInOtherAssembly.cs file defined in "OtherAssembly" project
    class OtherClassInTheSameAssembly
    {
        void Run()
        {
            Console.WriteLine(MainClass.PublicInt);
            Console.WriteLine(MainClass.InternalInt);
            //Console.WriteLine(MainClass.ProtectedInt); //protected - only available in inheriting classes
            Console.WriteLine(MainClass.ProtectedInternalInt);
            //Console.WriteLine(MainClass.PrivateProtectedInt); // private protected - only available in the same assembly, in the inheriting classes
            //Console.WriteLine(MainClass.PrivateInt); // private - not available anywhere outside it's declaring class
        }
    }

    class InheritingClassInTheSameAssembly : MainClass
    {
        void Run()
        {
            Console.WriteLine(MainClass.PublicInt);
            Console.WriteLine(MainClass.InternalInt);
            Console.WriteLine(MainClass.ProtectedInt); 
            Console.WriteLine(MainClass.ProtectedInternalInt);
            Console.WriteLine(MainClass.PrivateProtectedInt); 
            //Console.WriteLine(MainClass.PrivateInt); // private - not available anywhere outside it's declaring class
        }
    }
}
