public class Program
{

   public static void Main(string[] args)
   {
      List<DispositivoElettronico> listaDispositivi = new List<DispositivoElettronico>();



      for (var i = 0; i < 10; i++)
      {
         if (i % 2 == 0)
         {
            listaDispositivi.Add(new Computer());
         }
         else
         {
            listaDispositivi.Add(new Stampante());
         }
      }

      foreach (DispositivoElettronico item in listaDispositivi)
      {
         Console.WriteLine($"Info:");
         item.Mostrainfo();

         Console.WriteLine($"Accendi:");
         item.Accendi();

         Console.WriteLine($"Spegni:");
         item.Spegni();
      }
   }
}