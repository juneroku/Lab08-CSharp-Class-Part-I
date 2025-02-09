var myObj = new MyClass();

Console.WriteLine($"Default integer initialization F1 = {myObj.F1}"); // Implicit fields
Console.WriteLine($"Default string initialization F2 = {myObj.F2}");
Console.WriteLine($"Initialized integer F3 = {myObj.F3}"); // Explicit field initialization
Console.WriteLine($"Initialized string F4 = {myObj.F4}");

class MyClass
{
    public int F1;
    public string F2;
    public int F3 = 100;
    public string F4 = "ASDF";
}