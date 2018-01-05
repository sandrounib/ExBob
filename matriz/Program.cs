using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
              /*
           int[]numeros = new int[]{};
           numeros[0]=1;
           numeros[1]=5;

           int[] numbers = new int[2];
           numbers[0] = 5;
           numbers[1] = 3;
           Console.WriteLine(numbers.Length);
            */
           //matriz de  CADEIA de caracteres
           //não precisamos declarar de início qtos elementos"[5]" queremos
           //deixaremos o compilador fazer isso, ele criará os 4 itens entre "" abaixo
           string[] name = new string[]{"Sandro","Harian","Rosana","Vitor"};
            //há várias formas de fazer um loop para acessar cada item da matriz
            //uma delas será o loop for abaixo
            /*
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]); 
            }
            Console.ReadLine();
            */
            //note que não preciso colocar o tamanho da matriz name
            //name.lenght o foreach já inteaje in todos e joga para nomes
            /*
            foreach (string nomes in name)
            {
                Console.WriteLine(nomes);
            }
            Console.ReadLine();
            */
            /*
            pegar uma cadeia de caractere e invertê-la
            primeiro fazemos uma cadeia de caracter individual
            depois que eu tiver essa cadeiz eu digo inverta a ordem desse itens
            de modo que o primeiro vire o último.
            criarei uma cadeia de caractere chamade de zig
            que conterá uma das minha cotações favoritas na qual eu moldo minha vida
            you can get what you want out of life if you help enough other people get what they want
            agora quero criar uma matriz de cadeia de caractere
            */

            string zig ="you can get what you want"+
            "out of life if you help enough other people get what they want";
            //char contém apenas um caractere, mas, criarei uma matriz de caractere
            //chamada charArray
            //char[] chaArray = zig;//note que só isso não dá
            char[] chaArray = zig.ToCharArray();//chamei aqui um método auxiliar chamado ToCharArray()
            //cada tipo de dado possui alguns métodos auxiliares embutidos pelo.NET
            //ISSO SIMPLESMENTE dividirá em caracteres individuais, colocando-os em uma matriz de caractere
            //agora chamarei aaray.reverse e passarei charArray
            Array.Reverse(chaArray);
            foreach (char zigChar in chaArray)
            {
                Console.Write(zigChar);
            }

            Console.ReadLine();

            



            
        }
    }
}
