public class CentroMeteo : ISoggetto
{
   private readonly List<IObserver> _listaObservers = new List<IObserver>();

   public void Registra(IObserver observer)
   {
      Console.WriteLine($"Aggiungo observer...");
      _listaObservers.Add(observer);
      
   }

   public void Rimuovi(IObserver observer)
   {
      Console.WriteLine($"Rimuovo observer..");
      _listaObservers.Remove(observer);
      
   }

   public void Notifica(string msg)
   {
      foreach (var observer in _listaObservers)
      {
         observer.Aggiorna(msg);
      }
   }


   public void AggiornaMeteo(string dati)
   {
      Console.WriteLine($"Aggiornamento dati: {dati}");
      Notifica(dati);
      
   }
}

public class DisplayConsole : IObserver
{
   public void Aggiorna(string msg)
   {
      Console.WriteLine($"\nStato display aggiornato.\n messaggio: {msg}\n");
   }
}

public class DisplayMobile : IObserver
{
   public void Aggiorna(string msg)
   {
      Console.WriteLine($"\nStato mobile aggiornato.\n messaggio: {msg}\n");
   }

}

