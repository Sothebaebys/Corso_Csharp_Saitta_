
#region Interfacce
//Osservatore
public interface IObserver
{
   void NotificaCreazione(string nomeUtente);
}

//Interfaccia per l'osservato
public interface ISoggetto
{
   void Registra(IObserver observer);
   void Rimuovi(IObserver observer);

   void Notifica(string nomeUtente); 
}

#endregion

#region Factory method + classe user
//Factory Method
public static class UserFactory
{
   public static Utente Crea(string nome)
   {
      return new Utente(nome);
   }
}

public class Utente
{
   public string nome;

   public Utente(string nome)
   {
      this.nome = nome;
   }


   public override string ToString()
   {
      return $"L'utente ha questo nome: {nome}";
      
   }

}

#endregion

#region Osservato speciale
//OSSERVATO
public class GestoreCreazioneUtente : ISoggetto
{
   //private static GestoreCreazioneUtente _istanza;

   //private GestoreCreazioneUtente();
   private readonly List<IObserver> _listaObserver = new List<IObserver>();

   public void Registra(IObserver observer)
   {
      _listaObserver.Add(observer);
      Console.WriteLine($"Aggiunto nuovo osservatore");
      
   }
   public void Rimuovi(IObserver observer)
   {
      _listaObserver.Remove(observer);
      Console.WriteLine($"Rimosso osservatore");
      
   }

   public void Notifica(string userName)
   {
      foreach (var item in _listaObserver)
      {
         item.NotificaCreazione(userName);

      }
   }

   public void CreaUtente(string nome)
   {
      Utente user= UserFactory.Crea(nome);
      Console.WriteLine($"Creo Utente. . .");
      Notifica(nome);
   }
}

#endregion

#region OSSERVATORI
//Osservatore
public class ModuloLog : IObserver
{
   public void NotificaCreazione(string nomeUtente)
   {
      Console.WriteLine($"L'utente {nomeUtente} ha effettuato il log");
      
   }
}

//Osservatore
public class ModuloMarketing : IObserver
{
   public void NotificaCreazione(string nomeUtente)
   {
      Console.WriteLine($"L'utente {nomeUtente} è stato notato dal modulo marketing");
   }
}

#endregion

#region Singleton
public class Singleton : IObserver
{
   private static Singleton _istanza;

   private Singleton()
   {
      
   }

   public static Singleton getIstanza
   {
      get
      {
         if (_istanza == null)
         {
            _istanza = new Singleton();

         }
         return _istanza;
      }
   }

   public void Specifica()
   {
      Console.WriteLine($"L'utente è speciale");
      
   }

   public void NotificaCreazione(string nomeUtente)
   {
      Console.WriteLine($"L'utente {nomeUtente} è stato aggiunto al singleton");
   }

}

#endregion