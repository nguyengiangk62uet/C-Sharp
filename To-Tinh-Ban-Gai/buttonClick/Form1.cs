using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Width = 450;
            this.Height = 450;
            playSimpleSound();
        }
        public void playSimpleSound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\C#\buttonClick\buttonClick\Sound\lol.wav");
            sound.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
