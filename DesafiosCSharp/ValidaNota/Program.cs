using System;

namespace ValidaNota
{
    class Program
    {
        static void Main(string[] args)
        {
           short x;
            bool flag = false;

            do{
                int contador = 0;
                double media = 0;
                do
                  {
                   double notaAluno = Convert.ToDouble(Console.ReadLine());
                   if (notaAluno < 0 || notaAluno > 10)
                   {
                    Console.WriteLine("nota invalida");
                   }
                    else
                  {
                    media += notaAluno;
                    contador++;
                }
            }while(contador < 2);
            Console.WriteLine("media = " + (media / 2).ToString("N2"));
            Console.WriteLine("novo calculo (1-sim 2-nao)");

            x = short.Parse(Console.ReadLine());

            while (x != 1 && x != 2)

            {

              Console.WriteLine("novo calculo (1-sim 2-nao)");

              x = short.Parse(Console.ReadLine());

            }
               /* do
                {
                    System.Console.WriteLine("Novo calculo (1-sim 2-nao)");
                    x = short.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1: flag = true;break;
                        case 2:System.Environment.Exit(0);break;
                        default: flag = false;break;
                    }
                } while (flag == false);*/
                
            }while(x == 1);
        }
    }
}
