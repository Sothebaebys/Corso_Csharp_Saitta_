public abstract class DispositivoElettronico
{
   public string modello;

   public abstract void Accendi();
   public abstract void Spegni();
   public virtual void Mostrainfo()
   {
      Console.WriteLine($"Questo è un dispositivo elettrico");
      
   }
   
}

public class Computer : DispositivoElettronico
{
   public override void Accendi()
   {
      Console.WriteLine($"Il computer si accente");
      
   }

   public override  void Spegni()
   {
      Console.WriteLine($"Il computer si spegne");
      
   }

   public override void Mostrainfo()
   {
      base.Mostrainfo();
      Console.WriteLine($"E' un pc");
   }
}

public class Stampante : DispositivoElettronico
{
   public override  void Accendi()
   {
      Console.WriteLine($"La stampante si accente");
      
   }

   public override void Spegni()
   {
      Console.WriteLine($"La stampante si spegne");
      
   }

   public override void Mostrainfo()
   {
      base.Mostrainfo();
      Console.WriteLine($"E' una stampante");
   }

}