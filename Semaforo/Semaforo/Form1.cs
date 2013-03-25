using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Semaforo
{
    public partial class Form1 : Form
    {
        Thread semaforo;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void Inicializar()
        {
            Application.DoEvents();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            semaforo = new Thread(new ThreadStart(Hilo1));
            semaforo.Start();

        }
        public void Hilo1()
        {
            int i = 1;
            while (true)
            {
                //Thread.Sleep(200);


                //semaforo avenidas(1)
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_verde;
                //semaforo avenidas(2)
                this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_verde;
                Thread.Sleep(400);
                //semaforo calles
                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_rojo;
                Thread.Sleep(800);


              
                    this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    //semaforo avenidas(2)
                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(400);
                    //semaforo calles
                    this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
                   
                
          
                //semaforo.Abort();
            }           
        }
 
    }

}
