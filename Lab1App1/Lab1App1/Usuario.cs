using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1App1
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        public Usuario(string Nicol, double SinSaldo)
        {
            Nombre = Nicol;
            Saldo = SinSaldo;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
    public class Cliente : Usuario
    {

        public double LibrosCargados { get; set; }
        public Cliente(string nombre, double saldo, double librosCargados) : base(nombre, saldo)
        {
            LibrosCargados = librosCargados;
        }
        public virtual void MostrarLibros()
        {
            Console.WriteLine($"LibrosCargados: {LibrosCargados}");

        }
        public class Empleado : Usuario
        {
            public double Sueldo { get; set; }

            public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
            {
                Sueldo = sueldo;
            }
            public virtual void MostrarSueldo()
            {
                Console.WriteLine($"Sueldo: {Sueldo}");

            }
        }
    }
}
