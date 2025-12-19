// See https://aka.ms/new-console-template for more information
using Day2Demo;
Console.WriteLine("Hello, World!");

Student sObj = new Student(123,"Manish","Pilibhit");

sObj.DisplayDetails(sObj);

sObj = new Student(123,"Manish","Delhi");

sObj.DisplayDetails(sObj);

string[] citites = {"Pune","Delhi","Mumbai","Chennai"};

foreach(var item in citites)
{
    System.Console.WriteLine(item);
}

