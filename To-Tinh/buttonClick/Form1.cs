using System;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace buttonClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetVisibleCore(true);

            // Fixed cứng form
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.MaximizeBox = false;
            this.Width = 450;
            this.Height = 450;

            // Chạy nhạc khi bật
            playSimpleSound();
        }

        // Hàm chạy nhạc
        public void playSimpleSound()
        {
            string path = (Assembly.GetEntryAssembly().Location + "");
            path = path.Replace("name space", "filename.--");

            // [buttonClick] is name space 
            // You should copy your "mysound.wav" into Debug file 
            string path_sound = (Assembly.GetEntryAssembly().Location + "");
            path_sound = path_sound.Replace("buttonClick.exe", "lol.wav");

            SoundPlayer player1 = new SoundPlayer(path_sound);
            player1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu button chạm border thì set lại vị trí
            if (button1.Location.X > 100 && button1.Location.X < this.Height - 100 &&
                button1.Location.Y > 100 && button1.Location.Y < this.Width - 100)
            {
                button1.Location = new Point(button1.Location.X - new Random().Next(-50, 100), button1.Location.Y - new Random().Next(-50, 100));

            } else
            {
                button1.Location = new Point(new Random().Next(100, 300), new Random().Next(100, 300));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Button Yes
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            result = MessageBox.Show(this, "Chắc chắn không?", "Ha ha", buttons);
            while (result != DialogResult.Yes)
            {
                result = MessageBox.Show(this, "Em chắc chắn chứ?", "Ha ha", buttons);
            }
            MessageBox.Show(this, "Em bị lừa rồi! Còn lâu anh mới yêu em", "Lêu lêu");
        }
    }
}

