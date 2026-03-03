public class ContoBancario
{
   private double _saldo;

   public double Saldo
   {
      get 
      {
         return _saldo;
      }
      set
      {
         if (value >= 0)
            _saldo = value;
      }
   }

}

public class Program
{
   public static void Main(string[] args)
   {
      ContoBancario conto = new ContoBancario();

      conto.Saldo = 1000.50;
      Console.WriteLine(conto.Saldo);
      
      conto.Saldo = -500;
      Console.WriteLine(conto.Saldo);
      
   }
}