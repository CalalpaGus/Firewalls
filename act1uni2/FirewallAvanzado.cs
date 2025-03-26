
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FirewallAvanzado {

    private FirewallHardware hardwareFirewall;

    private FirewallSoftware softwareFirewall;

    private List<string> tecnologiasSoportadas;

    public FirewallAvanzado(FirewallHardware hardwareFirewall, FirewallSoftware softwareFirewall)
    {
        this.hardwareFirewall = hardwareFirewall;
        this.softwareFirewall = softwareFirewall;
    }

    public FirewallAvanzado(FirewallHardware hardwareFirewall, FirewallSoftware softwareFirewall, List<string> tecnologiasSoportadas)
    {
        this.hardwareFirewall = hardwareFirewall;
        this.softwareFirewall = softwareFirewall;
        this.tecnologiasSoportadas = new List<string>(tecnologiasSoportadas);

    }
    public virtual void Activar() {
        hardwareFirewall.Activar();
        softwareFirewall.Activar();
    }

    public virtual void MostrarEstado() {
        hardwareFirewall.MostrarEstado();
        softwareFirewall.MostrarEstado();
        if (tecnologiasSoportadas != null && tecnologiasSoportadas.Count > 0)
        {
            foreach (var tecnologia in tecnologiasSoportadas)
            {
                Console.WriteLine($"Tecnología soportada: {tecnologia}");

            }
        }
    }

    

}