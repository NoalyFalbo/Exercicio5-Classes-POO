using System;
using System.Globalization;

namespace exercicioClasses5
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Retangulo ret = new Retangulo();

      Console.WriteLine("Digite a largura do retnângulo:");
      ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Digite a altura do retângulo: ");
      ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Area = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Perimentro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}