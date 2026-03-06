public enum Anzianita
{
   junior,
   middle,
   senior
}

//Classe Persona generica per renderla potenzialmente implementabile per altre classi oltre al dipendente (visitatore, ospite,etc...)
public abstract class Persona
{
   #region Proprietà
   private string _nome;
   public string nome
   {
      get{return _nome;}
      set { if ((!string.IsNullOrEmpty(value))&& (value.Length> 3 ))
         {
            _nome = value.ToLower();
         }
         else{ 
            throw new ArgumentException("nome non valido.");
         }
      }
   }

   private string _cognome;

   public string cognome{get{return _cognome;}
   set {if ((!string.IsNullOrEmpty(value)) && (value.Length> 3 ))
         {
            _cognome = value.ToLower();
         }
         else{ 
            throw new ArgumentException("Cognome non valido.");
         }}}
   private int _id;
   public int id
   {
      get{return _id;}
      set
      {
         if (value > 0 )
         {
            _id = value;
         }
         else
         {
            _id = 0;
         }
      }
   }

   #endregion

   /*public void VerificaDati(string datoStr,ref string proprieta)
   {
      bool isValid = false;

      while (!isValid)
      {
         try
            {
               proprieta = datoStr;
               isValid = true;
            }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Errore: {e}\n Inserisci un testo valido:");
            proprieta = Console.ReadLine();
         }
      }
   }*/
   
   public Persona(string nome, string cognome, int id)
   {
      this.id = id;

      bool isValid = false;

      while (!isValid)
      {
         try
            {
               this.nome = nome;
               isValid = true;
            }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Errore: {e}\n Inserisci un testo valido:");
            this.nome = Console.ReadLine();
         }
      }
      isValid = false;
      
      while (!isValid)
      {
         try
            {
               this.cognome = cognome;
               isValid = true;
            }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Errore: {e}\n Inserisci un testo valido:");
            this.cognome = Console.ReadLine();
         }
      }
      
      //VerificaDati(nome,ref this.nome);
      //VerificaDati(cognome,ref this.cognome);
      
   }

   public abstract void StampaInfo();

}

//Classe dipendente che eredita da persona alcune  proprietà e metodi
public class Dipendente : Persona

{
   #region proprietà

   private List<Turno> listaTurno = new List<Turno>();
   private string _ruolo;
   private Anzianita _anzianita;

   public string ruolo
   {
      get { return _ruolo;}
      set
      {
         if (!string.IsNullOrEmpty(value))
         {
            _ruolo = value.ToLower();
         }
         else
         { 
            throw new ArgumentException("nome ruolo non valido.");
         }
      }
   }
   
   public Anzianita anzianita
   {
      get{return _anzianita;}
      set{_anzianita = value;}
   }
   
   private bool _isInServizio;
   public bool isInServizio
   {
      get
      {
         return _isInServizio;
      }
      set
      {
         _isInServizio = value ;
      }
   }
   #endregion
   
   //Costruttore
   public Dipendente (string nome,string cognome,int id, string ruolo, Anzianita anzianita) : base(nome, cognome, id)
   {
      //VerificaDati(ruolo,ref this.ruolo);
      this.anzianita = anzianita;

      bool isValid = false;

      while (!isValid)
      {
         try
            {
               this.ruolo = ruolo;
               isValid = true;
            }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Errore: {e}\n Inserisci un testo valido:");
            this.ruolo = Console.ReadLine();
         }
      }
   }

   #region Metodi

   //Qui aggiungo un turno alla lista
   public void IniziaTurno()
   {
      Console.WriteLine($"Inserisci la tipologia di turno: (G/N)");
      string inputTurno = Console.ReadLine();
      

      listaTurno.Add(new Turno(inputTurno));
      Console.WriteLine($"Aggiorno il turno...");
      listaTurno[listaTurno.Count -1].Ingresso();
      if (!isInServizio)
      {
         isInServizio = true;
      }
   }

   // accedo all'ultimo turno e lo chiudo.
   public void TerminaTurno()
   {
      listaTurno[listaTurno.Count -1].Uscita();
      if (isInServizio)
      {
         isInServizio = false;         
      }
   }

   public void MostraTurni()
   {
      foreach (Turno item in listaTurno)
      {
         item.InfoTurno();
      }
   }
   public override void StampaInfo()
   {
      Console.WriteLine($"Info dipendente:\n- Nome: {nome}\n- Cognome: {cognome}\n- ID: {id}\n- Ruolo: {ruolo}|\n- Livello di anzianità: {anzianita}");
      if(isInServizio)
      {
         Console.WriteLine($"Il dipendente è in servizio dalle ore: {listaTurno[listaTurno.Count -1].dataInizio}");
      }
      else
      {
         Console.WriteLine($"Il dipendente attualmente non è in servizio.");
      }

   }

   #endregion
}

//Classe sealed perchè non credo ci sarà bisogno di creare sottoclassi del turno, integra l'interfaccia IBadge
sealed class Turno : IBadge
{

   #region Proprietà
   //La tipologia di turno
   private string _turno;
   
   //Incapsulamento con Getter&Setter
   public string turno
   {
      get{ return _turno;}
      set
      {
         if (value.ToLower() == "g" || value.ToLower()=="n")
         {
            _turno = value.ToLower();
         }
         else{ 
            throw new ArgumentException("Turno non valido.\n Inserire un valore valido (g/n)");
         }
      }
   }

   // private int _id;
   // public int id
   // {
   //    get {return id;}
   //    set
   //    {
   //       _id = value;
   //    }
   // }

   private DateTime _dataInizio;
   
   //Incapsulamento con Getter&Setter
   public DateTime dataInizio
   {
      get { return _dataInizio;}
      set
      {
         _dataInizio = DateTime.Now;
      }
   }
   
   private DateTime _dataFine;
   
   //Incapsulamento con Getter&Setter
   public DateTime dataFine
   {
      get { return _dataFine;}
      set
      {
         _dataFine = DateTime.Now;
      }
   }

   //Booleana per il controllo dei dipendenti sui turni
   private bool _isAttivo = false;

   //Incapsulamento con Getter&Setter
   public bool isAttivo
   {
      get{return _isAttivo;}
      set
      {
         _isAttivo = value;
      }
   }
   
   #endregion

   //Metodo che non funziona correttamente con i setter privati, ho dovuto implementare la funzionalità all'interno del costruttore
   /*public static void VerificaDati(string datoStr, string proprieta)
   {
      bool isValid = false;

      while (!isValid)
      {
         try
            {
               proprieta = datoStr;
               isValid = true;
            }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Errore: {e}\n Inserisci un testo valido:");
            proprieta = Console.ReadLine();
         }
      }
   }*/

   #region Costruttore
   public Turno(string turno /*, int id*/)
   {
      //VerificaDati(turno, this.turno);

      //this.id = id;

      bool isValid = false;

      while (!isValid)
      {
         try
            {
               this.turno = turno;
               isValid = true;
            }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Errore: {e}\n Inserisci un testo valido:");
            this.turno = Console.ReadLine();
         }
      }
   }
   #endregion

   #region Metodi Classe

   public void InfoTurno()
   {
      if(turno.ToLower() == "g")
      {
         Console.WriteLine($"Turno attuale: mattina");
         if (isAttivo)
         {
            Console.WriteLine($"Il dipendente è attualmente in turno.\nInizio turno: {dataInizio}");
         }
         else
         {
            Console.WriteLine($"Il dipendente al momento non è in turno.");
         }
      }
      else
      {
         Console.WriteLine($"Turno attuale: sera");
         if (isAttivo)
         {
            Console.WriteLine($"Il dipendente è attualmente in turno.\nInizio turno: {dataInizio}");
         }
                  else
         {
            Console.WriteLine($"Il dipendente al momento non è in turno.");
         }
      }
   }

   //Metodo preso dall'interfaccia IBadge
   public void Ingresso()
   {
      if (!isAttivo)
      {
      this.dataInizio = DateTime.Now;
      isAttivo = true;
      }
      else
      {
         Console.WriteLine($"Il dipendente risulta già in servizio..");
      }
   }

   //Metodo preso dall'interfaccia IBadge
   public void Uscita()
   {
      if (isAttivo)
      {
         dataFine = DateTime.Now;
         isAttivo = false;
         Console.WriteLine($"Turno terminato: {dataFine}");
      }
      else
      {
         Console.WriteLine($"Non è stato registrato nessun ingresso.\n Non posso registrare l'uscita.");
      }

   }
   
   #endregion
}

