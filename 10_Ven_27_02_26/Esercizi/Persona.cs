public class Persona
{
   public string Nome;
   public string Cognome;
   public int AnnoDiNascita;

   public Persona()
   {
      
   }
   public Persona(string nome, string cognome, int anno)
   {
      Nome = nome;
      Cognome = cognome;
      AnnoDiNascita = anno;
   }

   //Sovrascrive il metodo ToString
   public override string ToString()
   {
      return $"Nome : {Nome}, cognome: {Cognome}";
   }

   //Sovrascrive il metodo Equals per confrontare le coordinate 
   public override bool Equals(object? obj)
   {
      if (obj is Persona persona)
      {
         return this.Nome == persona.Nome && this.Cognome == persona.Cognome;
      }
      return false;
      
   }

   public void Info()
   {
      Console.WriteLine($"{Cognome} {Nome} è nato nel {AnnoDiNascita}");
   }
}