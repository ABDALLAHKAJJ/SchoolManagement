using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SchoolManagement.Libraries.Core.Security.Encryption
{
    public static class AesEncryption
    {
        public static string Decrypt(string encryptedText, string key)
        {
            string ivStr = "00000000000000000000000000000000";
            string hexStrDecryptedText = "";
            byte[] ivArr = ConvertFromHexToBytesArray(ivStr);
            byte[] keyArr = ConvertFromHexToBytesArray(key);
            byte[] encryptedBytes = ConvertFromHexToBytesArray(encryptedText);

            AesManaged aesManaged = new AesManaged();
            aesManaged.Padding = PaddingMode.PKCS7;
            aesManaged.Mode = CipherMode.CBC;
            aesManaged.KeySize = key.Length * 4;
            aesManaged.BlockSize = 128;
            aesManaged.Key = keyArr;
            aesManaged.IV = ivArr;

            using (ICryptoTransform decrypto = aesManaged.CreateDecryptor(aesManaged.Key, aesManaged.IV))
            {
                byte[] decryptedText = decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                hexStrDecryptedText = ArrayBytesToString(decryptedText);
            }

            return ConvertHexToAscii(hexStrDecryptedText);
        }

        private static byte[] ConvertFromHexToBytesArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
            //return Enumerable.Range(0, hex.Length / 2)
            //        .Select(x => Convert.ToByte(
            //        hex.Substring(x * 2, 2), 16))
            //        .ToArray();
        }

        private static string ArrayBytesToString(byte[] bytes)
        {
            string hexString = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                hexString += bytes[i].ToString("X2");
            }
            return hexString;
        }

        private static string ConvertHexToAscii(string HexString)
        {
            // Windows-1254(Turkish) Code Page-----------------------------------------
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //-------------------------------------------------------------------------

            if (HexString.Length % 2 != 0)
            {
                HexString += "F";
            }
            byte[] bytes = (from x in Enumerable.Range(0, HexString.Length)
                            where x % 2 == 0
                            select Convert.ToByte(HexString.Substring(x, 2), 16)).ToArray();
            return Encoding.GetEncoding(1254).GetString(bytes);
        }
    }
}