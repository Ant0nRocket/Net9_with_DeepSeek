namespace T_0002_AbstractClass_vs_Interface;

class Program
{
    static void Main(string[] args)
    {
        var printer = new ExactPrinter();
        printer.Print(new Document());
    }
}

class Document : IPrintable
{

}

interface IPrintable
{

}

abstract class Printer
{
    public abstract void Print(IPrintable document);
}

class ExactPrinter : Printer
{
    public override void Print(IPrintable document)
    {
        Console.WriteLine(document.ToString());
    }
}