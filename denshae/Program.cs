// See https://aka.ms/new-console-template for more information
using System.Data.Common;

public class Vehiculo
{
    public int id = 0;
   public String? tipo = "";
   public DateTime? fechaFabricacion = DateTime.Now;
   public String? Terreno = "";
   public String? Modelo = "";
   public int ruedas = 0;
   public decimal velocidad = 0.0m;

}
public class tipo_combustiple
{
    public int id = 0;
    public String? tipo = "";
    public decimal capacidadTanque = 0.0m;
}

public class Tren : Vehiculo
{
    public int numeroVagones = 0;
    public String? tipoTren = "";
}   


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------- Vehiculo --------");
        Vehiculo vehiculo1 = new Vehiculo();
        vehiculo1.id = 1;
        vehiculo1.tipo = "Carro";
        vehiculo1.fechaFabricacion = DateTime.Now;
        vehiculo1.Terreno = "Carretera";
        vehiculo1.Modelo = "Toyota";
        vehiculo1.ruedas = 4;
        vehiculo1.velocidad = 120.5m;
        Console.WriteLine($"ID: {vehiculo1.id}");
        Console.WriteLine($"Tipo: {vehiculo1.tipo}");
        Console.WriteLine($"Fecha Fabricacion: {vehiculo1.fechaFabricacion}");
        Console.WriteLine($"Terreno: {vehiculo1.Terreno}");
        Console.WriteLine($"Modelo: {vehiculo1.Modelo}\n");
        Console.WriteLine("-------- Tipo Combustible --------");
        tipo_combustiple combustible1 = new tipo_combustiple();
        combustible1.id = 1;
        combustible1.tipo = "Gasolina";
        Console.WriteLine($"El Vehiculo con el ID: {combustible1.id}, usa combustible de tipo: {combustible1.tipo}\n");
        Console.WriteLine("\n\n\n-------- Tren --------");
        List<Tren> tren1 = new List<Tren>();
        tren1.Add(new Tren { id = 1, tipo = "Tren de carga", fechaFabricacion = DateTime.Now, Terreno = "Rieles", Modelo = "Freightliner", ruedas = 8, velocidad = 80.0m, numeroVagones = 50, tipoTren = "Carga" });
        tren1.Add(new Tren { id = 2, tipo = "Tren de pasajeros", fechaFabricacion = DateTime.Now, Terreno = "Rieles", Modelo = "Siemens", ruedas = 6, velocidad = 100.0m, numeroVagones = 20, tipoTren = "Pasajeros" });
        foreach (var tren in tren1)
        {
            Console.WriteLine($"ID: {tren.id}");
            Console.WriteLine($"Tipo: {tren.tipo}");
            Console.WriteLine($"Fecha Fabricacion: {tren.fechaFabricacion}");
            Console.WriteLine($"Terreno: {tren.Terreno}");
            Console.WriteLine($"Modelo: {tren.Modelo}");
            Console.WriteLine($"Numero de Ruedas: {tren.ruedas}");
            Console.WriteLine($"Velocidad: {tren.velocidad} km/h");
            Console.WriteLine($"Numero de Vagones: {tren.numeroVagones}");
            Console.WriteLine($"Tipo de Tren: {tren.tipoTren}\n");
        }

    }
}
