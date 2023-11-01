using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;                                         // Color de puntos(Balas)
using System.Windows.Forms;                                  // forma de los puntos del sistema de windows(balas)
                                                            //tt: Estas funciones se pusieron nuevas segun el video
namespace gamezombiesx
{
    class Bullet                                                  /*A bullets(balas) se le crea una clase publica y separada.
                                                                   Las variables asignadas de cadena y enteras se hacen publicas para
                                                                   poder acceder desde fuera de la clase, es decir para que podamos acceder a ellas con form1.cs*                                                                                                                                */
    {

        public string direction;                         //Cadena direction 
        public int bulletLeft;
        public int bulletTop;

        private int speed = 18;                         //timer, speed son privadas porque solo se ejecuran la clase misma Bullet.cs*
        private PictureBox bullet = new PictureBox();  //buller(pinturebox) sera para el color de la bala
        private Timer bulletTimer = new Timer();      //bullerTimer sera para el temporizador de la bala


        public void MakeBullet(Form form) // Se crea un formulario(Form)asociado al código que se genera de forma automática
                                          // cada vez que se añade un botón para crear una acción o una etiqueta

        //CREACION DE EL COLOR, TAMAÑO, ETIQUETA DE LA BALA
        {
            bullet.BackColor = Color.White;  
            bullet.Size = new Size(5, 5);  
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bullet.Top;
            bullet.BringToFront();

            form.Controls.Add(bullet);


            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }

        private void BulletTimerEvent(object sender, EventArgs e)  //(Evento privado)

        //MOVER BALA(DIRECCION DE LA BALA)
        {
            if (direction == "Left")      //Si direccion = izquierda entonces bulletLeft-=speed                                     
            {
                bulletLeft -= speed;
            }
            if (direction == "Rigth")
            {
                bulletLeft += speed;
            }
            if (direction == "Up")
            {
                bulletTop -= speed;
            }
            if (direction == "Down")
            {
                bulletTop += speed;
            }

            /*  LIMITES DE LA BALA, TEMPORIZADOR LIMITE DE LA BALA, 
              Aplicamos la condicion (if) NUEVAMENTE
             
               */

            /* Con esta funcion eliminamos el temporizador de la bala y la bala
              del lado izquierdo tiene un limite de 10, es decir que la bala tiene que
            tener distancia de 10 de recorrido. (Bulleleft) tiene que ser menor que diez
            al disparar la bala en un estado innercial de 0 (BulletTop) la bala tiene que
            tener una distancia menor que 10.¡¡ASI LO ENTENDI YO¡¡ La medida del cuadro del juego es de 900,700
             pero yo la cambie varia veces a como se vea mejor */



            if (bullet.Left < 10 || bullet.Left < 860 || bullet.Top < 10 || bullet.Top < 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;

            }
        } 
    }
}