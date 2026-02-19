using System;

class EserciziPomeriggio
{
   const int NUMERO_GUESS = 35;
   const int PASSWORD = 123456;
   const float PI_GRECO = 3.1415f;
   
   //Da un numero in input manda in stampa se il numero è pari o dispari
   public static void PariDispari()
   {
      Console.Write("Inserisci un numero intero: ");
      int numero = int.Parse(Console.ReadLine());

      if (numero % 2 == 0)
      {
         Console.WriteLine("Il numero è pari");
      }
      else
      {
         Console.WriteLine("Il numero è dispari");
      }
   }

   //Dato un valore in input manda in stampa se la scelta corrisponde alla costante PASSWORD
   public static void Password()
   {
      Console.Write("Inserisci la password: ");
      int pass = int.Parse(Console.ReadLine());
      if (pass == PASSWORD)
      {
         Console.WriteLine("Accesso consentito.");
      }
      else
      {
         Console.WriteLine("Accesso negato.");
      }
   }

   //Dati due valori in input e la tipologia di operazione esegue addizioni o sottrazioni
   public static void Calcolatrice()
   {
      Console.Write("Inserisci un numero: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.Write("Inserisci un secondo numero: ");
      double num2 = double.Parse(Console.ReadLine());

      Console.Write("Inserisci l'operatore(+ o -): ");
      string operatore = Console.ReadLine();

      if (operatore == "+")
      {
         Console.WriteLine($"la somma dei numeri è: {num1 + num2}");
      }
      if (operatore == "-")
      {
         Console.WriteLine($"la sottrazione dei numeri è: {num1 - num2} ");
      }
   }

   //Dato un valore in input manda in stampa la qualità del voto in 10mi
   public static void Valutazione()
   {
      Console.Write("Inserisci il voto di riferimento: ");
      int voto = int.Parse(Console.ReadLine());
   
      if (voto >=9 )
      {
         Console.WriteLine("Ottimo!");
      }
      else if (voto >= 7 )
      {
         Console.WriteLine("buono");
      }
      else if (voto >= 5 )
      {
         Console.WriteLine("sufficiente");
      }
      else
      {
         Console.WriteLine("insufficiente..");
      }
   }

   //Dati due valori in input calcola la massa grassa e mostra la categoria corrispondente
   public static void CalcoloBMI()
   {
      Console.Write("Inserisci il peso: ");
      int peso = int.Parse(Console.ReadLine());

      Console.Write("Inserisci l'altezza: ");
      float altezza = float.Parse(Console.ReadLine());

      float bmi = peso / (altezza * altezza) ;

      if (bmi >= 30)
      {
         Console.WriteLine("Obeso");
      }
      else if (bmi < 30 && bmi >= 25 )
      {
         Console.WriteLine("Sovrappeso");
      }
      else if (bmi >= 18.5f && bmi < 25)
      {
         Console.WriteLine("Normopeso");
      }
      else
      {
         Console.WriteLine("Sottopeso");
      }
   }

   //Data la temperatura in gradi celsius converte il valore in Fahrenheit, Kelvin o Rankine
   public static void Termometro()
   {
      Console.Write("Inserisci la temperatura in gradi celsius: ");
      float temperatura = float.Parse(Console.ReadLine());

      Console.WriteLine("Inserisci la tipologia di conversione (tra: Fahrenheit, Kelvin, Rankine ): ");
      string temp = Console.ReadLine();

      if (temp == "Fahrenheit")
      {
         Console.WriteLine($"La conversione in Fahrenheit è: { (temperatura *0.8f)+ 32} ");
      }
      else if ( temp == "Kelvin")
      {
         Console.WriteLine($"La conversione in Kelvin è: { temperatura + 273.15f} ");
      }
      else if ( temp == "Rankine")
      {
         Console.WriteLine($"La conversione in Rankine è: { (temperatura * 1.8) + 491.67f} ");
      }
      else
      {
         Console.WriteLine("Formato non corretto.");
      }
   }
   
   public static void Settimana()
   {
      Console.WriteLine("Inserisci un numero da 1 a 7");
      string giorno = Console.ReadLine();

      switch (giorno)
      {
         case "1":
            Console.WriteLine("lunedì");
            break;
         case "2":
            Console.WriteLine("martedì");
            break;
         case "3":
            Console.WriteLine("mercoledì");
            break;
         case "4":
            Console.WriteLine("giovedì");
            break;
         case "5":
            Console.WriteLine("venerdì");
            break;
         case "6":
            Console.WriteLine("sabato");
            break;
         case "7":
            Console.WriteLine("domenica");
            break;
         default:
            Console.WriteLine("Un giorno come un altro.");
            break;
      }

   }
   
   public static void FiguraGeometrica()
   {
      Console.Write("Scegli una tra le seguenti figure geometriche (triangolo, quadrato, cerchio): ");
      string figura = Console.ReadLine();

      switch (figura)
      {
         case "triangolo":
            Console.Write("Inserisci la dimensione della base:");
            float baseT = float.Parse(Console.ReadLine()); 
            Console.Write("Inserisci l'altezza del triangolo:");
            float altezzaT = float.Parse(Console.ReadLine());
            Console.WriteLine($"L'area del tuo triangolo è: {(baseT* altezzaT)/2}");
            break;
         case "quadrato":
            Console.Write("Inserisci la dimensione del lato");
            float lato = float.Parse(Console.ReadLine()); 
            Console.WriteLine($"L'area del quadrato è: {lato * lato}");
            break;
         case "cerchio":
            Console.Write("Inserisci il raggio del cerchio");
            float raggio = float.Parse(Console.ReadLine()); 
            Console.WriteLine($"L'area del tuo cerchio è: {PI_GRECO * (raggio * raggio)}");
            break;
         default:
            Console.WriteLine("Niente calcoli per oggi..");
            break;
      }
   }

   public static void SwitchExtra ()
   {
      Console.WriteLine("Inserisci un numero da 1 a 3");
      string numero = Console.ReadLine();
      
      Console.WriteLine("Inserisci un numero da 0 a 30");
      int numero2 = int.Parse(Console.ReadLine());

      switch (numero)
      {
         case "1":
            if (numero2 >= 15)
            {
               Console.WriteLine("Non so.");
            }
            else if (numero2 == 3) {
               Console.WriteLine("hai beccato il glitch");
            }
            else 
            {
               Console.WriteLine("Non so, ma più basso.");
            }
            break;
         case "2":
            if (numero2 >= 15)
            {
               Console.WriteLine("Non so.");
            }
            else if (numero2 !=4 || numero2== 29)
            {
               Console.WriteLine("Sei nel matrix Neo.");
            }
            else 
            {
               Console.WriteLine("Non so, ma più basso.");
            }
            break;
         case "3":
            if (numero2 >= 15)
            {
               Console.WriteLine("Non so.");
            }
            else if (numero2 <14 && numero2 != 0)
            {
               Console.WriteLine("Che strana combinazione");
            }
            else 
            {
               Console.WriteLine("Non so, ma più basso.");
            }
            break;
         default:
            Console.WriteLine("Enniente.");
            break;
      }
   }

   public static void CicloNumPositivi()
   {
      int valore = 0;
      bool continua = true;

      while(continua) {
         Console.Write("Inserisci un numero: ");
         int numero = int.Parse(Console.ReadLine());

         if (numero >= 0)
         {
            valore += numero;
         }
         else
         {
            continua = false;
         }

      }
   }
   
   public static void CicloIndovinaNumero()
   {
      bool isRun = true;
      Console.WriteLine("Dovrai indovinare un numero");


      while (isRun)
      {
         Console.Write("Inserisci un numero: ");
         int numero = int.Parse(Console.ReadLine());
         
         if (numero == NUMERO_GUESS)
         {
            Console.WriteLine("C'hai preso!");
            isRun = false;
         }
         else if(numero < NUMERO_GUESS)
         {
            Console.WriteLine("Troppo basso..");
         }
         else if(numero > NUMERO_GUESS)
         {
            Console.WriteLine("Troppo alto..");
         }
         else
         {
            Console.WriteLine("Riprova...");
         }
      }
   }
   static void Main(string[] args)
   {
      Console.WriteLine("Controllo un numero pari\n ");
      PariDispari();

      Console.WriteLine("Controllo della password\n ");
      Password();

      Console.WriteLine("Operazione di calcolo\n");
      Calcolatrice();

      Console.WriteLine("Operazione di calcolo della valutazione\n");
      Valutazione();
      
      Console.WriteLine("Operazione di calcolo BMI\n");
      CalcoloBMI();

      Console.WriteLine("Operazione di calcolo temperatura\n");
      Termometro();

      Console.WriteLine("Calcolo del giorno della settimana\n");
      Settimana();

      Console.WriteLine("Calcolo dell'area di alcune forme geometriche");
      FiguraGeometrica();

      Console.WriteLine("Switch su due numeri con degli if");
      SwitchExtra();

      Console.WriteLine("Ciclo su numeri positivi con somma dei passati.");
      CicloNumPositivi();

      Console.WriteLine("Ciclo per indovinare un numero.");
      CicloIndovinaNumero();

   }

}
