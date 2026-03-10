public interface IApple
{
   void Accendi();
   void Spegni();
   void Aggiorna();

}

public class Iphone : IApple
{
   public void Accendi()
   {
      Console.WriteLine($"Accendo");
      
   } 
   public void Spegni()
   {
      Console.WriteLine($"Spengo");
      
   }

   public void Aggiorna()
   {
      Console.WriteLine($"Aggiorno");
      
   }
}

public class Ipad : IApple
{
   public void Accendi()
   {
      Console.WriteLine($"Accendo");
      
   } 
   public void Spegni()
   {
      Console.WriteLine($"Spengo");
      
   }

   public void Aggiorna()
   {
      Console.WriteLine($"Aggiorno");
      
   }
}

public class Macbook : IApple
{
   public void Accendi()
   {
      Console.WriteLine($"Accendo");
      
   } 
   public void Spegni()
   {
      Console.WriteLine($"Spengo");
      
   }

   public void Aggiorna()
   {
      Console.WriteLine($"Aggiorno");
      
   }
}


public abstract class FabbricaCinese
{
   // Il factory method 
   // essendo astratto, questo metodo deve essere implementato da tutte le sottoclassi
   public abstract IApple CreoModello(string tipo);


   //Questo rimane per tutte le implementazioni 
   public void MettiInCommercio(string tipo)
   {
      var prodotto = CreoModello(tipo); //Così facendo deleghiamo la scelta del tipo alla sottoclasse

      prodotto.Accendi();
      prodotto.Aggiorna();
      prodotto.Spegni();
   }
}

public class ApplestoreVenezuela : FabbricaCinese
{
   public override IApple CreoModello(string tipo)
   {
      switch (tipo)
      {
         case ("telefono"):
            return new Iphone();
         case ("tablet"):
            return new Ipad();
         case ("notebook"):
            return new Macbook();
         default:
            Console.WriteLine($"Scelta non valida, ritenta..");
            return null;
            
      }
   }
}

public class ApplestoreIran : FabbricaCinese
{
   public override IApple CreoModello(string tipo)
   {
      switch (tipo)
      {
      case ("telefono"):
            return new Iphone();
         case ("tablet"):
            return new Ipad();
         case ("notebook"):
            return new Macbook();
         default:
            Console.WriteLine($"Scelta non valida, ritenta..");
            return null;
      }
   }
}

public class AppleStoreLibano : FabbricaCinese
{
   public override IApple CreoModello(string tipo)
   {
      switch (tipo)
      {
      case ("telefono"):
            return new Iphone();
         case ("tablet"):
            return new Ipad();
         case ("notebook"):
            return new Macbook();
         default:
            Console.WriteLine($"Scelta non valida, ritenta..");
            return null;
      }
   }
}