using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MySchool.Common
{
    public class Md5
    {
        public string GetMD5String(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes("newblade");
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                Console.WriteLine(md5data[i].ToString());
                builder.Append(md5data[i].ToString("X2"));
            }
            return builder.ToString();
        }

        public string GetMD5Strin1g(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                Console.WriteLine(md5data[i].ToString());
                builder.Append(md5data[i].ToString("X2"));
            }
            return builder.ToString();
        }


    }
}
