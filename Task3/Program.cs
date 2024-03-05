// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

void Main()
{

Console.WriteLine("Введите строку: ");
string? a = Console.ReadLine();
char[] inputString = StringFirst(a);
//PrintArray(inputString);
char[] reverseString = a.ToCharArray();
Array.Reverse(reverseString);
Console.WriteLine(reverseString);
if (inputString == reverseString)
{
    Console.WriteLine("Да!");
}
else 
{
    Console.WriteLine("Нет!");
}


//var reverse = a.Reverse();
//Console.WriteLine(reverse);


char[] StringFirst(string? a)
{
char[] inputString = new char[a!.Length];
for (int i = 0; i < a.Length; i++)
{
inputString[i] = a[i];
}
return inputString;
}

void PrintArray(char[] inputString)
{
Console.WriteLine(inputString);
}

}
Main();


// void PrintReverse(char[] inputString, char[] reverseString)
// {
//     if (inputString == reverseString)
//     {
//         Console.WriteLine("Да!");
//     }
//     else 
//     {
//         Console.WriteLine("Нет!");
//     }
// }
// char[] StringReverse(string? a)
// {
// char[] outputString = new char[a!.Length];
// for (int i = a.Length;i >=0; i--)
// {
// outputString[i] = a[i];
// }
// return outputString;
// }
// void PrintArray1(char[] outputString)
// {
// Console.WriteLine(string.Join("", outputString));
// }