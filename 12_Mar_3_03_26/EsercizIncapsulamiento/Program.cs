class Program
{
   public static void Main(string[] args)
   {
      PrenotazioneViaggio iran = new PrenotazioneViaggio("Iran");
      //iran.destinazione = "Iran";
      iran.PrenotaPosti(15);
      iran.PrenotaPosti(7);
      iran.PrenotaPosti(1);

      iran.AnnullaPrenotazione(2);
      iran.AnnullaPrenotazione(22);
      iran.AnnullaPrenotazione(4);
      
   }
}