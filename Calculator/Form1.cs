using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private async void LoadScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            float a = 0;
            while(a<1)
            {
                a += 0.01f;
                this.Opacity = a;
                await Task.Run(() => {
                    Task.Delay(2);
                });
            }
            await Task.Delay(200);
            label2.Text = "модуль речи";
            await Task.Delay(800);
            progressBar1.Value = 34;
            label2.Text = "основное меню";
            await Task.Delay(500);
            progressBar1.Value = 100;
            label1.Visible = false;
            label2.Text = "Запуск...";
            await Task.Delay(500);
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }
    }
}
