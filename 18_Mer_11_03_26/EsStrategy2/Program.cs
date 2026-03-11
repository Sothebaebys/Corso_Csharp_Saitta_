public interface IPaymentStrategy
{
   void Pay (decimal amount);

}

public class CreditCardPayment : IPaymentStrategy
{
   public void Pay (decimal amount)
   {
      Console.WriteLine($"Somma pagamento: {amount}\n Metodo: Carta di credito.");
      
   }
}

public class PaypalPayment : IPaymentStrategy
{
   public void Pay (decimal amount)
   {
      Console.WriteLine($"Somma pagamento: {amount}\n Metodo: Paypal.");

   }
}

public class BitcoinPayment : IPaymentStrategy
{
   public void Pay (decimal amount)
   {
      Console.WriteLine($"Somma pagamento: {amount}\n Metodo: Bitcoin.");
      
   }
}


public class PaymentContext
{
   private IPaymentStrategy _strat;
   
   /*
   public void SetStrat (IPaymentStrategy strat)
   {
      _strat = strat;
   }*/

   public void EseguiStrat (decimal amount)
   {
      if (_strat == null)
      {
         Console.WriteLine($"Nessun metodo selezionato");
         return;
      }
      _strat.Pay(amount);
   }

      public void CreaPay(string tipo)
   {
      switch (tipo.ToLower())
      {
         case ("carta"):
            _strat = new CreditCardPayment();
            break;
         case ("paypal"):
            _strat = new PaypalPayment();
            break;
         case ("btc"):
            _strat = new BitcoinPayment();
            break;
         default:
            Console.WriteLine($"Tipo di pagamento non supportato");
            _strat = null;
            break;

      }
   }

}


//Provo a mettere qui il main così magari l'intellisense non impazzisce

#region Main
public class Program
{
   public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per pagare con carta.");
      Console.WriteLine($"-2 Per pagare con paypal.");
      Console.WriteLine($"-3 Per pagare con bitcoin.");
      Console.WriteLine($"-0 Per uscire.");
   }
   public static void Main(string[] args)
   {
      var pagamento = new PaymentContext();
      
      bool isRunning= true;


      while (isRunning)
      {
         Console.WriteLine($"Inserisci l'importo per il pagamento:");
         
         decimal importo = decimal.Parse(Console.ReadLine());
         
         Menu();
         string scelta = Console.ReadLine();
         switch (scelta)
         {
            case ("1"):
               pagamento.CreaPay("carta");
               pagamento.EseguiStrat(importo);
               break;
            case ("2"):
               pagamento.CreaPay("paypal");
               pagamento.EseguiStrat(importo);
               break;
            case ("3"):
               pagamento.CreaPay("btc");
               pagamento.EseguiStrat(importo);
               break;

            case ("0"):
               Console.WriteLine($"Adioss");
               isRunning = false;
               break;
            default:
               Console.WriteLine($"Scelta non valida");
               break;
         }
         
      }
   }
}

#endregion