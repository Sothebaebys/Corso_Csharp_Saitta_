class Esercizi
{
   // Primo
   public static void InserisciElementiLista()
   {
      List<int> numeri = new List<int>();
      int numeroIterazioni=5;

      //popolo la lista
      for(int i=0 ;i<numeroIterazioni; i++)
      {
         Console.WriteLine($"Inserisci Un numero");
         
         int uInput= int.Parse(Console.ReadLine());
         numeri.Add(uInput);
      }

      //Se necessario rimuove degli elementi
      Console.WriteLine($"Vuoi rimuovere elementi dalla lista? (y/n)");
      string scelta = Console.ReadLine();
      if (scelta == "y")
      {
         Console.WriteLine($"Quanti elementi voi rimuovere?");
         int rimozione = int.Parse(Console.ReadLine());

         if (rimozione<= numeri.Count())
         {
            for(int i=0; i< rimozione; i++)
            {
               Console.WriteLine($"Inserisci un numero da rimuovere: ");
         
               int uInput= int.Parse(Console.ReadLine());
               numeri.Remove(uInput);
            }
         }
      }

      //Stampa finale della lista
      foreach (int num in numeri)
      {
         Console.Write($"{num}");
      }
   }

   //Secondo
   public static void ListaCasuale()
   {
      Random randm = new Random();

      List<int> numeri= new List<int>();
      List<int> pari= new List<int>();
      
      int lunghezzaLista=10;

      //Popolo la lista
      for (int i = 0; i < lunghezzaLista; i++)
      {
         numeri.Add(randm.Next(0,101));
      }

      //Mando in stampa la lista e aggiungo i valori pari ad una lista parallela
      Console.WriteLine($"Lista numeri: \n");
      
      foreach (int num in numeri)
      {
         Console.Write($"{num} ");

         if (num % 2 == 0)
         {
            pari.Add(num);
         }
      }

      //Ricerca all'interno della lista per cercare corrispondenze
      Console.WriteLine($"Cerca un numero:");
      int ricerca= int.Parse(Console.ReadLine());

      if (numeri.Contains(ricerca))
      {
         Console.WriteLine($"Il numero {ricerca} è presente nella lista in posizione {numeri.IndexOf(ricerca)}");
         
      }
      else
      {
         Console.WriteLine($"Numero non trovato nella lista..");  
      }

      //Manda in stampa la lista dei numeri pari
      Console.WriteLine($"Numeri pari:\n");
      
      foreach (int num in pari)
      {
         Console.WriteLine($"{num} ");
         
      }
   }

   //Terzo
   public static void ListaQuintici()
   {
      Random randm = new Random();

      List<int> numeri= new List<int>();
      List<int> listaTemp= new List<int>();

      int lunghezzaLista=15;


      //Popolo la lista con valori random
      for (int i = 0; i < lunghezzaLista; i++)
      {
         numeri.Add(randm.Next(1,21));
      }
      
      //Mando in stampa la lista 
      Console.WriteLine($"Lista:");
      
      foreach (int num in numeri)
      {
         Console.Write($"{num} ");
      }

      //aggiungo i valori non duplicati all'interno della lista temporanea
      foreach (int num in numeri)
      {
         if(!listaTemp.Contains(num))
         {
            listaTemp.Add(num);
         }         
      }

      //Ordino la lista aggiornata e la mando in stampa
      Console.WriteLine($"\n\nLista aggiornata:");
      listaTemp.Sort();

      foreach (int num in listaTemp)
      {
         Console.Write($"{num} ");
      }
   }
   
   public static void Main(string[] args)
   {
      ListaQuintici();
      //ListaCasuale();
      //InserisciElementiLista();
   }
}
