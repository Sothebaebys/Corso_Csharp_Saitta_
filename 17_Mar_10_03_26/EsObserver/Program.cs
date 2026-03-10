public class Program
{

   public static void Main(string[] args)
   {
      bool isRunning = true;
      string dato;

      var soggettoMeteo = new CentroMeteo();
   
      var osservatoreConsole = new DisplayConsole();
      var osservatoreMobile = new DisplayMobile();

      Console.WriteLine($"Aggiungo osservatore console");
      soggettoMeteo.Registra(osservatoreConsole);

      Console.WriteLine($"Aggiungo osservatore mobile");
      soggettoMeteo.Registra(osservatoreMobile);


      while (isRunning)
      {
         Console.WriteLine($"Vuoi aggiungere dei dati ? (Y/N) ");
         string scelta = Console.ReadLine();

         if(scelta.ToLower() == "y")
         {  
            Console.WriteLine($"Inserisci i dati meteo:");
            
            dato = Console.ReadLine();
            soggettoMeteo.AggiornaMeteo(dato);
         }
         else
         {
            isRunning = false;
         }
      }

   }
}