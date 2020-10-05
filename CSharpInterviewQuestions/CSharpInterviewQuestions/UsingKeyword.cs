using System; //so we can use types defined in System namespace
using System.IO;
using static System.Math; //so we can use math functions without specifying the full type name
using MyAliasForGenericsBecauseIDontLikeTheOriginalName = System.Collections.Generic; //to change the name for something that works better of us
using Generics = System.Collections.Generic; //to make the name shorter

//if we had the below 2 lines uncommented, the "new HellowWriter()" would give us an error saying "'HelloWriter' is an ambiguous reference between 'CSharpInterviewQuestions.Others.Namespace1.HelloWriter' and 'CSharpInterviewQuestions.Others.Namespace2.HelloWriter'"
//using CSharpInterviewQuestions.Others.Namespace1;
//using CSharpInterviewQuestions.Others.Namespace2;

//instead, we can specify an alias:
using HelloWriter = CSharpInterviewQuestions.Others.Namespace1.HelloWriter; //as an alias, because we have HelloWriter class in two different namespaces

namespace CSharpInterviewQuestions
{
    class UsingKeyword
    {
        public static void Run()
        {
            Console.WriteLine($"Square root of 9 is {Sqrt(9)}"); //we don't need to write Math.Sqrt because we used "using static Math;"
            var list = new MyAliasForGenericsBecauseIDontLikeTheOriginalName.List<int>();

            new HelloWriter().WriteHello();
            new Others.Namespace2.HelloWriter().WriteHello();

            string manyLines = @"
Five little ducks paddling to shore,
One paddled away, then there were four;
Four little ducks paddling toward me,
One paddled away, then there were three;
Three little ducks paddling toward you,
One paddled away, then there were two;
Two little ducks paddling in the sun,
One paddled away, then there was none!
";

            using (var reader = new StringReader(manyLines)) //to define a scope in which the IDisposable object will be used and disposed afterwards
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }
        }
    }

}
