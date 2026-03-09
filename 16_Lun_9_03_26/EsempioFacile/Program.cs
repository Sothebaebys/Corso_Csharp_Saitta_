public class Program
{
   public static void Menu()
   {
      Console.WriteLine($"Benvenuto\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un valore nuovo o aggiornarne uno esistente.");
      Console.WriteLine($"-2 Per leggere il valore corrispondente ad un altro");
      Console.WriteLine($"-3 Per visualizzare tutti i valori.");
      Console.WriteLine($"-4 Per visualizzare l'indirizzo di istanza.");/*
      Console.WriteLine($"-5 Per visualizzare tutti i valori.");
      Console.WriteLine($"-6 Per cercare corsi per nome docente.");
      Console.WriteLine($"-7 Per visualizzare il messaggio univoco del corso.");*/
      Console.WriteLine($"-0 Per uscire.");

   }
   public static void Main(string[] args)
   {
      var mod1 = S_ConfigurazioneSistema.istanza;
      var mod2 = S_ConfigurazioneSistema.istanza;


      bool isRunning = true;
      int counter = 1;

      while (isRunning)
      {

         Menu();
         string scelta = Console.ReadLine();
         switch (scelta)
         {
            case ("1"):
               Console.WriteLine($"Inserisci chiave:");
               string chiave = Console.ReadLine();
               
               Console.WriteLine($"Inserisci il valore:");
               string valore = Console.ReadLine();

               if (counter % 2 == 0)
               {
                  mod1.Imposta(chiave,valore);
               }
               else
               {
                  mod2.Imposta(chiave,valore);
               }
               break;

            //Leggere il valore corrispondente
            case ("2"):
               Console.WriteLine($"Seleziona la chiave di cui vuoi vedere il valore");
               string SChiave =Console.ReadLine();
               
               mod1.Leggi(SChiave);
               break;
            case ("3"):
               mod2.StampaTutte();
               break;
            case ("4"):
               Console.WriteLine($"{mod1.GetHashCode().ToString()}");
               Console.WriteLine($"{mod2.GetHashCode().ToString()}");
               
               break;
            case ("n"):
               break;
            case ("0"):
               Console.WriteLine($"Goodbye");
               isRunning = false;
               break;
            default:
               break;
         }
         counter ++;
      }


      //mod1.aggiorno();
   }
}