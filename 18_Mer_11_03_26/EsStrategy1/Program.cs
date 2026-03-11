public class Program
{
   public static void Main(string[] args)
   {

      IOsservatore log = new Log();
      var calcolatrice = new Calcolatrice();

      calcolatrice.Aggiungi(log);

      bool IsRunning = true;
      Console.WriteLine($"Benvenuto");
      
      while (IsRunning)
      {
         Console.WriteLine($"Seleziona il tipo di operazione :\n + per addizione \n - per sottrazione \n / per divisione \n * per moltiplicazione");
         string sceltaOp = Console.ReadLine();
         switch (sceltaOp)
         {
            case ("+"):
               calcolatrice.ImpostaStrategia(new SommaStrategia());
               break;
            case ("-"):
               calcolatrice.ImpostaStrategia(new SottraiStrategia());
               break;
               
            case ("*"):
               calcolatrice.ImpostaStrategia(new MoltiplicaStrategia());
               break;
            case ("/"):
               calcolatrice.ImpostaStrategia(new DividiStrategia());
               break;
            
            default:
               Console.WriteLine($"Scelta non valida");
               
               break;
         }

         Console.WriteLine($"Inserisci il primo valore numerico:\n");
         double num1 = double.Parse(Console.ReadLine());
         
         Console.WriteLine($"Inserisci il secondo valore numerico:\n");
         double num2 = double.Parse(Console.ReadLine());

         Console.WriteLine($"\nEseguo il calcolo...");

         calcolatrice.EseguiStrategia(num1,num2);
         
         Console.WriteLine($"Vuoi eseguire altre operazioni ? (Y/N)");
         string scelta = Console.ReadLine();
         if (scelta.ToLower() != "y")
         {
            Console.WriteLine($"Arrivederla!");
            IsRunning = false;
         }
      }
   }


}