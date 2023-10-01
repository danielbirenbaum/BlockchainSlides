using System;
using System.Collections.Generic;


namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tempo de complexidade -> O(n) No pior dos casos irá percorrer os n elmentos para encontrar o elemento desejado.
            LinkedList<String> minhaLista = new LinkedList<string>();

            //Através da função é adicionando um novo nó na lista
            //
            minhaLista.AddLast("Daniel");
            //Daniel apontará para Carlos
            minhaLista.AddLast("Carlos");
            minhaLista.AddLast("Pedro");
            minhaLista.AddLast("Jonas");
            minhaLista.AddLast("Davi");

            //Encontra o primeiro nó
            System.Console.WriteLine(minhaLista.First());
        }
    }
}