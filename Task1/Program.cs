// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

void Main()
{


char[,] chars = {{'c', 'a', 'b'},
{'d','e','b'}};
string str = "";

foreach(char letter in chars)
{
    str+=letter;
}
 System.Console.WriteLine(str);







}
Main();