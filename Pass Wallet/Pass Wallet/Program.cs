using System.Text;

namespace Pass_Wallet
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            /* 
             ApplicationConfiguration.Initialize();
             Application.Run(new LoginPage());
            */
            var encryptionKey = EncryptionKeyGenerator.GenerateKey();

            string base64Key = Convert.ToBase64String(encryptionKey);   

            var passwordManager = new PasswordManager("credentials.json", encryptionKey);


        }
    }
}