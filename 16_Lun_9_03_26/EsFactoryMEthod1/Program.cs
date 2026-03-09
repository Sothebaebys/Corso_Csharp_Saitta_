public interface IVeicolo
{
   void Avvia();

   void MostraTipo();
}

public class Auto: IVeicolo
{
   public void Avvia()
   {
      Console.WriteLine($"Avvio dell'auto");
      
   }

   public void MostraTipo()
   {
      Console.WriteLine($"Automobile");
      
   }
}

public class Moto: IVeicolo
{
   public void Avvia()
   {
      Console.WriteLine($"Avvio della moto");
      
   }

   public void MostraTipo()
   {
      Console.WriteLine($"Motocicletta");
      
   }
}

public class Camion: IVeicolo
{
   public void Avvia()
   {
      Console.WriteLine($"Avvio del camion");
      
   }

   public void MostraTipo()
   {
      Console.WriteLine($"Camion");
      
   }
}


public static class VeicoloFactory
{
   public static IVeicolo CreaVeicolo(string tipo)
   {
      if (tipo.ToLower() == "auto")
      {
         return new Auto();
      }
      else if(tipo.ToLower() == "moto")
      {
         return new Moto();
      }
      else if (tipo.ToLower() == "camion")
      {
         return new Camion();
      }
      else 
      {
         return null;
      }
   }

}

public class Program
{
   public static void Main(string[] args)
   {
      bool isRunning = true;
      while(isRunning)
      {
         Console.WriteLine($"Che tipo di veicolo vuoi creare ? \n - auto\n - moto\n - camion");
         string scelta = Console.ReadLine();

         IVeicolo veicolo = VeicoloFactory.CreaVeicolo(scelta.ToLower());

         if (veicolo == null)
         {
            Console.WriteLine($"Tipo non valido.. ritenta");
            continue;

         }
         veicolo.Avvia();
         veicolo.MostraTipo();

         Console.WriteLine($"Vuoi continuare ? (Y/N)");

         string continua = Console.ReadLine();

         if (continua.ToLower() != "y")
         {
            isRunning = false;
         }
         
      }
   }
}