// WinHasher - A File Hasher for Windows.
// Copyright (C) 2020 Joe Pitt

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version. 

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.If not, see<https://www.gnu.org/licenses/>.

using System;
using System.IO;
using JoePitt.WinHasher.Engines;

namespace JoePitt.WinHasher.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            string license = "WinHasher CLI Copyright (C) 2018 Joe Pitt" + Environment.NewLine +
                "This program comes with ABSOLUTELY NO WARRANTY. This is free software, and you " +
                "are welcome to redistribute it under certain conditions; see `" +
                "https://www.joepitt.co.uk/Project/WinHasher/' for details.";
            start:
            Console.Title = "WinHasher CLI V2.0";
            Console.Clear();
            Console.WriteLine(license);
            Console.WriteLine();
            Console.WriteLine();
            string file = "";
            while (string.IsNullOrEmpty(file) || !File.Exists(file))
            {
                Console.Write("File to Hash: ");
                file = Console.ReadLine();
            }
            if (File.Exists(file))
            {
                Console.WriteLine("Computing Hashes...");
                Console.WriteLine("MD5    : " + Formatter.HashTidy(MD5.Hash(File.OpenRead(file))));
                Console.WriteLine("SHA1   : " + Formatter.HashTidy(SHA1.Hash(File.OpenRead(file))));
                Console.WriteLine("SHA256 : " + Formatter.HashTidy(SHA256.Hash(File.OpenRead(file))));
                Console.WriteLine("SHA384 : " + Formatter.HashTidy(SHA384.Hash(File.OpenRead(file))));
                Console.WriteLine("SHA512 : " + Formatter.HashTidy(SHA512.Hash(File.OpenRead(file))));
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue");
                Console.ReadKey(true);
            }
            goto start;
        }
    }
}
