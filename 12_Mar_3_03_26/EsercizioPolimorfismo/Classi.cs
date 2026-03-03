public class Veicolo
{
   public string Targa;

   public Veicolo(string targa)
   {
      this.Targa = targa;
   }

   public virtual void Ripara()
   {
      Console.WriteLine($"Il veicolo con targa ({Targa}) viene controllato..");
   }
   
}

public class Auto : Veicolo
{
   public Auto(string targa) : base(targa)
   {
      
   }

   public override void Ripara()
   {
      base.Ripara();
      Console.WriteLine($"Controllo olio, freni e motore dell'auto.");
   }
}

public class Moto : Veicolo
{
      public Moto(string targa) : base(targa)
   {
      
   }
   public override void Ripara()
   {
      base.Ripara();
      Console.WriteLine($"Controllo catena, freni e gomme della moto.");
   }
}

public class Camion : Veicolo
{
      public Camion(string targa) : base(targa)
   {
      
   }
   public override void Ripara()
   {
      base.Ripara();
      Console.WriteLine($"Controllo sospensioni, freni rinforzati e carico del camiones.");      
   }

}