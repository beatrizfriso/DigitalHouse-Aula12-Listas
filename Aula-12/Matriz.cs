
namespace Aula_12
{
    internal class Matriz
    {
        public char[,] num = new char[,] 
        {  
           { '7', '8', '9' },
           { '4', '5', '6' },
           { '1', '2', '3' },
        };

        public void imprime()
        {
            for (int i=0; i<num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {   
                    if (j == 1 || j == 2)
                    {
                        Console.Write(" | ");
                    }
                    
                    Console.Write($" {num[i, j]}");

                    
                }
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("\n------------");
                }
                
            }
        }
    }
}

