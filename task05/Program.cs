/*5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" 
*/

Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Целые числа от -N до N: ");
        
        for (int i = -N; i <= N; i++)
        {
            if (i == N)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
        }

        Console.WriteLine();
    
