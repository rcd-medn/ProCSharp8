




using System;
using System.Text;
using System.Linq;

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

            //
            // "Estreitamento" e "alargamento" de tipos de dados, que PODE, mas não necessariamente,
            // ocasionar perda de dados.
            
            // Abaixo, exemplo de conversão de "alargamento" e "estreitamento" de tipos sem perda de dados.
            short n1 = 9, n2 = 10;
            short answer = (short)Add(n1, n2);
            Console.WriteLine("Alargamento e estreitamento sem perda de dados: {0}", answer);

            // Abaixo, exemplo de conversão de "alargamento" e "estreitamento" de tipos com perda de dados.
            short n3 = 30000, n4 = 30000;
            short answer2 = (short)Add(n3, n4);
            Console.WriteLine("Alargamento e estreitamento com perda de dados: {0}", answer2);

            NarrowingAttempt();
            ProccessBytes();
            

            //
            // Declaração implícita de variáveis utilizando a palavra-chave var
            DeclareImplicitVars();
            DeclareImplicitNumerics();
            LinqQueryOverInts();

            //
            // Tópico sobre loops do C#.
            ForLoopExample();
            ForEachLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();

            // Tópico sobre Estruturas de deicisão e operadores relacionais e de igualdade.
            IfElsePatternMatching();
            ExecuteEfElseUsingConditionalOperator();
            ConditionalRefExample();

            // Tópico sobre a estrutura switch e sua melhorias nas versões 7 e 7.2 do C#
            SwitchExample();
            SwitchOnStringsExample();
            SwitchOnEnumExample();
            ExecutePatternMatchingSwitch();
            ExecutePatternMatchingSwitchWithWhen();

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

        //
        // Tópico sobre "estreitamento" e "ampliação" durante a conversão de tipos.
        //

        // Primeiro método de exemplo.
        // Este método permite que valores inteiros de tipos "inferiores", ex. Byte, Short, sejam fornecidos
        // sem qualquer perda de dados, desde que o valor esteja dentro da faixa de valores dos tipos
        // inferiores.
        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            
            // Converte explicitamente um inteiro para um byte, "estreitamente de tipo", sem perda de
            // dados, já que o número 200 está dentro da faixa do tipo inteiro e do tipo byte.
            myByte = (byte)myInt;
            Console.WriteLine("\n\nMétodo NarrowingAttempt():");
            Console.WriteLine("Valor de myByte: {0}", myByte);
        }

        // Usando a palavra checked para detectar a perda de dados.
        private static void ProccessBytes()
        {
            byte b1 = 100;
            byte b2 = 200;
            byte sum = 0;
            
            try
            {
                sum = checked((byte)Add(b1, b2));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n\nMétodo ProccessBytes():");
            Console.WriteLine("Soma: {0}", sum);
        }

        //
        // Entendendo a tipagem implicita de dados.
        //

        private static void DeclareImplicitVars()
        {
            Console.WriteLine("\n\nMétodo DeclareImplicitVras():");

            // Variáveis locais tipadas implícitamente são delcaradas como segue abaixo.
            var myInt = 0;
            var myBool = true;
            var myString = "Marchando...";

            Console.WriteLine("myInt é do tipo: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool é do tipo: {0}", myBool.GetType().Name);
            Console.WriteLine("myString é do tipo: {0}", myString.GetType().Name);
        }

        // Declarando númericos implícitamente.
        private static void DeclareImplicitNumerics()
        {
            Console.WriteLine("\n\nMétodo DeclareImplicitNumerics():");

            var myUint = 0u;
            var myInt = 0;
            var myLong = 0L;
            var myDouble = 0.5;
            var myFloat = 0.5F;
            var myDecimal = 0.5M;

            // Informando os tipos subjacentes de cada variável!
            Console.WriteLine("myUInt: {0}", myUint.GetType().Name);
            Console.WriteLine("myInt: {0}", myInt.GetType().Name);
            Console.WriteLine("myLong: {0}", myLong.GetType().Name);
            Console.WriteLine("myDouble: {0}", myDouble.GetType().Name);
            Console.WriteLine("myFloat: {0}", myFloat.GetType().Name);
            Console.WriteLine("myDecimal: {0}", myDecimal.GetType().Name);
        }

        // Amostra de uso necessário de var, já que é difícil saber qual será o tipo retornado.
        private static void LinqQueryOverInts()
        {
            Console.WriteLine("\n\nMétodo LinqQueryOverInts()");
            
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers where i < 10 select i;

            Console.Write("Valores do sub conjunto: ");
            foreach (var i in subset)
            {
                Console.Write(" {0}" + i);
            }
            Console.WriteLine();

            Console.WriteLine("Tipo de subset: {0}", subset.GetType().Name);
            Console.WriteLine("subset está definido em: {0}", subset.GetType().Namespace);
        }

        //
        // Tópico sobre laços de repetição, em inglês loop.

        // Primeiro loop, for.
        private static void ForLoopExample()
        {
            Console.WriteLine("\n\nMétodo ForLoopExample():");
            
            // A variável i somente exist dentro do escopo do for.
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("O número atual é: {0}", i);
            }

            // "i" não é acessível aqui!
        }

        // Itera um array utilizando um foreach
        private static void ForEachLoopExample()
        {
            Console.WriteLine("\n\nMétodo ForEaxhLoopExample():");

            // Foreach funciona apenas de forma linear!.
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string car in carTypes)
            {
                Console.WriteLine(car);
            }
        }

        // Método para apresentar o uso de do/while loop
        private static void WhileLoopExample()
        {
            Console.WriteLine("\n\nMétodo WhileLoopExample():");
            
            // O loop é executado até o usuário informe yes
            string userIsDone = "";

            while(userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("Dentro do loop...");
                Console.Write("Você está pronto? [yes] ou [no]:");
                userIsDone = Console.ReadLine();
            }
        }

        // Método para apresentar o uso do loop do/while.
        private static void DoWhileLoopExample()
        {
            Console.WriteLine("\n\nMétodo DoWhileLoopExample():");

            // Ao contrário do while, o do/while garante que o bloco de código
            // seja executado ao menos 1 vez!
            string userIsDone = "";

            do
            {
                Console.WriteLine("Dentro do loop...");
                Console.Write("Você está pronto? [yes] ou [no]:");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
        }

        // ================================================================================================================================
        //
        // Tópico:
        // Construções de decisões e operadores relacionais e igualdade!
        //
        // ================================================================================================================================
        
        // Método para apresentar o if/else utilizando o "pattern matching", introduzido no C# 7.
        private static void IfElsePatternMatching()
        {
            Console.WriteLine("\n\nMétodo IfElsePatternMatching():");

            object testItem1 = 123;
            object testItem2 = "Hello";

            if (testItem1 is string myStringValue1)
            {
                Console.WriteLine($"{myStringValue1} é uma strings.");
            }

            if (testItem1 is int myIntValue1)
            {
                Console.WriteLine($"{myIntValue1} é um int");
            }

            if (testItem2 is string myStringValue2)
            {
                Console.WriteLine($"{myStringValue2} é uma strings.");
            }

            if (testItem2 is int myIntValue2)
            {
                Console.WriteLine($"{myIntValue2} é um int");
            }
        }

        // Método para apresentar o operador condicional introduzido no C# 7.2
        private static void ExecuteEfElseUsingConditionalOperator()
        {
            Console.WriteLine("\n\nMétodo ExecuteEfElseUsingConditionalOperator()");

            // O operador ?: também conhecido como operador ternário serve para executar if/else simples, onde
            // apenas temos duas condições, ou true ou false;
            // Quando true, executa o código após o "?", quando false executa o código após o ":".
            string stringData = "Meu dado textual";
            Console.WriteLine(stringData.Length > 0 ? "O comprimento do texto é maior que 0" : "O comprimento do texto é menor que 0");
        }

        // Funcionalidade adicionada na versão 7.2 do C#.
        private static void ConditionalRefExample()
        {
            Console.WriteLine("\n\nMétodo ConditionalRefExample()");

            // A partir da versão 7.2 do C#, o operador ternário ?: pode retornar uma referência ao resultado
            // da condição.
            var smallArray = new int[] { 1, 2, 3, 4, 5 };
            var largeArray = new int[] { 10, 20, 30, 40, 50 };

            int index = 7;
            ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
            refValue = 0;

            index = 2;
            ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

            Console.WriteLine(string.Join(" ", smallArray));
            Console.WriteLine(string.Join(" ", largeArray));
        }

        // Uso básico da estrutura switch.
        private static void SwitchExample()
        {
            Console.WriteLine("\n\nMétodo SwitchExample():");

            // Utilização do switch para escolher um fluxo de execução.
            Console.WriteLine("1 [C#] - 2 [VB]");
            Console.WriteLine("Por favor, selecione sua linguagem preferida!");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch(n)
            {
                case 1:
                    Console.WriteLine("Boa escolha, C# é uma linguagem muito boa!");
                    break;
                case 2:
                    Console.WriteLine("VB: POO, Multithreading, e muito mais");
                    break;
                default:
                    Console.WriteLine("Bem... boa sorte com isso!");
                    break;
            }
        }

        // Avaliar strings, além dos números.
        private static void SwitchOnStringsExample()
        {
            Console.WriteLine("\n\nMétodo SwitchExample():");

            // Utilização do switch para escolher um fluxo de execução.
            Console.WriteLine("1 [C#] - 2 [VB]");
            Console.WriteLine("Por favor, selecione sua linguagem preferida!");

            string langChoice = Console.ReadLine();

            switch(langChoice.ToUpper())
            {
                case "C#":
                    Console.WriteLine("Boa escolha, C# é uma linguagem muito boa!");
                    break;
                case "VB":
                    Console.WriteLine("VB: POO, Multithreading, e muito mais");
                    break;
                default:
                    Console.WriteLine("Bem... boa sorte com isso!");
                    break;
            }
        }

        // Executando um switch em enumeração (enum)
        private static void SwitchOnEnumExample()
        {
            Console.WriteLine("\n\nMétodo SwitchOnEnumExample():");

            // Utilização do switch para escolher um fluxo de execução.
            Console.Write("Por favor, selecione seu dia favorito ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dado não válido!");
                return;
            }

            switch(favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Outro dia, outro dinheiro");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Ao menos não é segunda feira");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Dia legal");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Quase sexta...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Sextou!!!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Ótimo dia!");
                    break;
                // default:
                //     Console.WriteLine("Bem... boa sorte com isso!");
                //     break;
            }
        }

        // Recurso adicionado ao switch na versão 7 do C#, Pattern Macthing baseado no tipo
        // da variável sendo verificada.
        private static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("\n\nMétodo ExecutePatternMatchingSwitch()");

            //
            Console.WriteLine("1 [Inteiro 5] - 2 [String (\"Ola\")] - 3 [Decimal (2.5)]");
            Console.Write("Por favor, escolha uma opção: ");
            string userChoice = Console.ReadLine();
            object choice;

            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Olá";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            // Novo padrão de busca - pattern matching C# 7.
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Sua escolha é um inteiro.");
                    break;
                case string s:
                    Console.WriteLine("Sua escolha é uma string");
                    break;
                case decimal d:
                    Console.WriteLine("Sua escolha é um decimal");
                    break;
                default:
                    Console.WriteLine("Sua escolha é qualquer coisa");
                    break;
            }
        }

        // Agora utilizando a claúsula "when".
        private static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("\n\nMétodo ExecutePatternMatchingSwitchWithWhen()");

            //
            Console.WriteLine("1 [C#] - 2 [VB]");
            Console.Write("Por favor, escolha uma opção: ");
            object userChoice = Console.ReadLine();
            var choice = int.TryParse(userChoice.ToString(), out int c) ? c : userChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB, POO e multithreading, legal!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Ótima escolha, C# é uma linguagem legal");
                    break;
                default:
                    Console.WriteLine("Boa sorte com sua escolha");
                    break;
            }
        }

        // Na versão 8 do C# é possível utilizar expressões lambda (=>) e caracteres descatáveis (_).
        private static string FromRainbow(string colorBand)
        {
            return colorBand switch
            {
                "Red" => "#FF0000",
                "Orange" => "#FF7F00",
                "Yellow" => "#FFFF00",
                "Green" => "#00FF00",
                "Blue" => "#0000FF",
                "Indigo" => "#4B0082",
                "Violet" => "#9400D3",
                _ => "#FFFFFF",
            };
        }

        // Na versão 8 do C# é possível utilizar tuplas.
        private static string RockPaperScissors(string first, string second)
        {
            // Os dois valores são avaliados ao mesmo tempo e o switch tenta encontra um padrão correspondente
            return (first, second) switch
            {
                ("pedra", "papel") => "Papel vence",
                ("pedra", "tesoura") => "Pedra vence",
                ("papel", "pedra") => "Papel vence",
                ("papel", "tesoura") => "Tesoura vence",
                ("tesoura", "pedra") => "Pedra vence",
                ("tesoura", "papel") => "Tesoura vence",
                (_, _) => "Empate",
            };
        }
    }
}
