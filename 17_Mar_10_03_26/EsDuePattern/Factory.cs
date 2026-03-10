public abstract class DispositivoFactory
{
   public abstract IDispositivo Factory(string tipo);

   public void CreaDispositivo(string tipo)
   {
      var dispositivo = Factory(tipo);
      dispositivo.Avvia();
   }
}

public class ModuloA : DispositivoFactory
{
   public override IDispositivo Factory(string tipo)
   {
      if (tipo.ToLower() == "computer")
      {
         return new Computer();
      }
      else if (tipo.ToLower() == "stampante")
      {
         return new Stampante();
      }
      else
      {
         Console.WriteLine($"Scelta non valida, ritenta..");
         return null;   
      }
   }
}

public class ModuloB : DispositivoFactory
{
   public override IDispositivo Factory(string tipo)
   {
      if (tipo.ToLower() == "computer")
      {
         return new Computer();
      }
      else if (tipo.ToLower() == "stampante")
      {
         return new Stampante();
      }
      else
      {
         Console.WriteLine($"Scelta non valida, ritenta..");
         return null;   
      }
   }
}

