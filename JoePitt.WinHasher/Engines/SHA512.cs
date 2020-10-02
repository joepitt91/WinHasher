﻿// WinHasher - A File Hasher for Windows.
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
// along with this program.If not, see https://www.gnu.org/licenses/.

using System;
using System.IO;
using System.Security.Cryptography;

namespace JoePitt.WinHasher.Engines
{
    public static class SHA512
    {
        public static string Hash(Stream Input)
        {
            SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider();
            return BitConverter.ToString(provider.ComputeHash(Input));
        }

        public static bool Verify(Stream Input, string Hash)
        {
            SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider();
            string inputHash = BitConverter.ToString(provider.ComputeHash(Input));
            return (Formatter.HashTidy(inputHash) == Hash);
        }
    }
}
