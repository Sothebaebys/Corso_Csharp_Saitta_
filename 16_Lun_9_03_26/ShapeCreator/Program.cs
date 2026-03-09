class Program
{
         public static void Menu()
   {
      Console.WriteLine($"\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per creare un cerchio.");
      Console.WriteLine($"-2 Per un quadrato.");
      Console.WriteLine($"-3 Per visualizzare tutti i log nella prima istanza..");
      Console.WriteLine($"-4 Per visualizzare tutti i log nella seconda istanza..");
      Console.WriteLine($"-5 Per visualizzare gli hashcode delle istanze.");
      Console.WriteLine($"-0 Per uscire.");
   }
   public static void Main(string[] args)
   {


      bool isRunning = true;
      while (isRunning)
      {
         Menu();
         Console.WriteLine($"Che forma vuoi creare? Scegli tra cerhcio e quadrato");
         string scelta = Console.ReadLine();
         switch (scelta.ToLower())
         {
            case ("cerchio"):
               IShape forma = ShapeCreator.CreateShape("circle");
               forma.Draw();
               break;
            case ("quadrato"):
               IShape forma1 = ShapeCreator.CreateShape("square");
               forma1.Draw();
               break;

            default:
               Console.WriteLine($"Scelta non valida");

               break;
         }

         Console.WriteLine($"Vuoi continuare? Y/N");
         string esci = Console.ReadLine();

         if (esci.ToLower() != "y")
         {
            isRunning= false;
         }

      }
   }
}