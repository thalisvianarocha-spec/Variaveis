namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cada tipo de variável guarda um tipo de dado diferente

            string nome = "thalis";   // texto
            int idade = 20;           // número inteiro
            double altura = 1.75;     // número com casas decimais
            char sexo = 'M';          // um único caractere (usa aspas simples)
            bool estudante = true;    // verdadeiro (true) ou falso (false)

            // O $ antes das aspas permite colocar variáveis dentro do texto com { }
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Estudante: {estudante}");

            // Espera o Enter para a janela não fechar sozinha
            Console.ReadLine();
        }
    }
}
