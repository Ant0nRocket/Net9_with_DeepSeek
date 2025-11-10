namespace T_0002_AbstractClass_vs_Interface;

class Program
{
    static void Main(string[] args)
    {
        // Create exatc printer and provide a document to print
        var printer = new ExactPrinter();
        printer.Print(new Document());

        // Or another way, create document and print it by itself
        var d = new Document();
        d.Print();

        // I think second variant is a peace of shit.
    }
}

// Document "can-do" -> it could print him-self (sic!)
class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine(this.ToString());
    }
}

// Everything that inherits this interface can print something
interface IPrintable
{
    void Print();

}

// There could be a lot of variants of printers, but all of them
// could print some IPrintable object
abstract class Printer
{
    // Our inheritants must implement Print()
    public abstract void Print(IPrintable document);

    // ... or could be a little bit another implementation
    public virtual void Print2(IPrintable document)
    {
        // Do something common for all printers
    }
}

class ExactPrinter : Printer
{
    public override void Print(IPrintable document)
    {
        Console.WriteLine(document.ToString());
    }

    public override void Print2(IPrintable document)
    {
        // We can call base method
        base.Print2(document);

        // ... or do something else
    }
}