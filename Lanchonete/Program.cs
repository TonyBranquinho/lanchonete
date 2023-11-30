using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int codigo;
            double total, preco, quantidade;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = double.Parse(Console.ReadLine());

            //primeiro = 5.00;
            ///segundo = 3.50;
            //terceiro = 4.80;
            //quarto = 8.90;
            //quinto = 7.32;
            preco = 0;

            if (codigo == 1) {
                preco = 5.00;
            }
            else if (codigo == 2) {
                preco = 3.50;
            }
            else if (codigo == 3) {
                preco = 4.80;
            }
            else if (codigo == 4) {
                preco = 8.90;
            }
            else if (codigo == 5) {
                preco = 7.32;
            }

            total = preco * quantidade;

            Console.WriteLine("Valor a pagar: " + total.ToString("F2"), CI);



        }
    }
}
