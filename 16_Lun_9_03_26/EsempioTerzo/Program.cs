public class Program
{
   public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un log alla prima istanza.");
      Console.WriteLine($"-2 Per aggiungere un log alla seconda istanza.");
      Console.WriteLine($"-3 Per visualizzare tutti i log nella prima istanza..");
      Console.WriteLine($"-4 Per visualizzare tutti i log nella seconda istanza..");
      Console.WriteLine($"-5 Per visualizzare gli hashcode delle istanze.");
      Console.WriteLine($"-0 Per uscire.");
   }

   public static void Main(string[] args)
   {
      Logger inst1 = Logger.istanza;

      Logger inst2 = Logger.istanza;

      bool isRunning = true;
      string msg;

      while (isRunning)
      {
         Menu();
         string scelta = Console.ReadLine();
         switch (scelta)
         {
            //Aggiornare il valore della prima istanza
            case ("1"):
               Console.WriteLine($"Inserisci il messaggio:");
               msg = Console.ReadLine();
               inst1.Log(msg);
               break;

            //Aggiornare il valore della seconda istanza
            case ("2"):
               Console.WriteLine($"Inserisci il messaggio:");
               msg = Console.ReadLine();
               inst2.Log(msg);
               break;
            
            //Visualizzare i log della prima istanza
            case ("3"):
               Console.WriteLine($"Logs prima istanza:");
               inst1.MostraLog();
               break;

            //Visualizzare i log della seconda istanza
            case ("4"):
               Console.WriteLine($"Logs seconda istanza:");
               inst2.MostraLog();
               break;

            //Visualizzare gli haschcode
            case ("5"):
               Console.WriteLine($"Prima ist: ");
               inst1.InfoIstanza();
               Console.WriteLine($"Seconda ist:");
               inst2.InfoIstanza();
               break;


            //Uscita
            case ("0"):
               Console.WriteLine($"Adioss");
               isRunning = false;
               break;

            //Errore di battitura
            default:
               Console.WriteLine($"Scelta non valida");
               break;
         }
         
      }
      /*
      Console.WriteLine($"Primo log aggiornato: CiaoCiccio");
      
      inst1.Log("CiaoCiccio");

      Console.WriteLine($"Secondo log aggiornato: CiaoCaio");
      inst2.Log("CiaoCaio");

      Console.WriteLine($"Terzo log aggiornato: Maramao");
      inst1.Log("Maramao");

      Console.WriteLine($"Quarto log aggiornato: Mirimeo");
      inst2.Log("Mirimeo");

      Console.WriteLine($"Log della prima istanza:");
      
      inst1.MostraLog();

      Console.WriteLine($"Log della seconda istanza:");

      inst2.MostraLog();

      Console.WriteLine($"Info prima istanza: ");
      inst1.InfoIstanza();

      Console.WriteLine($"Info seconda istanza: ");
      inst2.InfoIstanza();
      */
   }
}