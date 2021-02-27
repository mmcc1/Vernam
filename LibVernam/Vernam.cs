using System.Collections;

namespace LibVernam
{
    public static class Vernam
    {
        public static byte[] Encrypt(byte[] plainText, byte[] key)
        {
            if (plainText.Length != key.Length)
                return null;

            BitArray plainTextBits = new BitArray(plainText);
            BitArray keyBits = new BitArray(key);
            BitArray cipherBits = new BitArray(plainText.Length * 8);

            for(int i = 0; i < plainTextBits.Length; i++)
                cipherBits[i] = plainTextBits[i] ^ keyBits[i];

            return Helpers.BitArrayToByteArray(cipherBits);
        }

        public static byte[] Decrypt(byte[] ciphertext, byte[] key)
        {
            if (ciphertext.Length != key.Length)
                return null;

            BitArray ciphertextBits = new BitArray(ciphertext);
            BitArray keyBits = new BitArray(key);
            BitArray plainTextBits = new BitArray(ciphertext.Length * 8);

            for (int i = 0; i < ciphertextBits.Length; i++)
                plainTextBits[i] = ciphertextBits[i] ^ keyBits[i];

            return Helpers.BitArrayToByteArray(plainTextBits);
        }
    }
}
