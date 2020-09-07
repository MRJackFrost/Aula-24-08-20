using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaSalarial
{

    class Program
    {
        static void Main(string[] args)
        {
            Salario func1, func2;
            func1 = new Salario();
            Console.WriteLine("Qual o nome do primeiro funcionario");
            func1.nome = Console.ReadLine();
            Console.WriteLine("Qual o salario do primeiro funcionario");
            func1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            func2 = new Salario();
            Console.WriteLine("Qual o nome do segundo funcionario");
            func2.nome = Console.ReadLine();
            Console.WriteLine("Qual o salario do segundo funcionario");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func2.salario + func1.salario) / 2;

            Console.WriteLine("A media salarial dos funcionarios "+func2.nome+" e "+func1.nome+" é: "+media);
            Console.ReadKey();

        }
    }
}
