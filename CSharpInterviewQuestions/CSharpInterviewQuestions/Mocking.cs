using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestions
{
    public class UserController
    {
        private readonly IUsersRepository _repository;

        public UserController(IUsersRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetAllActive()
        {
            return _repository.GetAll().Where(a => a.IsActive);
        }
    }

    public interface IUsersRepository //implementation would connect to some actual database
    {
        IEnumerable<User> GetAll();
    }

    public class User : IEquatable<User>
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

        public bool Equals(User other)
        {
            return Id == other.Id;
        }
    }
}
