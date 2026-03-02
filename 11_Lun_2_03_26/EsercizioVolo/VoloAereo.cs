class CompagniaAerea
{
   public string codiceVolo;

   public CompagniaAerea(string codice)
   {
      this.codiceVolo = codice;
   }
}

class VoloAereo: CompagniaAerea
{
   private int _postiOccupati = 0;
   private int _postiLiberi = 142;
   const int MAX_POSTI = 142;
   
   public VoloAereo(string codiceVolo): base(codiceVolo)
   {
      
   }
   public override void CodiceVolo()
   {
      
   }

   public void EffettuaPrenotazione(int numero)
   {
      if(numero + _postiOccupati <= MAX_POSTI)
      {
         _postiOccupati += numero;
         _postiLiberi -= numero;
      }
      else
      {
         Console.WriteLine($"Impossibile prenotare, numero max raggiunto");
      }
      VisualizzaStato();
   }
   public void AnnullaPrenotazione(int numero)
   {
      if (numero + _postiLiberi >= 0)
      {
         _postiLiberi += numero;
         _postiOccupati -= numero;
      }
      else
      {
         Console.WriteLine($"Impossibile cancellare la prenotazione..");
      }
      VisualizzaStato();
   }

   public void VisualizzaStato()
   {
      Console.WriteLine($"Codice volo: {codiceVolo} | Posti occupati : {_postiOccupati} | posti liberi: {_postiLiberi}");
   }



}