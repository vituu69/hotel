using System;
using System.Globalization;

namespace Corse {
    class Program {
        static void Main(string[] args) {
        
            //inicio do meu vetor
            System.Console.WriteLine("quantos quartos desejam alugar?");
            Estudantes[] vetor = new Estudantes[10];
            int n = int.Parse(Console.ReadLine());
            
            // cria as alocacoes dos meus ospedis, vou percorrer meu vetor por completo 
            // para ver se tem espacos validos
            for(int i=1; i<=n; i++) {
                System.Console.WriteLine();
                System.Console.WriteLine($"aluguel {i}");
                System.Console.Write("nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string gmail = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());     
                vetor[quarto] = new Estudantes(nome, gmail);
            }

            // logica que verifica quais espacos do meu vetor esta vazil
            System.Console.WriteLine();
            System.Console.WriteLine("Quartos ocupados");
            for(int i=1; i<10; i++) {
                if(vetor[i] != null) {
                    System.Console.WriteLine(i + ": " + vetor[i]);
                }
            }


        }
    }
}