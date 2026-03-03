class Program
{
   public static List<Corso> listaCorsi = new List<Corso>();
   public static string nomeC="";
   public static int durataC;
   public static string nomeDoc="";

   public static void MenuInt()
   {
      Console.WriteLine($"Benvenuto\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un corso di Musica.");
      Console.WriteLine($"-2 Per aggiungere un corso di Pittura");
      Console.WriteLine($"-3 Per aggiungere un corso di Danza.");
      Console.WriteLine($"-4 Per aggiungere uno studente a un corso specifico.");
      Console.WriteLine($"-5 Per visualizzare tutti i corsi.");
      Console.WriteLine($"-6 Per cercare corsi per nome docente.");
      Console.WriteLine($"-7 Per visualizzare il messaggio univoco del corso.");
      Console.WriteLine($"-0 Per uscire.");

   }
   // 1 2 3    
   public static void AggiungiCorso(ref string nomec, ref int durataC, ref string nomeDoc)
   {
      Console.WriteLine($"Inserisci il nome del corso:");
      nomeC = Console.ReadLine();

      Console.WriteLine($"Inserisci la durata del corso:");
      durataC = int.Parse(Console.ReadLine());

      Console.WriteLine($"Inserisci il nome del docente del corso:");
      nomeDoc = Console.ReadLine();

   }

   //4
   public static void InserisciStud()
   {
      bool isFound = false;
      Console.WriteLine($"Inserisci il nome del corso:");
      string nomeCorsoI =Console.ReadLine();

      foreach (Corso item in listaCorsi)
      {
         if (item.nomeCorso == nomeCorsoI )
         {
            Console.WriteLine($"Inserisci il nome dello studente");
            string nome =Console.ReadLine();
            item.AggiungiStudente(nome);
            isFound = true;
         }
      }

      if(isFound)
      {
         Console.WriteLine("Studente aggiunto con successo al corso.");
      }
      else
      {
         Console.WriteLine($"Non è stato possibile aggiungere lo studente al corso..");
      }
   }

   //5
   public static void VisualizzaCorsi()
   {
      foreach (Corso item in listaCorsi)
      {
         item.ToString();
      }
   }

   //6
   public static void CercaDocente()
   {
      bool isFound = false;
      Console.WriteLine($"Inserisci il nome del docente:");
      string nomeDocente =Console.ReadLine();

      foreach (Corso item in listaCorsi)
      {
         if (item.docente == nomeDocente )
         {
            Console.WriteLine($"Il docente segue il corso di : {item.nomeCorso}.");
            
            isFound = true;
         }
      }
      if(!isFound)
      {
         Console.WriteLine("Non è stato trovato nessun docente corrispondente tra i corsi");
      }
   }

   //7
   public static void MostraMess()
   {
      bool isFound = false;
      Console.WriteLine($"Inserisci il nome del corso:");
      string nomeCorsoI =Console.ReadLine();

      foreach (Corso item in listaCorsi)
      {
         if (item.nomeCorso == nomeCorsoI)
         {
            //Console.WriteLine($"Il docente segue il corso di : {item.nomeCorso}.");
            item.MetodoSpeciale();
            isFound = true;
         }
      }
      if(!isFound)
      {
         Console.WriteLine("Mi spiace ma non è stato trovata nessuna corrispondenza...");
      }
   }


   public static void Main(string[] args)
   {
      List<Corso> listaCorsi = new List<Corso>();

      bool isActive = true;
      
      while(isActive)
      {
         MenuInt();
         string scelta = Console.ReadLine();

         switch (scelta)
         {
            case ("1"):
               //musica
               AggiungiCorso(ref nomeC, ref durataC, ref nomeDoc);
               Console.WriteLine($"Inserisci il nome dello strumento utilizzato nel corso:");
               string strumento = Console.ReadLine();
               CorsoMusica musicC = new CorsoMusica(nomeC, durataC, nomeDoc, strumento);
               break;
            case ("2"):
               //pittura
               AggiungiCorso(ref nomeC, ref durataC, ref nomeDoc);
               Console.WriteLine($"Inserisci il nome dello strumento utilizzato nel corso:");
               string tecnica = Console.ReadLine();  
               CorsoPittura  pitturaC = new CorsoPittura(nomeC, durataC, nomeDoc, tecnica);        
               break;
            case ("3"):
               //danza
               AggiungiCorso(ref nomeC, ref durataC, ref nomeDoc);
               Console.WriteLine($"Inserisci il nome dello strumento utilizzato nel corso:");
               string stile = Console.ReadLine(); 
               CorsoDanza danzaC = new CorsoDanza(nomeC, durataC, nomeDoc, stile);          
               break;
            case ("4"):
               InserisciStud();
               break;
            case ("5"):
               VisualizzaCorsi();
               break;
            case ("6"):
               CercaDocente();
               break;
            case ("7"):
               MostraMess();
               break;
            case ("0"):
               Console.WriteLine($"Arrivedorci..");
               isActive = false;
               break;
            default:
            Console.WriteLine($"Scelta non valida");
               break;
         }
      }
   }

}