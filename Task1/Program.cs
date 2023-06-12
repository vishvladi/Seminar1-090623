//  на вход 2 числа, на выход большее и меньшее
Console.Write("Введите первое число: ");
string inputedString = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString);
Console.WriteLine($"Вы ввели число {number1}");
Console.Write("Введите второе число: ");
inputedString = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString);
Console.WriteLine($"Вы ввели число {number2}");

if (number1 > number2){
     
    Console.WriteLine($"Наибольшее число {number1}, а наименьшее число {number2}");
}
else
{
   Console.WriteLine($"Наибольшее число {number2}, а наименьшее число {number1}"); 
}

