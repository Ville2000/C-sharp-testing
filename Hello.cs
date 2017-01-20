public class HelloWorld
{
    public static void Main()
    {
        int value = 10;
        string name = "Ville";
        System.Console.WriteLine(name);
        System.Console.WriteLine("Hello, World!");
        Message msg = new Message();
        msg.typeHei();
        System.Console.WriteLine(value);
        System.Console.WriteLine(name + value);
        typeWhatYouGet("Moikka!");
    }

    public static void typeWhatYouGet(string text)
    {
        System.Console.WriteLine(text);
    }
}

public class Message
{
    public void typeHei() {
        System.Console.WriteLine("Hei!");
    }
}
