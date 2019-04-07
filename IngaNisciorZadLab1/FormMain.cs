using System;
using System.Drawing;
using System.Windows.Forms;

namespace IngaNisciorZadLab1
{

    public partial class FormMain : Form
    {
        //licznik przedmiotow
        int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //nazwy obrazkow
        String[] pictures ={"rocks.png" , "rope.png", "leaf.png", "axe.png", "squirrel.png" , "match.png",
            "knife.png", "cup.png", "fork.png", "ballon.png","money.png", "stick.png" };
        //ilosc akcji wykonanych przez uzytkownika, jedno przejscie na planszy lub jedno podniesienie przedmiotu
        int actions = 0;
        // czy gracz znajduje sie na planszy glownej
        Boolean clicked = false;
        // zmienna uzywana do losowania warunkow
        Random random = new Random(3000);
        
        public FormMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// przycisk uruchamiajacy gre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {

            timer1.Interval = 1;
            timer1.Start();

            RefreshList();
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
                RamdomItems();
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
                RamdomItems();
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
                RamdomItems();
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
                RamdomItems();
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
        /// <summary>
        /// akcje wykonywane przy zmianie czasu np. odswiezanie wyswietlanego czasu, losowanie przedmiotow co 10 sekund, sprawdzanie limitu akcji i warunkow zakonczenia gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            textTimer.Text = (timer1.Interval).ToString();
            timer1.Interval += 1;
            if ((timer1.Interval % 100) == 1)
            {
                RamdomItems();

            }
            if (actions >= 20)
            {
                endOfGameButton.Visible = true;
                timer1.Stop();
                if (EndOfGame())
                {
                    endOfGameButton.Text = "WYGRALES";
                }
                else
                {
                    endOfGameButton.Text = "PRZEGRALES";
                }
            }
        }
        
        /// <summary>
        /// losowanie ilosci wyswietlanych przedmiotow na planszy i ich typu
        /// </summary>
        private void RamdomItems()
        {
            // losowanie ilosci i ukrywanie elementow
            int n = random.Next(2, 5);
            pictureBox1.Visible = (n >= 1);
            pictureBox2.Visible = (n >= 2);
            pictureBox3.Visible = (n >= 3);
            pictureBox4.Visible = (n >= 4);
            if (n >= 1)
            {
                // losowanie typu 
                int m = random.Next(0, 11);
                pictureBox1.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox1.Tag = pictures[m];
            }
            if (n >= 2)
            {
                // losowanie typu 
                int m = random.Next(0, 11);
                pictureBox2.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox2.Tag = pictures[m];

            }
            if (n >= 3)
            {
                // losowanie typu 
                int m = random.Next(0, 11);
                pictureBox3.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox3.Tag = pictures[m];
            }
            if (n >= 4)
            {
                // losowanie typu 
                int m = random.Next(0, 11);
                pictureBox4.Image = Image.FromFile(@"..\..\Pictures\" + pictures[m]);
                pictureBox4.Tag = pictures[m];
            }
        }
        /// <summary>
        /// podnoszenie przedmiotow z planszy
        /// </summary>
        /// <param name="nameOfItem"></param>
        public void TakeItems(String nameOfItem)
        {
            //znajdywnie przedmiotow w liscie 
            int index = Array.IndexOf(pictures, nameOfItem);
            // dodawanie ilosci znajdywanych przedmiotpw konkretnego typu
            counter[index]++;
            RefreshList();
            actions++;
        }
        /// <summary>
        /// podnoszenie pierwszego przedmiotu (lewy gorny rog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox1.Tag.ToString();
            TakeItems(imageAdress);
            pictureBox1.Visible = false;
        }
        /// <summary>
        /// podnoszenie pierwszego przedmiotu (prawy gorny rog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox2.Tag.ToString();
            TakeItems(imageAdress);
            pictureBox2.Visible = false;

        }
        /// <summary>
        /// podnoszenie pierwszego przedmiotu (lewy dolny rog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox3.Tag.ToString();
            TakeItems(imageAdress);
            pictureBox3.Visible = false;
        }
        /// <summary>
        /// podnoszenie pierwszego przedmiotu (prawy dolny rog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string imageAdress = pictureBox4.Tag.ToString();
            TakeItems(imageAdress);
            pictureBox4.Visible = false;
        }




        
        /// <summary>
        /// wypelnianie texboxu lista przedmiotow gracza
        /// </summary>
        private void RefreshList()
        {
            string result = "";
            for (int i = 0; i < 12; i++)
            {
                result += pictures[i].Substring(0, pictures[i].Length - 4);
                result += " : " + counter[i] + '\n';
            }
            listOfItemsTextBox.Text = result;
        }
        /// <summary>
        /// losuje przedmioty przeciwnika. Zwraca true jezeli ma 5 lub wiecej przedmiotow danego typu wiecej lub rowno od przeciwnika
        /// </summary>
        /// <returns></returns>
        private Boolean EndOfGame()
        {
            int more = 0;
            string result = "\n Przedmioty przeciwnika:\n";
            for (int i = 0; i < 12; i++)
            {
                int enemy = random.Next(0, 4);
                // dziele slowo na substring aby wyciac koncuwke .png
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

