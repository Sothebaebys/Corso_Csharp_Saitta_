using System;
using MySql.Data.MySqlClient; 

public class Connessione 
{
   private string _password = "MioSequel1326";
   private string _server = "localhost";
   private string _nomeDB = "rubrica_db";


   public Connessione(string password, string server, string nomeDB)
   {
      this._password = password;
      this._server = server;
      this._nomeDB = nomeDB;
   }
   
   public Connessione(string password)
   {
      this._password = password;
   }
   public Connessione()
   {
      
   }

   public string StringBuilderConn()
   {
      return $"server={_server};user=root;password={_password};database={_nomeDB}";
   }

   //test connessione 
   public bool Connetti()
   {
      using (MySqlConnection connection = new MySqlConnection(StringBuilderConn()))
      {
         try
         {
            connection.Open();
            Console.WriteLine("Connessione al database stabilita con successo.");
            return true;
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Errore di connessione: {ex.Message}");
            return false;
         }
      }
   }

   public void InserisciContatto(string nome, string contatto)
   {

      string query = "INSERT INTO contatti (nome, telefono) VALUES (@nome, @telefono)";
      
      //stanzio MySqlConnection e la apro
      using (MySqlConnection connection = new MySqlConnection(StringBuilderConn()))
      {
         try
         {
            connection.Open();
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
               command.Parameters.AddWithValue("@nome", nome);
               command.Parameters.AddWithValue("@telefono", contatto);
               command.ExecuteNonQuery();
               Console.WriteLine("Utente aggiunto.");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Errore durante l'inserimento: {ex.Message}");
         }
      }
   }

   public void RimuoviContatto(string nome)
   {
      string query = "DELETE FROM contatti WHERE nome = @nome";
      
      using (MySqlConnection connection = new MySqlConnection(StringBuilderConn()))
      {
         try
         {
            connection.Open();
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
               command.Parameters.AddWithValue("@nome", nome);
               int righe = command.ExecuteNonQuery();
               Console.WriteLine($"{righe} record eliminato.");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Errore durante l'eliminazione: {ex.Message}");
         }
      }
   }

   public void VisualizzaContatti()
   {
      string query = "SELECT id, nome, telefono FROM contatti";
      
      using (MySqlConnection connection = new MySqlConnection(StringBuilderConn()))
      {
         try
         {
            connection.Open();
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
               using (MySqlDataReader reader = command.ExecuteReader())
               {
                  Console.WriteLine("\nRubrica:");
                  while (reader.Read())
                  {
                     Console.WriteLine($"ID: {reader["id"]}, Nome: {reader["nome"]}, Telefono: {reader["telefono"]}");
                  }
                  Console.WriteLine("\n\n");
               }
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Errore durante la lettura: {ex.Message}");
         }
      }
   }
}

class Program
{
   public static void Menu()
   {
      Console.WriteLine("\nSeleziona l'azione. Premi: ");
      Console.WriteLine(" 1 Per aggiungere un contatto.");
      Console.WriteLine(" 2 Per eliminare un contatto per nome.");
      Console.WriteLine(" 3 Per visualizzare tutti i contatti in rubrica.");
      Console.WriteLine(" 0 Per uscire.");
      Console.Write("> ");
   }
   
   public static void Main(string[] args)
   {
  
      Connessione conDb = new Connessione();
      conDb.Connetti(); // Testiamo se il DB è raggiungibile all'avvio

      bool isRunning = true;

      Console.WriteLine("\nBenvenuto nella tua Rubrica!");
      
      while (isRunning)
      {
         Menu();
         string scelta = Console.ReadLine();

         switch (scelta)
         {
            case "1":
               Console.Write("Inserisci il nome da aggiungere: ");
               string nomeAgg = Console.ReadLine();
               
               Console.Write("Inserisci il numero da aggiungere: ");
               string contattoAgg = Console.ReadLine();

               conDb.InserisciContatto(nomeAgg, contattoAgg);
               break;

            case "2":
               Console.Write("Inserisci il nome da eliminare: ");
               string nomeRimuovi = Console.ReadLine();

               conDb.RimuoviContatto(nomeRimuovi);
               break;

            case "3":
               conDb.VisualizzaContatti();
               break;

            case "0":
               Console.WriteLine("Adios!");
               isRunning = false;
               break;

            default:
               Console.WriteLine("Scelta non valida. Riprova.");
               break;
         }
      }
   }
}