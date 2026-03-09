public interface IShape
{
   void Draw();
}

public class Circle : IShape
{
   public void Draw()
   {
      Console.WriteLine($"Disegno un cerchio");
   }
}

public class Square : IShape
{
   public void Draw()
   {
      Console.WriteLine($"Disegno un quadrato");
   }
}

public static class ShapeCreator
{
   public static IShape CreateShape(string shape)
   {
      switch (shape.ToLower())
      {
         case ("circle"):
            return new Circle();

         case ("square"):
            return new Square();   

         default:
            Console.WriteLine($"Scelta non valida");
            return null;
      }
      
   }
}

/*
public abstract class ShapeCreator
{
   public abstract IShape CreateShape();

   public void DrawShape()
   {
      IShape shape = CreateShape();
      shape.Draw();
   }
}


public class ConcreteShapeSquare : ShapeCreator
{
   public override IShape CreateShape(
   {
      return new Square();
   }

}

public class ConcreteShapeCircle : ShapeCreator
{
      public override IShape CreateShape()
   {
      return new Circle();
   }

}
*/
