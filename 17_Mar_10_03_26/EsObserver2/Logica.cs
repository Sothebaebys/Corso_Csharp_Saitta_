//Osservatore
public interface INewsSubscriber
{
   void Stampa (string msg);

}

//Osservatori concreti
public class MobileApp : INewsSubscriber
{
   private NewsAgency _osservato;

   public NewsAgency osservato
   {
      get
      {
         return _osservato;
      }
      set
      {
         _osservato = value;
      }
   }
   
   public MobileApp(NewsAgency obj)
   {
      this.osservato = obj;
   }

   public void Stampa (string msg)
   {
      Console.WriteLine($"Notifica pop on mobile: \n {msg} ");
      
   }
}

public class EmailClient : INewsSubscriber
{
   private NewsAgency _osservato;
   public NewsAgency osservato
   {
      get
      {
         return _osservato;
      }
      set
      {
         _osservato = value;
      }
   }
   
   public EmailClient(NewsAgency obj)
   {
      this.osservato = obj;
   }

   public void Stampa (string msg)
   {
      Console.WriteLine($"Email sent to user: \n {msg}");
      
   }
}


//Osservato

public class NewsAgency
{
   private readonly List<INewsSubscriber> _listaOsservatori = new List<INewsSubscriber>();
   public string news;

   /*
   public NewsAgency(string news)
   {
      this.news = news;
   }*/


   public void Add(INewsSubscriber osservatore)
   {
      _listaOsservatori.Add(osservatore);
   }

   public void Del(INewsSubscriber osservatore)
   {
      _listaOsservatori.Remove(osservatore);
   }
   
   public void Notifica (string msg)
   {
      foreach (var observer in _listaOsservatori)
      {
         observer.Stampa(msg);
      }
   }

   public void SyncData(string dati)
   {
      Console.WriteLine($"Aggiorno la newsssss");
      Notifica(dati);
   }
}

