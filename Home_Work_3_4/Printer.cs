using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_4
{
    class Printer
    {
        private ConsoleColor color;
        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        public void Print(string value)
        { 
            Console.ForegroundColor = color;
            Console.WriteLine(value);   
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
