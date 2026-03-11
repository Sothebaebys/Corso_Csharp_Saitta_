//Creo l'interfaccia Piatto
public interface IPiatto
{
   string Descrizione();

   string Prepara();
}

#region Classi concrete dei piatti
//Creazione delle classi concrete che implementano IPiatto
public class Pizza : IPiatto
{
   public string Descrizione()
   {
      Console.WriteLine($"Pizza!");
      return "Pizza";
   }

   //Prepara lo lascio vuoto al momento, penso che si dovrà comporre in base alla strategy
   public string Prepara()
   {
      Console.WriteLine($"Prepara..");
      
      return "Preparo..";
   }

}

public class Hamburger : IPiatto
{
   public string Descrizione()
   {
      Console.WriteLine($"Hanburger!");
      return "Hamburger";
   }

   //Prepara lo lascio vuoto al momento, penso che si dovrà comporre in base alla strategy
   public string Prepara()
   {
      Console.WriteLine($"Prepara..");
      return "Preparo..";
   }

}

public class Insalata : IPiatto
{
   public string Descrizione()
   {
      Console.WriteLine($"Insalata!");
      return "Insalata";
   }

   //Prepara lo lascio vuoto al momento, penso che si dovrà comporre in base alla strategy
   public string Prepara()
   {
      Console.WriteLine($"Prepara..");
      return "Preparo..";
   }

}
#endregion

#region Factory Method

//Creazione del factory
public static class PiattoFactory
{
   public IPiatto Crea(string tipo)
   {
      switch (tipo.ToLower)
      {
         case ("pizza"):

            // qui un return del tipo di piatto selezionato
            return new Pizza();
            
         case ("hamburgher"):
            // qui un return del tipo di piatto selezionato
            return new Hamburger();
            
         case ("insalata"):
            // qui un return del tipo di piatto selezionato
            return new Insalata();
            
         default:
            Console.WriteLine($"Piatto non valido");
            return null;
      }
      
   }
}

#endregion

#region Strategy
//Il contesto lo accolliamo allo chefff
//Interfaccia per la strategy
public interface IPreparazioneStrategia
{
   string Prepara(string descrizione);

}
#region Classi concrete Strategy
//Classi concrete che implementano l'interfaccia della strategia
public class Fritto : IPreparazioneStrategia
{
   public string Prepara(string descrizione)
   {
      return $"Preparazione: {descrizione} fritta";
   }
}

public class AlForno : IPreparazioneStrategia
{
   public string Prepara(string descrizione)
   {
      return $"Preparazione: {descrizione} cotta al forno";
   }
}

public class AllaGriglia : IPreparazioneStrategia
{
   public string Prepara(string descrizione)
   {
      return $"Preparazione: {descrizione} cotta in griglia";
   }
}


#endregion

#endregion

#region Classe chef con scelta tramite strategy&Singleton
public class Chef
{
   //Implementazione del singleton
   private static Chef _istanza = null;
   
   //Costruttore privato
   private Chef()
   {
      
   }
   //Getter dello chef
   public static Chef GetIstanza()
   {
      if(_istanza == null)
      {
         _istanza = new Chef();
      }
      return _istanza;
   }

   private IPreparazioneStrategia _strat;

   //Setter della strategy
   public void SetStrat(IPreparazioneStrategia strat)
   {
         _strat = strat;
      
   }

   //Qui si delega alla strategy
   public void PreparaPiatto(IPiatto piatto)
   {
      if(_strat == null)
      {
         Console.WriteLine($"Non posso procedere");
         Console.WriteLine($"Seleziona una strat");
         return;
      }

      Console.WriteLine($"Piatto: {piatto.Descrizione()}");
      Console.WriteLine($"Preparazione: {_strat.Prepara(piatto.Descrizione())}");
      
      
   }
}

#endregion

#region Decorator
//Decoratore
public abstract class IngredientiExtra : IPiatto
{
   protected IPiatto _componente;

   protected IngredientiExtra(IPiatto componente)
   {
      _componente = componente;
   }
   public string Descrizione()
   {
      _componente.Descrizione();
   }

   public string Prepara()
   {
      _componente.Prepara();
   }

}

public class ConFormaggio : IngredientiExtra
{
   public ConFormaggio(IPiatto componente): base (componente)
   {
      
   }

   public override string Descrizione()
   {
      string descrz = base.Descrizione();
      return $"{descrz} + formaggio";
   }

      public override string Prepara()
   {
      base.Prepara();
   }

}

public class ConBacon : IngredientiExtra
{
   public ConBacon(IPiatto componente): base (componente)
   {
      
   }

   public override string Descrizione()
   {
      string descrz = base.Descrizione();
      return $"{descrz} + bacon";
   }

   public override string Prepara()
   {
      base.Prepara();
   }
}

public class ConSalsa : IngredientiExtra
{
   public ConSalsa(IPiatto componente): base (componente)
   {
      
   }

      public override string Descrizione()
   {
      string descrz = base.Descrizione();
      return $"{descrz} + salsa";
   }

      public override string Prepara()
   {
      base.Prepara();
   }
}

#endregion

public class Program
{
   public static void MenuPiatti()
   {
      Console.WriteLine($"\n seleziona il piatto.\nPremi: ");
      Console.WriteLine($"-1 Per la pizza pazza.");
      Console.WriteLine($"-2 Per l'insalata campagnola.");
      Console.WriteLine($"-3 Per l'hamburgher di carne umana");
      Console.WriteLine($"-0 Per uscire.");
   }

   public static void MenuExtra()
   {
      Console.WriteLine($"\n seleziona l'extra.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere il formaggio.");
      Console.WriteLine($"-2 Per aggiungere il bacon.");
      Console.WriteLine($"-3 Per aggiungere la salsa.");
      Console.WriteLine($"-0 Per saltare.");

   }

   public static void MenuCottura()
   {
      Console.WriteLine($"\n seleziona la tipologia di cottura.\nPremi: ");
      Console.WriteLine($"-1 Per la cottura alla griglia.");
      Console.WriteLine($"-2 Per la cottura al forno.");
      Console.WriteLine($"-3 Per la fritturina");
      Console.WriteLine($"-0 Per saltare.");
   }

   public static void Main(string[] args)
   {
      bool isRunning=true;

      while (isRunning)
      {
         MenuPiatti();
         string scelta = Console.ReadLine();
         switch (scelta)
         {
            case ("1"):
               break;
            case ("2"):
               break;
            case ("3"):
               break;
            case ("0"):
               Console.WriteLine($"Adioss");
               isRunning = false;
               break;

            default:
               break;
         }
         bool isExtras = true;
         while (isExtras)
         {
            MenuExtra();
            string scelta = Console.ReadLine();
            switch (scelta)
            {
               case ("1"):
                  break;
               case ("2"):
                  break;
               case ("3"):
                  break;
               case ("0"):
                  Console.WriteLine($"Adioss");
                  isExtras = false;
                  break;

               default:
                  break;
            }
            
         }
         bool isCotto = true;
         while (isCotto)
         {
            MenuCottura();
            string scelta = Console.ReadLine();
            switch (scelta)
            {
               case ("1"):
                  break;
               case ("2"):
                  break;
               case ("3"):
                  break;
               case ("0"):
                  Console.WriteLine($"Adioss");
                  isCotto = false;
                  break;

               default:
                  break;
            }
            
         }

         Console.WriteLine($"Vuoi continuare? (Y/N)");
         string scelta = Console.ReadLine();
         if(scelta.ToLower() != "y")
         {
            Console.WriteLine($"Arrivedorsci");
            isRunning = false;
         }
         

      }

   }

}


/*



Manca solo l'observer, almeno così pare...

*/