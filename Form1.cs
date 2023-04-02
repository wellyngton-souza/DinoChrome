using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gameStart = false;
        bool jump = false;
        bool toFall = false;
        int scorePoint = 0;

        private void Form1_Resize(object sender, EventArgs e)
        {
            //form resize
            dino.Top = this.Height - dino.Height - 30;
            cacto1.Top = this.Height - cacto1.Height - 30;
            cacto1.Left = this.Width - 400;

            mainTitle.Left = (this.Width / 2) - mainTitle.Width / 2;
            mainTitle.Top = (this.Height / 2) - mainTitle.Height;
            scoreTwo.Left = (this.Width / 2) - scoreTwo.Width / 2;
            scoreTwo.Top = (this.Height / 2) - scoreTwo.Height + 30;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cacto1.Left = this.Width - 400;
        }

        private void gameTime(object sender, EventArgs e)
        {
            //cacto move
            if(gameStart == true){
                cacto1.Left = cacto1.Left - 30;
                if (cacto1.Left + cacto1.Width < 0){
                    cacto1.Left = this.Width;
                    scorePoint++;
                    score.Text = "Score " + scorePoint;
                }
            }
            //dino jump
            if(jump == true && toFall == false){
                if (dino.Top > this.Height - dino.Height * 2.8){
                    dino.Top -= 30;
                }
                else {
                    toFall = true;
                    jump = false;
                }
            } else{
                if (dino.Top < this.Height - dino.Height - 30)
                {
                    dino.Top += 15;
                } else{
                    toFall = false;
                }
            }
            //colission
            if(dino.Bounds.IntersectsWith(cacto1.Bounds)){
                mainTitle.Visible = true;
                gameStart = false;
                scoreTwo.Text = "Score " + scorePoint;
                scoreTwo.Visible = true;
                cacto1.Left = this.Width;
                scorePoint = 0;
                score.Text = "Score " + scorePoint;
                score.Visible = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //gameStart or keyJump
            if (gameStart == false){
                if (e.KeyCode == Keys.Space)
                {
                    scoreTwo.Visible = false;
                    score.Visible = true;
                    gameStart = true;
                    mainTitle.Visible = false;
                }
            } else{
                if(jump == false){
                    jump = true;
                }
            }
        }
    }
}
