
namespace gamezombiesx
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtmuni = new System.Windows.Forms.Label();
            this.txtkills = new System.Windows.Forms.Label();
            this.txvida = new System.Windows.Forms.Label();
            this.fecristo1 = new System.Windows.Forms.ProgressBar();
            this.Fe = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progresosalud = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmuni
            // 
            this.txtmuni.AutoSize = true;
            this.txtmuni.ForeColor = System.Drawing.Color.DarkRed;
            this.txtmuni.Location = new System.Drawing.Point(46, 9);
            this.txtmuni.Name = "txtmuni";
            this.txtmuni.Size = new System.Drawing.Size(143, 24);
            this.txtmuni.TabIndex = 0;
            this.txtmuni.Text = "Municion: 0";
            // 
            // txtkills
            // 
            this.txtkills.AutoSize = true;
            this.txtkills.ForeColor = System.Drawing.Color.DarkRed;
            this.txtkills.Location = new System.Drawing.Point(388, 9);
            this.txtkills.Name = "txtkills";
            this.txtkills.Size = new System.Drawing.Size(89, 24);
            this.txtkills.TabIndex = 1;
            this.txtkills.Text = "Kills: 0";
            // 
            // txvida
            // 
            this.txvida.AutoSize = true;
            this.txvida.ForeColor = System.Drawing.Color.DarkRed;
            this.txvida.Location = new System.Drawing.Point(668, 6);
            this.txvida.Name = "txvida";
            this.txvida.Size = new System.Drawing.Size(70, 24);
            this.txvida.TabIndex = 2;
            this.txvida.Text = "Vida:";
            this.txvida.Click += new System.EventHandler(this.label1_Click);
            // 
            // fecristo1
            // 
            this.fecristo1.BackColor = System.Drawing.Color.Yellow;
            this.fecristo1.ForeColor = System.Drawing.Color.Yellow;
            this.fecristo1.Location = new System.Drawing.Point(744, 38);
            this.fecristo1.Name = "fecristo1";
            this.fecristo1.Size = new System.Drawing.Size(168, 23);
            this.fecristo1.TabIndex = 4;
            this.fecristo1.Value = 100;
            // 
            // Fe
            // 
            this.Fe.AutoSize = true;
            this.Fe.ForeColor = System.Drawing.Color.DarkRed;
            this.Fe.Location = new System.Drawing.Point(668, 38);
            this.Fe.Name = "Fe";
            this.Fe.Size = new System.Drawing.Size(146, 24);
            this.Fe.TabIndex = 5;
            this.Fe.Text = "Fe en cristo:";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::gamezombiesx.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(408, 322);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(69, 66);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // progresosalud
            // 
            this.progresosalud.Location = new System.Drawing.Point(744, 9);
            this.progresosalud.Name = "progresosalud";
            this.progresosalud.Size = new System.Drawing.Size(168, 23);
            this.progresosalud.TabIndex = 7;
            this.progresosalud.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.progresosalud);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Fe);
            this.Controls.Add(this.fecristo1);
            this.Controls.Add(this.txvida);
            this.Controls.Add(this.txtkills);
            this.Controls.Add(this.txtmuni);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Form1";
            this.Text = "Zombies";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtmuni;
        private System.Windows.Forms.Label txtkills;
        private System.Windows.Forms.Label txvida;
        private System.Windows.Forms.ProgressBar fecristo1;
        private System.Windows.Forms.Label Fe;
        private System.Windows.Forms.PictureBox player;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progresosalud;
    }
}

