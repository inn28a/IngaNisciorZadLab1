using System;
using System.Drawing;
using System.Windows.Forms;

namespace IngaNisciorZadLab1
{

    public partial class FormMain : Form
    {
        //licznik
        int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        String[] pictures ={"rocks.png" , "rope.png", "leaf.png", "axe.png", "squirrel.png" , "match.png",
            "knife.png", "cup.png", "fork.png", "ballon.png","money.png", "stick.png" };
        int actions = 0;
        Boolean clicked = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Przycisk przenoszacy na planszy w dol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBottom_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                ramdomItems();
                actions++;
            }

            if (!clicked)
            {
                buttonRight.Visible = false;
                buttonLeft.Visible = false;
                buttonBottom.Visible = false;
            }
            else
            {
                buttonRight.Visible = true;
                buttonLeft.Visible = true;
                buttonUp.Visible = true;
            }
            clicked = !clicked;

            
        }
        /// <summary>
        /// przycisk przenoszacy na planszy w gore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                ramdomItems();
                actions++;
            }
            
            if (!clicked)
            {
                buttonRight.Visible = false;
                buttonLeft.Visible = false;
                buttonUp.Visible = false;
            }
            else
            {
                buttonRight.Visible = true;
                buttonLeft.Visible = true;
                buttonBottom.Visible = true;
            }
            clicked = !clicked;


           
        }
        /// <summary>
        /// przycisk przenoszacy na planszy w prawo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                ramdomItems();
                actions++;
            }
            

            if (!clicked)
            {
                buttonRight.Visible = false;
                buttonBottom.Visible = false;
                buttonUp.Visible = false;
            }
            else
            {
                buttonLeft.Visible = true;
                buttonBottom.Visible = true;
                buttonUp.Visible = true;
            }
            clicked = !clicked;


            
        }
        /// <summary>
        /// przycisk przenoszacy na planszy w lewo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                ramdomItems();
                actions++;
            }

            if (!clicked)
            {
                buttonLeft.Visible = false;
                buttonBottom.Visible = false;
                buttonUp.Visible = false;
            }
            else
            {
                buttonRight.Visible = true;
                buttonBottom.Visible = true;
                buttonUp.Visible = true;
            }
            clicked = !clicked;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textTimer.Text = (timer1.Interval).ToString();
            timer1.Interval += 1;
            if ((timer1.Interval % 100) == 1)
            {
                ramdomItems();

            }
            if (actions >= 20)
            {
                endOfGameButton.Visible = true;
                timer1.Stop();
                if (endOfGame())
                {
                    endOfGameButton.Text = "WYGRALES";
                }
                else
                {
                    endOfGameButton.Text = "PRZEGRALES";
                }
            }
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {

            timer1.Interval = 1;
            timer1.Start();

            refreshList();
        }
        Random random = new Random(3000);
        private void ramdomItems()
        {
            int n = random.Next(2, 5);
            pictureBox1.Visible = (n >= 1);
            pictureBox2.Visible = (n >= 2);
            pictureBox3.Visible = (n >= 3);
            pictureBox4.Visible = (n >= 4);
            if (n >= 1)
            {
                int m = random.Next(0, 11);
                pictureBox1.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox1.Tag = pictures[m];
            }
            if (n >= 2)
            {
                int m = random.Next(0, 11);
                pictureBox2.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox2.Tag = pictures[m];

            }
            if (n >= 3)
            {
                int m = random.Next(0, 11);
                pictureBox3.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox3.Tag = pictures[m];
            }
            if (n >= 4)
            {
                int m = random.Next(0, 11);
                pictureBox4.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox4.Tag = pictures[m];
            }
        }
        public void takeItems(String nameOfItem)
        {
            int index = Array.IndexOf(pictures, nameOfItem);
            counter[index]++;
            refreshList();
            actions++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox2.Tag.ToString();
            takeItems(imageAdress);
            pictureBox2.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox4.Tag.ToString();
            takeItems(imageAdress);
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox3.Tag.ToString();
            takeItems(imageAdress);
            pictureBox3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox1.Tag.ToString();
            takeItems(imageAdress);
            pictureBox1.Visible = false;
        }

        private void listOfItemsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void refreshList()
        {
            string result = "";
            for (int i = 0; i < 12; i++)
            {
                result += pictures[i].Substring(0, pictures[i].Length - 4);
                result += " : " + counter[i] + '\n';
            }
            listOfItemsTextBox.Text = result;
        }
        private Boolean endOfGame()
        {
            int more = 0;
            string result = "\n Przedmioty przeciwnika:\n";
            for (int i = 0; i < 12; i++)
            {
                int enemy = random.Next(0, 4);
                result += pictures[i].Substring(0, pictures[i].Length - 4);
                result += " : " + enemy + '\n';
                if (counter[i] >= enemy)
                {
                    more++;
                }


            }
            listOfItemsTextBox.Text += result;
            if (more > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}

