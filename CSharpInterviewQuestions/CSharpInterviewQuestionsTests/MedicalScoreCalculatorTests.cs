
using CSharpInterviewQuestions;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace CSharpInterviewQuestionsTests
{
    [TestFixture]
    public class MedicalScoreCalculatorTests
    {
        private Mock<IRepository> _repositoryMock;
        private Mock<IMedicalScoreCalculator> _medicalScoreCalculatorMock;
        private TestableMedicalScoreCalculator _cut;

        [OneTimeSetUp]
        public void SetUp()
        {
            _repositoryMock = new Mock<IRepository>();
            _medicalScoreCalculatorMock = new Mock<IMedicalScoreCalculator>();
            _cut = new TestableMedicalScoreCalculator(_repositoryMock.Object, _medicalScoreCalculatorMock.Object);
        }

        [Test]
        public void IfThereAre3PeopleWithScores_10_20_60_TheAverageScoreShouldBe_30()
        {
            var people = new List<Person>
                {
                    new Person("John Smith"),
                    new Person("John Doe"),
                    new Person("Jane Doe")
                };

            _repositoryMock.Setup(a => a.GetAllPeopleFromDatabase()).Returns(
                people);

            _medicalScoreCalculatorMock.Setup(a => a.GetScore(people[0])).Returns(10);
            _medicalScoreCalculatorMock.Setup(a => a.GetScore(people[1])).Returns(20);
            _medicalScoreCalculatorMock.Setup(a => a.GetScore(people[2])).Returns(60);

            Assert.AreEqual(30, _cut.CalculateAverageMedicalScoreOfPeople());
        }
    }
}
