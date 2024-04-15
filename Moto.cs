public class Moto : Vehicle
{

    public Moto(string yamaha): base (yamaha)
    {

    }
    public Moto() : base(2, 0, 2)
    {

    }
    public virtual void info()
    {
        Console.WriteLine("Esta moto modelo" + Getmodel);
        base.info();
    }

}