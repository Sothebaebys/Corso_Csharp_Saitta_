public interface IStrategiaOperazione
{
   double Calcola(double a, double b);
}

public class SommaStrategia : IStrategiaOperazione
{
   public double Calcola(double a,double b)
   {
      return a+b;
   }
}

public class SottraiStrategia : IStrategiaOperazione
{
   public double Calcola(double a,double b)
   {
      return a-b;
   }
}

public class DividiStrategia : IStrategiaOperazione
{
   public double Calcola(double a, double b)
   {
      if (b!=0)
      {
      return a/b;
      }
      else
      {
         Console.WriteLine($"Divisione per zero non consentita");
         return 0;
      }
   }
}

public class MoltiplicaStrategia : IStrategiaOperazione
{
   public double Calcola(double a, double b)
   {
      return a*b;
   }
}

public class Calcolatrice
{
   
   private IStrategiaOperazione _strategia;

#region Observer
   private readonly List<IOsservatore> _listaOsservatori = new List<IOsservatore>();

   public void Aggiungi(IOsservatore osservatore)
   {
      _listaOsservatori.Add(osservatore);
   }
   
   public void Rimuovi(IOsservatore osservatore)
   {
      _listaOsservatori.Remove(osservatore);
   }

   public void Notifica(string msg)
   {
      foreach(var item in _listaOsservatori)
      {
         item.Aggiorna(msg);
      }
   }
#endregion

   public void ImpostaStrategia(IStrategiaOperazione strategia)
   {
      _strategia = strategia;
   }

   public void EseguiStrategia (double a, double b)
   {
      if (_strategia == null)
      {
         Console.WriteLine($"Nessun calcolo selezionato.");
         return;
      }
      double risultato = _strategia.Calcola(a,b);
      string operazione = _strategia.GetType().Name;

      Console.WriteLine($"Risultato operazione: {risultato}");
      string msg = $"{operazione}: {a}  {b} = {risultato}";
      
      Notifica(msg);
      
   }
}

public interface IOsservatore
{
   void Aggiorna(string msg);
}

public class Log : IOsservatore
{
   public void Aggiorna(string msg)
   {
      Console.WriteLine($"Descrizione operazione eseguita:\n {msg}");
   }
}
/* Da attaccare alla calcolatrice


   private readonly List<IOsservatore> _listaOsservatori;

   void Aggiungi(IOsservatore osservatore);
   {
      _listaOsservatori.Add(osservatore);
   }
   
   void Rimuovi(IOsservatore osservatore);
   {
      _listaOsservatori.Remove(osservatore);
   }

   void Notifica(string msg)
   {
      foreach(var item in _listaOsservatori)
      {
         item.Aggiorna(msg);
      }
   }

   */