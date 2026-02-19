using System;

class Condizioni
{

   public static void CondizioneIf()
   {
      int a = 15;
      int b = 10;

      if (a > b) // Se a è maggiore di b da come risultato true
      {
         Console.WriteLine($"{a} è maggiore di {b}");
      }
   }

   public static void CondizioneConElse()
   {
      int a = 15;
      int b = 10;

      if (a > b) // Se a è maggiore di b da come risultato true
      {
         Console.WriteLine($"{a} è maggiore di {b}");
      }
      else  //Viene eseguito solo se la prima condizione non viene soddisfatta
      {
         Console.WriteLine($"{b} è maggiore di {a}");
      }
   }

   public static void CondizioneElseIf()
   {
      int eta = 30;

      if(eta >= 18)
      {
         Console.WriteLine($"Maggiorenne");
      }
      else if (eta >= 13)
      {
         Console.WriteLine($"Adolescente");   
      }
      else
      {
         Console.WriteLine("Bambino.");
      }
      
   }

   public static void SwitchCase()
   {
      string giorno= "lunedì";

      switch (giorno)
      {
         case "lunedì":
            Console.WriteLine("Inizio settimana");
            break;
         case "venerdì":
            Console.WriteLine("Fine settimana. i'm coming!");
            break;
         default:
            Console.WriteLine("giorno random");
            break;
      }
   }
   static void Main(string[] args)
   {
      Console.WriteLine("Esempio di condizione if:");
      CondizioneIf();

      Console.WriteLine("Esempio di condizione con else:");
      CondizioneConElse();

      Console.WriteLine("Esempio di condizione con elseIF");
      CondizioneElseIf();

      Console.WriteLine("Esempio di switch case");
      SwitchCase();
      
   }

}
