using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;         //Libreria activada para musica

namespace gamezombiesx
{
    
    public partial class Form1 : Form

    {


        SoundPlayer sonido = new SoundPlayer(@"d:\sonido\Damnded2.wav");
        public Form1()
        {
            InitializeComponent();
            //sonido.Play();
            
        }



        /*ASIGNACION DE LAS VARIABLES
         = Le asigne al movimiento del player, arriba,abajo,izquierda,derecha,gameOver.( Variable Tipo Booleano)
         = le asigne a la salud,velocidad,balas,velocidades de zombies, puntaje. (variable Tipo Entero)
        */
        bool goLeft, goRight, goUp, goDown, gameOver;
        String facing = "up";    // Esta variable tipo cadena. Establese la cara del player "Up" en predeterminado
        int playerHealth = 100;
        int speed = 10;
        int bala = 10;
        int speedZombies = 3;
        Random randNum = new Random();
        int score;
        List<PictureBox> zombiesList = new List<PictureBox>(); //Esta funcion nos permite crear una imagen agrupada de los zombies al azar 
        



        private void MainTimerEvent(object sender, EventArgs e)

            //CONDISIONALES IF - ELSE DE, SALUD, KILLS, MUNICION, BALAS
        {
            if (playerHealth > 1)  //si la salud del jugador es menor a 1 entonces, el progresoSalud=SaludDelJugador
            {
                progresosalud.Value = playerHealth; 
            }
            else                       //De otro modo, GameOver. Porque la salud del jugador seria 0 (playerHealth < 1)
            {
                gameOver = true;
            }
            txtmuni.Text = "Municion:" + bala;
            txtkills.Text = "Kills:" + score;

            //MOVIMIENTO DEL JUGADOR / ME GUIE EN EL JUEGO DE LA RANA
            

            if (goLeft == true && player.Left > 0) 
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)  //Izquierda,derecha:Width;ancho
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 45)                              //40 GoUp para que me permita ver la municion, kills,salud
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)//Arriba,abajo:Height;largo(altura)
            {
                player.Top += speed;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)

        {    /* Si se cumple la condicion de (if) GoLeft Es verdadera entonces, la cadena cara(Facing) sera left
              por lo tanto se realizara el cambio de imagen asignado al jugador, en este caso, player
            */ 
             //DIRECCIONAMIENTO de imagen DEL JUGADOR
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "Left";
                player.Image = Properties.Resources.left;     
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "Right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "Up";
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "Down";
                player.Image = Properties.Resources.down;
            }
        }

        private void KeyIsPress(object sender, KeyPressEventArgs e)
        {

        }


        private void KeyIsUp(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
              
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
              
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
              
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;           
            }
            if (e.KeyCode == Keys.Space)
            {
                ShootBullet(facing);
            }
        }

         public void ShootBullet(String direction)
        // DISPARAR BALA, la parte mas dificil. (LO Explicare Como Lo Entendi)
        /* En la clase (Bullet), en la cual string direction;  int bulletLeft;  int bulletTop;                   
         son publicas lo cual podemos acceder a ellas desde la clase Principal (Form1)
         Asi que primeramente enlazo dispararBala con las direccion, y shooBulletLeft que seria igual a la direccion del
        jugador(player)izquierda y player.top esto dividido por 2 para que el disparo se origine desde el centro del jugador
        de la parte izquierda
                                                */
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletLeft = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void Mainzombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Top = randNum.Next(0, 900);
            zombie.Left = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;  
            zombiesList.Add(zombie);  
            player.BringToFront();   //Traer al frente

        }
        

        private void Reiniciogame()
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


        
       
}
