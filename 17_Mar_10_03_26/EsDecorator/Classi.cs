using System;
public interface IBevanda
{
   string Descrizione();
   double Costo();

}

public class Caffe : IBevanda
{
   public string Descrizione()
   {
      Console.WriteLine($"Caffè, che te lo dico a fare");
      return "Caffè";
   }

   public double Costo()
   {
      Console.WriteLine($"Costo base 1.00 Eur.");
      return 1.00d;
   }
}

public class The : IBevanda
{
   public string Descrizione()
   {
      Console.WriteLine($"Thè delle 17, che charm");
      return "Thè";
   }

   public double Costo()
   {
      Console.WriteLine($"Costo base 2.50 Eur.");
      return 2.50d;
   }
}


//Decoratore astratto
public abstract class DecoratoreBevanda : IBevanda
{
   protected IBevanda _componente;

   protected DecoratoreBevanda(IBevanda bevanda)
   {
      _componente = bevanda;
   }

   public virtual void Descrizione()
   {
      _componente.Descrizione();
   }

   public virtual void Costo()
   {
      _componente.Costo();
   }

}

public class ConLatte : DecoratoreBevanda
{
   public ConLatte(IBevanda bevanda) : base (bevanda)
   {
      
   }

   public override string Descrizione()
   {
      return base.Descrizione()+"\nCon aggiunta di latte..";
   }
   public override double Costo()
   {
      return base.Costo()+ 1.00d;
   }
}

