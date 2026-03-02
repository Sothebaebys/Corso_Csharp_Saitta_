class Program
{
   public static void StampaMenu()
   {
      Console.WriteLine($"Seleziona le azioni:\n -1 Per inserire un nuovo veicolo.\n -2 Per visualizzare tutti i veicoli presenti nel garage.\n -0 Per uscire");
      
   }
   public static void Main(string[] args)
   {
      List<Veicolo> listaVeicoli = new List<Veicolo>();
      bool isRunning = true;

      while(isRunning)
      {
         StampaMenu();
         string scelta= Console.ReadLine();
         switch (scelta)
         {
            case("1"):
               Console.WriteLine($"Seleziona: \n -1 per auto\n -2 per moto");
               string sceltaVeicolo= Console.ReadLine();
               if (scelta == "1")
               {
                  Console.WriteLine($"Inserisci il numero di portiere:");
                  //int porte = int.Parse(Console.ReadLine());
                  string porte = Console.ReadLine();
                  if(!porte.Int.TryParse())
                  {
                     int portiere = 4;
                  }
                  else
                  {
                     int portiere = Int.Parse(porte);
                  }
                  Console.WriteLine($"Inserisci il modello:");
                  string modello = Console.ReadLine();
                  Console.WriteLine($"Inserisci la marca:");
                  string marca = Console.ReadLine();               

                  Auto auto = new Auto(porte, marca, modello);

                  listaVeicoli.Add(auto);
               }
               else if (scelta == "2")
               {
                  Console.WriteLine($"Inserisci il tipo di manubrio:");
                  string manubrio = Console.ReadLine();
                  Console.WriteLine($"Inserisci il modello:");
                  string modello = Console.ReadLine();
                  Console.WriteLine($"Inserisci la marca:");
                  string marca = Console.ReadLine();               

                  Moto moto = new Moto(manubrio, marca, modello);

                  listaVeicoli.Add(moto);
               }
               else
               {
                  Console.WriteLine($"Scelta non valida..");
               }
               break;
            case("2"):
               Console.WriteLine($"All'interno del garage attualmente ci sono:");

               foreach (Veicolo item in listaVeicoli)
               {
                  item.StampaInfo();
               }
               break;
            case("0"):
               Console.WriteLine($"Arrivederci!");
               isRunning = false;
               break;
            default:
               Console.WriteLine($"Scelta non valida.");
               break;

         }
      }
   }
}