public class Program
{
   public static void Main(string[] args)
   {
      List<Corso> listaCorsi = new List<Corso>();

      for (int i = 0; i < 10; i++)
      {
         if (i % 2 == 0)
         {
            listaCorsi.Add(new CorsoPresenza("Programmazione", 400, "A7", 18));

         }
         else
         {
            listaCorsi.Add(new CorsoOnline("PitturaDigitale", 1080, "Zoom", "https://nontelodico.boh"));
         }
      }

            foreach (Corso item in listaCorsi)
      {
         Console.WriteLine($"====================================");
         item.ErogaCorso();
         Console.WriteLine($"====================================");
         item.StampaDettagli();
         Console.WriteLine($"====================================\n\n\n");
      }
   }
}