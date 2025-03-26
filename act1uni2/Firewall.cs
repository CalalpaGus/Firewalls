
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public abstract class Firewall
{

    protected string nombre;
    protected string tipo;
    protected bool estado;
    protected List<string> reglas;
    public Firewall()
    {
    }
    public Firewall(string nombre, string tipo, List<string> reglas)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.estado = false;
        this.reglas = new List<string>(reglas);
    }
    public Firewall(string nombre, string tipo)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.estado = false;
        this.reglas = new List<string>();

    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public bool Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public List<string> Reglas
    {
        get { return reglas; }
        set { reglas = value; }
    }
    public virtual void Activar()
    {
        if (estado)
        {
            Console.WriteLine($"El firewall: {nombre} ya está activado");
        }
        else
        {
            Console.WriteLine($"Activando el firewall: {nombre}");
            this.estado = true;
        }
    }

    public void Desactivar()
    {
        if (!estado)
        {
            Console.WriteLine($"El firewall: {nombre} está desactivado");
        }
        else
        {
            Console.WriteLine($"Desactivando el firewall: {nombre}");
            this.estado = false;
        }
    }

    public void AgregarRegla(string regla)
    {
        reglas.Add(regla);
        Console.WriteLine($"Regla {regla} agregada exitosamente");
    }

    public virtual void MostrarEstado()
    {
        if (estado)
        {
            Console.WriteLine($"El firewall {nombre}: está activo");


        }
        else
        {
            Console.WriteLine($"El firewall {nombre}: está desactivado");

        }
        if (reglas != null && reglas.Count > 0)
        {
            foreach (var regla in reglas)
            {
                Console.WriteLine($"Reglas configuradas: {regla}");


            }

        }
    }
}