public interface IBadge
{
   private int _id;
   private string _turno;

   private DateTime _dataInizio;
   private DateTime _dataFine;

   public bool Ingresso();
   public bool Uscita();

}