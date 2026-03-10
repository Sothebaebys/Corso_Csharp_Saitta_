public class Program
{
   public static void Main(string[] args)
   {
      GestoreCreazioneUtente creatore = new GestoreCreazioneUtente();

      creatore.Registra(new ModuloLog());

      creatore.Registra(new ModuloMarketing());

      bool isRunning = true;
      while (isRunning)
      {
         Console.WriteLine($"Inserisci il nome del nuovo utente:");

         string input = Console.ReadLine();
         creatore.CreaUtente(input);

         Console.WriteLine($"Vuoi continuare? (Y/N)");

         string scelta = Console.ReadLine();
         if (scelta.ToLower() != "y")
         {
            isRunning = false;
         }

      }
   }


}