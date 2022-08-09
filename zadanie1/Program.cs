int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int value1;
value1 = Prompt("Введите первое число >");
int value2;
value2 = Prompt("Введите второе число >");
if (value1 == value2)
    {
    System.Console.Write("числа равны");
    return;
   } 
if (value1 > value2)
{
    System.Console.WriteLine($"максимальное число =  {value1} минимальное число =  {value2}");
}
else
{
    System.Console.WriteLine($"максимальное число =  {value2} минимальное число =  {value1}");
}

