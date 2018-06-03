using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

 class Calculadora{
     
    public void Sumar(double x,double y)
            {
               
                double resultado = x+y;
                Console.WriteLine("El Resultado es: " + resultado); 
                Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                Console.ReadKey();

            }
 
 

    public void Restar(double x,double y)
    {
                 
                
                double resultado= x-y;
                Console.WriteLine("El Resultado es: " + resultado); 
                Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                Console.ReadKey();
    }

     public void Multiplicar(double x,double y)
    {
                
                
                double resultado= x*y;
                Console.WriteLine("El Resultado es: " + resultado); 
                Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                Console.ReadKey();
    }
    public void Dividir(double x,double y)
    {
               
                if (y != 0)
                {
                    double resultado= x / y;
                    Console.WriteLine("El Resultado es: " + resultado); 
                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine( "No se puede dividir entre 0");
                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                }
    } 


 public void Raiz(double x,double y)
    {
                
                
                double resultado= Math.Sqrt(x);
                double resultado2= Math.Sqrt(y);
                Console.WriteLine("La raiz del primer número: "  + resultado); 
                Console.WriteLine("La raiz del primer número: "  + resultado2); 
                Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                Console.ReadKey();
    }


}
 

 