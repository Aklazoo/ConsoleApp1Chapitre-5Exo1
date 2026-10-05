using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez le premier nombre : ");
        int nombre1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entrez le deuxième nombre (le multiplicateur) : ");
        int nombre2 = Convert.ToInt32(Console.ReadLine());

        int resultat = 0;
        int compteur = 0;

        Console.Write(nombre1 + "*" + nombre2 + " = ");

        while (compteur < nombre2)
        {
            resultat = resultat + nombre1;

            
            Console.Write(nombre1);

            compteur++; 

           
            if (compteur < nombre2)
            {
                Console.Write(" + ");
            }
        }

        Console.WriteLine(" = " + resultat);
    }
}