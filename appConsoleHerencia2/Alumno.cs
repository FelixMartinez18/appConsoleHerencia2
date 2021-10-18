using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2___17._10._21_
{
    class Alumno : persona
    {
        protected string matricula;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }


        protected string carrera;

        public string Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }

            public Alumno()
        {
            matricula = "";
            carrera = "";
        }

        public Alumno(string nombre, string fechanacimiento)
        {
            this.matricula = Matricula;
            this.carrera = Carrera;
        }

        public override string ToString()
        {
            return "matricula: " + matricula + "\n carrera: " + carrera;

        }
    }
}