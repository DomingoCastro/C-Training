using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOK.Models
{
    // POR DEFECTO, ESTA CLASE SOL OES VISIBLE PARA ESTE PROYECTO DEBIDO A INTERNAL.
    // CAMBIAMOS SU VISIBILIDAD A PUBLICA.

    //DECLARAMOS UNA ENUMERACION CON UNA SERIE DE VALORES
    public enum Paises {España,Francia, Argentina, Marruecos, Alemania }


    public class Persona
    {
        // LA PROPIEDAD SE DECLARA CON EL TIPO ENUMERADO (PAISES)
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private int _Edad;

        public int Edad
        {
            get
            {
                return _Edad;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
            }
        }
    }
}
