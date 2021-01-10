





using System;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================================================================================================================
            // Aplicativo console para acompanhar o capítulo 4 do livro Pro C# 8 and .NET Core 3
            // ============================================================================================================================
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Capítulo 4 - Core C# Programming Constructs Part 2");

            // ============================================================================================================================
            //  Tópico - Understanding C# Arrays:
            // ============================================================================================================================
            SimpleArray();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMutidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFuncionality();

            // ============================================================================================================================
            // Tópico - Methods
            // Não ocorrerá chamadas aos métodos criados para para o tópico afim já que os exemplos apresentados
            // servem para apresentar a estrutura dos métodos e alguns conceitos adicionados na versão 7 & e 8 do C#.
            // ============================================================================================================================

            // ============================================================================================================================
            // Tópico - Method Parameters.
            // ============================================================================================================================

            Console.WriteLine("\n");
        }

        #region Tópico: Understanding C# Arrays
        // ================================================================================================================================
        //  Método para apresentar a declaração básica de um array.
        // ================================================================================================================================
        static void SimpleArray()
        {
            Console.WriteLine("Método: SimpleArray()");

            // ============================================================================================================================
            // Criação de um simples array com 3 números inteiros.
            // Em seguida atribui se um número inteiro a cada índice do array.
            // Após a atribuição, ocorre uma iteração através do array para "imprimir" cada valor.
            // ============================================================================================================================
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int item in myInts)
            {
                Console.WriteLine(item);
            }

            // Criação de um simples array com para 100 strings.
            string[] booksOnDotNet = new string[100];
        }

        // ================================================================================================================================
        //  Método para apresentar a sintaxe de inicialização de um array.
        // ================================================================================================================================
        static void ArrayInitialization()
        {
            Console.WriteLine("\n\nMétodo ArrayInitialization():");

            // Sintaxe de inicialização de um array.
            string[] stringArray = new string[] { "one", "two", "three" };

            // Retorna a quantidade de elementos.
            Console.WriteLine("O array stringArray possui {0} elementos.", stringArray.Length);

            // Sintaxe de inicialização de um array sem utilizar a palavra "new".
            bool[] boolArray = { false, true, true };
            Console.WriteLine("O array boolArray possui {0} elementos.", boolArray.Length);

            // Sintaxe de inicialização de um array utilizando a palavra "new" e especificando o tamanho do array.
            int[] intArray = new int[4] { 10, 20, 30, 40 };
            Console.WriteLine("O array intArray possui {0} elementos.", intArray.Length);
        }

        // ================================================================================================================================
        //  Método para apresentar a declaração de um array implicitamente tipado.
        // ================================================================================================================================
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("\n\nMétodo DeclaraImplicitArrays():");

            // a é um array de inteiros!
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a é um: {0}", a.ToString());

            // b é um array de double!
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b é um: {0}", b.ToString());

            // c é um array de strings!
            var c = new[] { "Olá", null, "Mundo!" };
            Console.WriteLine("c é um: {0}", c.ToString());
        }

        // ================================================================================================================================
        //  Método para apresentar a declaração de um array de objetos
        // ================================================================================================================================
        static void ArrayOfObjects()
        {
            Console.WriteLine("\n\nMétodo ArrayOfObjects():");

            // Array de objetos (tipos) diferentes.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1986, 08, 05);
            myObjects[3] = "Form & Void";

            foreach (var item in myObjects)
            {
                Console.WriteLine("Tipo: {0} - Valor: {1}", item.GetType(), item);
            }
        }

        // ================================================================================================================================
        //  Método para apresentar a declaração/criação de arrays retangular/tabular.
        // ================================================================================================================================
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("\n\nMétodo RectMultidimensionalArray():");

            // Declaração do array retangular/tabular.
            // 3 linhas e 4 colunas.
            int[,] myMatrix = new int[3,4];

            // Populando o array (3 * 4)
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            // Populando o array (3 * 4)
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // ================================================================================================================================
        //  Método para apresentar a declaração/criação de arrays identados.
        // ================================================================================================================================
        static void JaggedMutidimensionalArray()
        {
            Console.WriteLine("\n\nMétodo JaggedMutidimensionalArray():");

            int[][] myJaggedArray = new int[5][];

            // Preenche o array identado.
            for (int i = 0; i < myJaggedArray.Length; i++)
            {
                myJaggedArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    Console.Write(myJaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        // ================================================================================================================================
        //  Métodos para apresentar a a passagem de arrays como parâmetro e valor de retorno de um método.
        // ================================================================================================================================
        static void PrintArray(int[] myInts)
        {
            // Imprime os itens do array.
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("O item {0} é {1}.", i, myInts[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Olá", "de", "GetStringArray" };
            
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("\n\nMétodo PassAndReceiveArrays():");

            // Passando um array.
            int[] ages = { 20, 25, 30, 40 };
            PrintArray(ages);

            // Recebendo um array!
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
        }

        // ================================================================================================================================
        //  Método para apresentar alguns métodos utilitários para arrays.
        // ================================================================================================================================
        static void SystemArrayFuncionality()
        {
            Console.WriteLine("\n\nMétodo SystemArrayFuncionality()");

            // Inicializa um array
            string[] gothicBands = { "Tones on Tail", "Baughaus", "Syster of Mercy" };

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Inverte os array.
            Array.Reverse(gothicBands);
            Console.WriteLine("Array invertido!");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Apaga os 2 últimos elementos do array.");
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
        }
        #endregion

        #region Tópico: Methods
        // ================================================================================================================================
        // Método de exemplo para apresentar a técnica de "corpo de expressão" (expression-bodied) para métodos.
        // O método Add pode ser escrito da maneira tradicional, o resultado seria o mesmo.
        //
        // static int Add(int x, int y)
        // {
        //      return x + y;
        // }
        // ================================================================================================================================
        static int Add(int x, int y) => x + y;

        // ================================================================================================================================
        // Método para apresentar a declaração de funções locais (local functions), métodos dentro de outros métodos.
        // Conceito adicional no C# 7.
        // ================================================================================================================================
        static int AddWrapper(int x, int y)
        {
            // Chama o método interno (local function).
            return Add();

            // Add() é o método interno (local function).
            int Add()
            {
                return x + y;
            }
        }

        // ================================================================================================================================
        // Método apresenta o uso métodos locais estáticos, adicionado no C# 8.
        // ================================================================================================================================
        static int AddWrapperWithStatic(int x, int y)
        {
            // Com essa nova técnica o método Add não poderá alterar os valores do parâmetros x e y
            // algo que pode ocorrer no exemplo anterior.
            return Add(x, y);

            static int Add(int x, int y)
            {
                return x + y;
            }
        }
        #endregion

        #region Tópico: Method Parameters
        // ================================================================================================================================
        // Método apresenta o uso 
        // ================================================================================================================================
        #endregion
    }
}
