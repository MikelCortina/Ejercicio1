public class Vehicle
{
    protected string model;
    protected int numAsientos;
    protected Asiento Asiento;
    protected AsientoReclinable AsientoReclinablee;
    private int v;
    int totalreclinables = 0;
    List<Asiento> milista = new List<Asiento>();
    List<AsientoReclinable> milista2 = new List<AsientoReclinable>();   

    public Vehicle(string model)
    {
        this.model = model;

    }

    public Vehicle(int numAsientos, int noReclinable, int reclinable)
    {
        this.numAsientos = numAsientos;
        

        for (int i = 0; i < noReclinable; i++) {
            
            milista.Add(new Asiento());  
        }
        
        for (int i = 0; i < reclinable; i++)
        {
            milista2.Add(new AsientoReclinable());
            totalreclinables++;
        }
    }

    public virtual void info()
    {
        Console.WriteLine("Tiene" + numAsientos + "asientos" + " de los cuales " + totalreclinables + "son reclinables");
    }
  
    public virtual void Accelerate()
    {

    }
    public string Getmodel()
    {
        return model;
    }

}