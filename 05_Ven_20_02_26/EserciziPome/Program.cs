//using System;

class Esercizi
{

   //Primo esercizio
   public static void Raddoppia(ref int valore)
   {
      Console.WriteLine($"Valore originario: {valore}");
      Console.WriteLine($"Valore raddoppiato: {valore *= 2 }");
   }

   //Secondo esercizio
   public static void AggiustaData(ref int giorno, ref int mese, ref int anno)
   {
      if (giorno > 30)
      {
         mese ++;
         giorno = giorno - 30;
      }
      else if (mese > 12)
      {
         anno++;
         mese = mese - 12;
         
      }
   }
   
   //Terzo esercizio
   public static void Dividi(int num1,int num2, out float resto, out float quoziente)
   {
      quoziente = num1 / num2;
      resto = num1 % num2;
   }

   //Quarto esercizio
   public static void AnalizzaParola(string frase, out int vocali, out int consonanti, out int spazi)
   {  
      spazi = 0;
      consonanti=0;
      vocali = 0;

      foreach (char letter in frase)
      {
         if (char.IsWhiteSpace(letter))
         {
            spazi += 1;
         }
      }
      string vocale = "AEIOU";

      frase.Trim();

      for (int i = 0; i < frase.ToUpper().Length; i++)
      {
            for (int j = 0; j< vocale.Length; j++)
            {
               if ( frase[i] == vocale[j])
               {
                  vocali ++;
               }
               else
               {
                  consonanti++;
               }
            }
      }
   }
   
   //Quinto esercizio
   public static void AggiornaPunteggio (ref int counter,ref int punteggioCorrente, int bonus,out int punteggioTotale, out float media)
   {
      punteggioTotale = punteggioCorrente + bonus;
      media =punteggioTotale/counter;
      counter++;

      if (counter == 3)
      {
         Console.WriteLine($"La media è {media}") ;
      }
   }

   //Sesto esercizio
   public static bool ElaboraStudente(ref int voto1,ref int voto2, int bonus)
   {
      bool promosso= false;
      int totaleVoti = voto1+voto2+(bonus*2);
      int media;

      if (totaleVoti > 20)
      {
         media = 20/2;
      }
      else
      {
         media= totaleVoti/2;
      }

      if (media >= 6)
      {
         promosso =true;
      }
      
      return promosso;
   }

   //Settimo esercizio
   public static int AnalizzaSerieDiNumeri(int numA, int numB, int numC, out int min,out int max)
   {
      min= 0;
      max=0;

      if (numA <= numB && numA <= numC)
      {
         min = numA;
      }
      else if (numB <= numA && numB <= numC) {
         min = numB;
      }
      else
      {
         min = numC;
      }
      
      if (numA >= numB && numA >= numC)
      {
         max = numA;
      }
      else if (numB >= numA && numB >= numC) {
         max = numB;
      }
      else
      {
         max = numC;
      } 
      
      Console.WriteLine($"Il valore minimo è: {min}.\n Il massimo: {max}");
      return (numA+numB+numC)/3;
   }
   
   //Ottavo esercizio
   public static int CalcoloBonus(int voto)
   {
      int indiceBonus = voto/10;
      for (int i=0;i<indiceBonus; i++)
      {
         voto++;
      }
      if (voto > 30)
      {
         voto =30;
      }
      return voto;
   }
   public static bool AggiornaVoti(int votoInserito,ref int conta, ref int somma, ref int min, ref int max, ref int media)
   {  
      conta ++;

      if (votoInserito > 0)
      {
         if (votoInserito > 30)
         {
            while (votoInserito> 30)
            {
               votoInserito /= 10;
            }  
         }
         votoInserito=CalcoloBonus(votoInserito);
         somma += votoInserito;
         
         if (votoInserito < min)
         {
            min = votoInserito;
         }
         if (votoInserito>max)
         {
            max = votoInserito;
         }
         media = somma / conta;
         return true;
      }
      return false;
   }


   static void Main(string[] args)
   {

      #region Ottavo

      int conta =0;
      int somma= 0;
      int minVoto = 30;
      int maxVoto = 0;
      int mediaVoto = 0;
      int[] voti= [18,27,30,88];

      for(int i =0; i<voti.Length;i++)
         AggiornaVoti(voti[i],ref conta,ref somma, ref minVoto,ref maxVoto, ref mediaVoto);
         Console.WriteLine($"Numero voti: {conta}, voto min:{minVoto}, voto max: { maxVoto}, media {mediaVoto}");
      Console.WriteLine();

      #endregion
      
      #region Settimo

      int[] numeri = [2,4,7];
      int nuMin;
      int nuMax;

      AnalizzaSerieDiNumeri(numeri[0],numeri[1],numeri[2],out nuMin,out nuMax);
      
      #endregion

      #region Sesto

      int[] voto = [6,7];
      int bonus = 2;
      Console.WriteLine();
      Console.WriteLine($"Promosso?\n           '{ElaboraStudente(ref voto[0],ref voto[1],bonus)}'");

      #endregion

      #region Quinto
      int counter =1;
      int[] punti =[7,3,2];
      int puntiTot=0;
      float media;

      for( int i = 0; i < 3; i++)
      {
         AggiornaPunteggio(ref counter,ref punti[i], 5,out puntiTot,out media);
      }
      #endregion

      #region Quarto
      int vocali;
      int consonanti;
      int spazi;
      AnalizzaParola("Ambarabaciccicocò", out vocali, out consonanti, out spazi);
      #endregion

      #region Terzo
      float resto;
      float quoziente;
      int num = 7 ;
      int num1 = 2;
      Dividi(num,num1,out resto, out quoziente);
      Console.WriteLine($"{num}/{num1} = {quoziente}\n Resto: {resto} ");
      Console.WriteLine();
      #endregion

      #region Primo
      int valore = 2;
      Raddoppia(ref valore);
      #endregion

      #region Secondo

      int giorno = 15;
      int mese = 13;
      int anno = 1680;
      Console.WriteLine();
      
      Console.WriteLine($"Giorno: {giorno}   Mese: {mese}   Anno: {anno}");
      
      AggiustaData(ref giorno,ref mese, ref anno);

      Console.WriteLine($"Giorno: {giorno}   Mese: {mese}   Anno: {anno}");
      
      #endregion

   }
}