using System;

public class Program
{
   //public static List<Soldato> listaSoldati = new List<Soldato>();
   
   public static string nomeS, gradoS, armaS;
   public static int anniServizioS, calibroS;
   public static void Menu()
   {
      Console.WriteLine($"Benvenuto\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un nuovo Fante.");
      Console.WriteLine($"-2 Per aggiungere un nuovo Artigliere");
      Console.WriteLine($"-3 Per visualizzare tutti i soldati con descrizione.");
      Console.WriteLine($"-0 Per uscire.");
   }




   public static void Main(string[] args)
   {
      List<Soldato> listaSoldati = new List<Soldato>();

      bool isRunning = true;

      while(isRunning)
      {
         Menu();
         string scelta = Console.ReadLine();

         switch (scelta)
         {
            case ("1"):
               Console.WriteLine($"Inserisci il nome del soldato:");
               nomeS = Console.ReadLine();

               Console.WriteLine($"Inserisci il grado:");
               gradoS = Console.ReadLine();

               Console.WriteLine($"Inserisci il nome dell'arma:");
               armaS = Console.ReadLine();

               Console.WriteLine($"Inserisci la durata del servizio:");
               anniServizioS = int.Parse(Console.ReadLine());


               Fante fante1 = new Fante(nomeS,gradoS,anniServizioS,armaS);

               listaSoldati.Add(fante1);
               break;

            case ("2"):
               Console.WriteLine($"Inserisci il nome del soldato:");
               nomeS = Console.ReadLine();

               Console.WriteLine($"Inserisci il grado:");
               gradoS = Console.ReadLine();

               Console.WriteLine($"Inserisci il nome dell'arma:");
               armaS = Console.ReadLine();

               Console.WriteLine($"Inserisci il calibro dell'arma:");
               calibroS = int.Parse(Console.ReadLine());

               Console.WriteLine($"Inserisci la durata del servizio:");
               anniServizioS = int.Parse(Console.ReadLine());


               Artigliere artigliere1 = new Artigliere(nomeS,gradoS,anniServizioS,armaS,calibroS);
               listaSoldati.Add(artigliere1);
               break;

            case ("3"):
               foreach (Soldato item in listaSoldati)
               {
                  item.Descrizione();
               }
               break;

            case ("0"):
               Console.WriteLine($"Adiosss!");
               isRunning = false;
               break;

            default:
               Console.WriteLine($"Scelta errata..");
               break;
         }
         
      }
   }
}