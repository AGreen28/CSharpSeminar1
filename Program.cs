/*
//Задача 1.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("Квадрат равен: " + result);

//Задача 2.

Console.Write("Введите целое число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("Первое число является квадратом второго");
else
    Console.WriteLine("Первое число не является квадратом второго");

//Задача 3.

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
{
   Console.WriteLine("Неверный номер дня!"); 
}
else
{
    if(day == 1)
        Console.WriteLine("Это понедельник");
    if(day == 2)
        Console.WriteLine("Это вторник");
    if(day == 3)
        Console.WriteLine("Это среда");
    if(day == 4)
        Console.WriteLine("Это четверг");
    if(day == 5)
        Console.WriteLine("Это пятница");
    if(day == 6)
        Console.WriteLine("Это суббота");
    if(day == 7)
        Console.WriteLine("Это воскресенье");
}

//Задача 4.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if(num < 0)
{
    current = num;
    num = num * (-1);
}
else
{
    current = -1 * num;
}

while(current <= num)
{
    Console.Write(current + " ");
    current++; //current = current + 1
}

*/

//Задача 5.

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("Некорректное число!");
else
{
    int a = num % 10;
    Console.WriteLine("Последнее число = " + a);
}