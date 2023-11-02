class Coche : Vehiculo
{
    public Coche (string Marca, int Modelo, int Precio) : base (Marca, Modelo, Precio)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Precio = Precio;
    }

    public int Acelerando (int acelerando)
    {
        return acelerando;
    }

    public int Frenando (int frenando, int acelerando)
    {
        return Acelerando(acelerando) - frenando;
    }

    public override void Conducir()
    {
        Console.WriteLine ("El coche esta en marcha en direccion a un supermercado");
    }

    public override string ToString()
    {
        return base.ToString();
    }
}