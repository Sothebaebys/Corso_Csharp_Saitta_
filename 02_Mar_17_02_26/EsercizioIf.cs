using System;

class EsercizioIF
{
   //Dichiaro delle costanti 
   const int MAGGIORENNE = 18;

   const int SOGLIA_SCONTO = 100;

   const int MEDIA_MINIMA = 60;

   public static void CalcoloEta()
   {
      Console.Write("Quanti anni hai ? ");
      int userEta = int.Parse(Console.ReadLine());

      if (userEta >= MAGGIORENNE)
      {
         Console.WriteLine("Sei maggiorenne!");
      }
      if (userEta < MAGGIORENNE)
      {
         Console.WriteLine("Sei minorenne!");
      }
   }

   public static void ApplicaSconto()
   {
      Console.Write("Quanto costa l'articolo ?? ");
      float prezzo = float.Parse(Console.ReadLine());

      if (prezzo >= SOGLIA_SCONTO)
      {
         float totale = (prezzo * 10) / 100;
         Console.WriteLine($"Hai accesso ad uno sconto del 10%, del valore di: {totale}");
      }
      if (prezzo < SOGLIA_SCONTO)
      {
         Console.WriteLine($"ti mancano {SOGLIA_SCONTO - prezzo} per accedere allo sconto");
      }

   }

   public static void Media()
   {
      Console.Write("Inserisci il primo numero: ");
      float n1 = float.Parse(Console.ReadLine());

      Console.Write("Inserisci il secondo numero: ");
      float n2 = float.Parse(Console.ReadLine());

      Console.Write("Inserisci il terzo numero: ");
      float n3 = float.Parse(Console.ReadLine());

      float media = (n1+n2+n3)/3;

      if (media >= MEDIA_MINIMA)
      {
         Console.WriteLine($"La tua media è di {media}\nHai superato la prova! ");
      }
      
      if (media< MEDIA_MINIMA && media != MEDIA_MINIMA)
      {
         Console.WriteLine($"La tua media è di {media}.\nProva fallita. ");
      }

      /*if (media != MEDIA_MINIMA || media < 0)
      {
         Console.WriteLine("Numeri strani e dove trovarli");
      }
      */


      //media > MEDIA_MINIMA ? Console.WriteLine("Hai superato la prova!"):Console.WriteLine("Prova fallita");
   }

   static void Main(string[] args)
   {
      Console.WriteLine("Calcolo età se maggiorenne:");
      CalcoloEta();

      Console.WriteLine("Calcolo sconto:");
      ApplicaSconto();

      Console.WriteLine("Calcolo della media su tre numeri in input:");
      Media();
   }
}