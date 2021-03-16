using System;
using System.Text.RegularExpressions;

namespace ValidadorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
             string senha = Console.ReadLine();

            if (string.IsNullOrEmpty(senha)) break;
             Regex rx = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
             Match match = rx.Match(senha);
      
                 if (match.Success) {
                Console.WriteLine("Senha valida.");
                } else {
                 Console.WriteLine("Senha invalida.");
                }
            }
        }
    }
}
