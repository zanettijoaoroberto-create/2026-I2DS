using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Comentário de linha 
        /*
           Comentaeio de Bloco 
           Pode ter varias linhas
        */

        //Imprimir uma linha de texto na tela
        Console.WriteLine("Programação Orienta a Objetos\n");
        Console.WriteLine("Abstração - 1° Pilar da POO");

        /* Criar um classe em C# 
        A Classe deve ser declarada fora do bloco de programa 
        */ 

        /* Criar um Objeto a partir de uma class */

        pet pet1 = new pet();

        pet1.nome = "Totó";
        pet1.tipo = "Cachorro";
        pet1.idade = 3;

        pet1.MostrarNome();


    }
                public class pet // Nome da classe sempre inicia com letras MAIUSCULAS 
        {
            // Declaração dos Atributos

            public string nome; 

            public string tipo;

            public int idade; 

            // Declaração dos Métodos
            public void MostrarNome()
            {
            Console.WriteLine("Meu nome é" + this.nome);
            }
        }

    }
