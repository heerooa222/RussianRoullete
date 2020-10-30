using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete
{
    public class Shoot
    {
        public int bulletfire { get; set; }
        public int away { get; set; }
        public int total { get; set; }
        public bool kill { get; set; }
        public int loss { get; set; }
        public int win { get; set; }
        public int ran { get; set; }
        public bool fire_button { get; set; }
        public bool spin_button { get; set; }
        public bool play_again_button { get; set; }

        public void spinner()
        {
            //this function will be able to choose numbers randomly
            Random rnd = new Random();
            ran = rnd.Next(1, 7);

            //once the bullet is fired the points should be reset again
            bulletfire = 0;
            away = 0;
        }
        public void fireaway()
        {
            kill = true;
        }
        public void calculate()
        {
            bulletfire++;
            if (bulletfire == ran || away == 2)
            {
                fire();
            }
            else
            {
                blank();
            }

        }
        public void fire()
        {
            //this statement is defining win or lose
            if (kill == true)
            {
                MessageBox.Show("Congratulation you are dead");
                loss++;
            }
            else
            {
                MessageBox.Show("why are you still alive?");
                win++;
            }
            total++;

            //once you triggered the fire button some of the button will be disabled so that it does not make a problem
            away = 0;
            fire_button = false;
            spin_button = false;
            play_again_button = true;
        }
        public void blank()
        {
            //we will define now if the chambers is empty.
            MessageBox.Show("Empty");
            fire_button = true;
            spin_button = false;           
        }
        public int awayadded(int away)
        {
            //if the player shoots away he will still be left with 2 chances
            int Awayplusplus = away + 1;
            if (kill == false)
            {
                return Awayplusplus;
            }
            else
            {
                return away;
            }


        }

    }
}
