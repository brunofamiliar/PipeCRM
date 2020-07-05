using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Utils
{
    public class Utilitis
    {
        public static T[] CombineArrays<T>(params T[][] arrays)
        {
            var final = new T[arrays.Sum(a => a.Length)];
            int offset = 0;

            foreach (var a in arrays)
            {
                Buffer.BlockCopy(a, 0, final, offset, a.Length);
                offset += a.Length;
            }
            return final;
        }
    }
}
