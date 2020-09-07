using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pessoa.Idade{

    
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa persona1, persona2;
            persona1 = new Pessoa();
            persona2 = new Pessoa();
            Console.WriteLine("Qual o nome da primeira pessoa");
            persona1.nome = Console.ReadLine();
            Console.WriteLine("Qual a idade da primeira pessoa");
            persona1.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o nome da segunda pessoa");
            persona2.nome = Console.ReadLine();
            Console.WriteLine("Qual a idade da segunda pessoa");
            persona2.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (persona1.idade > persona2.idade)
            {
                Console.WriteLine(persona1.nome + " é a pessoa mais velha");
            }
            else if(persona1.idade == persona2.idade) {
                Console.WriteLine(persona2.nome + " e " + persona1.nome + " tem a mesma idade");
            }
            else {
                Console.WriteLine(persona2.nome + " é a pessoa mais velha");
            }
            Console.ReadKey();
        }
    }
}
