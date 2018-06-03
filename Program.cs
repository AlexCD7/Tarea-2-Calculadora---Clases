using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;



namespace myCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculadora Numeros = new Calculadora();
            Console.WriteLine("BIENVENIDO A MI CALCULADORA");
            Console.Write(
            "\n1º) Suma" 
            + "\n2º) Resta" 
            + "\n3º) Multiplicación"  
            + "\n4º) División" 
            + "\n5º) Raiz" 
            + "\n6º) Salir \n" );
            
            double a, b;
            Console.Write("\n" + "Introduce el 1er número: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n" + "Introduce el 2do número: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Seleccione una opción: ");
           

            switch (Console.Read())
            {
                case '1': Console.Write("Suma..");
                    Numeros.Sumar(a,b);
                    break;

                case '2': Console.Write("Resta..");
                    Numeros.Restar(a,b);
                    break;

                case '3': Console.Write("Multiplicación..");
                    Numeros.Multiplicar(a,b);
                    break;

                case '4': Console.Write("División..");
                    Numeros.Dividir(a,b);
                    break;

                case '5': Console.Write("Raiz..");
                    Numeros.Raiz(a,b);
                    break; 
                     
                 case '6': Console.Write("Salir..");
                    break;    
            } 
            Console.ReadKey();
        }
    }
}
