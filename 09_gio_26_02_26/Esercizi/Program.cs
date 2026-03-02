class Esercizi
{
   /* Traccia 1
   Scrivi un programma che:
a.Crea un Dictionary<string, string> dove la chiave è il nome e il valore è il numero di telefono.
b.Fa inserire 3 coppie nome-numero da tastiera.
c.Stampa tutta la rubrica.*/
   
   // Esercizio 1
   public static void DizionarioRubrica()
   {
      Dictionary<string,string> rubrica = new Dictionary<string, string>();
      string numero;
      string nome;
      int iterazioni =3;
      for (int i = 0; i < iterazioni; i++)
      {
         Console.Write($"Inserisci il numero di telefono: ");
         numero= Console.ReadLine();
      
         Console.WriteLine($"Inserisci il nome associato al numero:");
         nome= Console.ReadLine();

         rubrica[nome] = numero;
      }
      foreach (var contatto in rubrica)
      {
         Console.WriteLine($"Il numero di {contatto.Key} è: {contatto.Value}");
         
      }


      Console.WriteLine($"Text");
      
      Console.ReadLine();
      
      Console.WriteLine($"Text");
      
      Console.ReadLine();
   }

/* Traccia 2
   Scrivi un programma che:
a.Chiede all’utente di inserire una frase.
b.Divide la frase in parole (separate da spazio).
c.Usa un Dictionary<string, int> per contare quante volte compare ciascuna parola.
d.Stampa ogni parola con la relativa frequenza.
*/
   
   // Esercizio 2
   public static void ContatoreParole()
   {
      Dictionary<string, int> paroliere = new Dictionary<string, int>();

      Console.WriteLine($"Inserisci una frase:");
      
      string frase= Console.ReadLine().ToLower();

      string[] listaParole=frase.Split(" ");

      foreach (var parola in listaParole)
      {
         if (paroliere.ContainsKey(parola))
         {
            paroliere[parola] += 1; 
         }
         else
         {
            paroliere[parola]= 1;
         }
      }
      foreach (var parola in paroliere)
      {
         if (parola.Value > 1)
         {
            Console.WriteLine($"La parola {parola.Key} è presente {parola.Value} volte.");
         }
         else
         {
            Console.WriteLine($"La parola {parola.Key} è presente {parola.Value} volta.");
         }
      }
   }

/* Traccia 3
Scrivi un programma che:
a.Gestisce un Dictionary<string, int> dove la chiave è il nome di un prodotto e il valore è la
quantità disponibile.
b.Il programma deve permettere con un menu:
i.Aggiungere un nuovo prodotto (o aumentare la quantità se esiste già).
ii.Rimuovere un prodotto dal magazzino.
iii.Cercare un prodotto e mostrare la quantità.
iv.Stampare l’inventario completo.
c.Il menu deve ripetersi finché l’utente non sceglie “Esci”
.

//Numero di item da rimuovere ?
*/
   
   // Esercizio 3
   public static void Magazzino()
   {
      //Inizializzo il dizionario
      Dictionary<string,int> magazzino = new Dictionary<string,int>()
      {
         {"cipolle",33},
         {"barbagianni",774},
         {"orologi",1},
         {"cavi usb-c",1},
         {"cavi usb rotti",137}
      };

      //Condizione per l'esecuzione del ciclo
      bool isActive = true;

      while (isActive)
      {
         Console.WriteLine($"\nSeleziona l'azione:\n -A per aggiungere un prodotto.\n -R per rimuovere un prodotto. \n -C per cercare un prodotto.\n -S per stampare l'inventario completo \n -E per uscire.");
         string scelta = Console.ReadLine();

         // Per interagire con i vari casi possibili
         switch (scelta)
         {
            // Aggiunge item nel magazzino
            case "a":
               Console.WriteLine($"====================================================");
               Console.WriteLine($"Hai selezionato l'aggiunta di un prodotto");

               Console.WriteLine($"Seleziona l'item che vuoi aggiungere:");
               string itemAdd = Console.ReadLine();

               Console.WriteLine($"Seleziona la quantità:");
               int itemQuant = int.Parse(Console.ReadLine());
               
               // Check sulla presenza dell' item nel magazzino ed eventualmente si aggiorna il valore, altrimenti si crea un nuovo item
               if (magazzino.ContainsKey(itemAdd))
               {
                  magazzino[itemAdd] += itemQuant;
               }
               else
               {
                  Console.WriteLine($"L'item non era presente nel magazzino, creato nuovo item");
                  magazzino[itemAdd] = itemQuant;
               }
               
               break;

            // Rimuove parzialmente o totalmente item dal magazzino
            case "r":
               Console.WriteLine($"\n====================================================");
               Console.WriteLine($"\nHai selezionato la rimozione di un prodotto");

               Console.WriteLine($"Seleziona l'item che vuoi rimuovere:");
               string itemRemove = Console.ReadLine();
               
               //Check sulla presenza
               if(magazzino.ContainsKey(itemRemove))
               {
                  //Scelta se rimozione parziale o totale dell'item
                  Console.WriteLine($"Vuoi rimuovere l'item del tutto dal magazzino, o rimuoverne una parte?\n -P Per la rimozione parziale.\n -T per la rimozione totale.");
                  string totParz = Console.ReadLine();
                  
                  // Rimozione parziale
                  if (totParz == "p" ||totParz == "P")
                  {
                     Console.WriteLine($"\nPerfetto!\nInserisci la quantità da rimuovere:");
                     int removeQuantita =int.Parse(Console.ReadLine());
                     if ((magazzino[itemRemove]- removeQuantita) < 0)
                     {
                        int differenza = magazzino[itemRemove]- removeQuantita;

                        Console.WriteLine($"Non ci sono abbastanza {itemRemove} in magazzino, hai selezionato {removeQuantita} mentre in magazzino sono presenti {magazzino[itemRemove]}");
                        Console.WriteLine($"{differenza-(differenza*2)} item non verranno sottratti.");

                        magazzino[itemRemove]=0;
                     }
                     magazzino[itemRemove]-=removeQuantita;
                  }
                  
                  // RImozione totale
                  else if (totParz == "T" ||totParz == "t")
                  {
                     magazzino.Remove(itemRemove);
                  }
                  else
                  {
                     Console.WriteLine($"Scelta non valida...");
                  }
               }
               else
               {
                  Console.WriteLine($"\nItem non trovato all'interno del magazzino..");
               }
               break;

            // Ricerca di un item all'interno del magazzino
            case "c":
               Console.WriteLine($"\n====================================================");
               Console.WriteLine($"Hai selezionato la ricerca di un prodotto");
               Console.WriteLine($"Seleziona l'item che vuoi cercare:");
               string itemRicerca = Console.ReadLine();

               if (magazzino.ContainsKey(itemRicerca))
               {
                  Console.WriteLine($"\nCi sono {magazzino[itemRicerca]} unità del prodotto all'interno del magazzino.");
               }
               else
               {
                  Console.WriteLine($"\nMi dispiace, nessun item corrispondente..");
               }
               break;

            // Stampa l'inventario completo
            case "s":
               Console.WriteLine($"\n====================================================\n");
               if (magazzino.Count>0)
               {
                  Console.WriteLine($"Hai selezionato la stampa dell'inventario:\nEccolo:\n");

                        foreach (var item in magazzino)
                        {
                           if (item.Value > 1)
                           {
                              Console.WriteLine($"L'item {item.Key}, è presente {item.Value} volte nel magazzino.");
                           }
                           else
                           {
                              Console.WriteLine($"L'item {item.Key}, è presente {item.Value} volta nel magazzino.");
                           }
                        }
               }
               else
               {
                  Console.WriteLine($"Hai selezionato la stampa dell'inventario ma è vuoto...\n");
               }
               break;

            // Esce dal magazzino, va a casa proprio cioè ciao vah
            case "e":
               Console.WriteLine($"\n====================================================\n");
               Console.WriteLine($"Adiossss");
               Console.WriteLine($"\n====================================================\n");
               isActive = false;
               break;

            // Default per scelta non valida
            default:
               Console.WriteLine($"====================================================");
               Console.WriteLine($"\nScelta non valida ritenta...\n");
               Console.WriteLine($"====================================================\n");
               break;
               
         }
         
      }
   }


   static void Main(string[] args)
   {     
      //Magazzino();
      //ContatoreParole();
      //DizionarioRubrica();
   }
}