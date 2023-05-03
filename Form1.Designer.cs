namespace Reproductor_VLC_WF_CSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnVerArchivo = new System.Windows.Forms.Button();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(62, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 33);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Location = new System.Drawing.Point(644, 2);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(94, 33);
            this.btnVerArchivo.TabIndex = 1;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(94, 41);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(616, 349);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 2;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.Click += new System.EventHandler(this.vlcControl1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(62, 396);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(109, 42);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(644, 396);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 42);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(324, 396);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnVerArchivo;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

