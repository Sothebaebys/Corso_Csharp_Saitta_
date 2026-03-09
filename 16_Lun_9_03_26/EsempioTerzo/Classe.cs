public sealed class Logger
{
   private static Logger _istanza;
   public static Logger istanza
   {
      get
      {
         if(_istanza == null)
         {
            _istanza = new Logger();
         }
         return _istanza;
      }
   }
   
   
   private List<string> listaLog;

   
   private Logger()
   {
      listaLog = new List<string>();
   }

   public void Log(string message)
   {
      listaLog.Add(message);
   }

   public void MostraLog()
   {
      Console.WriteLine($"Il log contiene {listaLog.Count()} elementi");
      
      foreach (var item in listaLog)
      {
         Console.WriteLine($"Messaggio: \n - {item}.");
      }
   }

      public void InfoIstanza()
   {
      Console.WriteLine($"Hashcode: {GetHashCode().ToString()}");
   }

}