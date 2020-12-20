namespace PetalsAroundRose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img5 = new System.Windows.Forms.PictureBox();
            this.img6 = new System.Windows.Forms.PictureBox();
            this.btRollDice = new System.Windows.Forms.Button();
            this.btSubmitGuess = new System.Windows.Forms.Button();
            this.lblGuessScore = new System.Windows.Forms.Label();
            this.txtBxGuessScore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBestNum = new System.Windows.Forms.Label();
            this.lblWrongNum = new System.Windows.Forms.Label();
            this.lblCorrectNum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBestRun = new System.Windows.Forms.Label();
            this.lblWrongGuesses = new System.Windows.Forms.Label();
            this.lblCorrectGuesses = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(44, 35);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(61, 60);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.Location = new System.Drawing.Point(144, 35);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(60, 60);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 1;
            this.img2.TabStop = false;
            // 
            // img3
            // 
            this.img3.Image = ((System.Drawing.Image)(resources.GetObject("img3.Image")));
            this.img3.Location = new System.Drawing.Point(243, 35);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(60, 60);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 2;
            this.img3.TabStop = false;
            // 
            // img4
            // 
            this.img4.Image = ((System.Drawing.Image)(resources.GetObject("img4.Image")));
            this.img4.Location = new System.Drawing.Point(342, 35);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(60, 60);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4.TabIndex = 3;
            this.img4.TabStop = false;
            // 
            // img5
            // 
            this.img5.Image = ((System.Drawing.Image)(resources.GetObject("img5.Image")));
            this.img5.Location = new System.Drawing.Point(441, 35);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(60, 60);
            this.img5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img5.TabIndex = 4;
            this.img5.TabStop = false;
            // 
            // img6
            // 
            this.img6.Image = ((System.Drawing.Image)(resources.GetObject("img6.Image")));
            this.img6.Location = new System.Drawing.Point(540, 35);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(60, 60);
            this.img6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img6.TabIndex = 5;
            this.img6.TabStop = false;
            // 
            // btRollDice
            // 
            this.btRollDice.Location = new System.Drawing.Point(48, 146);
            this.btRollDice.Name = "btRollDice";
            this.btRollDice.Size = new System.Drawing.Size(90, 30);
            this.btRollDice.TabIndex = 18;
            this.btRollDice.Text = "Roll Dice";
            this.btRollDice.UseVisualStyleBackColor = true;
            this.btRollDice.Click += new System.EventHandler(this.btRollDice_Click);
            // 
            // btSubmitGuess
            // 
            this.btSubmitGuess.Enabled = false;
            this.btSubmitGuess.Location = new System.Drawing.Point(510, 146);
            this.btSubmitGuess.Name = "btSubmitGuess";
            this.btSubmitGuess.Size = new System.Drawing.Size(90, 30);
            this.btSubmitGuess.TabIndex = 19;
            this.btSubmitGuess.Text = "Submit Guess";
            this.btSubmitGuess.UseVisualStyleBackColor = true;
            this.btSubmitGuess.Click += new System.EventHandler(this.btSubmitGuess_Click);
            // 
            // lblGuessScore
            // 
            this.lblGuessScore.AutoSize = true;
            this.lblGuessScore.Location = new System.Drawing.Point(240, 155);
            this.lblGuessScore.Name = "lblGuessScore";
            this.lblGuessScore.Size = new System.Drawing.Size(68, 13);
            this.lblGuessScore.TabIndex = 20;
            this.lblGuessScore.Text = "Guess Score";
            // 
            // txtBxGuessScore
            // 
            this.txtBxGuessScore.Enabled = false;
            this.txtBxGuessScore.Location = new System.Drawing.Point(314, 152);
            this.txtBxGuessScore.Name = "txtBxGuessScore";
            this.txtBxGuessScore.Size = new System.Drawing.Size(54, 20);
            this.txtBxGuessScore.TabIndex = 21;
            this.txtBxGuessScore.TextChanged += new System.EventHandler(this.txtBxGuessScore_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestNum);
            this.groupBox1.Controls.Add(this.lblWrongNum);
            this.groupBox1.Controls.Add(this.lblCorrectNum);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblBestRun);
            this.groupBox1.Controls.Add(this.lblWrongGuesses);
            this.groupBox1.Controls.Add(this.lblCorrectGuesses);
            this.groupBox1.Location = new System.Drawing.Point(54, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 97);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // lblBestNum
            // 
            this.lblBestNum.AutoSize = true;
            this.lblBestNum.Location = new System.Drawing.Point(504, 72);
            this.lblBestNum.Name = "lblBestNum";
            this.lblBestNum.Size = new System.Drawing.Size(13, 13);
            this.lblBestNum.TabIndex = 6;
            this.lblBestNum.Text = "0";
            // 
            // lblWrongNum
            // 
            this.lblWrongNum.AutoSize = true;
            this.lblWrongNum.Location = new System.Drawing.Point(504, 45);
            this.lblWrongNum.Name = "lblWrongNum";
            this.lblWrongNum.Size = new System.Drawing.Size(13, 13);
            this.lblWrongNum.TabIndex = 5;
            this.lblWrongNum.Text = "0";
            // 
            // lblCorrectNum
            // 
            this.lblCorrectNum.AutoSize = true;
            this.lblCorrectNum.Location = new System.Drawing.Point(504, 16);
            this.lblCorrectNum.Name = "lblCorrectNum";
            this.lblCorrectNum.Size = new System.Drawing.Size(13, 13);
            this.lblCorrectNum.TabIndex = 4;
            this.lblCorrectNum.Text = "0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(14, 21);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(118, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Click Roll Dice to Begin";
            // 
            // lblBestRun
            // 
            this.lblBestRun.AutoSize = true;
            this.lblBestRun.Location = new System.Drawing.Point(405, 72);
            this.lblBestRun.Name = "lblBestRun";
            this.lblBestRun.Size = new System.Drawing.Size(51, 13);
            this.lblBestRun.TabIndex = 2;
            this.lblBestRun.Text = "Best Run";
            // 
            // lblWrongGuesses
            // 
            this.lblWrongGuesses.AutoSize = true;
            this.lblWrongGuesses.Location = new System.Drawing.Point(405, 45);
            this.lblWrongGuesses.Name = "lblWrongGuesses";
            this.lblWrongGuesses.Size = new System.Drawing.Size(83, 13);
            this.lblWrongGuesses.TabIndex = 1;
            this.lblWrongGuesses.Text = "Wrong Guesses";
            // 
            // lblCorrectGuesses
            // 
            this.lblCorrectGuesses.AutoSize = true;
            this.lblCorrectGuesses.Location = new System.Drawing.Point(405, 16);
            this.lblCorrectGuesses.Name = "lblCorrectGuesses";
            this.lblCorrectGuesses.Size = new System.Drawing.Size(85, 13);
            this.lblCorrectGuesses.TabIndex = 0;
            this.lblCorrectGuesses.Text = "Correct Guesses";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(311, 189);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(35, 13);
            this.lblErrorMessage.TabIndex = 23;
            this.lblErrorMessage.Text = "label1";
            this.lblErrorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 353);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBxGuessScore);
            this.Controls.Add(this.lblGuessScore);
            this.Controls.Add(this.btSubmitGuess);
            this.Controls.Add(this.btRollDice);
            this.Controls.Add(this.img6);
            this.Controls.Add(this.img5);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Petals Around the Rose";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.PictureBox img5;
        private System.Windows.Forms.PictureBox img6;
        private System.Windows.Forms.Button btRollDice;
        private System.Windows.Forms.Button btSubmitGuess;
        private System.Windows.Forms.Label lblGuessScore;
        private System.Windows.Forms.TextBox txtBxGuessScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBestRun;
        private System.Windows.Forms.Label lblWrongGuesses;
        private System.Windows.Forms.Label lblCorrectGuesses;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblBestNum;
        private System.Windows.Forms.Label lblWrongNum;
        private System.Windows.Forms.Label lblCorrectNum;
    }
}

