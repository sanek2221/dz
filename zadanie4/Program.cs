int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int value;
value = Prompt("Введите число >");
if (value < 0)
    {
    System.Console.WriteLine("Число меньше нуля");
    }
int i;
i = 1; //стартовое значение
while (value >= i)
   {
     if (i % 2 == 0)
        System.Console.WriteLine(i);
     i++;
   }