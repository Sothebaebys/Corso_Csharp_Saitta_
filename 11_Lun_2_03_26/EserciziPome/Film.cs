using System;

class Film
{
   public string titolo;
   public string regista;
   public int anno;
   public string genere;

   public Film (string titolo, string regista, int anno, string genere)
   {
      this.titolo = titolo;
      this.regista = regista ;
      this.anno = anno ;
      this.genere = genere ;
   }

   public override string ToString()
   {
      return $"Dati film:\n Titolo: {titolo}\n Regista: {regista}\n Anno: {anno}\n Genere: {genere}";
   }
}