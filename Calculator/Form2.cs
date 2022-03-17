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
    public partial class MainForm : Form
    {
        public static float sum = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate('+',button1);
        }
        private async void Colorize(Button button)
        {
            
        }
        private async void Calculate(char symbol,Button button)
        {
            if (symbol == '+')
            {
             try
                { 
                string[] nums = textBox1.Text.Split('+');
                int prevsum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int sum2 = 0;
                    int.TryParse(nums[i],out sum2);
                    sum += sum2;
                    prevsum += sum2;
                    }
                    listBox1.Items.Add(textBox1.Text + "=" + sum);
                    System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 3;
                try
                    {
                        speech.SelectVoice("Microsoft Irina Desktop");
                        speech.SpeakAsync("Я нашла для вас сумму чисел, это " + prevsum + ". Общий результат: " + sum);
                    MessageBox.Show("Я нашла для вас сумму чисел, это " + prevsum + ". Общий результат: " + sum);
                }
                catch
                {
                    MessageBox.Show("Я нашла для вас сумму чисел, это " + prevsum + ". Общий результат: " + sum);
                }
            }
                catch
            {
                MessageBox.Show("Похоже, вы ввели что-то не так. Попробуйте еще раз!");
            }
        }
            else if (symbol == '-')
            {
             try
                { 
                string[] nums = textBox1.Text.Split('-');
                int prevsum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int sum2 = 0;
                    int.TryParse(nums[i], out sum2);
                    sum -= sum2;
                    prevsum -= sum2;
                }
                System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 3;
                    listBox1.Items.Add(textBox1.Text + "=" + sum);
                    try
                    {
                        speech.SelectVoice("Microsoft Irina Desktop");
                        speech.SpeakAsync("Я нашла для вас разницу чисел, это " + prevsum + ". Общий результат: " + sum);
                    MessageBox.Show("Я нашла для вас разницу чисел, это " + prevsum + ". Общий результат: " + sum);
                }
                catch
                {
                    MessageBox.Show("Я нашла для вас разницу чисел, это " + prevsum + ". Общий результат: " + sum);
                }

            }
                catch
            {
                MessageBox.Show("Похоже, вы ввели что-то не так. Попробуйте еще раз!");
            }
        }
            else if (symbol == '*')
            {
                try
                { 
                string[] nums = textBox1.Text.Split('*');
                int prevsum = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    int sum2 = 0;
                    int.TryParse(nums[i], out sum2);
                    sum *= sum2;
                    prevsum *= sum2;
                }
                System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 3;
                    listBox1.Items.Add(textBox1.Text + "=" + sum);
                    try
                    {
                        speech.SelectVoice("Microsoft Irina Desktop");
                        speech.SpeakAsync("Я нашла для вас добуток чисел, это " + prevsum + ". Общий результат: " + sum);
                    MessageBox.Show("Я нашла для вас добуток чисел, это " + prevsum + ". Общий результат: " + sum);
                }
                catch
                {
                    MessageBox.Show("Я нашла для вас добуток чисел, это " + prevsum + ". Общий результат: " + sum);
                }

            }
                catch
            {
                MessageBox.Show("Похоже, вы ввели что-то не так. Попробуйте еще раз!");
            }
        }
            else if(symbol == '/')
            {
                try
                {
                    string[] nums = textBox1.Text.Split('/');
                    int prevsum = 1;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        int sum2 = 0;
                        int.TryParse(nums[i], out sum2);
                        prevsum /= sum2;
                        sum /= sum2;
                    }
                    System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
                    speech.SetOutputToDefaultAudioDevice();
                    speech.Rate = 3;
                    listBox1.Items.Add(textBox1.Text + "=" + sum);
                    try
                    {
                        speech.SelectVoice("Microsoft Irina Desktop");
                        speech.SpeakAsync("Я нашла для вас деление чисел, это " + prevsum + ". Общий результат: " + sum);
                        MessageBox.Show("Я нашла для вас деление чисел, это " + prevsum + ". Общий результат: " + sum);
                    }
                    catch
                    {
                        MessageBox.Show("Я нашла для вас деление чисел, это " + prevsum + ". Общий результат: " + sum);
                    }
                }
                catch
                {
                    MessageBox.Show("Похоже, вы ввели что-то не так. Попробуйте еще раз!");
                }
            }
            Colorize(button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate('-',button2);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate('*',button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate('/',button3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.mainform = this;
            f3.lb = listBox1;
            f3.tb = textBox1;
            f3.Show();
        }
    }
}
