using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Semaforo
{
    class Carro
    {
        public Point posicionActual { get; set; }
        public Point posicionDestino { get; set; }
        public Point posicionInicial { get; set; }
        public int direccion { get; set; }
        public bool movimiento { get; set; }
        public bool visible { get; set; }
        public PictureBox imagen { get; set; }

        public Carro()
        {
        }

        public void moverse(Carro car, Point fin)
        {
            if(car.direccion==0)
            {
                while(fin.X >= car.posicionActual.X)
                    car.posicionActual = new Point(car.posicionActual.X + 1,car.posicionActual.Y);
            }
            else if (car.direccion == 0)
            {
                while (fin.X <= car.posicionActual.X)
                    car.posicionActual = new Point(car.posicionActual.X - 1, car.posicionActual.Y);
            }
            else if (car.direccion == 1)
            {
                while (fin.Y >= car.posicionActual.Y)
                    car.posicionActual = new Point(car.posicionActual.X, car.posicionActual.Y + 1);
            }
            else
            {
                while (fin.Y <= car.posicionActual.Y)
                    car.posicionActual = new Point(car.posicionActual.X, car.posicionActual.Y - 1);
            }
        }

        public void mostrar(Carro car)
        {
            car.visible = true;
        }

        public void ocultar(Carro car)
        {
            car.visible = false;
        }
    }
}
