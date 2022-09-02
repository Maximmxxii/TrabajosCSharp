using System;
using System.Collections.Generic;
using Persistencia;
using Dominio;

namespace Consola
{
    class Program
    {
        /**
        *? VARIABLES Y OBJETOS GLOBALES
        */
        static int op = 0;
        static IRMunicipio _repoMunicipio = new RMunicipio(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Menu();
            
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("=== MENU DE OPCIONES ===");
            Console.WriteLine("  1. Crear Municipio");
            Console.WriteLine("  2. Buscar Municipio");
            Console.WriteLine("  3. Eliminar Municipio");
            Console.WriteLine("  4. Actualizar Municipio");
            Console.WriteLine("  5. Listar Municipio");
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Seleccione Accion a Realizar con Municipio");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                {
                    crearMunicipio();
                    break;
                }
                case 2:
                {
                    buscarMunicipio();
                    break;
                }
                case 3:
                {
                    eliminarMunicipio();
                    break;
                }
                case 4:
                {
                    actualizarMunicipio();
                    break;
                }
                case 5:
                {
                    listarMunicipio();
                    break;
                }
                default:
                {
                     System.Console.WriteLine("Opcion Invalida. Seleccione una Opcion Valida!");
                     Recargar();
                     break;
                }
            }
        }

        private static void crearMunicipio()
        {
            Municipio municipio = new Municipio();
            System.Console.WriteLine("Ingrese el nombre del nuevo Municipio");
            municipio.Nombre = Console.ReadLine();
            System.Console.WriteLine("Ingrese la secretaria del nuevo municipio");
            municipio.Secretaria = Console.ReadLine();
            bool Funciono = _repoMunicipio.CrearMunicipio(municipio);
            if (Funciono)
            {
                Console.WriteLine("Municipio creado con exito");
                Recargar();
            }else
            {
                System.Console.WriteLine("Error en el Proceso");
                Recargar();
            }
            
        }

        private static void buscarMunicipio()
        {
            Municipio Mun = null;
            int Id = 0; 
            System.Console.WriteLine("Ingrese el Id Del municipio que desea buscar");
            Id = int.Parse(Console.ReadLine());
            Mun = _repoMunicipio.BuscarMunicipio(Id);
            if (Mun != null)
            {
                Console.WriteLine(Mun.Id);
                Console.WriteLine(Mun.Nombre);
                Console.WriteLine(Mun.Secretaria);
                Recargar();
            }else
            {
                System.Console.WriteLine("Municipio no encontrado");
                Recargar();
            }
            
        }

        private static void eliminarMunicipio()
        {
            int Id = 0;
            
            System.Console.WriteLine("Ingrese el Id del municipio a Eliminar");
            Id = int.Parse(Console.ReadLine());
            bool Funciono = _repoMunicipio.EliminarMunicipio(Id);
            if (Funciono)
            {
                System.Console.WriteLine("Municipio eliminado");
                Recargar();
            }else
            {
                System.Console.WriteLine("Municipio no encontrado, Imposible Eliminar");
            }
            
        }

        private static void actualizarMunicipio()
        {
            Municipio Mun = new Municipio();
            System.Console.WriteLine("Ingrese el Id del Municipio que desea Modificar");
            Mun.Id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el nuevo nombre del Municipio");
            Mun.Nombre = Console.ReadLine();
            System.Console.WriteLine("Ingrese la Nueva Secretaria del Municipio");
            Mun.Secretaria = Console.ReadLine();

            bool Funcion = _repoMunicipio.ActualizarMunicipio(Mun);
            if (Funcion)
            {
                System.Console.WriteLine("Municipio actualizado");
                Recargar();
            }else
            {
                System.Console.WriteLine("Municipio no actualizado, Verifique La Información Ingresada");
                Recargar();
            }
            
        }

        private static void listarMunicipio()
        {
            List<Municipio> lstMunicipio = _repoMunicipio.ListarMunicipios1();
            foreach (Municipio Mun in lstMunicipio)
            {
                System.Console.WriteLine(Mun.Id + " - " + Mun.Nombre + " - " + Mun.Secretaria);
            }            
            Recargar();
        }

        private static void Recargar()
        {
            System.Console.WriteLine("Presione una tecla para Continuar...");
            System.Console.ReadLine();
            System.Console.Clear();
            Menu();
        }
    }
}
