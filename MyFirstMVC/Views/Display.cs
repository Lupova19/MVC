using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public double TipSum { get; set; }
        public double TotalSum { get; set; }
        public void Input()
        {
            Console.Write("Vavedete sumata na smetkata:");
            double suma = double.Parse(Console.ReadLine());
            this.Amount = suma;
            Console.Write("Vavedete procent na kelnera:");
            double percent = double.Parse(Console.ReadLine());
            this.Percent = percent;
        }
        public void Output() 
        {
            Console.WriteLine($"Bakshishat za servityora e:{this.TipSum} lv.");
            Console.WriteLine($"Sumata za plashtane e:{this.TotalSum} lv.");

        }
    }
}
