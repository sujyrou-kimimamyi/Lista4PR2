using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Exercício 1
              
             
            A resposta é que a sentença é parcialmente verdadeira. É possível atribuir um número do tipo int para uma variável tipo float, mas não o contrário.
            Para transformar um número tipo float em int basta utilizar o comando "float.parse(x);"


            Exercício 2

            O "Console.Read();" serve apenas para ler um caracter, retornando o valor ASCII, enquanto o "Console.ReadLine();" serve para ler uma linha inteira, 
            e retorna o valor em string.

            Exercício 3

            Precisamos fazer a conversão do valor lido para a variável na qual desejamos. Para isso usamos o comando ".Parse".

            Exercício 4

            O programa serviria para ver se um número é divisível por 2 e menor por 10. Caso fosse entrado o número 8, a resposta seria a mensagem 2. 
            Caso o número fosse 27, mensagem 02
            Caso fosse 28, mensagem 1

            Exercício 5
            */

            /*double s0, v, t, s;

            Console.Write("Digite a posição inicial do objeto: ");
            s0 = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade do objeto: ");
            v = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo total decorrido: ");
            t = double.Parse(Console.ReadLine());

            s = s0 + v * t;

            Console.WriteLine("A posição final do objeto é: " + s);
            Console.ReadKey();


            Exercício 6

            Random random = new Random();
            int n = random.Next(0, 5000);

            Console.WriteLine("O número gerado foi " + n);

            if (n % 3 == 0 && n % 5 == 0 && n % 10 == 0)
            {
                Console.WriteLine("O número é divisível por 3, 5 e 10.");
            }
            else if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("O número é divisível por 3 e 5.");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("O número é divisível por 3.");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("O número é  divisível por 5.");
            }
            else
            {
                Console.WriteLine("O número não é divisível por 3, 5 e nem por 10.");
            }

            Console.ReadKey();

            Exercício 7

            Exercício 8

            não consgui realizar os dois ultimos exercicios.




          }
    }
}