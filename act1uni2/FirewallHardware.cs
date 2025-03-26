
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FirewallHardware : Firewall {

    private string modelo;
    private string ipPublica;
    public FirewallHardware(string nombre, string tipo, string modelo, string ipPublica)
        :base(nombre,tipo) {
        
        this.modelo = modelo;
        this.ipPublica = ipPublica;
    }
    public FirewallHardware(string nombre, string tipo, List<string> reglas, string modelo, string ipPublica)
        : base(nombre, tipo, reglas)
    {
        this.modelo = modelo;
        this.ipPublica = ipPublica;
    }
    

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string IpPublica
    {
        get { return ipPublica; }
        set { ipPublica = value; }
    }

    public override void Activar() {
        base.Activar();
        Console.WriteLine($"Modelo: {modelo}\nIP: {ipPublica}");
    }

    public override void MostrarEstado() {
        base.MostrarEstado();
        Console.WriteLine($"Modelo: {modelo}\nIP: {ipPublica}");
    }

}