﻿//Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
void Method2v2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2("Текст сообщения.");
//Method2v2("Текст", 4);
//Method2v2(count: 4, msg: "Новый текст");

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }

    return result;
}
string res = Method4(10, "Asdf");
Console.WriteLine(res);