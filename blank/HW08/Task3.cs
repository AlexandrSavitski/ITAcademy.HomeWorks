using System;
using System.Collections.Generic;
using System.Text;

namespace HW08
{
    class Task3
    {
        internal void ActionWithString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.IndexOf('?'); i++)
            {
                if (!str[i].Equals('\u0021') && !str[i].Equals('.')) sb.Append(str[i]);
            }
            for (int i = str.IndexOf('?'); i < str.Length; i++)
            {
                if (!str[i].Equals(' ')) sb.Append(str[i]);
                else sb.Append('_');
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
