using System;

public class Busca_Linear
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[] {2, 13, 16, 9, 8, 4, 10, 29, 30, 20};

        Console.Write("Digite o número que deseja buscar: ");

        if (!int.TryParse(Console.ReadLine(), out int numeroBuscado))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }

        int posicaoEncontrada = -1;

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == numeroBuscado)
            {
                posicaoEncontrada = i;
                break;
            }
        }

        if (posicaoEncontrada != -1)
        {
            Console.WriteLine($"O número {numeroBuscado} foi encontrado no vetor");
        }
        else
        {
            Console.WriteLine($"O número {numeroBuscado} não foi encontrado no vetor");      
        }
 
    }
 }  

