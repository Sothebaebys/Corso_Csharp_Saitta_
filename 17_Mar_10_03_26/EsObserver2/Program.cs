public class Program
{
   public static void Main(string[] args)
   {
      var osservato = new NewsAgency();

      var osservatoreApp = new MobileApp(osservato);
      var osservatoreMail= new EmailClient(osservato);

      osservato.Add(osservatoreApp);
      osservato.Add(osservatoreMail);

      osservato.SyncData("Ambarabaciccicocò");
      osservato.SyncData("Han bombardato anche il bistrot");

   }

}