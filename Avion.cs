class Avion : Vehiculo
{
    public Avion(string Marca, int Modelo, int Precio) : base(Marca, Modelo, Precio)
    {

    }

    public void Despegar()
    {
        Console.WriteLine("El avion esta despegando");
    }

    public void Aterrisar()
    {
        Console.WriteLine("El avion esta aterrisando");
    }

    public override void Conducir()
    {
        Console.WriteLine("El avion esta volando en direccion a EE.UU");
    }
    public override string ToString()
    {
       return base.ToString();
    }
}