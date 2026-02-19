using System;
using System.Diagnostics.Metrics;

class Esercizi
{
   
   public static void Bancomatto(float saldo=0)
   {
      bool isAttivo = true;
      //float saldo = 0;
      string testoIniziale = "\nSeleziona un'operazione tra le seguenti:\n\n - Premi 1 per visualizzare il saldo\n - Premi 2 per depositare. \n - Premi 3 per prelevare \n - Premi 4 per uscire \n";
      //string scelta;

      Console.WriteLine(testoIniziale);
      Console.Write(":");
      string scelta = Console.ReadLine();

      while(isAttivo)

         switch (scelta)
         {
            case "1":
               Console.WriteLine($"Il tuo saldo è pari a: {saldo}");
               Bancomatto(saldo);
               break;
            case "2":
               Console.WriteLine("Seleziona l'importo da depositare:");
               float deposito = float.Parse(Console.ReadLine());
               if (deposito > 0)
               {
               saldo += deposito;
               Console.WriteLine($"Depositato con successo\nSaldo aggiornato a: {saldo}");
               
               }
               Bancomatto(saldo);
               break;
            case "3":
               Console.Write("Seleziona l'importo da prelevare:");
               float prelievo = float.Parse(Console.ReadLine());
               if (prelievo > saldo)
               {
               Console.WriteLine("Saldo insufficente..");
               }
               else
               {
               prelievo -= saldo;
               Console.WriteLine($"Hai prelevato {prelievo}.\nSaldo aggiornato a: {saldo}");
               }
               Bancomatto(saldo);
               break;
            case "4":
               Console.Write("Sei Sicuro ? \n (Y/N)");
               string esci = Console.ReadLine(); 

               if (esci == "y" || esci == "Y")
               {
               isAttivo = false;
               Console.Write("Alla prossima!");
               }
               break;
            default:
               Console.WriteLine("Scelta non valida..\nRiprova:");
               Bancomatto(saldo);
               break;
         }
      

   }
   
   public static void Password()
   {
      int counter = 0;
      const string PASSWORD = "123456";

      do
      {
         Console.WriteLine("Inserisci la password:");
         string tentativo = Console.ReadLine();
         if (tentativo == PASSWORD)
         {
            Console.WriteLine("Ottimo lavoro, accesso garantito.");
         }
         else
         {
            counter ++;
         }
      }
      while( counter <3);
   }
   
   public static void GiocoNum()
   {
      int scelta;
      int totale = 0;
      int occorrenze = 0;

      do
      {
         Console.WriteLine("Inserisci un numero intero:");
         scelta = int.Parse(Console.ReadLine());
         totale += scelta;
         occorrenze ++;
      } while (scelta!= 0);

      Console.WriteLine($"Esecuzione terminata\nIl totale delle scelte attive è stato di :{totale}\n Hai effettuato {occorrenze-1} scelte");
   }
   
   public static void Calcolatrice()
   {
      bool isAcceso = true;
      Console.WriteLine("Seleziona il tipo di operazione:");
      string operazione= Console.ReadLine();
      Console.WriteLine("Inserisci un numero");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Inserisci un numero");
      int num2 = int.Parse(Console.ReadLine());

      do
      {
         switch (operazione)
         {
            case "+":
               Console.WriteLine($" La somma dei numeri ({num1} + {num2}) è: {num1 + num2}");
               isAcceso=Continua();
               break;
            case "-":
               Console.WriteLine($" La sottrazione dei numeri ({num1} - {num2}) è: {num1 - num2}");
               isAcceso=Continua();
               break;
            case "*":
               Console.WriteLine($" La moltiplicazione dei numeri ({num1}  {num2}) è: {num1 * num2}");
               isAcceso=Continua();
               break;
            case "/":
               Console.WriteLine($" La divisione dei numeri ({num1} + {num2}) è: {num1 / num2}");
               isAcceso=Continua();
               break;
            default:
               isAcceso=Continua();
               break;
         }
      } while (isAcceso);


   }

   public static bool Continua()
   {
      Console.WriteLine("Vuoi continuare? (Y/N):");
      string continua = Console.ReadLine();

      if (continua == "Y" || continua == "y")
      {
         return true;
      }
      else
      {
         return false;
      }
   }

   public static void Tabellina()
   {
      Console.WriteLine("Seleziona un numero:");
      int numero = int.Parse(Console.ReadLine());

      for(int i = 1; i<= 10; i++)
      {
         Console.WriteLine($" {numero} x {i} = {numero * i}");
      }
   }

   public static void Media()
   {
      Console.WriteLine("Su quanti numeri vuoi calcolare la media?\n Seleziona un numero:");
      int numeriMedia = int.Parse(Console.ReadLine());
      int somma = 0;

      for (int i = 1; i<= numeriMedia; i++)
      {
         Console.WriteLine("Inserisci il numero:");
         int numeroInput = int.Parse(Console.ReadLine());
         somma += numeroInput;
      }
      Console.WriteLine($"La media dei numeri è: {somma/numeriMedia}");  
   }

   public static void Fattoriale()
   {
      Console.WriteLine("Seleziona un numero per il fattoriale:");
      int numeroFattoriale = int.Parse(Console.ReadLine());
      if (numeroFattoriale > 0)
      {
         int totale = 0;

         for (int i = 1; i <= numeroFattoriale; i++)
         //for (int i = 0; i < numeroFattoriale; i++)
         {
            totale += numeroFattoriale * numeroFattoriale;
            //totale += numeroFattoriale * (numeroFattoriale - i);
         }
         Console.WriteLine($"Il fattore di {numeroFattoriale} è: {totale}");
      }
      else
      {
         Console.WriteLine("Numeri negativi non consentiti.\n Riprova.");
         Fattoriale();
      }
   }

   static void Main(string[] args)
   {

      //Esercizio media
      Console.WriteLine("Settimo esercizio su fattori di numeri:");
      Fattoriale();


      //Esercizio media
      Console.WriteLine("Sesto esercizio sulla media di n numeri:");
      Media();

      //Esercizio Tabellina
      Console.WriteLine("Quinto esercizio sulla stampa di una tabellina:");
      Tabellina();

      // Esercizio bancomat
      Console.WriteLine("Primo esercizio sulla simulazione di un bancomat:");
      Bancomatto();
      
      //Esercizio calcolatrice
      Console.WriteLine("Secondo esercizio sulla simulazione di una Calcolatrice:");
      Calcolatrice();

      //ESERCIZIO PASSWORD
      Console.WriteLine("terzo esercizio sulla simulazione di un counter di password:");
      Password();

      //Esercizio Gioco numerico
      Console.WriteLine("Quarto esercizio sulla simulazione di un gioco numerico:");
      GiocoNum();


   }
   
}
