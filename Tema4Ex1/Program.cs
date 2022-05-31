using System;

// Ex 1. Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul


namespace Tema4Ex1
{
    class Program
    {
        static void printVector(int[] vect , int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(vect[i] + " ");
            }
            Console.WriteLine();
        }

        static void inversie(int[] vect, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                int aux;
                aux = vect[i];
                vect[i] = vect[n - i - 1];
                vect[n - i - 1] = aux;
            }

        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti dimensiunea vectorului");
            int n = int.Parse(Console.ReadLine());
            
            int[] vectorIntregi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti numarul: ");
                vectorIntregi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul original = ");
            printVector(vectorIntregi, n);

            inversie(vectorIntregi, n);

            Console.WriteLine("Vectorul inverse = ");
            printVector(vectorIntregi, n);


        }


    }
}
