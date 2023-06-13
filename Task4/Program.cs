// На вход число N, а на выходе все четные числа от 1 до N.
Console.Write("Введите число > 1 ");
string inputedString = Console.ReadLine();
int N = Convert.ToInt32(inputedString);
Console.WriteLine($"Вы ввели число {N}");
Console.WriteLine($"Все четные числа от 1 до {N}:");
int count = 1;
while (count <= N){
    if(count % 2 == 0){
    Console.Write(count + " ");
    }
    count ++;
}
    

