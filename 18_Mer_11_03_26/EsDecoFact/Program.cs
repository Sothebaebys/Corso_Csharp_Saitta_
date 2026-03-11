using System;

public class Program
{
         public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per prenotare una torta.");
      Console.WriteLine($"-2 Per aggiungere un topper.");
      Console.WriteLine($"-0 Per uscire.");
   }


   public static void Main(string[] args)
   {
      //bool IsTopper = true;
      bool IsRunning = true;
      string scelta= "";
      string output= "";
      ITorta torta = null;

      Console.WriteLine($"Benvenuto!");

      while (IsRunning)
      {
         Menu();
         scelta = Console.ReadLine();


         switch (scelta)
         {
            //Crea torta
            case ("1"):
               if(torta != null)
               {
                  Console.WriteLine($"\nTorta già in prenotazione.\nProcedi con il topper o esci.");
                  break;
               }
               Console.WriteLine($"Seleziona il tipo di torta tra: Cioccolato, Vaniglia, Frutta");
               string inputTorta = Console.ReadLine();

               torta = TortaFactory.CreaTortaBase(inputTorta);

               if(torta != null)
               {
                  output = torta.Descrizione();
                  Console.WriteLine($"\nDescrizione: \n {output}");
               }
               break;

            //Topper
            case("2"):

               if(torta != null)
               {
                  Console.WriteLine($"Seleziona il tipo di topper tra: Panna, Fragole, Glassa");
                  string inputTopper = Console.ReadLine();

                  switch (inputTopper.ToLower())
                  {
                     case ("panna"):
                        torta = new ConPanna(torta);
                        output = torta.Descrizione();
                        Console.WriteLine($"\nDescrizione: \n {output}");
                        break;
                     case("fragole"):
                        torta = new ConFragole(torta);
                        output = torta.Descrizione();
                        Console.WriteLine($"\nDescrizione: \n {output}");
                        break;
                     case("glassa"):
                        torta = new ConGlassa(torta);
                        output = torta.Descrizione();
                        Console.WriteLine($"\nDescrizione: \n {output}");
                        break;

                     default:
                        Console.WriteLine($"Scelta non valida");
                        break;

                  }
               }
               else
               {
                  
                  
               }
               break;

            case("0"):
               //Inviare qui la notifica agli observer
               Console.WriteLine($"Arrivederla!");

               IsRunning=false; 
               break;
               
            default:
               Console.WriteLine($"Sceltanonvalida");
               break;
         }
         
      }
   }
}