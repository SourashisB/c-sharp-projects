using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Pass_Wallet
{
    public class PasswordManager
    {
        private readonly string filePath;
        private readonly byte[] encryptionKey;
        private Dictionary<string, string> credentials;

        public PasswordManager(string filePath, byte[] key)
        {
            this.filePath = filePath;
            this.encryptionKey = key;
            this.credentials = LoadCredentials();
        }

        private Dictionary<string, string> LoadCredentials()
        {
            if (!File.Exists(filePath))
            {
                return new Dictionary<string, string>();
            }

            string json = File.ReadAllText(filePath);
            var encryptedCredentials = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            var decryptedCredentials = new Dictionary<string, string>();

            if (encryptedCredentials != null)
            {
                foreach (var pair in encryptedCredentials)
                {
                    decryptedCredentials[pair.Key] = Decrypt(pair.Value, encryptionKey);
                }
            }

            return decryptedCredentials;
        }

        private void SaveCredentialsToFile()
        {
            var encryptedCredentials = new Dictionary<string, string>();

            foreach (var pair in credentials)
            {
                encryptedCredentials[pair.Key] = Encrypt(pair.Value, encryptionKey);
            }

            string json = JsonSerializer.Serialize(encryptedCredentials);
            File.WriteAllText(filePath, json);
        }

        public void AddOrUpdateCredential(string username, string password)
        {
            credentials[username] = password;
            SaveCredentialsToFile();
        }

        public bool TryGetPassword(string username, out string password)
        {
            if (credentials.TryGetValue(username, out string decryptedPassword))
            {
                password = decryptedPassword;
                return true;
            }

            password = null;
            return false;
        }

        private string Encrypt(string clearText, byte[] key)
        {
            using var aes = Aes.Create();
            aes.Key = key;
            aes.GenerateIV();

            var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (var sw = new StreamWriter(cs))
            {
                sw.Write(clearText);
            }

            var iv = aes.IV;
            var encrypted = ms.ToArray();
            var result = new byte[iv.Length + encrypted.Length];
            Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
            Buffer.BlockCopy(encrypted, 0, result, iv.Length, encrypted.Length);

            return Convert.ToBase64String(result);
        }

        private string Decrypt(string encryptedText, byte[] key)
        {
            var fullCipher = Convert.FromBase64String(encryptedText);

            using var aes = Aes.Create();
            aes.Key = key;

            var iv = new byte[aes.BlockSize / 8];
            var cipher = new byte[fullCipher.Length - iv.Length];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, cipher.Length);

            aes.IV = iv;

            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream(cipher);
            using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            using var sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
    }

}
