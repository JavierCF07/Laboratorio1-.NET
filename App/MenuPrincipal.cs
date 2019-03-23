using System;
using System.Collections.Generic;
using static System.Console;
using JavierCifuentes.Model;

namespace JavierCifuentes.App
{
    public class MenuPrincipal
    {
        public float alturaMaximaAvion;
        public float alturaMinimaAvion;
        public float profundidadMaximaSubmarino;
        public List<Avion> Avion { get; set; }
        public List<Submarino> Submarino { get; set; }
        public MenuPrincipal()
        {
            this.Avion = new List<Avion>();
            this.Submarino = new List<Submarino>();
        }
        public void mostrarMenu()
        {
            int opcion = 100;
            do
            {
                try
                {
                    WriteLine("1. Crear objeto avión");
                    WriteLine("2. Crear objeto Submarino");
                    WriteLine("3. Mostrar información de los aviones");
                    WriteLine("4. Mostrar información de los submarinos");
                    WriteLine("0. Salir");
                    WriteLine("Ingrese una opción: ");
                    string valor = ReadLine();
                    opcion = Convert.ToInt16(valor);
                    if (opcion == 1)
                    {
                        CrearAvion(opcion);
                    }
                    else if (opcion == 2)
                    {
                        CrearSubmarino(opcion);
                    }
                    else if (opcion == 3)
                    {
                        MostrarDetalleAvion();
                        ReadKey();
                    }
                    else if (opcion == 4)
                    {
                        MostrarDetalleSubmarino();
                        ReadKey();
                    }
                }
                catch (Exception)
                {
                    WriteLine("No puede ingresar una letra, debe ingresar un numero");
                    ReadKey();
                }
            } while (opcion != 0);
        }
        public void CrearAvion(int opcion)
        {
            string marca = "";
            string modelo = "";
            float velocidadMinima = 0;
            float velocidadMaxima = 0;
            Avion avion = null;

            WriteLine("Ingrese la marca del avión");
            marca = ReadLine();
            WriteLine("Ingrese el modelo del avión");
            modelo = ReadLine();
            WriteLine("Ingrese la velocidad mínima del avión");
            string velMinima = ReadLine();
            velocidadMinima = Convert.ToInt16(velMinima);
            WriteLine("Ingrese la velocidad máxima del avión");
            string velMaxima = ReadLine();
            velocidadMaxima = Convert.ToInt16(velMaxima);
            if (opcion == 1)
            {
                avion = new Avion(marca, modelo, velocidadMinima, velocidadMaxima);
                ((Avion)avion).AlturaMaxima = alturaMaximaAvion;
                ((Avion)avion).AlturaMinima = alturaMinimaAvion;

            }
            else
            {
                WriteLine("Tipo de vehiculo no registrado");
            }
            this.Avion.Add(avion);
        }

        public void CrearSubmarino(int opcion)
        {
            string marca = "";
            string modelo = "";
            float profundidadMaxima = 0;
            Submarino submarino = null;

            WriteLine("Ingrese la marca del submarino");
            marca = ReadLine();
            WriteLine("Ingrese el modelo del submarino");
            modelo = ReadLine();
            WriteLine("Ingrese la profundidad máxima para el submarino");
            string profMaxima = ReadLine();
            profundidadMaxima = Convert.ToInt16(profMaxima);
            if (opcion == 2)
            {
                submarino = new Submarino(marca, modelo, profundidadMaxima);
            }
            else
            {
                WriteLine("Tipo de vehiculo no registrado");
            }
            this.Submarino.Add(submarino);
        }
        public void MostrarDetalleAvion()
        {
            if (Avion.Count > 0)
            {
                foreach (var avion in Avion)
                {
                    WriteLine(avion);
                }
            }
            else if (Avion.Count <= 0)
            {
                WriteLine("No hay aviones ingresados");
            }
        }
        public void MostrarDetalleSubmarino()
        {
            if (Submarino.Count > 0)
            {
                foreach (var submarino in Submarino)
                {
                    WriteLine(submarino);
                }
            }
            else if (Submarino.Count <= 0)
            {
                WriteLine("No hay submarinos ingresados");
            }
        }
    }
}