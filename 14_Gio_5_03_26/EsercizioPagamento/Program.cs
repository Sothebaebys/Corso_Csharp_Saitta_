public class Program
{
   public static void Main(string[] args)
   {
      List<IPagamento> listaPagamenti = new List<IPagamento>();

      for (var i = 0; i < 10; i++)
      {
         if (i % 2 == 0)
         {
            listaPagamenti.Add(new PagamentoCarta("ViSa"));
            listaPagamenti.Add(new PagamentoContanti());
         }
         else
         {
            listaPagamenti.Add(new PagamentoPaypal("CiccioMail"));
            listaPagamenti.Add(new PagamentoContanti());
         }
      }

      foreach (IPagamento item in listaPagamenti)
      {
         Console.WriteLine($"====================================");
         item.EseguiPagamento(13);

         Console.WriteLine($"====================================");
         item.MostraMetodo();
         Console.WriteLine($"====================================\n\n\n");
      }

   }

}