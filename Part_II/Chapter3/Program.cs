




using System;

namespace Chapter3
{
    class Program
    {
        // Ponto de entrada da aplicação, ou seja, o método Main é o primeiro código a ser executado quando
        // a aplicação é executada.
        // O método é estático (static), está no nível da classe e não de um objeto. Além disso o método Main
        // não retorna nenhum valor após a finalização de execução, por isso é declardo como void.
        // OP método recebe um parâmetro que é um array de strings.
        static void Main(string[] args)
        {
            // Apresenta uma mensagem simples ao usuário do programa.
            Console.WriteLine("***** Meu primeiro aplicativo em C# *****");
            Console.WriteLine();

            // Processa os argumentos passados durante a chamada ao método Main.
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argumento: {0}", args[i]);
            }

            // Quebra de linha.
            Console.WriteLine("");
            
            // Outra maneira de obter os argumentos de linha de comando utilizando o método GetCommandLineArgs()
            // da classe Environment que está no namespace System.
            // O primeiro argumento é o nome da própria aplicação com o todo o caminho do diretório da aplicação.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            ShowEnvironmentDetails();

            GetUserData();

            FormatNumericalData();

            // O console espera até uma tecla qualquer seja pressiona.
            Console.ReadLine();

            // A linguagem C# é case-sensitive, logo Main é diferente de main e ReadLine
            // não é o mesmo que Readline.
            // Todas as palavras chaves do C#, exemplo, public, var, static, int..., estão
            // em minúsculo, já os namespaces e nomes de tipos iniciam, por convenção com
            // a primeira letra em maiúsculo.
        }

        #region Possíveis variações do método Main.

        // Os métodos Main apresentados estão comentados, servindo apenas como exemplos.

        // Precisa retornar um valor inteiro antes de finalizar a execução
        // static int Main(byte[] args)
        // {
        //     return 0;
        // }

        // Não precisa retornar um valor antes de finalizar a execução
        // static void Main()
        // {

        // }

        // Não precisa receber parâmetros e retorna um inteiro antes de finalizar a execução.
        // static int Main()
        // {

        // }

        // Com o lançamento da versão 7.1 da linguagem C# o método Main pode ser assíncrono.
        // static Task Main() { }
        // static Task<int> Main() { }
        // static Task Main(string[]) { }
        // static Task<int> Main(string[]) { }
        #endregion

        // O método ShowEnvironmentDetails() imprimi algumas informações sobre o ambiente
        // de execução atual que hospeda a aplicação.
        static void ShowEnvironmentDetails()
        {
            // Informa os discos rígidos locais que estão na máquina hospedeira da aplicação
            // e alguns outros detalhes interessantes.
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Disco Rígido: {0}", drive);
            }

            Console.WriteLine("SO: {0}", Environment.OSVersion);
            Console.WriteLine("Número de Processadores: {0}", Environment.ProcessorCount);
            Console.WriteLine("Versão .NET Core: {0}", Environment.Version);
        }

        // Método criado para estudar o básico de entrada (input) e saída (output) da classe Console.
        // Este exemplo está na seção The System.Console class do capítulo 3 - Chapter 3.
        private static void GetUserData()
        {
            Console.WriteLine("\n\nMétodo: GetUserData()");
            
            // Solicita o nome e a idade.
            Console.Write("Por favor, informe seu nome: ");
            string userName = Console.ReadLine();

            Console.Write("Por favor, informe sua idade: ");
            string userAge = Console.ReadLine();

            // Altera a cor do primeiro plano (letras) da linha de comando.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Envia os dados obtidos para a saída padrão, linha de comando, no momento.
            Console.WriteLine("Olá, {0}! Você está com {1} de idade!", userName, userAge);

            // Restaura a cor da linha de comando.
            Console.ForegroundColor = prevColor;
        }

        // Formata números utilizando caracteres de formatação dos placeholders.
        private static void FormatNumericalData()
        {
            Console.WriteLine("\n\nMétodo: FormatNumericalData()");

            Console.WriteLine("Formatando o número 99999 em diversos formatos:");
            Console.WriteLine("Formato c: {0:c}", 99999);
            Console.WriteLine("Formato d9: {0:d9}", 99999);
            Console.WriteLine("Formato f3: {0:f3}", 99999);
            Console.WriteLine("Formato n: {0:n}", 99999);
            
            // Reparar na caixa alta e baixa para hexadecimais.
            // Determina se a letras estão em caixa alta ou baixa.
            Console.WriteLine("Format E: {0:E}", 99999);
            Console.WriteLine("Formato e: {0:e}", 99999);
            Console.WriteLine("Formato X: {0:X}", 99999);
            Console.WriteLine("Formato x: {0:x}", 99999);
        }
    }
}
