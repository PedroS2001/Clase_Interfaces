using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : ICazador
    {
        private string nombre;
        int edad;
        public string Cazador()
        {
            return "Voy con la escopeta";
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;   
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Edad: {this.edad}";
        }

    }
}
