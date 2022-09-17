// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int num0 = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num1 = int.Parse(Console.ReadLine());
// if (num1==num0){
//     Console.Write("Числа равны");
// }
// else{
//     if(num0 > num1){
//     Console.Write("Первое число больше второго");
//     }
//     else{
//         Console.Write("Второе число больше первого");
//     }
// }

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int num0 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите третее число: ");
// int num2 = int.Parse(Console.ReadLine());
// if(num0 > num1){
//     if (num0 > num2){
//         Console.Write("Первое число является максимальным");
//     }
//     else Console.Write("третее число является максимальным");
// }
// else{
//     if(num1 > num2){
//         Console.Write("Второе число является макисмальным");
//     }
//     else Console.Write("Третее число является максимальным");
// }


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введи число: ");
// int num = int.Parse(Console.ReadLine());
// if (num%2 == 0){
//     Console.Write(num+" является чётным");
// }
// else {
// Console.Write(num+" является нечётным");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num > 1){
    int ordinal = 0;
    while(ordinal < num - 1){
        ordinal += 2;
        Console.Write(ordinal+" ");
    }
}
else{
    Console.Write("Нет чётных чисел меньше или равным введённому");
}
