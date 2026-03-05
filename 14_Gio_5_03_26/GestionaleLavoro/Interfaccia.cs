public interface IBadge
{
   private int _id;

   private DateTime _dataInizio;
   private DateTime _dataFine;

   public bool Ingresso();
   public bool Uscita();

}