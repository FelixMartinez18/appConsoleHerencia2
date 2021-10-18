using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassPersona
{
    class Persona
    {
        protected string nombre;

        public string Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }


        protected string FechaNacimiento;

        public string fechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }


            public Persona()
        {
            nombre = "";
            fechaNacimiento = "";
        }

        public Persona(string nombre, string fechanacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\n Fecha de nacimiento: " + fechaNacimiento;

        }
    }
}
