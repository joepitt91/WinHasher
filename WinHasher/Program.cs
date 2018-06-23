using System;
using System.IO;
using System.Security.Cryptography;

namespace SHA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string version = "WinHasher v1.1";
        start:
            Console.Title = version;
            Console.Clear();
            Console.WriteLine(version);
            Console.WriteLine();
            Console.WriteLine();
            string file = "";
            while (string.IsNullOrEmpty(file) || !File.Exists(file))
            {
                Console.Write("File to Hash: ");
                file = Console.ReadLine();
            }
            Hash(file);
            Console.ReadKey(true);
            goto start;
        }

        static private void Hash(string Path)
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                //MD5
                MD5CryptoServiceProvider md5er = new MD5CryptoServiceProvider();
                string md5 = BitConverter.ToString(md5er.ComputeHash(sr.BaseStream));
                md5 = md5.ToLower();
                md5 = md5.Replace("-", "");
                
                //SHA-1
                SHA1CryptoServiceProvider sha1er = new SHA1CryptoServiceProvider();
                string sha1 = BitConverter.ToString(sha1er.ComputeHash(sr.BaseStream));
                sha1 = sha1.ToLower();
                sha1 = sha1.Replace("-", "");

                //SHA-256
                SHA256CryptoServiceProvider sha256er = new SHA256CryptoServiceProvider();
                string sha256 = BitConverter.ToString(sha256er.ComputeHash(sr.BaseStream));
                sha256 = sha256.ToLower();
                sha256 = sha256.Replace("-", "");

                //SHA-384
                SHA384CryptoServiceProvider sha384er = new SHA384CryptoServiceProvider();
                string sha384 = BitConverter.ToString(sha384er.ComputeHash(sr.BaseStream));
                sha384 = sha384.ToLower();
                sha384 = sha384.Replace("-", "");

                //SHA-512
                SHA512CryptoServiceProvider sha512er = new SHA512CryptoServiceProvider();
                string sha512 = BitConverter.ToString(sha512er.ComputeHash(sr.BaseStream));
                sha512 = sha512.ToLower();
                sha512 = sha512.Replace("-", "");
                
                //Print Results
                Console.WriteLine("MD5:       " + md5);
                Console.WriteLine("SHA-1:     " + sha1);
                Console.WriteLine("SHA-256:   " + sha256);
                Console.WriteLine("SHA-384:   " + sha384);
                Console.WriteLine("SHA-512:   " + sha512);
            }
        }
    }
}
