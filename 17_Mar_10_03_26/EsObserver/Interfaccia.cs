public interface IObserver
{
   void Aggiorna(string msg);
}

public interface ISoggetto
{
   void Registra(IObserver osservatore);
   void Rimuovi(IObserver osservatore);
   void Notifica (string msg);
   
}

