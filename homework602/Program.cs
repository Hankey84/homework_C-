﻿// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-” 

Console.Write("Веедите сроку в разном регистре: ");
string? str = Console.ReadLine();
Console.WriteLine($"\n{str} => {str!.ToLower()}");
