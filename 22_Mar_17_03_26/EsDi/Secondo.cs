/*
Esercizio 2
Realizza una classe PaymentProcessor che riceve nel costruttore
un'interfaccia IPaymentGateway.
Crea almeno due implementazioni (es. PaypalGateway, StripeGateway)
e consenti la scelta dell'implementazione a runtime.
Usa la DI per collegare le dipendenze.
*/

public interface IPaymentGateway
{
   void Payment(float somma);
}


public class PaymentProcessor
{
   private readonly IPaymentGateway _paymentGateway;

   public PaymentProcessor(IPaymentGateway paymentGateway)
   {
      _paymentGateway = paymentGateway;
   }

   public void Paga(float somma)
   {
      Console.WriteLine($"\nPagamento di {somma} in elaborazione");

      _paymentGateway.Payment(somma);

   }
}


public class PaypalGateway : IPaymentGateway
{

   public void Payment(float somma)
   {
      Console.WriteLine($"Metodo: Paypal\n Somma: {somma}");

   }
}

public class StripeGateway : IPaymentGateway
{
   public void Payment(float somma)
   {
      Console.WriteLine($"Metodo: Stripe\n Somma: {somma}");

   }
}