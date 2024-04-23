internal class Program
{
    private static void Main(string[] args)
    {
        Fish fishYellow  = new Fish();
        IAnimal fishRed = new Fish();
        fishRed.Eat();
        IWater fishGreen = new Fish();
        fishGreen.Swiming();
        IAttack fishBlue = new Fish();
        fishBlue.Attack();
    }
}
public abstract class CatSmall()
{
    public abstract string HowToEat();
}
public interface IAnimal
{
    void Eat();
}
public interface IWater
{
    void Swiming();
}

public interface IAttack
{
    void Attack();
}
public class Fish : IAnimal, IWater, IAttack
{
    public void Attack()
    {
        Console.WriteLine("Attack");
    }

    public void Eat()
    {
        Console.WriteLine("an reu");
    }
    public void Swiming()
    {
        Console.WriteLine("boi");
    }
}
public class Cat : CatSmall
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
public class CharFish : CatSmall
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}