using System;
class Utente
{
   public string nome;
   public int credito = 10;

   public Macchina macchina = new Macchina();

   public override string ToString()
   {
      return $" Nome utente : {nome}\n crediti residui: {credito}\n {macchina.ToString()}";
   }

   public Utente(string nome, int credito)
   {
      this.nome = nome;
      this.credito = credito;
   }

   public object MacchinaUtenteInput(ref Macchina macchina)
   {
      Console.WriteLine($"Inserisci il nome del motore");
      macchina.motore = Console.ReadLine();
      Console.WriteLine($"Inserisci la velocità massima di default:");
      macchina.velocitaMax = float.Parse(Console.ReadLine());
      Console.WriteLine($"Inserisci le sospensioni:");
      macchina.sospensioniMax = int.Parse(Console.ReadLine());
      //macchina = new Macchina(nomeMotore, velocitaMax, sospensioni);
      return macchina;
   }

   public object MacchinaDefault()
   {
      Macchina macchina = new Macchina();
      return macchina;
   }

   public void SceltaModifiche(int scelta)
   {
      if (scelta == 1 && credito>0)
      {
         macchina.ModificaMotore();
         credito -= 1;
      }
      else if (scelta == 2 && credito>0)
      {
         macchina.AumentaVelocità();
         credito -= 1;
      }
      else if (scelta == 3 && credito>0)
      {
         macchina.AumentaSospensioni();
         credito -= 1;
      }
      else
      {
         Console.WriteLine($"Crediti esauriti o scelta scorretta");
      }
   
   }
}