using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Persona
    {
        private int documento;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;

        private int _documento
        {
            get { return documento; }
            set { this.documento = value; }
        }
        private string _nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        private string _apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        private DateTime _fechaNacimiento
        {
            get { return fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public void CargarPersona()
        {
            this.documento = _documento;
            string nombre = _nombre;
            string apellido = _apellido;
            DateTime fechaNacimiento= _fechaNacimiento;
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese el documento de la persona: ");
                _documento = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_documento);
                if (_documento<999999 || _documento > 999999999)
                {
                    flag = false;
                    Console.WriteLine("Por Favor ingrese un documento válido");
                }
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                _nombre = Console.ReadLine();
                flag = ValidarString(_nombre);
                if (_nombre.Length>30)
                {
                    flag = false;
                    Console.WriteLine("Por Favor ingrese un nombre más corto");
                }
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el apellido de la persona:");
                _apellido = Console.ReadLine();
                flag = ValidarString(_apellido);
                if (_apellido.Length > 30)
                {
                    flag = false;
                    Console.WriteLine("Por Favor ingrese un apellido más corto");
                }
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la fecha de nacimiento: \n");
                string fechanacimiento;
                fechanacimiento = Console.ReadLine();
                flag = ValidarFecha(fechanacimiento);
            } while (flag == false);

            bool ValidarString(string userinput)
            {
                bool validar = false;
                if (string.IsNullOrEmpty(userinput))
                {
                    Console.WriteLine("Error. No ingreso ningun dato.");
                }
                else
                {
                    validar = true;
                }
                return validar;
            }
            
            bool ValidarInt(int numero)
            {
                bool flagg = false;
                if (numero < 0)
                {
                    Console.WriteLine("Debe ingresar un número mayor a 0");
                }
                else
                {
                    flagg = true;
                }
                return flagg;
            }

            bool ValidarFecha(string userinput)
            {
                bool validar = false;
                DateTime fecha;
                DateTime.TryParse(userinput, out fecha);
                if (!fecha.Equals(DateTime.MinValue))
                {
                    validar = true;
                }
                if (DateTime.Now < fecha)
                {
                    Console.WriteLine("La fecha ingresada es mayor a la fecha de hoy");
                    validar = false;
                }
                return validar;
            }

        }


    }


}
