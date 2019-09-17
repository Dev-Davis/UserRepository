using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorage.Data
{
    class UserRepository
    {

        List<User> _users = new List<User>();

        public List<User> GetAll()
        {
            // get the users from the "database"
            return _users;
        }

        public void Add(User userToAdd)
        {
            // add the users to the "database"
            userToAdd.Id = Guid.NewGuid();

            _users.Add(userToAdd);
        }

        public void Remove(User userToRemove)
        {
            // remove user from the "database"
            _users.Remove(userToRemove);
        }

        public User Update(Guid userId, string firstName, string lastName)
        {
            // update the user
            var user = _users.Find(x => x.Id == userId);

            user.FirstName = firstName;
            user.LastName = lastName;

            return user;
        }

    }

    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
