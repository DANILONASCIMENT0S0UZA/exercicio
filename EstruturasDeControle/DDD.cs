﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class DDD {

        public static void Executar() {

            Console.WriteLine("Digite seu DDD:");
            int.TryParse(Console.ReadLine(), out int ddd);

            switch (ddd) {

                case 61:
                    Console.WriteLine("Brasilia");
                    break;

                case 71:
                    Console.WriteLine("Salvador");
                    break;

                case 11:
                    Console.WriteLine("São Paulo");
                    break;

                case 21:
                    Console.WriteLine("Rio de janeiro");
                    break;

                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;

                case 19:
                    Console.WriteLine("Campinas");
                    break;

                case 27:
                    Console.WriteLine("Vitoria");
                    break;

                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;

                default:
                    Console.WriteLine("Digite um DDD válido!");
                    break;
            }
        }
    }
}
