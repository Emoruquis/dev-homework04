using System;

namespace dev_homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voy a preparar un sandwich");
            Console.WriteLine("agregar pan");
            Console.WriteLine("¿Quieres mayonesa o crema?");
            var adherezo = Console.ReadLine();
            Console.WriteLine("Poner jamòn");
            Console.WriteLine("¿Con lechuga?");
            var lechuga = Console.ReadLine();
            Console.WriteLine("¿Con jitomate?");
            var jitomate = Console.ReadLine();
            Console.WriteLine("¿Con queso?");
            var queso = Console.ReadLine();
            Console.WriteLine("¿Con Chile?");
            var chile = Console.ReadLine();
            string[]sandwich = new string [9];
            sandwich[0] = "tapa de arriba";
            if(adherezo == "mayonesa"){
                sandwich[1] = "mayonesa";
            }
            else if(adherezo == "crema"){
                sandwich[1] = "crema";
            }
            sandwich[2] = "jamòn";
            if(lechuga == "con"){
                sandwich[3] = "lechuga";
            }
            else if(lechuga == "sin"){
                
            }
            if(jitomate == "con"){
                if(lechuga== "sin"){
                    sandwich[4] = "jitomate";
                } else{
                   sandwich[4] = "jitomate"; 
                }
                    
                }
            if(queso =="con"){
                sandwich[5] = "queso";
            }
            else if(queso =="sin"){
                sandwich[5] = "queso";
            }

            if(adherezo == "mayonesa"){
                sandwich[6] = "mayonesa";
            }
            else if(adherezo == "crema"){
                sandwich[6] = "crema";
            }

            if(chile == "con"){
                sandwich[7] = "chile";
            }

            else if(chile == "sin"){
                sandwich[7] = "chile";
            }

            sandwich[8] = "tapa de abajo";

            Console.WriteLine("********");
            for(int indice = 0;indice < 9; indice++){
                if(!string.IsNullOrEmpty(sandwich [indice]))
                { Console.WriteLine(sandwich [indice]);}   
            }
        }
    }
}
