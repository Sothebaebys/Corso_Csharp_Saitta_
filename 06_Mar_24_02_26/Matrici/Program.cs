
//class Matrici
//{
   
      Console.WriteLine($"----------------------------");
      Console.WriteLine($" M A T R I C I");
      Console.WriteLine($"----------------------------");
//   public static void ModificaMatrice()
//   {
      int[,] matrice = new int[3,3];

      int nRighe = matrice.GetLength(0);
      int nColonne = matrice.GetLength(1);

      for(int i = 0; i<nRighe; i++)
      {
         for (int j=0; j<nColonne; j++)
         {
            matrice[i,j] = (i+j);
            Console.WriteLine($"cella [{i}] [{j}] = {matrice [i,j]}");
            
         }
      }

      Console.WriteLine($"----------------------------");
      Console.WriteLine($"Esplorazione della diagonale:");
      Console.WriteLine($"----------------------------");

      //Esplorazione diagonale
      int sommaDiagonale = 0;

      for( int i= 0; i< nRighe; i++)
      {
         for (int j =0; j <nColonne ; j++)
         {
            if (i == j)
            {
               sommaDiagonale += matrice[i,j];
            }
         }
      }

      Console.WriteLine($"Somma diagonale = {sommaDiagonale}");
      Console.WriteLine();
      
      #region DIAGONALE

      Console.WriteLine($"----------------------------");
      Console.WriteLine($"Esplorazione della diagonale inversa:");
      Console.WriteLine($"----------------------------");

      //Esplorazione diagonale
      int sommaDiagonaleInv = 0;

      for( int i= 0; i< nRighe; i++)
      {
         sommaDiagonaleInv += matrice[i, nColonne - 1 - i];
      }
      #endregion

      Console.WriteLine($"Somma diagonale inversa = {sommaDiagonaleInv}");

      Console.WriteLine($"----------------------------");
      Console.WriteLine($"Popolare la matrice in modo randomico con int:");
      Console.WriteLine($"----------------------------");

      int [,] matriceRandom = new int [10,10];

      //Modulo random
      Random numRandom = new Random();

            for( int i= 0; i< matriceRandom.GetLength(0); i++)
      {
         for (int j =0; j <matriceRandom.GetLength(1) ; j++)
         {
            matriceRandom[i,j] = numRandom.Next(101);
            Console.WriteLine($"matriceRandom cella [{i},{j}] = {matriceRandom[i,j]}");
         }
      }

      Console.WriteLine($"----------------------------");
      Console.WriteLine($"Popolare la matrice in modo randomico con double:");
      Console.WriteLine($"----------------------------");

      double [,] matriceDbl = new double [10,10];
      int numerominimo = 0;
      int numeromassimo = 100;

      //Modulo random
      Random numRandomDbl = new Random();

            for( int i= 0; i< matriceDbl.GetLength(0); i++)
      {
         for (int j =0; j <matriceDbl.GetLength(1) ; j++)
         {
            matriceDbl[i,j] = numRandom.NextDouble() * (numeromassimo - numerominimo)+numerominimo;
            Console.WriteLine($"matriceRandom cella [{i},{j}] = {matriceRandom[i,j]}");
         }
      }
      

      


//   }
//}