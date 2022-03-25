using System;

namespace Teorema_Pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Apariencia();
            PedirCalculo();
        }

        static void PedirCalculo()
        {
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Que quieres calcular: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine("Cateto/Hipotenusa");
            string input = Console.ReadLine();
            if (input == "Cateto")
            {
                Cateto();
                PedirCalculo();
            } else if (input == "Hipotenusa")
            {
                Hipotenusa();
                PedirCalculo();
            } else 
            {
                Console.WriteLine("No te entiendo, repite por favor:");
                PedirCalculo();
            }
        }

        static void Cateto()
        {
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Longitud hipotenusa: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            float longH = (float)Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Longitud cateto 1: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            float longC = (float)Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = System.ConsoleColor.Green;
            double longC2 = CalcularCateto(longH, longC);
            Console.Write("Longitud cateto 2: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(longC2);

            Console.ForegroundColor = System.ConsoleColor.Green;
            double P = longH + longC + longC2;
            Console.Write("Perímetro: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(P);

            Console.ForegroundColor = System.ConsoleColor.Green;
            double A = (longC * longC2)/2;
            Console.Write("Area: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(A);

            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------");
        }

        static double CalcularCateto(float longH, float longC)
        {
            double longC2 = MathF.Sqrt(MathF.Pow((float)longH, 2) - MathF.Pow((float)longC, 2));
            return longC2;
        }

        static void Hipotenusa()
        {
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Longitud cateto 1: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            float _longC1 = (float)Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Longitud cateto 2: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            float _longC2 = (float)Convert.ToDouble(Console.ReadLine());

            double _longH = CalcularHipotenusa(_longC1, _longC2);
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Longitud hipotenusa: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(_longH);

            double P = _longC1 + _longC2 + _longH;
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Perímetro: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(P);

            double A = (_longC1 * _longC2)/2;
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Area: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(A);

            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------");
        }

        static double CalcularHipotenusa(float longC1, float longC2)
        {
            double longH = MathF.Sqrt(MathF.Pow(longC1, 2) + MathF.Pow(longC2, 2));
            return longH;
        }

        static void Apariencia ()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------JatoMixo----------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("----------Teorema de Pitágoras----------");

            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------");
            Console.Title = "JatoMixo: Teorema de Pitágoras";
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WindowWidth = 40;
        }
    }
}