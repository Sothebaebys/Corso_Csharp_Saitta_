public sealed class ConfigurazioneSistema
{
   private static ConfigurazioneSistema _istanza;
   private Dictionary<string,string> dizSistema;
   private ConfigurazioneSistema()
   {
      dizSistema = new Dictionary<string, string>();
   }

   public static ConfigurazioneSistema GetIstanza
   {
      get
      {
         if (_istanza == null)
         {
            _istanza = new ConfigurazioneSistema();
         }
         return _istanza;
      }
   }

public void Imposta(string chiave, string valore)
   {
      if (dizSistema.ContainsKey(chiave))
      {
         Console.WriteLine($"Configurazione già presente nel sistema, aggiorno..");
         dizSistema[chiave] = valore;
      }
      else
      {
         Console.WriteLine($"Aggiungo configurazione..");
         dizSistema.Add ( chiave, valore);
      }
   }

   public string Leggi(string chiave)
   {
      if (dizSistema.ContainsKey(chiave))
      {
         return dizSistema[chiave];
      }
      else
      {
         return "Configurazione non presente";
      }

   }

   public void StampaTutte()
   {
      foreach (var item in dizSistema)
      {
         Console.WriteLine($"chiave: {item.Key}\n valore: {item.Value}");
      }
   }
/*
void Imposta(string chiave, string valore) → aggiunge o aggiorna una configurazione.

string Leggi(string chiave) → restituisce il valore associato alla chiave, se esiste.

void StampaTutte() → stampa tutte le configurazioni salvate.
*/

}

