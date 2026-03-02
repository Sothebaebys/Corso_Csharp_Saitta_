class Program
{
   public static void Main(string[] args)
   {
      VoloAereo volo = new VoloAereo("A375b2");
      volo.VisualizzaStato();
      volo.EffettuaPrenotazione(5);
      volo.AnnullaPrenotazione(3);
      
      bool isValid = true;

      while (isValid)
      {
         Console.WriteLine($"Inserisci il codice volo:");
         string codiceStato = Console.ReadLine();
         Console.WriteLine($"Seleziona l'operazione da effettuare: \n -1 per la prenotazione \n -2 per annullare una prenotaizone\n -0 per uscire");
         int scelta = int.Parse(Console.ReadLine());
         if (scelta == 1)
         {
            Console.WriteLine($"Per quante persone vuoi prenotare? ");
            int numeroPass = int.Parse(Console.ReadLine());
            volo.EffettuaPrenotazione(numeroPass);
         }
         else if (scelta == 2)
         {
            Console.WriteLine($"Per quante persone vuoi disdire? ");
            int numeroPass = int.Parse(Console.ReadLine());
            volo.AnnullaPrenotazione(numeroPass);
         }
         else if (scelta == 0)
         {
            Console.WriteLine($"Arrivederci!");
            isValid = false;
         }
         else
         {
            Console.WriteLine($"Scelta non valita...");
         }
         
      }
   }
}
