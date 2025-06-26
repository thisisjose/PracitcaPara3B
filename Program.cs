using System;

class Persona
{
    private string nombre;
    private int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años.");
    }

    public void CumplirAnios()
    {
        edad++;
        Console.WriteLine($"{nombre} ahora tiene {edad} años.");
    }
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona("Ana", 20);
        persona1.Saludar();
        persona1.CumplirAnios();
    }
}
//Para correr en Visual Code es dotnet run
//para crear un programa es dotnet new console -n NombreProyecto
