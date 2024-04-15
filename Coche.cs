public class Coche : Vehicle
{
    protected string techo;
    public Coche(string toyota, string techo) : base(toyota)
    {
        this.techo = techo;
    }

    public Coche() : base(5, 3, 2)
    {
        
    }
    private bool forward;
    public virtual void Accelerate()
    {
        if (forward == true)
        {
            Console.WriteLine("movin forward");
        }
        else
        {
            Console.WriteLine("Back");
        }
    }
    public virtual void info()
    {
        
        Console.WriteLine("Este coche, modelo " + Getmodel);
        base.info();
    }
}