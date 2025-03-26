
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FirewallSoftware : Firewall {
    private string version;
    private string licencia;
    public FirewallSoftware(string nombre, string tipo 
        , string version, string licencia):base(nombre, tipo)
    {
        this.version = version;
        this.licencia = licencia;
    }

   public string Version
    {
        get { return version; }
        set { version = value; }  
    }

    public string Licencia
    {
        get { return licencia; }
        set { licencia = value; }
    }

    public override void Activar() {
        base.Activar();
        Console.WriteLine($"Licienca: {licencia}\nVersion de software: {version}");
    }

    public override void MostrarEstado() {
        base.MostrarEstado();
        Console.WriteLine($"Licienca: {licencia}\nVersion de software: {version}");
    }

}