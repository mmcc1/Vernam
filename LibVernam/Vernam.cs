using System.Collections;

namespace LibVernam
{
    public static class Vernam
    {
        public static byte[] Encrypt(byte[] plainText, byte[] key)
        {
            if (plainText.Length != key.Length)
                return null;

            BitArray dataBits = new BitArray(plainText);
            BitArray keyBits = new BitArray(key);
            BitArray cipherBits = new BitArray(plainText.Length * 8);

            for(int i = 0; i < dataBits.Length; i++)
            {
                cipherBits[i] = dataBits[i] ^ keyBits[i];
            }

            return Helpers.BitArrayToByteArray(cipherBits);
        }

        public static byte[] Decrypt(byte[] ciphertext, byte[] key)
        {
            if (ciphertext.Length != key.Length)
                return null;

            BitArray dataBits = new BitArray(ciphertext);
            BitArray keyBits = new BitArray(key);
            BitArray plainTextBits = new BitArray(ciphertext.Length * 8);

            for (int i = 0; i < dataBits.Length; i++)
            {
                plainTextBits[i] = dataBits[i] ^ keyBits[i];
            }

            return Helpers.BitArrayToByteArray(plainTextBits);
        }
    }
}
