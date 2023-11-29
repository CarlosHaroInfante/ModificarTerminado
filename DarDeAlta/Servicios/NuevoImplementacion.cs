using DarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal class NuevoImplementacion : NuevoInterfaz
    {
        public void borrarCliente(List<ClientesDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniPedido = mi.pedirDNI();


            //Se elimina por referencia de memoria no por valores.
            ClientesDto clienteABorrar = new ClientesDto();
            foreach (ClientesDto clientes in listaAntigua)
            {
                if (clientes.DniCliente.Equals(dniPedido))
                {
                    clienteABorrar = clientes;
                    break;
                }
            }
        }


            //Posición
            /**  int i;
              bool aBorrar = false;

              for (i = 0; i < listaAntigua.Count(); i++) 
              {

                  if (listaAntigua[i].DniCliente.Equals(dniPedido)) 
                  {
                      aBorrar = true;
                      break;
                  }
              }
              if(aBorrar) 
              { 
                  listaAntigua.RemoveAt(i);
              }
              else
              {
                  Console.WriteLine("El cliente no existe");
              }

              
          }*/

            public void darAltaCliente(List<ClientesDto> listaAntigua)
            {


                ClientesDto cliente = darAlta();
                listaAntigua.Add(cliente);

            }

       

        /// <summary>
        /// Implementación donde se pondrán los datos del usuario y lo añadirá a la lista.
        /// 171123 - chi
        /// </summary>

        private ClientesDto darAlta()
            {

                ClientesDto clienteNuevo = new ClientesDto();

                Console.WriteLine("Datos del usuario");

                Console.WriteLine("ID: ");
                clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());
                long idClient = clienteNuevo.IdCliente;

                Console.WriteLine("Nombre: ");
                clienteNuevo.NombreCliente = Console.ReadLine();

                Console.WriteLine("Apellidos: ");
                clienteNuevo.ApellidosCliente = Console.ReadLine();

                Console.WriteLine("DNI: ");
                clienteNuevo.DniCliente = Console.ReadLine();

                Console.WriteLine("Fecha de nacimiento: ");
                clienteNuevo.FchNacimientoCliente = Console.ReadLine();

                Console.WriteLine("email: ");
                clienteNuevo.EmailCliente = Console.ReadLine();

                Console.WriteLine("Tlf: ");
                clienteNuevo.TlfCliente = Convert.ToInt32(Console.ReadLine());
                //long tlfCliente = clienteNuevo.TlfCliente;

                


                return clienteNuevo;

            }

        public void modificarCliente(List<ClientesDto> listaAntigua)
            {
                ClientesDto modClientes = new ClientesDto();
                MenuInterfaz mi = new MenuImplementacion();
                string dni = mi.pedirDNI();
            

            foreach (ClientesDto cliente in listaAntigua)
            {
                if (cliente.DniCliente.Equals(dni)) { 



                    bool cerrarMenu = false;


                    while (!cerrarMenu)
                    {
                        int opcion = mi.seleccion();

                        switch (opcion)
                        {
                            case 0:
                                Console.WriteLine("Se cerrará el menú");
                                cerrarMenu = true;
                                break;

                            case 1:
                                Console.WriteLine("Modificar Nombre");
                                string nombreNuevo = Console.ReadLine(); ;
                                cliente.NombreCliente = nombreNuevo;
                                break;
                            case 2:
                            Console.WriteLine("Modificar Apellidos");
                                string apellidosNuevos = Console.ReadLine(); ;
                                cliente.ApellidosCliente = apellidosNuevos;
                            break;

                            case 3:
                            Console.WriteLine("Modificar DNI");
                            string DNInuevo = Console.ReadLine();
                            cliente.DniCliente = DNInuevo;
                            break;

                            case 4:
                            Console.WriteLine("Modificar Fecha de Nacimiento");
                            string FchNueva = Console.ReadLine();
                            cliente.FchNacimientoCliente = FchNueva;
                            break;

                            case 5:
                            Console.WriteLine("Modificar Email");
                                string EmailNuevo = Console.ReadLine();
                                    cliente.EmailCliente = EmailNuevo;
                            break;

                            case 6:
                            Console.WriteLine("Modificar tlf");
                                int tlfNuevo = Convert.ToInt32(Console.ReadLine());
                                cliente.TlfCliente = tlfNuevo;
                            break;


                        }
                       
                    }
                }
            }
        }

        }
    }

