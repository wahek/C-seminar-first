﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int num0 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1==num0){
    Console.Write("Числа равны");
}
else{
    if(num0 > num1){
    Console.Write("Первое число больше второго");
    }
    else{
        Console.Write("Второе число больше первого");
    }
}


