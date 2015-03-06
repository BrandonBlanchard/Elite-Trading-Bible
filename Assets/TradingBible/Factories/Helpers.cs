using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Assets.TradingBible
{
    public static class Helpers
    {
        // Takes in highTech returns High Tech
        public static string CamelToSpaces (string camel)
        {
            char[] decamel = camel.ToCharArray();
            decamel[0] = Char.ToUpper(decamel[0]);
            camel = new String(decamel);
            return Regex.Replace(camel, "(\\B[A-Z])", " $1"); // Sorcery
        }

        public static int Loop(int current, int count, int modifier)
        {
            int i = current + modifier;

            if( i < 0)
            {
                return i % count;
            }

            if( i > count)
            {
                return 0;
            }
            
            return 1;
        }
    }
}
