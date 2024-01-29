using TestesUnitarios;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Exemplo de utilização dos testes unitários
        ExecutarTestes();
    }

    static void ExecutarTestes()
    {
        // Testes para ValidacaoLista
        ValidacaoListaTestes();

        // Testes para ValidacaoString
        ValidacaoStringTestes();
    }

    static void ValidacaoListaTestes()
    {
        ValidacaoLista validacaoLista = new ValidacaoLista();

        // Teste 1
        List<int> listaTeste1 = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"A lista contém o item 3? {validacaoLista.ListaContemItem(listaTeste1, 3)}");

        // Teste 2
        List<int> listaTeste2 = new List<int> { 10, 20, 30 };
        Console.WriteLine($"A soma da lista é 60? {validacaoLista.SomaLista(listaTeste2) == 60}");

        // Teste 3
        List<int> listaTeste3 = new List<int>();
        Console.WriteLine($"A soma da lista vazia é 0? {validacaoLista.SomaLista(listaTeste3) == 0}");

        // Teste 4
        List<int> listaTeste4 = new List<int>();
        validacaoLista.RemoverElementoLista(listaTeste4, 10);
        Console.WriteLine($"A lista está vazia após remover o elemento inexistente? {listaTeste4.Count == 0}");

        // Teste 5
        List<int> listaTeste5 = new List<int> { 1, 2, 3, 4, 5 };
        validacaoLista.RemoverElementoLista(listaTeste5, 3);
        Console.WriteLine($"A lista contém o item 3 após removê-lo? {validacaoLista.ListaContemItem(listaTeste5, 3)}");

        // Teste 6
        List<int> listaTeste6 = new List<int> { 1, 2, 2, 3, 3, 4 };
        Console.WriteLine($"A lista contém elementos duplicados? {validacaoLista.ListaContemDuplicatas(listaTeste6)}");
    }

     static void ValidacaoStringTestes()
    {
        ValidacaoString validacaoString = new ValidacaoString();

        // Teste 1
        string stringTeste1 = "Teste";
        Console.WriteLine($"A string está vazia? {validacaoString.VerificarStringVazia(stringTeste1)}");

        // Teste 2
        string stringTeste2 = "Hello, ";
        string stringTeste3 = "World!";
        Console.WriteLine($"A concatenação das strings é 'Hello, World!'? {validacaoString.ConcatenarStrings(stringTeste2, stringTeste3) == "Hello, World!"}");

        // Teste 3
        string stringTeste4 = "OpenAI";
        Console.WriteLine($"O comprimento da string 'OpenAI' é 6? {validacaoString.ObterComprimentoString(stringTeste4) == 6}");
    }
}    
