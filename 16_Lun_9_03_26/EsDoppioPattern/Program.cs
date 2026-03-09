
using System;
public class Program
{

   public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un automobile.");
      Console.WriteLine($"-2 Per aggiungere una moto.");
      Console.WriteLine($"-3 Per aggiungere un camion.");
      Console.WriteLine($"-4 Per visualizzare i registri..");
      Console.WriteLine($"-0 Per uscire.");
   }

   public static void Main(string[] args)
   {
      string scelta;
      RegistroVeicoli registro = RegistroVeicoli.istanza;
   
      bool isRunning = true;
      Console.WriteLine($"Benvenuto");
      
      while (isRunning)
      {
         Menu();
         //Console.WriteLine($"Scegli l'azione:");
         scelta = Console.ReadLine();
         
         switch (scelta)
         {
            case ("1"):
               IVeicolo auto = Factory.CreaVeicolo("auto");
               auto.Avvia();
               registro.RegistraNuovo(auto);

               break;
            case ("2"):
               IVeicolo moto = Factory.CreaVeicolo("moto");
               moto.Avvia();
               registro.RegistraNuovo(moto);
               break;
            case ("3"):
               IVeicolo camion = Factory.CreaVeicolo("camion");
               camion.Avvia();
               registro.RegistraNuovo(camion);
               break;
            case ("4"):
               registro.StampaTutti();
               break;
            case ("0"):
               Console.WriteLine($"Adiosss");
               isRunning = false;
               break;
            default:
               Console.WriteLine($"Scelta non valida");

               break;
         }
         
      }
   }
}