public class PrenotazioneViaggio
{
   const int MAX_POSTI = 20;
   private int _postiPrenotati=0;

   public string destinazione;

   public string Destinazione
   {
      get
      {
         return destinazione;
      }
      set
      {
         if (value != "")
            destinazione = value;
      }
   }

   protected int postiDisponibili;

   public int PostiDisponibili
   {
      get
      {
         return postiDisponibili;
      }
      set
      {
         postiDisponibili = MAX_POSTI -_postiPrenotati;
      }
   }


   public PrenotazioneViaggio(string destinazione)
   {
      this.destinazione = destinazione;
      this.postiDisponibili = MAX_POSTI;
   }


   public void PrenotaPosti(int numeroP)
   {
      if (postiDisponibili >= numeroP)
      {
         _postiPrenotati += numeroP;
         postiDisponibili-= numeroP;
         Console.WriteLine($"Prenotazione effettuata con successo!");
         
      }
      else
      {
      Console.WriteLine($"La prenotazione non è andata a buon fine..\nCi sono {postiDisponibili} posti disponibili e si sta provando a prenotare per {numeroP}.");
      }
      
      Console.WriteLine($"Resoconto:\n\n\n{ToString()}");
      
   }

   public void AnnullaPrenotazione(int numeroP)
   {
      if (((postiDisponibili + numeroP )<= MAX_POSTI) && (_postiPrenotati- numeroP > 0))
      {
         postiDisponibili += numeroP;
         Console.WriteLine($"Cancellazione effettuata con successo!");
         _postiPrenotati -= numeroP;
      }
      else
      {
         Console.WriteLine($"La prenotazione non è andata a buon fine..");
      }

      Console.WriteLine($"Resoconto:\n\n\n{ToString()}");

   }

   public override string ToString()
   {
      return $"Prenotazione volo per : {destinazione} \n Posti disponibili per il viaggio: {postiDisponibili}\n Posti occupati per il viaggio: {_postiPrenotati}";
   }

}