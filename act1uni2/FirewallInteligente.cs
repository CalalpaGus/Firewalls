
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

public class FirewallInteligente : FirewallAvanzado {

   
       
    private int nivelDeInteligencia;
    private List<string> logActividades;

    public FirewallInteligente(int nivelDeInteligencia, List<string> logActividades, FirewallHardware hardwareFirewall, FirewallSoftware softwareFirewall) 
        : base(hardwareFirewall, softwareFirewall)
    {
        this.nivelDeInteligencia = nivelDeInteligencia;
        this.logActividades = new List<string> (logActividades);
        
    }

    public override void Activar() {
        base.Activar();
        Console.WriteLine($"Nivel de inteligencia: {nivelDeInteligencia}");

    }

    public override void MostrarEstado() {
        base.MostrarEstado();
        Console.WriteLine($"Nivel del inteligencia {nivelDeInteligencia}");
        if (logActividades != null && logActividades.Count > 0)
        {
            foreach (var log in logActividades)
            {
                Console.WriteLine($"Registro de actividad: {log}");

            }
        }

    }

    public void AnalizarTrafico() {
        Console.WriteLine("Análisis de tráfico");
    }

}