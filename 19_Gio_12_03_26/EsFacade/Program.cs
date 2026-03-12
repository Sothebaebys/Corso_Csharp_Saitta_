//+ Observer + singleton
#region Classi
public class Monitor
{
   public void Accendi()
   {
      Console.WriteLine($"Il monitor si è acceso");
      
   }
   public void Spegni()
   {
      Console.WriteLine($"Il monitor si è spento");
      
   }
}

public class Tastiera
{
   public void Inizializza()
   {
      Console.WriteLine($"Tastiera inizializzata");
      
   }
   public void AccendiLed()
   {
      Console.WriteLine($"Led accesi");
      
   }

      public void SpegniLed()
   {
      Console.WriteLine($"Led spenti");
      
   }
}

public class Mouse
{
   public void AccendiLed()
   {
      Console.WriteLine($"Led accesi");
      
   }

   public void SpegniLed()
   {
      Console.WriteLine($"Led spenti");
      
   }
   public void Inizializza()
   {
      Console.WriteLine($"Mouse inizializzato");
      
   }


}

public class SchedaVideo()
{
   public void Inizializza()
   {
      Console.WriteLine($"Scheda video inizializzata");
      
   }


}

#endregion

#region Facade
public class GamingSetupFacade
{
   //Lista per gli observer
   private readonly List<IOsservatore> _listaObserver = new List<IOsservatore>();

   //Proprieta statica privata per il singleton
   private static GamingSetupFacade _instance;
   
   //Getter dell'instance per il singleton
   public static GamingSetupFacade GetInstance
   {
      get
      {
      if (_instance == null)
      {
         _instance = new GamingSetupFacade();
      }
      return _instance;
      }
   }
   
   private Monitor _monitor;
   private Tastiera _tastiera;
   private Mouse _mouse;
   private SchedaVideo _schedavideo;
   

   //Costruttore privato per il singleton
   private GamingSetupFacade()
   {
      _monitor = new Monitor();
      _tastiera = new Tastiera();
      _mouse = new Mouse();
      _schedavideo = new SchedaVideo();
   }

   public void AvviaPostazione()
   {
      NotificaObs("Richiesta di avvio ricevuta");

      Console.WriteLine($"\nAvvio:");

      _schedavideo.Inizializza();

      _monitor.Accendi();
      
      _tastiera.Inizializza();
      _mouse.Inizializza();

      _mouse.AccendiLed();
      _tastiera.AccendiLed();

      NotificaObs("Postazione avviata con successo");
   }

   public void SpegniPostazione()
   {
      NotificaObs("Richiesta di spegnimento ricevuta");
      Console.WriteLine($"\nSpengo:");
      
      _mouse.SpegniLed();
      _tastiera.SpegniLed();
      _monitor.Spegni();

      NotificaObs("Postazione spenta con successo");
   }

   //metodi per gli observer
   public void AggiungiObs (IOsservatore observer)
   {
      _listaObserver.Add(observer);
   }

   public void RimuoviObs (IOsservatore observer)
   {
      _listaObserver.Remove(observer);
   }

   public void NotificaObs (string msg)
   {
      foreach (var item in _listaObserver)
      {
         item.Aggiorna(msg);
      }
   }
}

#endregion

#region Observer
public interface IOsservatore
{
   void Aggiorna(string msg);
}

public class CentroNotifiche : IOsservatore
{
   public void Aggiorna(string msg)
   {
      Console.WriteLine($"\n\nHey!\nHai una notifica: {msg}\n\n");
      
   }
}

#endregion


public class Program
{
   public static void Main(string[] args)
   {
      /*
      Monitor monitor = new Monitor();
      Tastiera tastiera = new Tastiera();
      Mouse mouse = new Mouse();
      SchedaVideo schedaVideo = new SchedaVideo();

      
      GamingSetupFacade setupFacade = new GamingSetupFacade(monitor,tastiera,mouse,schedaVideo);
      */

      //Accedo all'istanza di GamingSetupFacade tramite il getter
      GamingSetupFacade setupper = GamingSetupFacade.GetInstance;
      
      //Inizializzo il centro notifiche (observer)
      CentroNotifiche notifiche = new CentroNotifiche();

      //Aggiungo il centro notifiche alla lista degli observer
      setupper.AggiungiObs(notifiche);

      Console.WriteLine($"\n\nAvvio la postazione..");
      
      setupper.AvviaPostazione();

      Console.WriteLine($"\n\nSpegno la postazione");
      
      setupper.SpegniPostazione();
   }
}