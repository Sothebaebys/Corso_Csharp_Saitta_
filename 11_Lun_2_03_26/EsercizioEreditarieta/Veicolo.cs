class Veicolo
{
   public string marca;
   public string modello;

   public Veicolo(string marca, string modello)
   {
      this.marca = marca;
      this.modello = modello;
   }
   public virtual void StampaInfo()
   {
      Console.WriteLine($"Il modello è: {modello} di marca {marca}");
      
   }

}

class Auto : Veicolo
{
   public int numeroPorte;

   public Auto(int numeroPorte, string marca, string modello): base(marca, modello)
   {
      //this.marca = marca;
      //this.modello = modello;
      this.numeroPorte = numeroPorte;
   }

   public override void StampaInfo()
   {
      Console.WriteLine($"L'auto è del modello: {modello}\n Marca {marca}\n Con {numeroPorte} porte. ");
      
   }

}
class Moto : Veicolo
{
   public string tipoManubrio;

   public Moto(string manubrio,string marca, string modello): base(marca, modello)
   {
      //this.marca = marca;
      //this.modello = modello;
      this.tipoManubrio = manubrio;
   }

      public override void StampaInfo()
   {
      Console.WriteLine($"La moto è un modello: {modello}\n Marca {marca}\n Con {tipoManubrio} come manubrio. ");
      
   }
}