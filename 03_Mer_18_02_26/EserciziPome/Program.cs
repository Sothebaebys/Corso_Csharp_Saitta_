using System;
using System.Diagnostics.Metrics;

class EserciziPome
{
   //Esercizio sugli Array
   public static void SceltaLista()
   {
      //int[] listaNum;
      //string[] listaStr;

      Console.WriteLine("Vuoi creare un'array numerico (int) o letterale (str) ?:");
      string scelta =Console.ReadLine();
      Console.WriteLine("Quanti elementi vuoi che ci siano dentro ? :");
      int lunghezza = int.Parse(Console.ReadLine());

      if (scelta == "int")
      {
         if (lunghezza > 0)
         {
            int[] listaNum = new int[lunghezza];

            for(int i = 0; i<(lunghezza - 1); i++)
            {  
               Console.WriteLine("Scrivi il valore dell'elemento:");
               int itemN = int.Parse(Console.ReadLine());

               listaNum[i]= itemN;

            foreach (int num in listaNum)
            {
               Console.WriteLine(num);
            }
            
            }
         }
         else
         {
            Console.WriteLine("Scelta non valida.\n");
            SceltaLista();
         }
      }
      else if (scelta == "str")
      {
         if (lunghezza > 0)
         {
            string[] listaStr = new string[lunghezza];

            for(int j = 0; j< (lunghezza - 1); j++)
            {
               Console.WriteLine("Scrivi il valore dell'elemento:");
               string itemS = Console.ReadLine();
               listaStr[j] = itemS;
            }
            foreach (string parola in listaStr)
            {
               Console.WriteLine(parola);
            }
         }
         else
         {
            Console.WriteLine("Scelta non valida.\n");
            SceltaLista();
         }
      }

      Console.WriteLine("Vuoi ripetere ? (Y/N)");
      string ripeti =Console.ReadLine();
      
      if(ripeti =="Y" || ripeti == "y")
      {
         SceltaLista();
      }
      
   }

   //Esercizio 1 dei foreach
   public static void ContaNumeri()
   {
      int counter = 0;
      Console.WriteLine("Dimmi qualcosa, conterò i numeri presenti:");
      string frase = Console.ReadLine();

      foreach (char letter in frase)
      {
         if (char.IsDigit(letter))
         {
            counter += 1;
         }

      }

      Console.WriteLine($"All'interno della frase ho trovato {counter} caratteri numerici");

   }

   //Esercizio 2 dei foreach
   public static void TolgoSpazi()
   {
      Console.WriteLine("Dimmi qualcosa, rimuoverò gli spazi presenti:");
      string frase = Console.ReadLine();
      Console.WriteLine($"{frase.Trim()}");

   }

   //Esercizio 3 dei foreach
   public static void ContoVocali()
   {
      int counter = 0;
      string vocali = "aeiou";
      Console.WriteLine("Dimmi qualcosa, conterò le vocali presenti:");
      string frase = Console.ReadLine();
      frase.ToLower();
      
      for (int i = 0; i < frase.Length; i++)
      {
            for (int j = 0; j< vocali.Length; j++)
            {
               if ( frase[i] == vocali[j])
            {
               counter ++;
            }
            }
      }
      Console.WriteLine($"Totale di {counter} vocali");
      /*    if (frase[i].Contains())
      // }
      // foreach (char vocale in vocali)
      // {

      // }
      // {
      //    if (letter.Contains)
      */
   }

   //Esercizio 4 dei foreach
   public static void CheckPassword()
   {  
      bool isValid = false;
      //bool isNumero = false;
      //bool isConSpazi = false;
      Console.WriteLine("Inserisci una password che sia più lunga di 8 caratteri, che contenga almeno una maiuscola, una cifra numerica e che non inizi o finisca con uno spazio");
      string passw = Console.ReadLine();

      if (passw.Length >= 8)
      {
         if (!(passw.StartsWith(" ")|| passw.EndsWith(" ")))
         {
            foreach (char carattere in passw)
         {
            if (char.IsDigit(carattere)|| char.IsUpper(carattere))
               {
                  isValid = true;
               }
         }
      }
      if (isValid)
         {
            Console.WriteLine("Password valida!");
         }
         else
         {
            Console.WriteLine("Password non valida.\nRitenta..");
            CheckPassword();
         }
   }
   }

   //Esercizio 5 dei foreach
   public static void ContatoreVariegato()
   {
      int counterPunteggiatura= 0;
      int counterLettere = 0;
      int counterSpazi = 0;
      int numeroParole = 0;
      Console.WriteLine("Dimmi qualcosa, conterò un pò di elementi:");
      string frase = Console.ReadLine();
      string[] array = frase.Split(" ");
      numeroParole = array.Length;

      foreach (char crt in frase)
      {
         if (char.IsLetter(crt))
         {
            counterLettere ++;
         }
         else if (char.IsWhiteSpace(crt))
         {
            counterSpazi ++;
         }
         else if (char.IsPunctuation(crt))
         {
            counterPunteggiatura ++;
         }
      }
      Console.WriteLine($"All'interno della tua frase dovrebbero esserci:\n - Un totale di {numeroParole} parole.\n - {counterLettere} lettere.\n - {counterSpazi} spazi vuoti.\n - e {counterPunteggiatura} segni di punteggiatura");
   }
   
   static void Main(string[] args)
   {
      
      Console.WriteLine("Analisi di una stringa e conteggio di: numero parole,caratteri alfabetici, numero di spazi e segni di punteggiatura.");
      ContatoreVariegato();

      Console.WriteLine("Analisi di una stringa per vedere se è idonea per una password:\nlungheza minima, almeno una maiusola,no spazi all'inizio, almeno un numero.");
      CheckPassword();
      
      Console.WriteLine("Conteggio di vocali all'interno di una stringa");
      ContoVocali();

      Console.WriteLine("Analisi di una stringa per la rimozione degli spazi:");
      TolgoSpazi();

      Console.WriteLine("Creazione e popolamento di un array");
      SceltaLista();

      Console.WriteLine("Analisi di una stringa per il conteggio dei caratteri numerici:");
      ContaNumeri();
   }
}