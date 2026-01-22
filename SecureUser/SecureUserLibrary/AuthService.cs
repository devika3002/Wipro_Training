using System;
using System.Collections.Generic;

namespace SecureUserLibrary
{
    public class AuthService
    {
        private readonly Dictionary<string, string> users = new();

        // Register a new user
        public void Register(string username, string password)
        {
            if (users.ContainsKey(username))
                throw new Exception("User already exists");

            string hashedPassword = PasswordHasher.HashPassword(password);
            users[username] = hashedPassword;
        }

        // Login existing user
        public bool Login(string username, string password)
        {
            if (!users.ContainsKey(username))
                return false;

            string hashedPassword = PasswordHasher.HashPassword(password);
            return users[username] == hashedPassword;
        }
    }
}
