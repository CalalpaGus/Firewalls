//Gustavo Calalpa


using act1uni2;
using System.Reflection;
using System.Xml;




bool continuar = true;

do 
{
    //Menú
    //Console.Clear();
    Console.WriteLine("Gestión de firewalls\n");

    Console.WriteLine("Selecciona el  número deseado\n");
    Console.WriteLine("1.- Crear Firewall");
    Console.WriteLine("2.- Activar/desactivar Firewall");
    Console.WriteLine("3.- Agregar reglas de seguridad");
    Console.WriteLine("4.- Mostrar estado de los firewalls");
    Console.WriteLine("5.- Salir\n");

    string opc = Console.ReadLine();
    bool subCont = true;
    switch (opc)
    {
        case "1":
            //Menú de creación de firewalls
            while (subCont)
            {
                
                Console.Clear();
                Console.WriteLine("Crear Firewall\n");
                Console.WriteLine("Selecciona el  número deseado\n");
                Console.WriteLine("1.- Crear Firewall Hardware");
                Console.WriteLine("2.- Crear Firewall Software");
                Console.WriteLine("3.- Crear Firewall Avanzado");
                Console.WriteLine("4.- Crear Firewall Inteligente");
                Console.WriteLine("5.- Regresar\n");

                string subOpc = Console.ReadLine();

                switch (subOpc)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Firewall Hardware");
                        MetodosMenu.CreateFiwall(typeof(FirewallHardware));
                        
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Firewall Software\n");
                        MetodosMenu.CreateFiwall(typeof(FirewallSoftware));

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Firewall Avanzado\n");
                        if (MetodosMenu.ListHardMostrar() && MetodosMenu.ListSoftMostrar())
                        {
                            MetodosMenu.CreateFiwall(typeof(FirewallAvanzado));
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Firewall Inteligente\n");
                        if (MetodosMenu.ListHardMostrar() && MetodosMenu.ListSoftMostrar())
                        {
                         
                            MetodosMenu.CreateFiwall(typeof(FirewallInteligente));
                        }
                        
                        break;
                    case "5":
                        Console.Clear();
                        subCont = false;

                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        Console.Clear();
                        break;
                }

            }
            break;
        case "2":
            //Menú de activación de firewalls

            while (subCont)
            {
                
                Console.WriteLine("Activar/desactivar Firewall\n");
                Console.WriteLine("Selecciona el  número deseado\n");
                Console.WriteLine("1.- Activar/desactivar Firewall Hardware");
                Console.WriteLine("2.- Activar/desactivar Firewall Software");
                Console.WriteLine("3.- Activar Firewall Avanzado");
                Console.WriteLine("4.- Activar Firewall Inteligente");
                Console.WriteLine("5.- Regresar\n");
                string subOpc2 = Console.ReadLine();
                switch (subOpc2)
                {
                    case "1":
                        Console.Clear();
                        if (MetodosMenu.ListHardMostrar())
                        {

                            Console.WriteLine("Indique el número de Firewall para activar/desactivar");
                            int lh = int.Parse(Console.ReadLine()) - 1;
                            FirewallHardware lfh = MetodosMenu.listHardware[lh];
                            if (lfh.Estado)
                            {
                                lfh.Desactivar();

                            }
                            else
                            {
                                lfh.Activar();
                            }
                            Console.WriteLine();
                        }
                        

                        break;

                    case "2":
                        Console.Clear();
                        if (MetodosMenu.ListSoftMostrar())
                        {

                            Console.WriteLine("Indique el número de Firewall para activar/desactivar");
                            int ls = int.Parse(Console.ReadLine()) - 1;
                            FirewallSoftware lfs = MetodosMenu.listSoftware[ls];
                            if (lfs.Estado)
                            {
                                lfs.Desactivar();

                            }
                            else
                            {
                                lfs.Activar();
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Clear();
                        if (MetodosMenu.listAvanzado.Count > 0)
                        {
                            MetodosMenu.ListAvanMostrar();
                            Console.WriteLine("Indique el número de Firewall para activar");
                            int la = int.Parse(Console.ReadLine()) - 1;
                            FirewallAvanzado lfa = MetodosMenu.listAvanzado[la];

                            lfa.Activar();

                        }
                        Console.WriteLine();

                        break;
                    case "4":
                        Console.Clear();
                        if (MetodosMenu.ListIntelMostrar())
                        {
                            
                            Console.WriteLine("Indique el número de Firewall para activar");
                            int li = int.Parse(Console.ReadLine()) - 1;
                            FirewallAvanzado lfi = MetodosMenu.listInteligente[li];

                            lfi.Activar();

                        }
                        Console.WriteLine();

                        break;
                    case "5":
                        Console.Clear();
                        subCont = false;
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");

                        break;
                }
            }
            break;
        case "3":
            //Menú para agregar listado de reglas sólo hardware
            while (subCont)
            {
                Console.Clear();
                Console.WriteLine("Agregar una regla");
                Console.WriteLine("1.- Agregar regla al Firewall tipo hardware");
                Console.WriteLine("2.- Regresar");
                string subOpc2 = Console.ReadLine();
                switch (subOpc2)
                {
                    case "1":
                        Console.Clear();
                        if (MetodosMenu.ListHardMostrar())
                        {
                            Console.WriteLine("Indique el número de Firewall que desea agregar la lista");
                            int lh = int.Parse(Console.ReadLine()) - 1;
                            FirewallHardware lfh = MetodosMenu.listHardware[lh];
                            
                            
                            do
                            {
                                Console.WriteLine("Ingrese la regla o indicque 's' para salir");
                                string valor= Console.ReadLine();
                                if (valor.ToLower() == "s")
                                {
                                    break;
                                }
                                else
                                {
                                    lfh.AgregarRegla(valor);
                                }
                                
                            } while (true);
                            
                        }
                        Console.WriteLine();
                        break; 
                    
                    case "2":
                        Console.Clear();
                        subCont = false;
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            }
            break;
        case "4":
            //Menú para Mostrar información
            while (subCont)
            {
                Console.Clear();
                Console.WriteLine("Mostrar información\n");
                Console.WriteLine("Selecciona el  número deseado\n");
                Console.WriteLine("1.- Mostrar información del Firewall Hardware");
                Console.WriteLine("2.- Mostrar información del  Firewall Software");
                Console.WriteLine("3.- Mostrar información del  Avanzado");
                Console.WriteLine("4.- Mostrar información del  Inteligente");
                Console.WriteLine("5.- Regresar\n");
                string subOpc2 = Console.ReadLine();
                switch ((subOpc2))
                {
                    case "1":
                        Console.Clear();
                        if (MetodosMenu.ListHardMostrar())
                        {

                            Console.WriteLine("Indique el número del Firewall tipo Hardware para Mostrar información");
                            int lh = int.Parse(Console.ReadLine()) - 1;
                            FirewallHardware lfh = MetodosMenu.listHardware[lh];
                            lfh.MostrarEstado();
                            Console.ReadLine();
                        }


                        break;

                    case "2":
                        Console.Clear();
                        if (MetodosMenu.ListSoftMostrar())
                        {

                            Console.WriteLine("Indique el número del Firewall tipo software para Mostrar información");
                            int ls = int.Parse(Console.ReadLine()) - 1;
                            FirewallSoftware lfs = MetodosMenu.listSoftware[ls];
                            lfs.MostrarEstado();
                            Console.ReadLine();
                        }


                        break;
                    case "3":
                        Console.Clear();
                        if (MetodosMenu.listAvanzado.Count > 0)
                        {
                            MetodosMenu.ListAvanMostrar();
                            Console.WriteLine("Indique el número del Firewall Avanzado para Mostrar información");
                            int la = int.Parse(Console.ReadLine()) - 1;
                            FirewallAvanzado lfa = MetodosMenu.listAvanzado[la];

                            lfa.MostrarEstado();
                            Console.ReadLine();

                        }


                        break;
                    case "4":
                        Console.Clear();
                        if (MetodosMenu.ListIntelMostrar())
                        {

                            Console.WriteLine("Indique el número del Firewall inteligente para Mostrar información");
                            int li = int.Parse(Console.ReadLine()) - 1;
                            FirewallAvanzado lfi = MetodosMenu.listInteligente[li];

                            lfi.MostrarEstado();
                            Console.ReadLine();

                        }


                        break;
                    case "5":
                        subCont = false;
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");

                        break;
                }
            }

                break;
        case "5":
            continuar = false;
            Console.WriteLine("Saliendo del programa");
            break;
        default:
            Console.WriteLine("Opción invalida");
            break;
    }



}while (continuar);
