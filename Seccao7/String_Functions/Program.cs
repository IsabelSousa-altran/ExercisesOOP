using System;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            // Toda a string com letras maiúsculas
            string s1 = original.ToUpper();
            // Toda a string com letras minúsculas
            string s2 = original.ToLower();
            // Apaga os espaços em branco, tanto no início como no fim da string
            string s3 = original.Trim();

            // Coloca a posição em que encontra a primeira vez que aparece o b
            int n1 = original.IndexOf("bc");
            // Coloca a posição em que encontra a ultima vez que aparece o b
            int n2 = original.LastIndexOf("bc");

            // Corta a string a partir da posição 3
            string s4 = original.Substring(3);
            // Corta a string a partir da posição 3, mas desta vez unicamente 5 caracteres
            string s5 = original.Substring(3, 5);

            // Troca todo o caracter a pelo x
            string s6 = original.Replace('a', 'x');
            // Troca todas as ocorrência de abc por xy
            string s7 = original.Replace("abc", "xy");

            // Verifica se a string é nula ou está vazia
            bool b1 = String.IsNullOrEmpty(original);
            // Verifica se a string é nula ou o espaço está em branco, por exemplo com um espaço(não é considerado vazia)
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");

            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
