using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game4
{
    public partial class Form1_load : Form
    {
        Image[] diceImage;
        int[] dice;
        Random rand = new Random();
        int AcccountBal = 1000;


        public Form1_load()
        {

            InitializeComponent();


            diceImage = new Image[7];
            diceImage[0] = Properties.Resources.dice_blank;
            diceImage[1] = Properties.Resources.dice_1;
            diceImage[2] = Properties.Resources.dice_2;
            diceImage[3] = Properties.Resources.dice_3;
            diceImage[4] = Properties.Resources.dice_4;
            diceImage[5] = Properties.Resources.dice_5;
            diceImage[6] = Properties.Resources.dice_6;

            dice = new int[4] { 0, 0, 0, 0 };


        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Betdice();
            
        }
        private void Rolldice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
            }
            lab_dice1.Image = diceImage[dice[0]];
            lab_dice2.Image = diceImage[dice[1]];
            lab_dice3.Image = diceImage[dice[2]];
            lab_dice4.Image = diceImage[dice[3]];
           
        }



        private void getdiceResult()
        {
            //check for 2 chance

            for (int i = 0; i < 4; i++)
            {
                if (dice[0] == dice[3] || dice[0] == dice[2] || dice[0] == dice[1] || dice[1] == dice[2] || dice[1] == dice[3] || dice[2] == dice[3])
                {

                    displayResult.Text = "Two Matches";

                }

            }


            //checking 3 matches 
            for (int m = 0; m < 4; m++)
            {

                if (dice[0] == dice[1] && dice[1] == dice[2])
                {
                    displayResult.Text = "Three Matches";

                }

                else if (dice[3] == dice[2] && dice[3] == dice[1])
                {
                    displayResult.Text = "Three Matches";

                }
                else if (dice[3] == dice[2] && dice[2] == dice[0])
                {
                    displayResult.Text = "Three Matches";

                }
                else if (dice[0] == dice[1] && dice[1] == dice[3])
                {
                    displayResult.Text = "Three Matches";

                }


            }
            //cheking for four matches 
            for (int n = 0; n < 4; n++)
            {
                if ((dice[0] == dice[1] && dice[1] == dice[2]) && (dice[0] == dice[3] && dice[2] == dice[3]))
                {
                    displayResult.Text = "Four matches";

                }

            }

            //cheking no matches 
            for (int k = 0; k < 4; k++)
            {

                if (dice[0] != dice[1] && dice[1] != dice[2] && dice[2] != dice[3] && dice[1] != dice[3] && dice[0] != dice[2] && dice[0] != dice[3])
                {

                    displayResult.Text = "No matches";

                }

            }

        }
        private void Betdice()
        {



            if (lab_bet4.Checked == true)
            {
                int betMoney_four;


                if (!int.TryParse(betamt_4.Text, out betMoney_four))
                {

                    return;
                }


                if (betMoney_four > AcccountBal)
                {
                    MessageBox.Show("Sorry You Don't Have Enough Money for Betting ");

                    return;
                }

                AcccountBal = AcccountBal - betMoney_four;
                Rolldice();
                getdiceResult();



                if ((dice[0] == dice[1] && dice[1] == dice[2]) && (dice[0] == dice[3] && dice[2] == dice[3]))
                {

                    display_bet_result.Text = "You Win";
                    //AcccountBal = AcccountBal - betMoney_four;
                    int betwin_4 = betMoney_four * 4;
                    winamt_display.Text = betwin_4.ToString();
                    AcccountBal = AcccountBal + betwin_4;
                    account_balance.Text = AcccountBal.ToString();
                    betamt_4.Text = string.Empty;
                   
                }
                else
                {
                    display_bet_result.Text = "You Lose";
                    //AcccountBal = AcccountBal - betMoney_four;
                    int betlose_4 = betMoney_four;
                    winamt_display.Text = betMoney_four.ToString();
                    account_balance.Text = AcccountBal.ToString();
                    betamt_4.Text = string.Empty;

                }

            }




            if (lab_bet3.Checked == true)
            {
                int betMoney_three;

                if (!int.TryParse(betamt_3.Text, out betMoney_three))
                {
                    return;
                }
                if (betMoney_three > AcccountBal)
                {

                 MessageBox.Show("Sorry You Don't Have Enough Money for This Betting ");
                       

                    return;
                }

                AcccountBal = AcccountBal - betMoney_three;
                Rolldice();
                getdiceResult();

                if (dice[0] == dice[1] && dice[1] == dice[2])
                {

                    display_bet_result.Text = "You win";

                    int betwin_3 = betMoney_three * 3;
                    winamt_display.Text = betwin_3.ToString();
                    AcccountBal = AcccountBal + betwin_3;
                    account_balance.Text = AcccountBal.ToString();
                    betamt_3.Text = string.Empty;
                }

                else if (dice[3] == dice[2] && dice[3] == dice[1])
                {

                    display_bet_result.Text = "You win";
                    int betwin_3 = betMoney_three * 3;
                    winamt_display.Text = betwin_3.ToString();
                    AcccountBal = AcccountBal + betwin_3;
                    account_balance.Text = AcccountBal.ToString();
                    betamt_3.Text = string.Empty;

                }
                else if (dice[3] == dice[2] && dice[2] == dice[0])
                {
                    display_bet_result.Text = "You win";
                    int betwin_3 = betMoney_three * 3;
                    winamt_display.Text = betwin_3.ToString();
                    AcccountBal = AcccountBal + betwin_3;
                    account_balance.Text = AcccountBal.ToString();
                    betamt_3.Text = string.Empty;
                }
                else if (dice[0] == dice[1] && dice[1] == dice[3])
                {
                    display_bet_result.Text = "You win";
                    int betwin_3 = betMoney_three * 3;
                    winamt_display.Text = betwin_3.ToString();
                    AcccountBal = AcccountBal + betwin_3;
                    account_balance.Text = AcccountBal.ToString();
                    betamt_3.Text = string.Empty;
                }
                else
                {


                    display_bet_result.Text = "You Lose";
                    int betlose_3 = betMoney_three;
                    winamt_display.Text = betMoney_three.ToString();
                    account_balance.Text = AcccountBal.ToString();
                    betamt_3.Text = string.Empty;

                }


            }
            if (lab_bet2.Checked == true)
            {
                int betMoney_two;

                if (!int.TryParse(betamt_2.Text, out betMoney_two))
                {
                    return;
                }
                if (betMoney_two > AcccountBal)
                {
                    MessageBox.Show("Sorry You Don't Have Money for Betting ");

                    return;
                }

                AcccountBal = AcccountBal - betMoney_two;

                Rolldice();
                getdiceResult();
               


                    if (dice[0] == dice[3] || dice[0] == dice[2] || dice[0] == dice[1] || dice[1] == dice[2] || dice[1] == dice[3] || dice[2] == dice[3])
                    {
                        if ((dice[0] == dice[1] && dice[1] == dice[2]) || (dice[3] == dice[2] && dice[3] == dice[1]) || (dice[3] == dice[2] && dice[2] == dice[0]) || (dice[0] == dice[1] && dice[1] == dice[3]))
                        {


                            display_bet_result.Text = "You Lose";
                            int betlose_2 = betMoney_two;
                            winamt_display.Text = betMoney_two.ToString();
                            account_balance.Text = AcccountBal.ToString();
                            betamt_2.Text = string.Empty;


                        }

                        else
                        {

                            display_bet_result.Text = "You win";
                            int betwin_2 = betMoney_two *2;
                            winamt_display.Text = betwin_2.ToString();
                            AcccountBal = AcccountBal + betwin_2;
                            account_balance.Text = AcccountBal.ToString();
                            betamt_2.Text = string.Empty;
                        }


                    }

                    else
                    {
                        display_bet_result.Text = "You Lose";
                        int betlose_2 = betMoney_two;
                        winamt_display.Text = betMoney_two.ToString();
                        account_balance.Text = AcccountBal.ToString();
                        betamt_2.Text = string.Empty;
                    }
            }
        

                    if (lab_bet0.Checked == true)
                    {
                        int betMoney_zero;

                        if (!int.TryParse(betamt_0.Text, out betMoney_zero))
                        {

                            return;
                        }


                        if (betMoney_zero > AcccountBal)
                        {
                            MessageBox.Show("Sorry You Don't Have Money for Betting ");

                            return;
                        }

                        AcccountBal = AcccountBal - betMoney_zero;
                        Rolldice();
                        getdiceResult();


                        if (dice[0] != dice[1] && dice[1] != dice[2] && dice[2] != dice[3] && dice[1] != dice[3] && dice[0] != dice[2] && dice[0] != dice[3])
                        {


                            display_bet_result.Text = "You win";
                            int betwin_0 = betMoney_zero * 1;
                            winamt_display.Text = betwin_0.ToString();
                            AcccountBal = AcccountBal + betwin_0;
                            account_balance.Text = AcccountBal.ToString();
                            betamt_0.Text = string.Empty;
                        }
                        else
                        {

                            display_bet_result.Text = "You Lose";
                            int betlose_0 = betMoney_zero;
                            winamt_display.Text = betMoney_zero.ToString();
                            account_balance.Text = AcccountBal.ToString();
                            betamt_0.Text = string.Empty;



                        }
                    }

                }
            

        
        

        public void addBalance()
        {
            
            if (AcccountBal == 0)
            {
                   
             AcccountBal = 1000;
            }


        }



        private void label1_Click_1(object sender, EventArgs e)
        {
            getdiceResult();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_load_Load(object sender, EventArgs e)
        {

        }


        private void lab_userguess_display_Click(object sender, EventArgs e)
        {

        }

        private void lab_dice1_Click(object sender, EventArgs e)
        {

        }

        private void betamt_1_TextChanged(object sender, EventArgs e)
        {
            // int betMoney_four = int.Parse(betamt_4.Text);

        }

        private void lab_bet_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void lab_bet3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lab_bet2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lab_bet1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lab_bet0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lab_bet1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void betamt_2_TextChanged(object sender, EventArgs e)
        {
            //  int betMoney_Three = int.Parse(betamt_3.Text);

        }

        private void betamt_3_TextChanged(object sender, EventArgs e)
        {
            //int betMoney_Two = int.Parse(betamt_2.Text);
        }

        private void betamt_0_TextChanged(object sender, EventArgs e)
        {
            // int betMoney_One = int.Parse(betamt_0.Text);
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = 0;
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void howToPlayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=w-DN1qhhiiM");
            }
            catch (MissingFieldException  e2){

                Console.WriteLine("sorry resource is unavilable");
            }
        }

        private void TopUp_Click(object sender, EventArgs e)
        {
           
            addBalance();
            account_balance.Text = "1000";
        }

        private void display_bet_result_Click(object sender, EventArgs e)
        {

        }
    }

}
