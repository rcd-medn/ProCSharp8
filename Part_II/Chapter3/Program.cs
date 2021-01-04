




using System;
using System.Text;

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
            BasicStringFuncionality();
            EscapeChars();
            StringConcatenation();
            StringInterpolation();
            StringEquality();
            StringEqualitySpecifyingCompareRules();
            StringsAreImmutable();
            FunWithStringBuilder();

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

        //
        // Tópico: Working with Data String
        // Trabalhando com dados do tipo string.
        //

        // Método para apresentar funcionalidades básicas de strings.
        private static void BasicStringFuncionality()
        {
            Console.WriteLine("\n\nMétodo BasicStringFuncionality():");

            //
            string firstName = "Ricardo Medina";
            Console.WriteLine("Valor de firstName: {0}", firstName);
            Console.WriteLine("firstName possui {0} caracteres: ", firstName.Length);
            Console.WriteLine("firstName em caixa alta: {0}", firstName.ToUpper());
            Console.WriteLine("firstName em caixa baixa: {0}", firstName.ToLower());
            Console.WriteLine("firstName possui a letra M?: {0}", firstName.Contains("M"));
            Console.WriteLine("firstName após uma alteração: {0}", firstName.Replace("o", ""));
        }

        // Método para apresentar os conceitos de concatenação de strings
        private static void StringConcatenation()
        {
            Console.WriteLine("\n\nMétodo StringConcatenation():");

            // Concatenação feita utilizando o operador +
            string s1 = "Programado o";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);

            // Concatenação utilizando String.Concat.
            string s4 = String.Concat(s1, s2);
            Console.WriteLine("String.Concat(s1, s2): {0}", s4);
        }

        // Caracteres de escape
        private static void EscapeChars()
        {
            Console.WriteLine("\n\nMétodo EscapeChars():");

            // Caracteres de escape em ação!
            string strWithStr = "Modelo\tCor\tVelocidade\tNome\a";
            Console.WriteLine(strWithStr);
            Console.WriteLine("Todos gostam do \"Hello World\"\a");

            // Três quebras de linha e um beep no final.
            Console.WriteLine("\n\n\n\a");
        }

        // Interpolação de strings - string interpolation
        private static void StringInterpolation()
        {
            Console.WriteLine("\n\nMétodo StringInterpolation():");

            // Algumas variáveis para testes.
            int age = 35;
            string name = "Ricardo";

            // Utilizando a sintaxe de placeholders {0}, {1}, etc.
            Console.WriteLine("Olá {0}, você está com {1} anos de idade", name, age);

            // Interpolação de strings.
            Console.WriteLine($"Olá {name.ToUpper()} você está com {age} anos de idade");
        }

        // Iqualdade de strings
        private static void StringEquality()
        {
            Console.WriteLine("\n\nMétodo StringEquality():");

            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);

            // Comparação de strings para saber se são iguais (possuem o mesmo valor!)
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
        }

        // Comparação avançada de strings com diversas regras.
        private static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("\n\nMétodo StringEqualitySpecifyingCompareRules():");

            //
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // Realiza a comparação de strings alterando a regra padrão!
            Console.WriteLine("Regra padrão: s1={0}, s2={1} | s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignora a capitalização das letras: s1.Equals(s2, StringComparison.OrdinalIgnoreCase) {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignora a capitalização das letras, cultura invariante: s1.Equals(s2, StringComparison.OrdinalIgnoreCase) {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();

            Console.WriteLine("Regra padrão: s1={0}, s2={1} | s1.Index(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignora a capitalização das letras: s1.Index(\"E\", StringComparison.OrdinalIgnoreCase) {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignora a capitalização das letras, cultura invariante: s1.Index(\"E\", StringComparison.InvariantCultureIgnoreCase) {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        }

        private static void StringsAreImmutable()
        {
            Console.WriteLine("\n\nMétodo StringsAreImmutable():");

            // Strings são imutáveis!
            string s1 = "Esta é minha strings";
            Console.WriteLine("s1 = {0}", s1);

            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            Console.WriteLine("s1 = {0}", s1);
        }

        // Trabalhando com grande quantidades de textos!
        private static void FunWithStringBuilder()
        {
            Console.WriteLine("\n\nMétodo FunWithStringBuilder():");

            //
            StringBuilder sb = new StringBuilder("***** Games fantásticos *****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowing");
            sb.AppendLine("Deus Ex " + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Infinity War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb possui {0} caracteres.", sb.Length);
        }
    }
}
