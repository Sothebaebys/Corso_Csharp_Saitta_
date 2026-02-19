using System;

class StruttureDati
{
   public static void EsempioArray()
   {
      int[] voti = new int[5];

      for (int i=0;i< voti.Length; i++)
      {
         Console.WriteLine($"Inserisci il voto di {i+1}: ");
         voti[i] = int.Parse(Console.ReadLine());
      }

      int somma= 0;
      for (int i=0; i<voti.Length; i++)
      {
         somma += voti[i];
      }

      float media = (float)somma/ voti.Length;
      Console.WriteLine($"La media dei voti +: {media}");
   }

   public static void CicloForeach()
   {
      string parola ="CiccioCiao";

      Console.WriteLine("Caratteri della stringa:");
      foreach (char lettera in parola)
      {
         Console.WriteLine(lettera);
      }
   }

   public static void CicloForeachNumerico()
   {
      int[] anni = new int[5];
      int x = 1;

      Console.WriteLine("Numeri della lista:");
      foreach (int number in anni)
      {
         Console.WriteLine(number);
         anni[number] = (number + x);
         x++;
         Console.WriteLine(number);
      }
      //Non itera con gli elementi mostrerà sempre l'elemento
      Console.WriteLine(anni);
   }

   public static void ManipolazioneStr()
   {
      char carattere = "A";


      Console.WriteLine(char.IsLetter(carattere));
      Console.WriteLine(char.IsDigit(carattere));
      Console.WriteLine(char.ToLower(carattere));
      Console.WriteLine(carattere);


      Console.WriteLine("Check sui simboli:");
      char simb = "@";
      if (char.IsPunctuation(simb))
      {
         Console.WriteLine($"{simb} è un simbolo");
      }


   }

   static void Main(string[] args)
   {
      CicloForeachNumerico();
   }

}