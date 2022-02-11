using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using LBFML;

namespace note_pad
{
    internal class Security
    {
        //from this point We have the methods nessecary for the program to function

        #region Encryption Methods
        /// <summary>
        /// the 2 following functions Decrypt and Encrypt data  (string -> encrypted hexadecimal) string and vise versa
        /// Padding Protocol: PKCS7
        /// Cipher Protocol: ECB
        /// </summary>

        public static string Encryptor(string Input, byte[] key)
        {
            byte[] InputArray = UTF8Encoding.UTF8.GetBytes(Input);
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            TDES.Key = key;
            TDES.Mode = CipherMode.ECB;
            TDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = TDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(InputArray, 0, InputArray.Length);
            TDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decryptor(string Input, byte[] key)
        {
            byte[] InputArray = Convert.FromBase64String(Input);
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            TDES.Key = key;
            TDES.Mode = CipherMode.ECB;
            TDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = TDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(InputArray, 0, InputArray.Length);
            TDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        private static byte[] KeyGenerator(string password)
        {
            int passwordSize = UTF8Encoding.UTF8.GetByteCount(password);
            List<byte> key = UTF8Encoding.UTF8.GetBytes(password).ToList();
            if(passwordSize == 16) return key.ToArray();
            else if(passwordSize > 16)
            {
                int extraBytes = passwordSize - 16;
                for(int i = 0; i < extraBytes; i++)
                {
                    key.RemoveAt(16);
                }
                return key.ToArray();
            }
            else 
            {
                int neededBytes = 16 - passwordSize;
                Stack<byte> FixedCharactyers = new Stack<byte>(UTF8Encoding.UTF8.GetBytes("ParsaKH__ArashHA"));
                for(int i = 0;i < neededBytes;i++)
                {
                    key.Add(FixedCharactyers.Pop());
                }
                return key.ToArray();
            }
        }
        public static string MD5HashWithSalt(string input, string salt) //Retruns a String containing The hashed data in hexadecimal
        {


            #region Hashing
            byte[] TmpInput = ASCIIEncoding.ASCII.GetBytes(input + salt);
            byte[] TmpHash = new MD5CryptoServiceProvider().ComputeHash(TmpInput);
            #endregion
            #region Converting it to Hexadecimal
            int i = 0;
            string resault = "";
            for (i = 0; i < TmpHash.Length; i++)
            {
                resault += (TmpHash[i].ToString("X2"));
            }
            #endregion
            return resault;


        }
        #endregion
        public static void SaveAndEncrypt(string Name, string input, string UserName, string Password)
        {
            #region Generating key
            byte[] key = KeyGenerator(Password); 
            #endregion
            #region Proccessing Data
            string resault = input;
            resault = Encryptor(input, key);
            #endregion
            Data DataFolder = new Data(@"accounts\" + UserName);
            DataFolder.WriteToFile(Name + ".Encrypted", resault);



        }
        public static string LoadAndDecrypt(string Name, string UserName, string Password)
        {
            #region Generating key
            byte[] key = KeyGenerator(Password);
            #endregion
            #region Getting the Data
            Data DataFolder = new Data(@"accounts\" + UserName);
            string input = DataFolder.ReadFile(Name + ".Encrypted");
            #endregion
            #region Decrypting it
            string resault = Decryptor(input, key);
            #endregion
            return resault;
        }
    }
}
