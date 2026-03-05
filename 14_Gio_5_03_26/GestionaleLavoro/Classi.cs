//Abstract Dipendente
//Classe Persona
//Classe Ruolo
//Classe Turni ? o interface?
   //log entrata/uscita
//
//badge interface
public abstract class Persona
{
   #region Proprietà
   private string _nome;
   public string nome
   {
      get{return _nome;}
      set { if ((!string.IsNullOrEmpty(value))&& (value.Length()> 3 ))
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
   set {if ((!string.IsNullOrEmpty(value)) && (value.Length()> 3 ))
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

   public void VerificaDati(string datoStr, string proprieta)
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
   }
   
   public Persona(string nome, string cognome, string id)
   {
      VerificaDati(nome, this.nome);
      VerificaDati(cognome, this.cognome);
      this.id = id;
   }

   public void StampaInfo();

}

public class Dipendente : Persona

{
   #region proprietà
   private string _ruolo;
   private string _anzianita;

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
   
   public string anzianita
   {
      get{return _anzianita;}
      set
      {
         if (!string.IsNullOrEmpty(value))
         {
            _anzianita = value.ToLower();
         }
         else
         { 
            throw new ArgumentException("anzianità non valida.");
         }
      }
   }
   
   private bool isInServizio;
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
   public Dipendente (string nome,string cognome,int id, string ruolo, string anzianita) : base(nome, cognome, id)
   {
      VerificaDati(ruolo, this.ruolo);
      VerificaDati(anzianita, this.anzianita);
   }
   public override void StampaInfo()
   {
      Console.WriteLine($"Info dipendente:\n- Nome: {nome}\n- Cognome: {cognome}\n- ID: {id}\n- Ruolo: {ruolo}|\n- Livello di anzianità: {anzianita}");
   }

}

sealed class Turno : IBadge
{
   private string _turno;
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

   private int _id;
   public int id
   {
      get {return id;}
      set
      {
         _id = value;
      }
   }

   private DateTime _dataInizio;
   public DateTime dataInizio
   {
      get { return _dataInizio;}
      set
      {
         _dataInizio = DateTime.Now();
      }
   }
   
   private DateTime _dataFine;
   public DateTime dataFine
   {
      get { return _dataFine;}
      set
      {
         _dataFine = DateTime.Now();
      }
   }

   private bool _isAttivo = false;
   public bool isAttivo
   {
      get{return _isAttivo;}
      set
      {
         _isAttivo = value;
      }
   }
   public static void VerificaDati(string datoStr, string proprieta)
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
   }

   public Turno(string turno, int id)
   {
      VerificaDati(turno, this.turno);
   }

   public void InfoTurno()
   {
      if(turno.ToLower() == "g")
      {
         Console.WriteLine($"Turno mattina");
         
      }
      else
      {
         Console.WriteLine($"Turno sera");
      }

   }

   public bool Ingresso()
   {
      
   }

   public bool Uscita()
   {
      
   }
}
