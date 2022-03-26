using System;

namespace Learning_Strings_Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string oneFriend = ("Joao");
            string twoFriend = ("Maria");
            Console.WriteLine($"{oneFriend} conheceu {twoFriend} na festa da faculdade");


            //trocando o valor das strings com o metodo replace
            oneFriend = oneFriend.Replace("Joao", "Felipe");
            Console.WriteLine(oneFriend);

            //aplicando metodo .toUpper e .toLower 
            Console.WriteLine(twoFriend.ToLower());
            Console.WriteLine(oneFriend.ToUpper());

            //tirando espaços com o metodo trim
            //colchetes apenas para mostrar o "fim" dos espaços em branco
            //.TrimStart(); para tirar apenas espaços da esquerda(começo da string)
            //.TrimEnd(); para tirar apenas espaços da direita(fim da string)
            //.Trim(); para tirar espaços de ambos os lados(esquerda e direita)
            
            string saudacao = ("          Olá Mundo!!              ");
            Console.WriteLine($"[{saudacao}]");

            string saudacaoComTrim = saudacao.TrimStart();
            Console.WriteLine($"[{saudacaoComTrim}]"); 

            saudacaoComTrim = saudacao.TrimEnd();
            Console.WriteLine($"[{saudacaoComTrim}]");

            saudacaoComTrim = saudacao.Trim();
            Console.WriteLine($"[{saudacaoComTrim}]");

            //usando a .Length para saber o comprimento da string

            string firstName = "Afranio";
            string lastName = "Junior";
            Console.WriteLine($"O nome {firstName} tem {firstName.Length} letras");
            Console.WriteLine($"O nome {lastName} tem {lastName.Length} letras");

            // usando o metodo .Contains para checar a existencia de palavras na string.Sempre retornará true/false por ser boolean

            string songLyrics = "Inspiração que me visita, Depois ela me abandona";
            Console.WriteLine(songLyrics.Contains("Inspiração"));  
            Console.WriteLine(songLyrics.Contains("Nada"));

            
            

            
           
            

        }
    }
}
