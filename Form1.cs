using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reproductor_VLC_WF_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta de la carpeta seleccionada
                string selectedPath = folderDialog.SelectedPath;

                // Crear carpetas para cada tipo de archivo si no existen
                string imagesFolder = Path.Combine(selectedPath, "Imágenes");
                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string videosFolder = Path.Combine(selectedPath, "Videos");
                if (!Directory.Exists(videosFolder))
                {
                    Directory.CreateDirectory(videosFolder);
                }

                string musicFolder = Path.Combine(selectedPath, "Música");
                if (!Directory.Exists(musicFolder))
                {
                    Directory.CreateDirectory(musicFolder);
                }

                string otherFolder = Path.Combine(selectedPath, "Otros");
                if (!Directory.Exists(otherFolder))
                {
                    Directory.CreateDirectory(otherFolder);
                }
                // Obtener una lista de todos los archivos en la carpeta seleccionada
                string[] files = Directory.GetFiles(selectedPath);

                // Mover los archivos a las carpetas correspondientes
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    string fileName = Path.GetFileName(file);

                    if (extension.Equals(".jpg") || extension.Equals(".jpeg") || extension.Equals(".png") || extension.Equals(".gif"))
                    {
                        string destFile = Path.Combine(imagesFolder, fileName);
                        File.Move(file, destFile);
                    }
                    else if (extension.Equals(".mp4") || extension.Equals(".avi") || extension.Equals(".mov") || extension.Equals(".wmv"))
                    {
                        string destFile = Path.Combine(videosFolder, fileName);
                        File.Move(file, destFile);
                    }
                    else if (extension.Equals(".mp3") || extension.Equals(".wav") || extension.Equals(".flac"))
                    {
                        string destFile = Path.Combine(musicFolder, fileName);
                        File.Move(file, destFile);
                    }
                    else  
                    {
                        string destFile = Path.Combine(otherFolder, fileName);
                        File.Move(file, destFile);
                    }
                }
            }

        
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos multimedia|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    string filePath = openFileDialog.FileName;
                    
                    vlcControl1.Play(new Uri(filePath));
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "Pause")
            {
                vlcControl1.Pause();
                btnPlay.Text = "Play";
            }
            else if (btnPlay.Text == "Play")
            {
                vlcControl1.Play();
                btnPlay.Text = "Pause";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = trackBar1.Value * 10;
        }
    }
}
