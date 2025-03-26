using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1uni2
{
     class MetodosMenu
    {
        
        public static List<FirewallHardware> listHardware = new List<FirewallHardware>();
        public static List<FirewallSoftware> listSoftware = new List<FirewallSoftware>();
        public static List<FirewallAvanzado> listAvanzado = new List<FirewallAvanzado>();
        public static List<FirewallInteligente> listInteligente = new List<FirewallInteligente>();

        public List<FirewallHardware> firewallHardwares { get; set; }
        public List<FirewallSoftware> firewallSoftwares { get; set; }
        public List<FirewallAvanzado> firewallAvanzados { get; set; }
        public List<FirewallInteligente> firewallInteligentes { get; set; }
        
        
        

        public static void CreateFiwall(Type tipoClase)
        {



            if (tipoClase == typeof(FirewallHardware))
            {

                Console.WriteLine("Ingresa el nombre del Firewall: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el tipo del Firewall: ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese la IP pública: ");
                string ipp = Console.ReadLine();

                List<string> listReglas = new List<string>();
                Console.WriteLine("Ingrese las reglas (enter para enviar parametro, 'f' para terminar):");
                while (true)
                {
                    string valor = Console.ReadLine();
                    if (valor.ToLower() == "f")
                    {
                        break;
                    }
                    listReglas.Add(valor);
                    //Console.WriteLine(listReglas.Count);
                }
                FirewallHardware nfh = new FirewallHardware(nombre, tipo, listReglas, modelo, ipp);
                listHardware.Add(nfh);

            }
            else if (tipoClase == typeof(FirewallSoftware))
            {

                Console.WriteLine("Ingresa el nombre del Firewall: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el tipo del Firewall: ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Ingrese la version: ");
                string version = Console.ReadLine();
                Console.WriteLine("Ingrese la licencia: ");
                string licencia = Console.ReadLine();


                FirewallSoftware nfs = new FirewallSoftware(nombre, tipo, version, licencia);
                listSoftware.Add(nfs);

            }
            else if (tipoClase == typeof(FirewallAvanzado))
            {


                Console.WriteLine("Ingrese el número del firewall hardware: ");
                int opcHard = Int32.Parse(Console.ReadLine()) - 1;
                FirewallHardware firewallHardware = listHardware[opcHard];
                Console.WriteLine("Ingrese el número del firewall software: ");
                int opcSoft = Int32.Parse(Console.ReadLine()) - 1;
                FirewallSoftware firewallSoftware = listSoftware[opcSoft];
                List<string> listTecno = new List<string>();
                Console.WriteLine("Ingrese las tecnologías soportadas (enter para enviar parametro, 'f' para terminar):");
                while (true)
                {
                    string valor = Console.ReadLine();
                    if (valor.ToLower() == "f")
                    {
                        break;
                    }
                    listTecno.Add(valor);
                }

                FirewallAvanzado nfa = new FirewallAvanzado(firewallHardware, firewallSoftware, listTecno);
                listAvanzado.Add(nfa);

            }
            else if (tipoClase == typeof(FirewallInteligente))
            {

                Console.WriteLine("Ingrese el número del firewall hardware: ");
                int opcHard = int.Parse(Console.ReadLine()) - 1;
                FirewallHardware firewallHardware = listHardware[opcHard];
                Console.WriteLine("Ingrese el número del firewall software: ");
                int opcSoft = int.Parse(Console.ReadLine()) - 1;
                FirewallSoftware firewallSoftware = listSoftware[opcSoft];
                Console.WriteLine("Nivel de capacidad para detectar comportamientos anómalos (escala de 1 a 10): ");
                int inteligencia = int.Parse(Console.ReadLine());
                List<string> listLog = new List<string>();
                Console.WriteLine("Ingrese el log de actividades (enter para enviar parametro, 'f' para terminar):");
                while (true)
                {
                    string valor = Console.ReadLine();
                    if (valor.ToLower() == "f")
                    {
                        break;
                    }
                    listLog.Add(valor);
                }

                FirewallInteligente nfi = new FirewallInteligente(inteligencia, listLog, firewallHardware, firewallSoftware);
                listInteligente.Add(nfi);
            }
            else
            {
                Console.WriteLine("Tipo de clase no soportado.");
                return;
            }

        }

        public static bool ListHardMostrar()
        {
            if (listHardware.Count == 0)
            {
                Console.WriteLine("No hay Firewall tipo hardware registrados");
                return false;
            }
            else
            {
                Console.WriteLine("Lista de Firewalls tipo Hardware");
                for (int i = 0; i < listHardware.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listHardware[i].Nombre}, {listHardware[i].Tipo}, {listHardware[i].Modelo}");
                }
                return true;
            }
        }

        public static bool ListSoftMostrar()
        {
            if (listSoftware.Count == 0)
            {
                Console.WriteLine("No hay Firewall tipo software registrados");
                return false;
            }
            else
            {
                Console.WriteLine("Lista de Firewalls tipo Software");
                for (int i = 0; i < listSoftware.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listSoftware[i].Nombre}, {listSoftware[i].Tipo}, {listSoftware[i].Version}");
                }
                return true;
            }
        }

        public static bool ListAvanMostrar()
        {
            if (listAvanzado.Count == 0)
            {
                Console.WriteLine("No hay Firewall Avanzados registrados");
                return false;
            }
            else
            {
                Console.WriteLine("Lista de Firewalls Avanzados");
                foreach (var objeto in listAvanzado)
                {
                    Console.WriteLine(objeto.ToString());
                }
                return true;
            }

        }

        public static bool ListIntelMostrar()
        {
            if (listInteligente.Count == 0)
            {
                Console.WriteLine("No hay Firewall inteligentes registrados");
                return false;
            }
            else
            {
                Console.WriteLine("Lista de Firewalls Inteligentes");
                foreach (var objeto in listInteligente)
                {
                    Console.WriteLine(objeto.ToString());
                }
                return true;
            }


        }
    }
}
