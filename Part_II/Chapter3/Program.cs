




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

            // Métodos desenvolvidos para seguir os exemplos do capítulo 03 da parte ii do livro.
            // Não é a melhor maneira de se fazer, mas faço dessa maneira para não ter que criar um novo
            // projeto para cada exemplo do livro.
            ShowEnvironmentDetails();
            GetUserData();
            FormatNumericalData();
            LocalVarDeclarations();
            DefaultDeclarations();
            NewingDataTypes();
            ObjectFuncionality();
            DataTypeFuncionality();
            CharFuncionality();
            ParseFromStrings();
            ParseFromStringsWithTryParse();
            UseDatesAndTime();
            DigitSeparators();
            BinaryLiterals();

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
            Console.WriteLine("\n\nMétodo: GetUserData():");
            
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
            Console.WriteLine("\n\nMétodo: FormatNumericalData():");

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

        // Exmeplo de declaração de variáveis no C#.
        private static void LocalVarDeclarations()
        {
            Console.WriteLine("\n\nMétodo LocalVarDeclarations():");
            
            // Variáveis podem são delcaradas seguindo das seguintes formas.
            // tipoDado nomeVariavel;
            // nomeVariavel = valorInicial;
            // tipoDado nomeVariavel = valorInicial;
            // tipoDado nomeVar1 = valorInicial, nomeVar2 = valorInicial;
            int myInt = 15;
            string myString = "Este é um dado de string (cadeia de caracteres)";
            bool b1 = true, b2 = false, b3 = b1;

            Console.WriteLine("Dados: {0} - {1} - {2} - {3} - {4}", myInt, myString, b1, b2, b3);
        }

        // Método que apresenta a utilização do literal "default" para atribuir o valor default
        // de um tipo de dados.
        static void DefaultDeclarations()
        {
            Console.WriteLine("\n\nMétodo DefaultDeclarations():");
            int myInt = default;

            Console.WriteLine("Valor default do tipo int: {0}", myInt);
        }

        // Declaração de variáveis com valor padrão utilizando o construtor padrão utilizando "new".
        private static void NewingDataTypes()
        {
            Console.WriteLine("\n\nMétodo NewingDataTypes():");

            bool b = new bool();            // Atribui false a b.
            int i = new int();              // Atribui 0 a i.
            double d = new double();        // Atribui 0 a d.
            DateTime dt = new DateTime();   // Atribui 01/01/0001 a dt.

            Console.WriteLine("Valor padrão dos tipos: int = {0}, bool = {1}, double = {2}, DateTime = {3}", i, b, d, dt);
        }

        // Funcionalidades de System.Object.
        private static void ObjectFuncionality()
        {
            Console.WriteLine("\n\nMétodo ObjectFuncionality():");
            
            // int de fato é um atalho em C# para System.Int32
            // que herda os membros a seguir de System.Object
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
        }

        // Alguns membros para os tipos de dados numéricos e booleanos
        private static void DataTypeFuncionality()
        {
            Console.WriteLine("\n\nMétodo DataTypeFuncionality():");

            // Abaixo algumas funcionalidades para os tipos de dados numéricos do C#.
            Console.WriteLine("Máximo de int: {0}", int.MaxValue);
            Console.WriteLine("Mínimo de int: {0}", int.MinValue);
            Console.WriteLine("Máximo de double: {0}", double.MaxValue);
            Console.WriteLine("Mínimo de double: {0}", double.MaxValue);
            Console.WriteLine("double.epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString(): {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString(): {0}", bool.TrueString);
            Console.WriteLine("");
        }

        // Alguns membros para o tipo de dados char.
        private static void CharFuncionality()
        {
            Console.WriteLine("\n\nMétodo CharFuncionality():");

            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There!', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There!', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            // Console.WriteLine("");
        }

        // Parsing de strings para seu tipo correspondente.
        private static void ParseFromStrings()
        {
            Console.WriteLine("\n\nMétodo ParseFromStrings():");

            // Converte o valor textual literal para o tipo correspondente da variável.
            bool b = bool.Parse("True");
            Console.WriteLine("Valor de b: {0}", b);

            double d = double.Parse("999.884");
            Console.WriteLine("Valor de d: {0}", d);

            int i = int.Parse("8");
            Console.WriteLine("Valor de i: {0}", i);

            char c = char.Parse("w");
            Console.WriteLine("Valor de c: {0}", c);
        }

        // Parse de strings com manipulação de exceções.
        private static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("\n\nMétodo ParseStringsWitTryhParse():");

            // Com esta técnica executamos o parse de strings para os tipos subjacentes sem
            // o risco de lançar exceções, risco que ocorre no método ParseFromStrings();
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Valor de b: {0}", b);
            }
            else
            {
                Console.WriteLine("Valor padrão de b: {0}", b);
            }

            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Valor de d: {0}", d);
            }
            else
            {
                Console.WriteLine("Ocorreu um problema ao converter o valor ({0}) em um double, a variável acabou recebendo o valor padrão ({1})", value, d);
            }
        }

        // Método para dar uma amostra do uso de DateTime e TimeSpan.
        private static void UseDatesAndTime()
        {
            Console.WriteLine("\n\nMétodo UseDatesAndTime():");

            // Trabalhando com DateTime.
            // Formato padrão, ano, mês e dia.
            DateTime dateTime = new DateTime(2015, 10, 25);
            Console.WriteLine("O dia de {0} é {1}", dateTime.Date, dateTime.DayOfWeek);

            // Vai para o mês de Dezembro.
            dateTime.AddMonths(2);
            Console.WriteLine("Horário de verão?: {0}", dateTime.IsDaylightSavingTime());

            // Este TimeSpan recebe horas, minutos e segundos no construtor.
            TimeSpan timeSpan = new TimeSpan(4, 30, 0);
            Console.WriteLine(timeSpan);

            // Subtrai 15 minutos do atual timeSpan e imprime o valor
            Console.WriteLine(timeSpan.Subtract(new TimeSpan(0, 15, 0)));
        }

        // Método para apresentar o separador de digitos (digit separator) apresentando no C# 7.0
        private static void DigitSeparators()
        {
            Console.WriteLine("\n\nMétodo DigitSeparators():");

            // O digito separador é o underscore (_), conhecido no BR como underline.
            Console.Write("Integer (inteiro): ");
            Console.WriteLine(123_456);

            Console.Write("Long: ");
            Console.WriteLine(123_456_789L);

            Console.Write("Float: ");
            Console.WriteLine(123_456_789.12345F);

            Console.Write("Double: ");
            Console.WriteLine(12345_6789.526363);

            Console.Write("Decimal: ");
            Console.WriteLine(123_456_789.52M);

            // A partir do C# 7.2 um hexadecimal pode iniciar com undescore (_).
            Console.Write("Hexadecimal: ");
            Console.WriteLine(0x_00_00_FF);
        }

        // Método para apresentar binários literais.
        private static void BinaryLiterals()
        {
            Console.WriteLine("\n\nMétodo BinaryLiterals():");

            // A partir do C# 7.0 foi introduzido um novo literal para binário.
            // O novo digito separador (digit separator) funcionar com binários literais e o
            // C# 7.2 permite que binários e hexadecimais comecem com underscore (_)
            Console.WriteLine("16: {0}", 0b_0001_0000);
            Console.WriteLine("32: {0}", 0b_0010_0000);
            Console.WriteLine("64: {0}", 0b_0100_0000);
        }
    }
}
