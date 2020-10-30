using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete
{
    public partial class Form1 : Form
    {
        Shoot myCalc = new Shoot();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.shoot;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.fire1);
            audio.Play();
            myCalc.fire();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.reload;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.reload2);
            audio.Play();
        }

        private void play_again_button_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources.play;
            spin_button.Enabled = true;
            fire_button.Enabled = false;
            load_button.Enabled = true;

        
        }

        private void spin_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.spin;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.spin1);
            audio.Play();

            //this will run the the spinner class
            myCalc.spinner();
            label3.Text = myCalc.ran.ToString();
            lbl_bullets_fired.Text = myCalc.bulletfire.ToString();
            //once you click the spin button the shooting button will be enable
            fire_button.Enabled = true;
            spin_button.Enabled = false;



        }

        private void randon_number_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void win_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
