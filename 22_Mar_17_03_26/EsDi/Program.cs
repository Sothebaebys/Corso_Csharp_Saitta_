class Program
{
   public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per Pagare con paypal.");
      Console.WriteLine($"-2 Per Pagare con stripe.");
      Console.WriteLine($"-0 Per scappare.");
   }
   public static void Main(string[] args)
   {
      bool isRunning= true;
      float amount;
      IPaymentGateway gateway = null;
      PaymentProcessor process = null;


      while(isRunning)
      {
         Menu();
         string scelta = Console.ReadLine();

         switch (scelta)
         {
            case ("1"):
               Console.WriteLine($"Inserisci la quantità: ");
               amount = float.Parse(Console.ReadLine());

               gateway = new PaypalGateway();
               process = new PaymentProcessor(gateway);
               process.Paga(amount);
               break;

            case ("2"):
               Console.WriteLine($"Inserisci la quantità: ");
               amount = float.Parse(Console.ReadLine());


               gateway = new StripeGateway();
               process = new PaymentProcessor(gateway);
               process.Paga(amount);
               break;

            case ("0"):
               isRunning = false;
               break;
            default:
            Console.WriteLine($"Scelta non valida");
            
               break;
         }
         
      }


   }
}