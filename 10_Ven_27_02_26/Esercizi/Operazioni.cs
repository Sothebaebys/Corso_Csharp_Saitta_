public class Operazioni
{
   public int Num1;
   public int Num2;
   private string _simbolo;

   public int Risultato;

   public Operazioni(int num,int num2)
   {
      Num1 = num;
      Num2 = num2;
   }
   public void Somma()
   {
      _simbolo = "+";
      Risultato = Num1 + Num2;

      StampaRes();
   }
   public void Moltiplica()
   {
      _simbolo = "x";
      Risultato = Num1 * Num2;

      StampaRes();

   }

   private void StampaRes()
   {
      Console.WriteLine($"Il risultato di {Num1} {_simbolo} {Num2} è : {Risultato}");
   }
}