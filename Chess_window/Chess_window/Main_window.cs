using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_window
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    pic[i, j].Parent = (Control)tableLayoutPanel2Доска;
                    pic[i, j].Dock = DockStyle.Fill;
                    if ((i + j) % 2 == 0) { pic[i, j].BackColor = Color.White; }
                    else { pic[i, j].BackColor = Color.Black; }
                }
        }

        bool hod_now = true; //правда белые, ложь черные
        bool gamer = true; //игрок играет за белые если правда, если ложь то за черные
        PictureBox[,] pic = new PictureBox[8,8];
        bool[,] doska = new bool[8, 8];

        private void new_game_расстановка()
        {
            /*поле
            0 1 2 3 4 5 6 7
            8 9 10 11 12 13 14 15
            16 17 18 19 20 21 22 23
            24 25 26 27 28 29 30 31
            32 33 34 35 36 37 38 39
            40 41 42 43 44 45 46 47
            48 49 50 51 52 53 54 55
            56 57 58 59 60 61 62 63*/
            //растановка черных
            Bitmap a = new Bitmap(10,10, System.Drawing.Imaging.PixelFormat.Alpha);
            a.SetPixel(1,1,Color.AliceBlue);
        }

        

        private void одинИгрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В настоящий момент одиночная игра недоступна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void дваИгрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_game_расстановка();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_game_расстановка();
        }

        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_game_расстановка();
        }
    }
}
