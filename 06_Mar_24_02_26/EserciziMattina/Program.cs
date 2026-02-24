using System.Numerics;

class EserciziMattina
{
   #region Random
   //Primo Esercizio
   public static void GuessNumber()
   {
      Random random = new Random();

      int numeroRandom = random.Next(11);

      Console.WriteLine("Indovina il numero:");

      int guess = int.Parse(Console.ReadLine());

      if (guess == numeroRandom)
      {
         Console.WriteLine($"Hai beccato il numero!");
         
      }
      else
      {
         Console.WriteLine($"Dispiaceri, era : {numeroRandom}");
         //Console.WriteLine($"Riprova con un nuovo numero...");
         //GuessNumber();
         
      }

   }  

   //Secondo Esercizio
   public static void LancioDadi()
   {
      Random random = new Random();

      Console.WriteLine($"Lancio dadi:");
      
      int dado1 = random.Next(7);
      
      Console.WriteLine($"Il primo dado è un: {dado1}");

      int dado2 = random.Next(7);
      
      Console.WriteLine($"Il secondo dado è un: {dado2}");

      Console.WriteLine($"La somma tra i valori è di: {dado1+dado2}");

   }

   //Terzo Esercizio
   public static void MeteoPazzo()
   {
      Random random = new Random();

      double somma = 0;
      double media = 0;
      double min = 45;
      double max = -4;

      
      double tempMin = -4;
      double tempMax = 45;

      Console.WriteLine($"Per quanti giorni vuoi generare la previsione delle temperatura?");
      
      int giorni = int.Parse(Console.ReadLine());

      for (int i= 0; i<giorni; i++)
      {
         double numeroRandom = random.NextDouble() * (tempMax-tempMin) + tempMin;
         
         somma += numeroRandom;

         if (numeroRandom > max)
         {
            max = numeroRandom;
         }
         if (numeroRandom < min)
         {
            min = numeroRandom;
         }

         Console.WriteLine($"La temperatura prevista per il giorno {i+1} è di : {numeroRandom}");
         
      }
      
      media = somma/giorni;
      Console.WriteLine($"Per tutta la previsione la temperatura massima prevista è di :\n Massima: {max}°\n Minima: {min}°\n Media: {media}°");
      
   }

   #endregion

   #region Matrici
   //Primo Esercizio
   public static void GeneratoreMatrice()
   {
      int sommaTotale =0;
      
      //int lastInR = 0;
      //int lastInC = 0;

      Console.WriteLine($"Creiamo una matrice, quante righe?: ");
      int nRighe = int.Parse(Console.ReadLine());

      int[] sommaRighe = new int [nRighe];

      Console.WriteLine($"Quante colonne?: ");
      int nColonne = int.Parse(Console.ReadLine());

      int[] sommaColonne = new int [nColonne];

      int[,] matrics= new int[nRighe,nColonne];

      for (int i=0; i< nRighe; i++)
      {
         for (int j=0; i<nColonne; j++)
         {
            sommaTotale += matrics[i,j];
            sommaColonne[j] += matrics[i,j]; 
            sommaRighe[i] += matrics[i,j];
            /*
            if (i != lastInR)
            {
               lastInR += 1;
            }
            else
            {
               sommaRighe[lastInR] += matrics[i,j];
            }
            */
            
         }
      }

      Console.WriteLine($"Somma totale dei valori: {sommaTotale}.");

      foreach (int num in sommaRighe)
      {
         Console.WriteLine($"la somma della riga è:\n           {num}");
      }
      foreach (int num in sommaColonne)
      {
         Console.WriteLine($"La somma della colonna è:\n        {num}");
      }

   }

   //Secondo Esercizio
   public static void QuattroPerQuattro()
   {
      Random random = new Random();

      int count1 = 0;
      int count2 = 0;

      int[,] matrice1 = new int[4,4];
      int[,] matrice2 = new int[4,4];
      int indice = 0;

      int[] sommaMatr1 = new int[matrice1.GetLength(0)];
      int[] sommaMatr2 = new int[matrice2.GetLength(0)];

      Console.WriteLine($"Prima matrice:");
      for (int i=0; i< matrice1.GetLength(1); i++)
      {
         for (int j=0; j<matrice1.GetLength(0); j++)
         {
            matrice1[i,j]= random.Next(1,51);

            sommaMatr1[i] += matrice1[i,j];

            if( i!= indice)
            {
               indice ++;
               Console.WriteLine();
            }
            Console.Write($"{matrice1[i,j]} ");
            
         }
         Console.WriteLine($"       - La somma di questa riga è di : {sommaMatr1[i]}");
      }


      indice = 0;
      Console.WriteLine("\n");

      Console.WriteLine($"Seconda matrice:");
      for (int i=0; i< matrice2.GetLength(1); i++)
      {
         for (int j=0; j<matrice2.GetLength(0); j++)
         {
            matrice2[i,j]= random.Next(1,51);

            sommaMatr2[j] += matrice2[i,j];
            
            if( i!= indice)
            {
               indice ++;
               Console.WriteLine();
               
            }
            Console.Write($"{matrice2[i,j]} ");
         }
         Console.WriteLine($"       - La somma di questa riga è di : {sommaMatr2[i]}");
      }   

      for (int i=0 ; i < sommaMatr1.Length; i++)
      {
         if (sommaMatr1[i]>sommaMatr2[i])
         {
            Console.WriteLine($"La prima matrice ha un valore maggiore nel confronto con la riga {i+1}.");
            count1 ++;
         }
         else if (sommaMatr1[i]<sommaMatr2[i])
         {
            Console.WriteLine($"La seconda matrice ha un valore maggiore nel confronto con la riga {i+1}.");
            count2 ++;
         }
         else
         {
            Console.WriteLine($"Pareggio nella riga {i+1}");
            
         }
      }

      Console.WriteLine($"La matrice 1 ha dei valori assoluti maggiori per riga in {count1} casi\n La matrice 2 in {count2}");
      
      if (count1 > count2)
      {
         Console.WriteLine($"La matrice 1 ha dei valori assoluti maggiori per riga");
      }
      else
      {
         Console.WriteLine($"La matrice 1 ha dei valori assoluti maggiori per riga");
      }

   }

   //Terzo Esercizio
   public static void Diagonali()
   {
      int[,] matrice = new int[5,5];
      int indice = 0;

      int diagonale = 0;
      int diagonaleInv = 0;

      Random random = new Random();

      Console.WriteLine($"Matrice 5x5:");
      for (int i=0; i< matrice.GetLength(1); i++)
      {
         for (int j=0; j<matrice.GetLength(0); j++)
         {
            matrice[i,j]= random.Next(1,21);

            if( i!= indice)
            {
               indice ++;
               Console.WriteLine();
            }
            Console.Write($"{matrice[i,j]} ");
            
         }
      }
      
      for (int i=0; i< matrice.GetLength(1); i++)
      {
         for (int j=0; j<matrice.GetLength(0); j++)
         {
            if (j==i)
            {
               diagonale += matrice[i,j];
            }
            if (i + j == 4)
            {
               diagonaleInv += matrice[i,j];
            }
         }
      }
      Console.WriteLine($"\n\nLa somma della prima diagonale è uguale a: {diagonale}\nLa somma della seconda è uguale a: {diagonaleInv}");
      

   }

   #endregion
   public static void Main(string[] args)
   {
      //QuattroPerQuattro();
      //Diagonali();
   }
}