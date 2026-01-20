using System;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {
        //creating cryptographical secure random bytes
        byte[] key = new byte[32];
        using (RandomNumberGenerator rannumgen = RandomNumberGenerator.Create())
        {
            rannumgen.GetBytes(key);
        }
        //convert to base64 string
        string secureKey = Convert.ToBase64String(key);
        Console.WriteLine("Generated New Key: " +secureKey);
    }
}
