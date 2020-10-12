

using System;

namespace CSharpInterviewQuestionsTests
{
    //see the FIRSTPrinciplesTests.cs
    public class ClassToBeTested
    {
        public int Count { get; private set; } = 0;

        public void PerformOperationTaking1Second()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public void RaiseCountBy1()
        {
            Count++;
        }

        public DateTime GetDateTimeToday()
        {
            return DateTime.Now.Date;
        }

        public double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
