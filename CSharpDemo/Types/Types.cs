using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Types
{
    public class Types
    {

        public void Test()
        {
            // long/L, uint/U, ulong/UL, float/F, double/D, decimal/M
            var a = 1L;
            decimal d = -1.23M;
            var l = new[] { 'a', 'e', 'i' };
            Console.WriteLine(d.GetType().ToString());
        }
    }

}
