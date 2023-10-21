/*
28. Напишите программу, которая принимает на вход 
число N и выдаёт произвидение чисел от 1 до N.
4-> 24
5->120
*/

int Rrompt(string massage)
{
   System.Console.WriteLine(massage);
   string value=Console.ReadLine();
   int result=Convert.ToInt32(value);
   return result;    
}

double MultNumber (int varA){

    int result = 1;
    for (int i = 1; i <= varA; i++)
    {
        result = result * i;
    }

    return result; 
}

int varA = Rrompt("Введите число: ");
double result = MultNumber(varA);
System.Console.WriteLine(result);
