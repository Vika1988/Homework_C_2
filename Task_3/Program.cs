/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7*/ 

Console.WriteLine("Введите число соответствующее дню недели: ");
int a = int.Parse(Console.ReadLine()!);

if(a < 1 || a > 7){
    Console.WriteLine("В неделе 7 дней. Введите число от 1 до 7");
    return;}

if(a == 1 || a == 2 || a == 3 || a == 4 || a == 5){
    Console.WriteLine("День недели не является выходным");}

if(a == 6 || a == 7){
    Console.WriteLine("Ура!!! Выходной!!!");}
    