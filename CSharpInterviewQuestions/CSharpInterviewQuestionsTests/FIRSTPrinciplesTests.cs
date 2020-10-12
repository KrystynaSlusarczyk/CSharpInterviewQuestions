using NUnit.Framework;
using System;

namespace CSharpInterviewQuestionsTests
{
    [TestFixture]
    class FIRSTPrinciplesTests
    {
        private readonly ClassToBeTested _cut = new ClassToBeTested();

        [SetUp]
        //this method is run before each test's execution
        public void SetUp()
        {

        }

        [Test]
        //solution would be hiding the time-consuming operation behind an interface, and mocking it
        public void ThisTestIsNot_Fast()
        {
            Assert.DoesNotThrow(() =>
            {
                for (int i = 0; i < 5; ++i)
                {
                    _cut.PerformOperationTaking1Second();
                }
            });
        }

        [Test]
        public void TheTestBelow_ReliesOnMe()
        {
            _cut.RaiseCountBy1();
            Assert.AreEqual(1, _cut.Count);
        }

        [Test]
        //this test relies on the test above
        //if we deleted the test above, or executed it as second, this test here would stopw working
        //the solution would be to reset the Count value in the SetUp method,
        //or simply create a brand new _cut object there
        //we could also consider refactoring of the class under test to be stateless
        public void ThisTestIsNot_Isolated()
        {
            _cut.RaiseCountBy1();
            Assert.AreEqual(2, _cut.Count);
        }

        [Test]
        //this test only works on 2020/10/12, it will start failing the next day
        //the solution is to hide the DateTime.Now method behind an interface and mock it
        public void ThisTestIsNot_Repeatable()
        {
            Assert.AreEqual(new DateTime(2020, 10, 12), _cut.GetDateTimeToday());
        }

        [Test]
        //this test doesn't really check what is expected - that the Count should be 3
        //the developer would probably have to set a breakpoint in the test to see the value of _cut.Count
        public void ThisTestIsNot_SelfValidating()
        {
            _cut.RaiseCountBy1();
            _cut.RaiseCountBy1();
            _cut.RaiseCountBy1();

            Console.WriteLine(_cut.Count);
        }

        [Test]
        //we only check one set of arguments
        //what if we divided by 0? We would expect an exception
        //we should also check couple of other cases:
        //for very small and big numbers,
        //for negative numbers
        //for two zeros divided by each other
        //etc
        public void ThisTestIsNot_Thorough()
        {
            Assert.AreEqual(5, _cut.Divide(20, 4));
        }
    }
}
