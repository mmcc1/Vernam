using LibVernam;
using System;
using System.Text;

namespace VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToBeEncrypted = "This is a string of text.";
            byte[] bytesToBeEncrypted = Encoding.ASCII.GetBytes(textToBeEncrypted);
            byte[] key = Helpers.GenerateRandomBytes(bytesToBeEncrypted.Length);

            byte[] cipherText = Vernam.Encrypt(bytesToBeEncrypted, key);
            byte[] bytesDeciphered = Vernam.Encrypt(bytesToBeEncrypted, key);

            string textDeciphered = Encoding.ASCII.GetString(Vernam.Decrypt(cipherText, key));
            
            Console.WriteLine(textDeciphered);
            
            Console.ReadLine();
        }

        
    }
}
