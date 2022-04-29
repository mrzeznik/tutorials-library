using System;
using System.Collections.Generic;

namespace Library.Repository
{
    /// <summary>Interface defining access to users related data.</summary>
    public interface IUserRepository
    {
        /// <summary>Find users, one can specify search criteria.</summary>
        IEnumerable<User> Find(string name = "");

        /// <summary>Add a new user to the library.</summary>
        void Add(string name, string gender, DateTime? ValidTo = null);
    }
}