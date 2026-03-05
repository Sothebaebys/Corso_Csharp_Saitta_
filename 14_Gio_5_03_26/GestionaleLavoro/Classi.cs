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



public interface IBadge
{
   private int _id;
   private string _turno;

   private DateTime _dataInizio;
   private DateTime _dataFine;


}