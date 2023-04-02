namespace DinoGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dino = new System.Windows.Forms.PictureBox();
            this.cacto1 = new System.Windows.Forms.PictureBox();
            this.mainTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.scoreTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacto1)).BeginInit();
            this.SuspendLayout();
            // 
            // dino
            // 
            this.dino.Image = ((System.Drawing.Image)(resources.GetObject("dino.Image")));
            this.dino.Location = new System.Drawing.Point(120, 481);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(169, 169);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            // 
            // cacto1
            // 
            this.cacto1.Image = ((System.Drawing.Image)(resources.GetObject("cacto1.Image")));
            this.cacto1.Location = new System.Drawing.Point(805, 531);
            this.cacto1.Name = "cacto1";
            this.cacto1.Size = new System.Drawing.Size(150, 150);
            this.cacto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cacto1.TabIndex = 1;
            this.cacto1.TabStop = false;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(440, 193);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(347, 75);
            this.mainTitle.TabIndex = 2;
            this.mainTitle.Text = "Dino Game";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTime);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 19);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(136, 39);
            this.score.TabIndex = 3;
            this.score.Text = "Score 0";
            // 
            // scoreTwo
            // 
            this.scoreTwo.AutoSize = true;
            this.scoreTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTwo.Location = new System.Drawing.Point(547, 280);
            this.scoreTwo.Name = "scoreTwo";
            this.scoreTwo.Size = new System.Drawing.Size(144, 33);
            this.scoreTwo.TabIndex = 4;
            this.scoreTwo.Text = "Score two";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.scoreTwo);
            this.Controls.Add(this.score);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.cacto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.PictureBox cacto1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreTwo;
    }
}

