﻿using System;
using System.Collections.Generic;

namespace Platonus_Tester.Helper
{
    public abstract class SwearHashProcessor
    {

        public static List<string> GetHashList(string text)
        {
            var result = new List<string>(0);
            var splitSeparators = new[] { "#\n" };
            var list = text.Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
            result.AddRange(list);
            return result;
        }
    }
}