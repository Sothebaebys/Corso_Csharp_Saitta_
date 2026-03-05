public interface IPagamento
{
   void EseguiPagamento(decimal importo);
   void MostraMetodo();
}

public class PagamentoCarta : IPagamento
{
   //public decimal importo;
   private string _circuito;
   public string circuito
   {
      get {return _circuito;}
      set{
         if ((value.ToLower() == "mastercard")|| (value.ToLower() == "visa") )
         {
            _circuito = value;
         }
         else
         {
            _circuito = "mastercard";
         }
      }
   }
   

   public PagamentoCarta(string circuito)
   {
      this.circuito=circuito;
   }
   
   public void EseguiPagamento(decimal importo)
   {
      Console.WriteLine($"Pagamento di {importo} euro con carta (Circuito: {circuito})");
   }
   public void MostraMetodo()
   {
      Console.WriteLine($"Metodo: Carta di credito");
   }
}

public class PagamentoContanti : IPagamento
{
   // public decimal importo;
   // public PagamentoContanti(decimal importo)
   // {
   //    this.importo = importo;
   // }
   public void EseguiPagamento(decimal importo)
   {
      Console.WriteLine($"Pagamento di {importo} euri in contanti");
      
   }

   public void MostraMetodo()
   {
      Console.WriteLine($"Metodo: contanti");
      
   }
}

public class PagamentoPaypal : IPagamento

{

   private string _mail;
   public string mail
   {
      get{return _mail;}
      set {_mail = value;}
   }

   public PagamentoPaypal( string mail)
   {
      this.mail = mail;
   }

   public void EseguiPagamento(decimal importo)
   {
      Console.WriteLine($"Pagamento di {importo} euri con Paypal");
      
   }

   public void MostraMetodo()
   {
      Console.WriteLine($"Metodo: paypal");
      
   }
}


