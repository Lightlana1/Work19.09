Console.WriteLine("Введите число больше 0:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 2;
if(number1 <= 0)
{
    Console.WriteLine("Вы ввели неверное значение");
}
else
{
    while (number2 <= number1)
    {
        Console.Write(number2 + ",");
        number2 = number2 + 2;
    }
}
