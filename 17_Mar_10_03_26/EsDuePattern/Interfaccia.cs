public interface IDispositivo
{
   void Avvia();

   void MostraTipo();

}

public class Computer : IDispositivo
{
   public void Avvia()
   {
      Console.WriteLine($"Il computer si avvia.");
      
   }

   public void MostraTipo()
   {
      Console.WriteLine($"Tipo: Computer. ");
      
   }
}

public class Stampante : IDispositivo
{
      public void Avvia()
   {
      Console.WriteLine($"La stampante si accende.");
      
   }

   public void MostraTipo()
   {
      Console.WriteLine($"Tipo: Stampante. ");
      
   }
}