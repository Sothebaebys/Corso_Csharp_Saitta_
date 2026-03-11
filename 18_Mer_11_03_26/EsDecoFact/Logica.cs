public interface ITorta
{
   string Descrizione();

}


public class TortaCioccolato : ITorta
{
   public TortaCioccolato(){}

   public string Descrizione()
   {
      return "Torta al cioccolato";
   }
}


public class TortaVaniglia : ITorta
{
   public TortaVaniglia(){}

   public string Descrizione()
   {
      return "Torta alla vaniglia";
   }
}


public class TortaFrutta : ITorta
{
   public TortaFrutta(){}

   public string Descrizione()
   {
      return "Torta alla frutta";
   }
}


public static class TortaFactory
{
   public static ITorta CreaTortaBase(string tipo)
   {
      switch (tipo.ToLower())
      {
         case ("cioccolato"):
            return new TortaCioccolato();
         case ("vaniglia"):
            return new TortaVaniglia();
         case ("frutta"):
            return new TortaFrutta();
         default:
            Console.WriteLine($"Tipo di torta non presente");
            return null;

      }
      
   }

}


public abstract class DecoratoreTorta : ITorta
{
   protected ITorta _torta;

   protected DecoratoreTorta(ITorta torta)
   {
      _torta = torta;
   }

   public virtual string Descrizione()
   {
      return _torta.Descrizione();
   }

}


public class ConPanna : DecoratoreTorta
{
   public ConPanna(ITorta torta) : base(torta){}

   public override string Descrizione()
   {
      Console.WriteLine($"con aggiunta di: panna.");
      
      return base.Descrizione()+ " con panna";
   }
}


public class ConFragole: DecoratoreTorta
{
   public ConFragole(ITorta torta) : base(torta){}

   public override string Descrizione()
   {
      Console.WriteLine($"con aggiunta di: fragole.");
      
      return base.Descrizione()+ " con fragole";
   }
}


public class ConGlassa : DecoratoreTorta
{
   public ConGlassa(ITorta torta) : base(torta){}

   public override string Descrizione()
   {
      Console.WriteLine($"con aggiunta di: glassa.");
      
      return base.Descrizione()+ " con glassa";
   }

}


public interface IObserver
{
   void Aggiorna(string msg);
}

public class Osservatore : IObserver
{
   public void Aggiorna(string msg)
   {
      Console.WriteLine($"Text");
      
   }
}
// Da fare:

   //singleton
   
   //observer
