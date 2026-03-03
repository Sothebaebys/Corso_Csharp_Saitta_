using System.Security.Cryptography.X509Certificates;

class Program
{
      public static void Menu()
   {
      Console.WriteLine($"\nSeleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un nuovo operatore.");
      Console.WriteLine($"-2 Per Vedere tutti gli operatori");
      Console.WriteLine($"-3 Per vedere i compiti di tutti gli operatori.");
      Console.WriteLine($"-0 Per uscire.");

   }

   public static void TipoOperatore()
   {
      Console.WriteLine($"Seleziona il tipo di operatore da inserire.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un nuovo operatore per le emergenze.");
      Console.WriteLine($"-2 Per aggiungere un nuovo operatore addetto alla sicurezza");
      Console.WriteLine($"-3 Per aggiungere un nuovo operatore addetto alla logistica");
   }


   public static void Main(string[] args)
   {
      string nome, turno, areaSorvegliata;
      int livelloUrgenza, numConsegne;
      
      List<Operatore> listaOperatori = new List<Operatore>();
      bool isRunning = true;
      Console.WriteLine($"Benvenuto!");
      
      while(isRunning)
      {
         Menu();
         string scelta = Console.ReadLine();
         switch (scelta)
         {
            //Aggiungere operatore
            case ("1"):
               TipoOperatore();
               string selOperatore = Console.ReadLine();
               switch (selOperatore)
               {
                  case ("1"):
                  //Emergenze
                     Console.WriteLine($"Inserisci il nome dell'operatore:");
                     nome = Console.ReadLine();

                     Console.WriteLine($"Inserisci il turno (giorno/notte)");
                     turno =Console.ReadLine();

                     Console.WriteLine($"Inserisci il livello di urgenza (da 1 a 5)");
                     livelloUrgenza = int.Parse(Console.ReadLine());

                     listaOperatori.Add(new OperatoreEmergenza(nome, turno, livelloUrgenza));

                     break;
                  
                  case ("2"):
                  //Sicurezza
                     Console.WriteLine($"Inserisci il nome dell'operatore:");
                     nome = Console.ReadLine();

                     Console.WriteLine($"Inserisci il turno (giorno/notte):");
                     turno =Console.ReadLine();

                     Console.WriteLine($"Inserisci l'area di sorveglianza:");
                     areaSorvegliata = Console.ReadLine();
                     
                     listaOperatori.Add(new OperatoreSicurezza(nome,turno,areaSorvegliata));

                     break;
                  case ("3"):
                  //Logistica
                     Console.WriteLine($"Inserisci il nome dell'operatore:");
                     nome = Console.ReadLine();

                     Console.WriteLine($"Inserisci il turno (giorno/notte)");
                     turno =Console.ReadLine();

                     Console.WriteLine($"Inserisci il numero di consegne:");
                     numConsegne = int.Parse(Console.ReadLine());

                     listaOperatori.Add(new OperatoreLogistica(nome,turno,numConsegne));
                     break;

                  default:
                     Console.WriteLine($"Scelta non valida.");
                     break;
               }
               
               break;
            //Vedere tutti gli operatori
            case ("2"):
               foreach (Operatore item in listaOperatori)
               {
                  Console.WriteLine($"Nome : {item.Nome}");
                  Console.WriteLine($"Turno: {item.Turno}");
                  Console.WriteLine($"Tipo: {item.GetType()}");

               }
               break;

            // Vedere i compiti
            case ("3"):
               foreach (Operatore item in listaOperatori)
               {
                  item.EseguiCompito();
                  
               }
               break;
            case ("0"):

               Console.WriteLine($"Arrivederci e grazie!");
               isRunning = false;

               break;
            default:
               Console.WriteLine($"Scelta non valida, ritenta...");
               break;
         }
         
      }
   }
}
