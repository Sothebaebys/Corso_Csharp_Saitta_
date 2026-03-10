public class Program
{
   public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un computer col modulo 1.");
      Console.WriteLine($"-2 Per aggiungere una stampante col modulo 1.");
      Console.WriteLine($"-3 Per aggiungere un computer col modulo 2.");
      Console.WriteLine($"-4 Per aggiungere una stampante col modulo 2.");
      Console.WriteLine($"-5 Per visualizzare una configurazione dai registri..");
      Console.WriteLine($"-6 Per visualizzare i registri totali..");

      Console.WriteLine($"-7 Per visualizzare gli indirizzi delle istanze..");
      Console.WriteLine($"-0 Per uscire.");
   }
   public static void Main(string[] args)
   {
      ModuloA moduloA = new ModuloA();
      ModuloB moduloB = new ModuloB();

      string scelta;
      ConfigurazioneSistema registro = ConfigurazioneSistema.GetIstanza;
      int id = 10;
      bool isRunning = true;
      Console.WriteLine($"Benvenuto");

      while (isRunning)
      {
         id ++;
         Menu();
         scelta = Console.ReadLine();

         switch (scelta)
         {
            //PC MODULO A
            case ("1"):
               Console.WriteLine($"Text");

               
               IDispositivo computerA = moduloA.Factory("computer");

               registro.Imposta(id.ToString(),"computer");
               
               break;
            //PC MODULO A
            case ("2"):
               Console.WriteLine($"Text");
               
               IDispositivo stampanteA = moduloA.Factory("stampante");
               
               registro.Imposta(id.ToString(),"stampante");
               
               
               break;
            //PC MODULO B
            case ("3"):
               Console.WriteLine($"Text");
               
               IDispositivo computerB = moduloB.Factory("computer");
               
               registro.Imposta(id.ToString(),"computer");
               
               break;
            //PC MODULO B
            case ("4"):
               Console.WriteLine($"Text");
               
               IDispositivo stampanteB = moduloB.Factory("stampante");
               
               registro.Imposta(id.ToString(),"stampante");
               
               break;
            case ("5"):
               Console.WriteLine($"Seleziona l'id");
               string idDiz = Console.ReadLine();
               
               registro.Leggi(idDiz);
               break;
            case ("6"):

               registro.StampaTutte();
               break;

            case ("7"):
               if (ReferenceEquals(moduloA,moduloB))
               {
                  Console.WriteLine($"Stesso indirizzo");
                  
               }
               else
               {
                  Console.WriteLine($"Indirizzi diversi..");
                  
               }
               break;

            case ("0"):
               Console.WriteLine($"Arrivedorsci!");
               isRunning = false;
               break;

            default:
               Console.WriteLine($"Scelta non valida..");
               break;
         }
         
      }
      
   }
}