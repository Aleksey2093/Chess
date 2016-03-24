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
            for (int j = 0; j < 8; j++)
                for (int i = 0; i < 8; i++)
                {
                    pic[i, j] = new PictureBox();
                    doska[i, j] = false;
                    doska_who[i, j] = 0;
                    if ((i + j) % 2 == 0) { pic[i, j].BackColor = Color.White; }
                    else { pic[i, j].BackColor = Color.Black; }
                    pic[i, j].Dock = DockStyle.Fill;
                    pic[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    tableLayoutPanel2Доска.Controls.Add(pic[i, j], j, i);
                }
            label_hod_gamer_now.Text = "";
            label_type_game.Text = "";
        }

        public static bool local_game = true; //если правда локальная игра, если нет то сетевая
        public static bool hod_now = true; //правда белые, ложь черные
        public static bool gamer = true; //игрок играет за белые если правда, если ложь то за черные
        public static bool pause = false; //переменная для сетевой игры, отвечает за паузу во время игры
        public static PictureBox[,] pic = new PictureBox[8,8];
        public static bool[,] doska = new bool[8, 8];
        public static int[,] doska_who = new int[8, 8];

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
            /*
            0 1 2 3 4 5 6 7
            1
            2
            3
            4
            5
            6
            7
            */
            //растановка черных
            pic[0, 0].Image = pic[0, 7].Image = Properties.Resources.black__1_; doska[0, 0] = doska[0, 7] = true;
            pic[0, 1].Image = pic[0, 6].Image = Properties.Resources.black__2_; doska[0, 1] = doska[0, 6] = true;
            pic[0, 2].Image = pic[0, 5].Image = Properties.Resources.black__3_; doska[0, 2] = doska[0, 5] = true;
            pic[0, 3].Image = Properties.Resources.black__4_; doska[0, 3] = true;
            pic[0, 4].Image = Properties.Resources.black__5_; doska[0, 4] = true;
            for (int i = 0; i < 8; i++)
            {
                doska[1, i] = true;
                pic[1, i].Image = Properties.Resources.black__6_;
            }

            //расстановка белых
            pic[7, 0].Image = pic[7, 7].Image = Properties.Resources.white__1_; doska[7, 0] = doska[7, 7] = true;
            pic[7, 1].Image = pic[7, 6].Image = Properties.Resources.white__2_; doska[7, 1] = doska[7, 6] = true;
            pic[7, 2].Image = pic[7, 5].Image = Properties.Resources.white__3_; doska[7, 2] = doska[7, 5] = true;
            pic[7, 3].Image = Properties.Resources.white__4_; doska[7, 3] = true;
            pic[7, 4].Image = Properties.Resources.white__5_; doska[7, 4] = true;
            for (int i = 0; i < 8; i++)
            {
                doska[6, i] = true;
                pic[6, i].Image = Properties.Resources.white__6_;
            }
        }

        private void одинИгрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В настоящий момент одиночная игра недоступна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void дваИгрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_game_расстановка();
            label_type_game.Text = "Локальная игра. Два игрока.";
            label_hod_gamer_now.Text = "Сейчас ходят белые.";
            local_game = true;
            hod_now = true;
            //не учитывается переменная gamer;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В настоящий момент сетевая игра недоступна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //new_game_расстановка();
        }

        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В настоящий момент сетевая игра недоступна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //new_game_расстановка();
        }

        private void tableLayoutPanel2Доска_MouseEnter(object sender, EventArgs e)
        {
            int cursorX = Cursor.Position.X, cursorY = Cursor.Position.Y;
            int[] widths = tableLayoutPanel2Доска.GetColumnWidths();
            int[] heights = tableLayoutPanel2Доска.GetRowHeights();
            int ugolX = tableLayoutPanel2Доска.Location.X + this.Location.X, ugolY = tableLayoutPanel2Доска.Location.Y;

            int col = -1, row = -1;
            
            for (int i=0; i < widths.Length; i++)
            {
                if (ugolX < cursorX)
                {

                }
            }

            if (row != -1 && col != -1 && doska[row,col])
            {
                pic[row, col].BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
