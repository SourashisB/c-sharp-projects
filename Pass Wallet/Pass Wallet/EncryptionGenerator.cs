using System;
using System.Security.Cryptography;


namespace Pass_Wallet
{
    public static class EncryptionKeyGenerator
    {
        public static byte[] GenerateKey(int keySize = 32) // Default to 256 bits (32 bytes)
        {
            using var rng = new RNGCryptoServiceProvider();
            byte[] key = new byte[keySize];
            rng.GetBytes(key);
            return key;
        }
    }
}
