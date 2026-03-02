class Cane
{
   //Proprietà o stato
   public string? nome;
   public int eta;

   //MEtodi (Comportamento)
   public void Abbaia()
   {
      Console.WriteLine($"Il cane {nome} sta abbaiando");
      
   }

   public void Descrivi()
   {
      Console.WriteLine($"Il cane di nome {nome} ha {eta} anni.");
      
   }
}
