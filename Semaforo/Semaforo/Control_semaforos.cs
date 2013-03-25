using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading;

namespace Semaforo
{
   public class Control_semaforos 
    {
        Thread semafororojo;
        Thread semaforoamarillo;
        Thread semaforoverde;
        public void Hilo1()
        {
            int i = 1;
            while (true)
            {
                //Thread.Sleep(200);
                if (i == 1)
                {
                    this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(400);
                    this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_verde;
                    i = 2;
                }
                if (i == 2)
                {
                    Thread.Sleep(800);
                    this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
                    this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    i = 1;
                }

            }
        }     
    }
}
