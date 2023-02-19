//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



/*void FindPointOfCross (double k1, double k2, double b1, double b2)
{
    if(k1 == k2)
        Console.Write("Straights parallel");
    else if (k1 == k2 && b1 == b2)
        Console.Write("Straights match");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k2 * x) + b2;
        Console.Write($"The point of cross of two straights is ({x}; {y})");
    }
}
Console.Write("Input numbe one: ");
double num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two: ");
double num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number three: ");
double num_3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number four: ");
double num_4 = Convert.ToInt32(Console.ReadLine());
FindPointOfCross (num_1, num_2, num_3, num_4);
*/


//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


int CountPositivNumbers (int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine ("Input your number and press ENTER: ");
        int us_number = Convert.ToInt32(Console.ReadLine());  
        {
            if (us_number > 0)
            count = count + 1;    
        } 
    
    }
    return count;
}
   
Console.Write("Input your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());


int result = CountPositivNumbers (userNumber);
Console.WriteLine($"Count of entered numbers which is > 0 is {result}");
