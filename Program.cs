using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSonarQube
{
    public class Program
    {
        static void Main(string[] args) {
        }

        public static int Sub(int a, int b, int c) {
            if (a == 0) {
                return b;
            }
            if (b == 0) {
                return a;
            }
            return c;
        }
    }
}
