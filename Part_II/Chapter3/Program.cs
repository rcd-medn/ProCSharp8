﻿




using System;
using System.Threading.Tasks;

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
    }
}
