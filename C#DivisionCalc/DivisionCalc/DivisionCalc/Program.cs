using System;

namespace DivisionCalc
{
    class Program
    {
        static void calcFactoriel(int nombre, out string resultat)
        {
            resultat = "";

            for (int i = 1; i < nombre; i++)
            {
                if((nombre % i) == 0)
                {
                    resultat =  resultat + "," +  i;
                }
            }
        }
        static void Main(string[] args)
        {
            int nombre;
            string resultat;

            Console.WriteLine("Entrer votre nombre svp :");
            nombre = int.Parse(Console.ReadLine());

            calcFactoriel(nombre, out resultat);

            Console.WriteLine(($"Les diviseurs de {nombre} sont : {resultat}"));

            Console.ReadLine();

        }
    }
}
