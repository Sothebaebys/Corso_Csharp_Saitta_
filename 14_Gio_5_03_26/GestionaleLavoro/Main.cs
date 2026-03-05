public class Program
{
     public static void MenuInt()
   {
      Console.WriteLine($"Benvenuto\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un dipendente.");
      Console.WriteLine($"-2 Per timbrare l'ingresso");
      Console.WriteLine($"-3 Per timbrare l'uscita.");
      Console.WriteLine($"-4 Per visualizzare i dipendenti del turno notturno.");
      Console.WriteLine($"-5 Per visualizzare i dipendenti del turno diurno.");
      Console.WriteLine($"-6 Per cercare un dipendente tramite ID.");
      Console.WriteLine($"-7 Per vedere i dipendenti in base al ruolo.");
      Console.WriteLine($"-0 Per uscire.");
   }
   public static void Main(string[] args)
   {
      List<Persona> listaPersone = new List<Persona>();

   }
}