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
int value3;
value3 = Prompt("Введите третье число >");
if (value1 == value2)
 {
    if (value2 == value3)
       {
        System.Console.Write("все числа равны");
        return;
         }
   } 
int max = value1;   
if (value2 > max) max=value2;
if (value3 > max) max=value3;
System.Console.WriteLine($"максимальное число = {max}");