using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helpers
{
    public static class Helper
    {
        public static void CW(this ConsoleColor color, string str)
        {
            Console.ForegroundColor= color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
