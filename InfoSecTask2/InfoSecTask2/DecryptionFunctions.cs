using System.Security.Cryptography;
using System.Text;

namespace InfoSecTask2
{
    internal class DecryptionFunctions
    {

        public static void CBC()
        {
            throw new NotImplementedException();
        }

        public static void CFB()
        {
            throw new NotImplementedException();
        }

        public static void ECB()
        {
            Console.Write("Enter 1 for encryption, 2 for decryption: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Enter plaintext: ");
                string plainText = Console.ReadLine();
                Console.Write("Enter key: ");
                string key = Console.ReadLine();
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                using (Aes aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.KeySize = 128;
                    aes.Key = keyBytes;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                    Console.WriteLine(Convert.ToBase64String(encryptedBytes));
                }
            }
            else if (input == "2")
            {
                Console.Write("Enter encrypted text: ");
                string encryptedString = Console.ReadLine();
                Console.Write("Enter key: ");
                string key = Console.ReadLine();
                byte[] encryptedBytes = Convert.FromBase64String(encryptedString);
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                using (Aes aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.KeySize = 128;
                    aes.Key = keyBytes;

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                    Console.WriteLine(Encoding.UTF8.GetString(decryptedBytes));
                }
            }
        }
    }
}