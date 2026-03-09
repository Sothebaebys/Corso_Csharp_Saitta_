public sealed class S_Logger
{
   private static S_Logger _istanza;

   public static S_Logger getIstanza
   {
      get
      {
         if (_istanza == null)
         {
            _istanza = new S_Logger();
         }
         return _istanza;
      }
   }
   private S_Logger()
   {
      
   }


/*

   public static object GetIstanza()
   {
      Console.WriteLine($"Text");
      
   }
*/


   public void ScriviMessaggio(string message)
   {
      Console.WriteLine($"Data e ora: {DateTime.Now}\n{message}");
      Console.WriteLine($"hashCode: {GetHashCode().ToString()}\n\n\n");
      //GetHashCode().ToString()
   }


   public void InfoIstanza()
   {
      Console.WriteLine($"Hashcode: {GetHashCode().ToString()}");
      
   }
}