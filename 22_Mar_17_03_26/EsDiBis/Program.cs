/*
Esercizio 1 

Crea una classe Printer che ha una proprietà ILogger settabile dall'esterno. 

L'interfaccia ILogger ha un metodo Log. 

Implementa un logger che stampa su console. 

Chiama il metodo Print() che usa il logger per stampare un messaggio.
*/
public interface ILogger
{
   void Log(string msg);
}

public class Logger : ILogger
{
   public void Log(string msg)
   {
      Console.WriteLine(msg);
   }
}

public class Printer
{
   public ILogger log  {get; set;}

   public void Print()
   {
      if (log == null)
      {
         return;
      }
      Console.WriteLine($"Scrivi mess");
      
      log.Log(Console.ReadLine());
   }
}

class Program
{
   public static void Main(string[] args)
   {
      Printer printer = new Printer();
      printer.log = new Logger();
      printer.Print();
   }
}