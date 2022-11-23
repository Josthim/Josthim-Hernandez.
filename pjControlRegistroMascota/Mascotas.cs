using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjControlRegistroMascota
{
    internal class Mascotas : Object
    {
        private string nombredeMascotas;

        private string colorPelo;

        private int edadMascota;

        private int costoMascota;

        private string razaMascota;

        public Mascotas(string nombre, string color, int edad,
            int costo, string raza)
            {
                nombredeMascotas = nombre;
                    colorPelo = color;
                edadMascota = edad;
                costoMascota = costo;
                razaMascota = raza;
            }

            public string NombredeMascotas
            {
                get
                {
                    return nombredeMascotas;
                }
            }

            public string ColorPelo
            {
                get
                {
                    return colorPelo;
                }
            }

            public int EdadMascota
            {
                get
                {
                    return edadMascota;
                }
            }

            public int CostoMascotas
            {
                get
                {
                    return costoMascota;
                }

            }

            public string RazaMascota
            {
                get
                {
                    return razaMascota;
                }

            }

        

    }
}
