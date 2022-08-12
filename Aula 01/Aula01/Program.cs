using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            try{  
            Console.WriteLine("Informe uma largura:");
            double largura = Convert.ToDouble(Console.ReadLine());       
            Console.WriteLine("Informe uma altura:");
            double altura = Convert.ToDouble(Console.ReadLine());
            double area = CalcularArea(largura, altura );
            Console.WriteLine("A area equivale a:" +  area);
            //Console.WriteLine(area);     
            }
            catch(Exception erro) {
                Console.WriteLine(erro.Message);
            }   
        }
        static double CalcularArea(double largura, double altura){
            return largura * altura;
            
        }
    }
    
}

