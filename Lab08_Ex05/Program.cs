var myObj = new MyClass();
myObj.Info();

class MyClass
{
    int F1;
    string F2;
    int F3 = 100;
    string F4 = "ASDF";

    public void Info()
    {
        Console.WriteLine($"Default integer initialization F1 = {F1}"); // Implicit fields
        Console.WriteLine($"Default string initialization F2 = {F2}");
        Console.WriteLine($"Initialized integer F3 = {F3}"); // Explicit field initialization
        Console.WriteLine($"Initialized string F4 = {F4}");
    }
}