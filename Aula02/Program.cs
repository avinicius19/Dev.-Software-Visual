using System;

namespace Aula02
{
    class Program
    {
        static double calculaMedia(double[] numeros){
            double media = 0.0;
            double soma = 0.0;

            for(int i = 0; i < numeros.Length; i++){
                soma += numeros[i];
            };

            media = soma / numeros.Length; 
            

            return media;
        }

        static double calculaMediana(double[] numeros){
            for(int i = 0; i < numeros.Length; i++){
                Console.Write(numeros[i] + " ");
            };
            Console.Write("\n");
            int meio = numeros.Length / 2;
            Array.Sort(numeros);
            if((numeros.Length % 2) == 0){
                return (numeros[meio] + numeros[meio - 1]) / 2;
            }else{
                return numeros[meio];
            }
        }

        static double calculaModa(double[] numeros){
            double[] repeticoes = new double[numeros.Length];
            for(int i = 0; i < numeros.Length; i++){
                double atual = numeros[i];
                int cont = 0;

              for(int j = 0; j < numeros.Length; j++){
                  if(numeros[j] == atual){
                      cont++;
                  }
              }
              repeticoes[i] = cont;
            }
            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine(numeros[i] + "");
            }
            Console.WriteLine();

            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine(numeros[i] + "");
            }
            Console.WriteLine();

            int maior = 0;
            for(int i = 1; i < repeticoes.Length; i++){
                if(repeticoes[i] > repeticoes[i - 1]){
                    maior = i;

                }
            }

            return numeros[maior];
        }
        static void Main(string[] args)
        {
            double[] numeros = {2,4,6,8};
            double media = calculaMedia(numeros);
            Console.WriteLine("A média é" + media);
            double mediana = calculaMediana(numeros);
            Console.WriteLine("A médiana é" +  mediana);
            double moda = calculaMediana(numeros);
            Console.WriteLine("A moda é" +  moda);

            
        }
    }
}
