using System;
class Program
{
   public static void Main(string[] args)
   {
      double totale;
      //Istanzio l'oggetto di base, in questo caso il caffè
      IBevanda bevanda = new Caffe();
      bevanda.Descrizione();
      bevanda.Costo();
      
      Console.WriteLine($"\nAggiungo la panna.\n");
      //Decoratore Panna
      IBevanda bevandaConSupplemento = new ConPanna(bevanda);
      bevandaConSupplemento.Descrizione();
      totale = bevandaConSupplemento.Costo();

      Console.WriteLine($"\nTotale: {totale} Eur.");

      Console.WriteLine($"\nAggiungo la cioccolata.\n");

      //Decoratore cioccolata
      IBevanda bevandaSuppBis = new ConCioccolato(bevandaConSupplemento);

      bevandaSuppBis.Descrizione();
      totale = bevandaSuppBis.Costo();

      Console.WriteLine($"\nNuovo totale: {totale} Eur.");

   }
}

