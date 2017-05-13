using System;
using System.IO;
using System.Security.Cryptography;

namespace Filer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D://hashes.txt";

            //string val = null;
            //int j = 0;
            //for(int i=100000;i <= 999999; i++)
            //{
            //    val += i.ToString();
            //    val += "\n";
            //    j++;

            //}
            // File.WriteAllText(path,val);
            MD5 md = MD5.Create();
            var prex = "\007";
            var sufx = "\\207\\363\\325\\237\\330\\324\\155\\356\\207\\135\\272\\210\\262\\263\\374\\166";
            string[] content = File.ReadAllLines(path);
           for(int i=0; i <= File.ReadAllLines(path).Length;i++)
            {
                HMACMD5
                Console.WriteLine(content[i]);
            }
        }
    }
}
