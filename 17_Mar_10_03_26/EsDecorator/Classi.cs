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
      Console.WriteLine($"Caffè");
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

   public virtual string Descrizione()
   {
      return _componente.Descrizione()+"";
   }

   public virtual double Costo()
   {
      return _componente.Costo()+0.0d;
   }

}
//Decoratori concreti
public class ConLatte : DecoratoreBevanda
{
   public ConLatte(IBevanda bevanda) : base (bevanda)
   {
      
   }

   public override string Descrizione()
   {
      Console.WriteLine($"Con aggiunta di latte..");
      return base.Descrizione()+"\nCon aggiunta di latte";
   }
   public override double Costo()
   {
      Console.WriteLine($"Con latte: +1.00Eur");
      return base.Costo()+ 1.00d;
   }
}

public class ConCioccolato : DecoratoreBevanda
{
   public ConCioccolato(IBevanda bevanda) : base (bevanda)
   {
      
   }

   public override string Descrizione()
   {
      Console.WriteLine($"Con aggiunta di cioccolato..");
      return base.Descrizione()+"\nCon aggiunta di cioccolato";
   }
   public override double Costo()
   {
      Console.WriteLine($"Con cioccolato: +1.00Eur");
      return base.Costo()+1.00d;
   }
}

public class ConPanna : DecoratoreBevanda
{
   public ConPanna(IBevanda bevanda) : base (bevanda)
   {
      
   }

   public override string Descrizione()
   {
      base.Descrizione();
      Console.WriteLine($"Con aggiunta di panna..");
      
      return "\nCon aggiunta di panna";
   }
   public override double Costo()
   {
      
      Console.WriteLine($"Con panna: +1.00 Eur ");
      return base.Costo()+1.00d;
   }
}

