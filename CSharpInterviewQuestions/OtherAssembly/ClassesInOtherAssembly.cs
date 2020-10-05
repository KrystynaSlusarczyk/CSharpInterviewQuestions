using CSharpInterviewQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherAssembly
{
    public class ClassesInOtherAssembly
    {
        void Run()
        {
            Console.WriteLine(MainClass.PublicInt);
            //Console.WriteLine(MainClass.InternalInt); // internal - only available in the same assembly
            //Console.WriteLine(MainClass.ProtectedInt); //protected - only available in inheriting classes
            //Console.WriteLine(MainClass.ProtectedInternalInt); // protected internal - only available in inheriting classess OR in the same assembly
            //Console.WriteLine(MainClass.PrivateProtectedInt); // private protected - only available in the same assembly, in the inheriting classes
            //Console.WriteLine(MainClass.PrivateInt); // private - not available anywhere outside it's declaring class
        }
    }

    class InheritingClassInTheOtherAssembly : MainClass
    {
        void Run()
        {
            Console.WriteLine(MainClass.PublicInt);
            //Console.WriteLine(MainClass.InternalInt); // internal - only available in the same assembly
            Console.WriteLine(MainClass.ProtectedInt);
            Console.WriteLine(MainClass.ProtectedInternalInt);
            //Console.WriteLine(MainClass.PrivateProtectedInt); // private protected - only available in the same assembly, in the inheriting classes
            //Console.WriteLine(MainClass.PrivateInt); // private - not available anywhere outside it's declaring class
        }
    }
}
