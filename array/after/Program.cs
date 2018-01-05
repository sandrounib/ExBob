using System;
using System.Text;

namespace after
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]names = new string[]{"Sandro","Rosana"};
            string frase = "Você pode conseguir o que quiser na vida";
            char[] nomesArray = frase.ToCharArray();
            Array.Reverse(nomesArray);
            foreach (char fraseArray in nomesArray)
            {
                Console.Write(fraseArray);
                
            }            

            Array.Reverse(names);
            foreach (string nomeArray in names)
            {
                Console.Write(nomeArray);
                
            }
            Console.ReadLine();
        }
    }
}
