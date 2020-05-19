using System;
using System.Collections.Generic;
using System.Text;

namespace HW08
{
    class Task1
    {

        internal void Poem(string poem)
        {
            string[] arrPoem = poem.Split(new Char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arrPoem.Length; i++)
            {
                arrPoem[i] = arrPoem[i].Trim().Replace("о", "A", StringComparison.InvariantCultureIgnoreCase);
            }
            foreach (var item in arrPoem)
            {
                Console.WriteLine(item);
            }
        }
    }
}
