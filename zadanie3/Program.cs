int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int value1;
value1 = Prompt("Введите число >");
if (value1 % 2 == 0)
 {System.Console.WriteLine($"число {value1} четное");}
else
 {System.Console.WriteLine($"число {value1} не четное");}