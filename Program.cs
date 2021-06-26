using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_EnumPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("====== Bienvenido(a) al sistema de comisiones =====");
            Console.WriteLine("=======================================================");
            Console.WriteLine();

            Empleado Usuario = new Empleado("","",0,0);

            Console.WriteLine("Ingrese la cedula del empleado:");
            Usuario.setCedula(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el nombre del empleado:");
            Usuario.setNombre(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el salario del empleado:");
            Usuario.setSalario(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Ingrese las ventas obtenidas por el empleado:");
            Usuario.setVentas(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("----------- Resumen del empleado -----------");
            Console.WriteLine();

            Console.WriteLine("Cedula: " + Usuario.getCedula());
            Console.WriteLine("Nombre: " + Usuario.getNombre());
            Console.WriteLine("Salario: "+ Usuario.getSalario());
            Console.WriteLine("Ventas: " + Usuario.getVentas());
            Console.WriteLine("El salario total es: " + Usuario.CalcularSalario());
            Console.ReadLine();

        }
    }

    class Empleado{
        //** Atributos - Variables **//
        string cedula;
        string nombre;
        double salario;
        double ventas;

        //Enumeraciones de comisiones
        enum Comision { normal=50000, alta=150000};

        //** Metodos **//
        //Constructor
        public Empleado(string cedula, string nombre, double salario, double ventas) {
            this.cedula = "";
            this.nombre = "";
            this.salario = 0;
            this.ventas = 0;
        }

        //Metodos Set
        public void setCedula(string cedula) {
            this.cedula = cedula;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public void setSalario(double salario) {
            this.salario = salario;
        }

        public void setVentas(double ventas) {
            this.ventas = ventas;
        }

        //Metodos Get
        public string getCedula()
        {
            return cedula;
        }

        public string getNombre() {
            return nombre;
        }

        public double getSalario() {
            return salario;
        }

        public double getVentas() {
            return ventas;
        }

        //Metodos de clase
        public double CalcularSalario() {
            double salario_total = 0;

            if (ventas >= 100000 && ventas <= 250000) {
                salario_total = salario + (double)Comision.normal;
            }
            else if(ventas > 250000 && ventas <=300000){
                salario_total = salario + (double)Comision.alta;
            }
            return salario_total;
        }
            
    }
}
