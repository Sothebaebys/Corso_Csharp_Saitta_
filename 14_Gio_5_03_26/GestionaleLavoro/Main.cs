public class Program
{
   //Variabili di classe per le interazioni dell'utente
   public static string nome;
   public static string cognome;
   public static string ruolo;
   public static int id;

   //Metodo per la visualizzazione del menù
   public static void MenuInt()
    {
        Console.WriteLine($"\nSeleziona l'azione.\nPremi: ");
        Console.WriteLine($"-1 Per aggiungere un dipendente.");
        Console.WriteLine($"-2 Per timbrare l'ingresso");
        Console.WriteLine($"-3 Per timbrare l'uscita.");
        Console.WriteLine($"-4 Per visualizzare i turni dei dipendenti.");
        Console.WriteLine($"-5 Per visualizzare i dipendenti attivi in turno.");
        Console.WriteLine($"-6 Per cercare un dipendente tramite ID.");
        Console.WriteLine($"-7 Per vedere i dipendenti in base al ruolo.");
        Console.WriteLine($"-0 Per uscire.");
    }

   public static void Main(string[] args)
   {
      // Dati di prova
      List<Dipendente> listaDipendenti = new List<Dipendente>()
      {
         new Dipendente("Mario", "Mario", 1, "developer", Anzianita.senior),
         new Dipendente("Luca", "Barbagianni", 2, "designer", Anzianita.junior),
         new Dipendente("Ciccio", "Miao", 3, "manager", Anzianita.middle),
      };
      

      Console.WriteLine($"Benvenuto!");
      
      
      bool isAttivo = true;
      
      while (isAttivo)
      {
            MenuInt();
            string sceltaUser = Console.ReadLine();

            switch (sceltaUser)
            {
               //Inserire un nuovo dipendente
               case "1":
                  Console.WriteLine("Inserisci il nome:");
                  nome = Console.ReadLine();

                  Console.WriteLine("Inserisci il cognome:");
                  cognome = Console.ReadLine();

                  Console.WriteLine("Inserisci l'ID:");
                  id = int.Parse(Console.ReadLine());

                  Console.WriteLine("Inserisci ruolo:");
                  ruolo = Console.ReadLine();

                  Console.WriteLine($"Inserisci anzianità (junior, middle, senior):");
                  Anzianita anzianita = Enum.Parse<Anzianita>(Console.ReadLine(), true);

                  listaDipendenti.Add(new Dipendente(nome, cognome, id, ruolo, anzianita));

                  Console.WriteLine("Dipendente aggiunto con successo!");

                  break;

               //Inizio turno
               case "2":

                  Console.WriteLine("Inserisci ID dipendente:");
                  id = int.Parse(Console.ReadLine());
                  foreach (Dipendente item in listaDipendenti)
                  {
                     if (item.id == id)
                     {
                        item.IniziaTurno();
                        break;
                     }
                  }
                  break;

               //Fine turno
               case "3":

                  Console.WriteLine("Inserisci ID dipendente:");
                  id = int.Parse(Console.ReadLine());

                  foreach (Dipendente item in listaDipendenti)
                  {
                     if (item.id == id)
                     {
                        item.TerminaTurno();
                        break;
                     }
                  }
                  break;

               //Mostra tutti i turni dei dipendenti
               case "4":
                  Console.WriteLine("Mostro tutti i turni:");
                  foreach (Dipendente item in listaDipendenti)
                  {
                     item.MostraTurni();
                     break;
                  }
                  break;

               //Mostra tutti i dipendenti attivi in turno
               case "5":
                  Console.WriteLine("Dipendenti attivi:");
                  
                  foreach (Dipendente item in listaDipendenti)
                  {
                     if(item.isInServizio)
                     {
                        item.StampaInfo();
                        break;
                     }
                     
                  }
                  break;

               //Ricerca dipendente tramite ID
               case "6":
                  Console.WriteLine("Inserisci ID da cercare:");
                  id = int.Parse(Console.ReadLine());
                  foreach (Dipendente item in listaDipendenti)
                  {
                     if (item.id == id)
                     {
                        item.StampaInfo();
                        break;
                     }
                  }                    
                  break;

               //Ricerca per ruolo
               case "7":
                  Console.WriteLine("Inserisci ruolo da cercare:");
                  ruolo = Console.ReadLine();

                  foreach (Dipendente item in listaDipendenti)
                  {
                     if (item.ruolo == ruolo.ToLower())
                     {
                        item.StampaInfo();
                        break;
                     }
                  }
                  break;

               //Uscita
               case "0":
                    isAttivo = false;
                    Console.WriteLine("Arrivederci!");
                    break;

               //Caso default
               default:

                  Console.WriteLine("Scelta non valida.");
                  break;
            }
      }
   }
}