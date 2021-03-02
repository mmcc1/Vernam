using LibVernam;
using System;
using System.Text;

namespace VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Use Vernam Cipher
            string textToBeEncrypted = "This is a string of text.";
            byte[] bytesToBeEncrypted = Encoding.ASCII.GetBytes(textToBeEncrypted);
            byte[] key = Helpers.GenerateRandomBytes(bytesToBeEncrypted.Length);

            byte[] cipherText = Vernam.Encrypt(bytesToBeEncrypted, key);
            string textDeciphered = Encoding.ASCII.GetString(Vernam.Decrypt(cipherText, key));
            
            Console.WriteLine(textDeciphered);
            */


            //Use VernamHash
            string textToEncrypt = "This is a test.";
            byte[] bytesToEncrypt = Encoding.ASCII.GetBytes(textToEncrypt);
            byte[] key = Helpers.GenerateRandomBytes(64);  //Key is 64 bytes (512 bits) in length
            int byteSelection = 4;  //Select a byte from hash, valid values for SHA512 is 0-64.

            byte[] cipherText = VernamHash.Encrypt(key, bytesToEncrypt, byteSelection);
            byte[] decipheredText = VernamHash.Decrypt(key, cipherText, byteSelection);

            string textDeciphered = Encoding.ASCII.GetString(decipheredText);

            Console.WriteLine(textDeciphered);

            Console.ReadLine();
        }
    }
}
