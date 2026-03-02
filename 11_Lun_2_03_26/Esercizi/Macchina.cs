class Macchina
{
   public string motore= "pandina";
   public float velocitaMax= 90.0f;
   public int sospensioniMax= 3;
   private int _nModifiche = 0;

   
   public Macchina ()
   {
      
   }

   public Macchina (string motore, float velocita, int sospensioni)
   {
      this.motore = motore;
      this.velocitaMax = velocita;
      this.sospensioniMax = sospensioni;
   }



   public override string ToString()
   {
      return $"Caratteristiche della macchina:\n motore: {motore}\n velocità massima: {velocitaMax}\n sospensioni: {sospensioniMax}\n totale modifiche: {_nModifiche}";
   }

   public void ModificaMotore()
   {
      _nModifiche += 1;
      this.motore = Console.ReadLine();
   
   }

   public void AumentaVelocità()
   {
      _nModifiche += 1;
      this.velocitaMax += 10;
   }

   public void AumentaSospensioni()
   {
      _nModifiche += 1;
      this.sospensioniMax += 10;
   }

   }

