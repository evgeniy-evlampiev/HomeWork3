// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число ");
int num1 = int.Parse(Console.ReadLine()!);
string num = Convert.ToString(num1);

if(num.Length == 5){
    if(num[0] == num[4])
    {
        if(num[1] == num[3]){
            Console.WriteLine($"{num}  является палиндромом");
        }
    }
    else{
        Console.WriteLine($"{num}  не является палиндромом");
    }
}
else{
    Console.WriteLine(" не является пятизначным числом ");
}
