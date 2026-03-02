using System;

class Libro
{
   public string titolo;
   public string autore;
   public int annoPubblicazione;

   public Libro()
   {
      
   }
   
   public Libro(string titolo, string autore,int annoPubblicazione)
   {
      this.titolo = titolo;
      this.autore = autore;
      this.annoPubblicazione = annoPubblicazione;
   }

   public override string ToString()
   {
      return $"Titolo : '{titolo}'\n di: {autore}\n anno: {annoPubblicazione} ";
   }

   public override bool Equals(object? obj)
   {
      if(obj is Libro lib)
      {
         return this.titolo == lib.titolo && this.autore == lib.autore;
      }
      return false;
   }

/*
   public override bool Equals(object obj)
   {
      if(obj is Libro lib)
      {
         return this.GetHashCode() == lib.GetHashCode();
      }
   }
   */
   public override int GetHashCode()
   {
      return HashCode.Combine(titolo,autore);
   }

}