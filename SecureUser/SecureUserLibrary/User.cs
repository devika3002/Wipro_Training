namespace SecureUserLibrary
{
    public class User
    {
        public string Username { get; set; }
        public string HashedPassword { get; set; }

        // Constructor to initialize properties
        public User(string username, string hashedPassword)
        {
            Username = username;
            HashedPassword = hashedPassword;
        }
    }
}
