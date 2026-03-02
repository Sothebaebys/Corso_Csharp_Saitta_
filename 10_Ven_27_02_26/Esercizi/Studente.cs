public class Studente
{
   public string Nome;
   
   public int Matricola;

   public float MediaVoti;

   public void Info()
   {
      Console.WriteLine($"Lo studente {Nome} con matricola ({Matricola}) ha una media di : {MediaVoti}");
      
   }


}