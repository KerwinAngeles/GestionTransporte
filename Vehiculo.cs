class Vehiculo
{
    public string Marca { get; set; }
    public string Color { get; set; }
    public int Modelo { get; set; }
    public int Precio { get; set; }

    public Vehiculo(string Marca, int Modelo, int Precio)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Precio = Precio;
        Color = "red";
    }

    public void ArrancarMotor()
    {
        Console.WriteLine("El motor del vehiculo esta encendido");
    }

    public void PararMotor()
    {
        Console.WriteLine("El motor del vehiculo esta apagado");
    }

    public virtual void Conducir()
    {
        Console.WriteLine("El vehiculo esta en marcha");
    }

    public virtual string ToString()
    {
        return "Marca: " + Marca + " Modelo: " + Modelo + " Precio: " + Precio;
    }


}