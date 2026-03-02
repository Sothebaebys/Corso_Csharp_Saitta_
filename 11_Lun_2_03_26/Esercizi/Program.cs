using System;

class Program
{
   
   public static void Main(string[] args)
   {
      #region Libro
      Libro l = new Libro("IlTitolo","L'autore",1035);
      Libro l1 = new Libro("IlTitolo","L'autore",1035);
      Libro l2 = new Libro("IlTitoloneee","L'autoricchio",2135);

      Console.WriteLine($" To string : {l.ToString()}");
      Console.WriteLine($"l Equals l1 ? {l.Equals(l1)}");
      Console.WriteLine($"l Equals l2 ? {l.Equals(l2)}");
      Console.WriteLine($"Hashcode di l1 : {l1.GetHashCode()}");
      Console.WriteLine($"Hashcode di l2 : {l2.GetHashCode()}");
      Console.WriteLine($"Hashcode di l : {l.GetHashCode()}");

      Console.WriteLine($"Il tipo di l è: {l.GetType()}");
      Console.WriteLine($"Il tipo di l1 è: {l1.GetType()}");
      Console.WriteLine($"Il tipo di l2 è: {l2.GetType()}");

      Console.WriteLine($"{ReferenceEquals(l.titolo,l1.titolo)}");
      Console.WriteLine($"{ReferenceEquals(l,l1)}");
#endregion
   
      #region Persona
      List<Utente> listaUsers = new List<Utente>();

      bool isActive = true;
      int numeroIterazioni = 3;

      //Utente user = new Utente("Franco", 7);
      //Utente user1 = new Utente("Ciccio", 15);

      //user.MacchinaDefault();
      //user1.MacchinaUtenteInput(ref user1.macchina);


      while (isActive)
      {
         for (var i = 0; i < numeroIterazioni; i++)
         {
            Console.WriteLine($"Vuoi creare un nuovo utente?: Y/N");
            string scelta =Console.ReadLine();
      
            if (scelta == "Y" || scelta == "y")
            {
               Console.WriteLine($"Inserisci il nome:");
               string sceltaNome =Console.ReadLine();

               Console.WriteLine($"Vuoi personalizzare i crediti?: Y/N");
               string sceltaCrediti = Console.ReadLine();
               
               if (scelta == "Y" || scelta == "y")
               {
                  Console.WriteLine($"Quanti crediti?:");
                  int crediti = int.Parse(Console.ReadLine());
                  Utente user = new Utente(sceltaNome, crediti);
                  listaUsers.Add(user);
               }
               else
               {
                  Utente user = new Utente(sceltaNome, 10);
                  listaUsers.Add(user);
               }
            }
            else
            {
               isActive =false;
            }
         }
      }
      
      foreach ( Utente user in listaUsers)
         {
            Console.WriteLine($"Hai a disposizione {user.credito}, vuoi spenderli per delle modifiche? (Y/N)");
            string scelta = Console.ReadLine();
            
            if (scelta == "Y" || scelta == "y")
            {
               bool isModificato = true;
               
               while (isModificato)
               {
                  Console.WriteLine($"Seleziona la modifica:\n 1 per il motore\n 2 per la velocità massima\n 3 per le sospensioni\n 0 per uscire");
                  int opzione = int.Parse(Console.ReadLine());
                  switch (opzione)
                  {
                     case (1):
                        user.SceltaModifiche(1);
                        break;
                     case(2):
                        user.SceltaModifiche(2);
                        break;
                     case(3):
                        user.SceltaModifiche(3);
                        break;
                     case(0):
                        Console.WriteLine(user.ToString());
                        Console.WriteLine($"Fine modifiche..");
                        isModificato = false;
                        break;
                     default:
                        Console.WriteLine($"Scelta non valida...");
                        break;
                  }
               }
            }
         }


      #endregion  
   }
   }