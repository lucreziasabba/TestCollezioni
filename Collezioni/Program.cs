using System;
using Libreria;

namespace Collezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la prima stringa: ");
            string s1 = Console.ReadLine();
            Console.Write("Inserisci la seconda stringa: ");
            string s2 = Console.ReadLine();
            bool uguaglianza = MetodiCollezioni.Uguali(s1, s2);
            Console.Write("Le stringhe sono uguali? " + uguaglianza);

            Console.WriteLine();

            Console.Write("Inserisci una stringa: ");
            string s3 = Console.ReadLine();
            bool maiuscole = MetodiCollezioni.Maiuscola(s3);
            Console.Write("La stringa contiene lettere maiuscole? " + maiuscole);
        }
    }
}
