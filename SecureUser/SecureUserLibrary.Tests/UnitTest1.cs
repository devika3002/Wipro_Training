using NUnit.Framework;
using SecureUserLibrary;

namespace SecureUserLibrary.Tests
{
    public class SecureUserTests
    {
        private AuthService authService;

        [SetUp]
        public void Setup()
        {
            authService = new AuthService();
        }

       
        // AUTHENTICATION TESTS
   

        [Test]
        public void Register_And_Login_WithCorrectPassword_ShouldReturnTrue()
        {
            authService.Register("Satya", "password123");

            bool result = authService.Login("Satya", "password123");

            Assert.That(result, Is.True);
        }

        [Test]
        public void Login_WithWrongPassword_ShouldReturnFalse()
        {
            authService.Register("Satya", "password123");

            bool result = authService.Login("Satya", "wrongpassword");

            Assert.That(result, Is.False);
        }

        // PASSWORD HASHING TESTS

        [Test]
        public void HashPassword_SameInput_ShouldReturnSameHash()
        {
            string hash1 = PasswordHasher.HashPassword("test123");
            string hash2 = PasswordHasher.HashPassword("test123");

            Assert.That(hash1, Is.EqualTo(hash2));
        }

        [Test]
        public void HashPassword_DifferentInput_ShouldReturnDifferentHash()
        {
            string hash1 = PasswordHasher.HashPassword("test123");
            string hash2 = PasswordHasher.HashPassword("test456");

            Assert.That(hash1, Is.Not.EqualTo(hash2));
        }

        // ENCRYPTION TESTS
       

        [Test]
        public void Encrypt_Then_Decrypt_ShouldReturnOriginalText()
        {
            string original = "SensitiveData123";

            string encrypted = EncryptionService.Encrypt(original);
            string decrypted = EncryptionService.Decrypt(encrypted);

            Assert.That(decrypted, Is.EqualTo(original));
        }

       
        // ERROR HANDLING TEST

        [Test]
        public void Login_WithUnknownUser_ShouldNotThrowException()
        {
            bool result = authService.Login("unknownUser", "password");

            Assert.That(result, Is.False);
        }
    }
}
