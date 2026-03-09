public sealed class RegistroVeicoli
{
   private static RegistroVeicoli _istanza;
   public static RegistroVeicoli istanza
   {
      get
      {
         if(_istanza == null)
         {
            _istanza = new RegistroVeicoli();
         }

         return _istanza;
      }
   }
   private List<IVeicolo> veicoliCreati;

   private RegistroVeicoli()
   {
      veicoliCreati = new List<IVeicolo>();
   }

   public void RegistraNuovo(IVeicolo veicolo)
   {
      veicoliCreati.Add(veicolo);
   }

   public void StampaTutti()
   {
      Console.WriteLine($"Nel registro sono presenti {veicoliCreati.Count()} elementi");
      
      foreach (var item in veicoliCreati)
      {
         item.MostraTipo();

      }
      Console.WriteLine($".");
      

   }

}