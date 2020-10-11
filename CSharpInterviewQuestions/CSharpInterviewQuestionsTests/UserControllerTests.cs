using CSharpInterviewQuestions;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace CSharpInterviewQuestionsTests
{
    [TestFixture]
    public class UserControllerTests
    {
        private UserController _cut;
        private Mock<IUsersRepository> _usersRepositoryMock;

        [OneTimeSetUp]
        public void SetUp()
        {
            // _cut = new UserController(new RealDbRepository()); //bad idea!
            _usersRepositoryMock = new Mock<IUsersRepository>();
            _cut = new UserController(_usersRepositoryMock.Object);
        }

        [Test]
        public void GetAllActive_ShouldExcludeNonActiveUsers()
        {
            var allUsers = new List<User>
            {
                new User(1, "user1@gmail.com", false),
                new User(2, "user2@gmail.com", true),
                new User(3, "user3@gmail.com", false),
            };

            _usersRepositoryMock.Setup(a => a.GetAll()).Returns(allUsers);

            var result = _cut.GetAllActive();
            var expectedResult = new List<User>
            {
                new User(2, "user2@gmail.com", true)
            };

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
