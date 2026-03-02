public class Animale
{
   protected int eta;
   public void FaiVerso()
   {
      Console.WriteLine($"L'animale fa il verso");
      
   }


   public virtual void Verso()
   {
   Console.WriteLine($"L'animale emette un verso..");
   
   }

   public void Mangia()
   {
      Console.WriteLine($"L'animale mangia..");
      
   }

}
public class Elefante: Animale
   {
      public void ImpostaEta(int nuovaEta)
      {
         eta = nuovaEta; //Accesso consentito grazie a protected
      }
   }

public class Cane:Animale
   {
      public void Scodinzola()
      {
         Console.WriteLine($"Il cane scodinzola");
         
      }

   public override void Verso()
   {
      base.Verso();
      Console.WriteLine($"Il cane abbaia..");
      
   }

   public new void Mangia()
   {
      Console.WriteLine($"Il cane mangia crocche");
      
   }
   }


public class Program
{

   public static void Main(string[] args)
   {
      Cane miocane = new Cane();
      miocane.FaiVerso();
      miocane.Scodinzola();      
   }
}