public interface IVeicolo
{
   void Avvia();
   void MostraTipo();

}

public class Auto : IVeicolo
{
   public void Avvia()
   {
      Console.WriteLine($"L'auto si avvia");
      
   }

   public void MostraTipo()
   {
      Console.Write($"Auto ");

   }
}

public class Moto : IVeicolo
{
   public void Avvia()
   {
      Console.WriteLine($"La moto si avvia");
      
   }

   public void MostraTipo()
   {
      Console.Write($"Moto ");

   }
}

public class Camion : IVeicolo
{
   public void Avvia()
   {
      Console.Write($"Il camion si avvia ");
      
   }

   public void MostraTipo()
   {
      Console.WriteLine($"Camion");

   }
}

public static class Factory
{
   public static IVeicolo CreaVeicolo(string tipo)
   {
      switch (tipo.ToLower())
      {
         case ("auto"):
            return new Auto();

         case ("moto"):
            return new Moto();

         case ("camion"):
            return new Camion();

         default:
            Console.WriteLine($"Tipo ({tipo.ToLower()}) non valido");
            return null;
      }
   
   }
}


