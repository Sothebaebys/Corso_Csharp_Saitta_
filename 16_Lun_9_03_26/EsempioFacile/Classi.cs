public sealed class S_ConfigurazioneSistema

{
   //riferimento all'istanza
   private static S_ConfigurazioneSistema _instance;
   //Proprietà per accedere all'istanza
   public static S_ConfigurazioneSistema istanza
   {
      get
      {
         if (_instance == null)
         {
            _instance = new S_ConfigurazioneSistema();
         }
         return _instance;
      }
   }
   
   
   public Dictionary<string,string> diz;


   //Costruttore privato
   private S_ConfigurazioneSistema()
   {
      
   }

   public void Imposta(string key, string value)
   {
      if (!diz.ContainsKey(key))
      {
         diz.Add(key,value);
      }
      else
      {
         Console.WriteLine($"chiave già presente, la aggiorno");
         diz[key]=value;
      }
   }

   public string Leggi(string key)
   {
      if (diz.ContainsKey(key))
      {
         return $"il valore corrispondente è: {diz[key]}";
      }
      else
      {
         return "Nessun valore corrispondente";
      }
   }

   public void StampaTutte()
   {
      foreach (var item in diz)
      {
         Console.WriteLine($"Chiave: {diz.Keys}\nValore: {diz.Values}");
      }
   }

}

/*
public class Modulo
{

   public Modulo(object istanza)
   {

   }

   public void Imposta(string key, string value)
   {
      if (!diz.ContainsKey(key))
      {
         diz.Add(key,value);
      }
      else
      {
         Console.WriteLine($"chiave già presente, la aggiorno");
         diz[key]=value;
      }
   }

   public string Leggi(string key)
   {
      if (diz.ContainsKey(key))
      {
         return $"il valore corrispondente è: {diz[key]}";
      }
   }

   public void StampaTutte()
   {
      foreach (var item in diz)
      {
         Console.WriteLine($"Chiave: {diz.Key}\nValore: {diz.Value}");
      }
   }
}
*/