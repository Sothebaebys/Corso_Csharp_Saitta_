public class Program
{
   public static void Main(string[] args)
   {
      var istanzaLogger = S_Logger.getIstanza;
      istanzaLogger.ScriviMessaggio("Messaggio 1");

      var istanzaBis = S_Logger.getIstanza;
      istanzaBis.ScriviMessaggio("messaggio 2");


   }
}