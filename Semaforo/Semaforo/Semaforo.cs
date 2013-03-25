using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Semaforo
{
    class Semaforo
    {
        public int id { get; set; }
        public Point posicion { get; set; }
        public Point posicionCarroDetenido { get; set; }
        public Point posicionCarroFinal { get; set; }
        public int estado { get; set; }
        public bool visible { get; set; }
        public PictureBox imagen { get; set; }

        public Semaforo()
        {

        }

        public Semaforo(int id, Point pos)
        {
            this.id = id;
            this.posicion = pos;
        }

    }
}
