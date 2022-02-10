using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LBFML
{
    /// <summary>
    /// Autohrs: Parsa Khatibzadeh & Arash Hajibeyki
    /// 
    /// This class is meant to make using txt files easier
    /// </summary>
    public class Data
    {
        public static readonly string userLocalDirectory = @"C:\Users\" + Environment.UserName + @"\AppData\Local\";
        public string Path;
        public bool IsHidden;
        public Data(string Directory_, bool isInvisible = false)
        {

            {
                DirectoryInfo di = Directory.CreateDirectory(Directory_);
                //Controlls If the directory is hidden.
                if (isInvisible) di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

                Path = Directory_;
                IsHidden = isInvisible;


            }
        }
        public string currentPath()
        {
            return Path;
        }
        public void CreateFile(string fileName, string Data = null)
        {
            if (!File.Exists(Path + @"\" + fileName))
            {
                File.Create(Path + @"\" + fileName).Close();

            }
            if (Data != null)
            {

                File.WriteAllText(Path + @"\" + fileName, Data);
            }

        }
        public string ReadFile(string fileName)
        {
            return File.ReadAllText(Path + @"\" + fileName);

        }
        public void WriteToFile(string fileName, string Data, bool shouldOverWrite = true)

        {
            string filePath = (Path + @"\" + fileName);
            if (shouldOverWrite)
            {
                File.WriteAllText(filePath, Data);
            }
            else
            {
                //checks if the file exists so if it doesn't system does't do the tests and WriteAllText.
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);
                    //check for existing data so if it's the first line it doesn't apply "  \n  "
                    if (data != null) File.AppendAllText(filePath, "\n" + Data);
                    else File.WriteAllText(filePath, Data);

                }
                else
                {
                    File.WriteAllText(filePath, Data);
                }



            }
        }
        public void ChangeFileName(string currentName, string changedName)

        {
            File.Move(Path + @"\" + currentName, Path + @"\" + changedName);
        }
        public bool FileExist(string fileName)

        {
            if (File.Exists(Path + @"\" + fileName)) return true;
            else return false;
        }
        public void DeleteFile(string fileName)
        {
            if (File.Exists(Path + @"\" + fileName))
            {
                File.Delete(Path + @"\" + fileName);
            }
        }
        public string ReadLine(string fileName, int line = 0)
        {
            StreamReader SR = new StreamReader(Path + @"\" + fileName);

            for (int i = 0; i < line; i++)
            {
                SR.ReadLine();
            }
            string rt = SR.ReadLine();
            SR.Close();
            return rt;

        }
        public string[] ReadAllLines(string fileName)
        {
            string[] rs = File.ReadAllLines(Path + @"\" + fileName);
            return rs;
        }
        public void WriteLine(string fileName, int lineNumber, string Data)
        {
            string[] lines = ReadAllLines(Path + @"\" + fileName);
            lines[lineNumber] = Data;
            DeleteFile(Path + @"\" + fileName);
            CreateFile(Path + @"\" + fileName);
            foreach (string line in lines)
            {
                WriteToFile(Path + @"\" + fileName, line, false);
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








    }
}