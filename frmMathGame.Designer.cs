namespace MathGame
{
    partial class frmMathGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRound = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.lbOperator = new System.Windows.Forms.Label();
            this.txtbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRightAnswer = new System.Windows.Forms.Label();
            this.lbPlayerAnswer = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pbImojiThinking = new System.Windows.Forms.PictureBox();
            this.pbBoyThinking = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImojiThinking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoyThinking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Round:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:  ";
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.BackColor = System.Drawing.Color.Transparent;
            this.lbRound.Font = new System.Drawing.Font("Urdu Typesetting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRound.ForeColor = System.Drawing.Color.Maroon;
            this.lbRound.Location = new System.Drawing.Point(142, 9);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(113, 60);
            this.lbRound.TabIndex = 3;
            this.lbRound.Text = "NULL";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Urdu Typesetting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Maroon;
            this.lbLevel.Location = new System.Drawing.Point(142, 60);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(113, 60);
            this.lbLevel.TabIndex = 4;
            this.lbLevel.Text = "NULL";
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber1.Font = new System.Drawing.Font("Urdu Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber1.ForeColor = System.Drawing.Color.Blue;
            this.lbNumber1.Location = new System.Drawing.Point(32, 46);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(75, 110);
            this.lbNumber1.TabIndex = 6;
            this.lbNumber1.Text = "0";
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber2.Font = new System.Drawing.Font("Urdu Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber2.ForeColor = System.Drawing.Color.Blue;
            this.lbNumber2.Location = new System.Drawing.Point(248, 46);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(75, 110);
            this.lbNumber2.TabIndex = 7;
            this.lbNumber2.Text = "0";
            // 
            // lbOperator
            // 
            this.lbOperator.AutoSize = true;
            this.lbOperator.BackColor = System.Drawing.Color.Transparent;
            this.lbOperator.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperator.ForeColor = System.Drawing.Color.Black;
            this.lbOperator.Location = new System.Drawing.Point(113, 34);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(129, 149);
            this.lbOperator.TabIndex = 8;
            this.lbOperator.Text = "+";
            // 
            // txtbResult
            // 
            this.txtbResult.BackColor = System.Drawing.Color.Silver;
            this.txtbResult.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbResult.ForeColor = System.Drawing.Color.Blue;
            this.txtbResult.Location = new System.Drawing.Point(51, 149);
            this.txtbResult.MaxLength = 9;
            this.txtbResult.Name = "txtbResult";
            this.txtbResult.ReadOnly = true;
            this.txtbResult.Size = new System.Drawing.Size(250, 64);
            this.txtbResult.TabIndex = 9;
            this.txtbResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbResult_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(773, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Right Answer: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(773, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Player Answer:";
            // 
            // lbRightAnswer
            // 
            this.lbRightAnswer.AutoSize = true;
            this.lbRightAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbRightAnswer.Font = new System.Drawing.Font("Urdu Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightAnswer.ForeColor = System.Drawing.Color.Red;
            this.lbRightAnswer.Location = new System.Drawing.Point(970, 2);
            this.lbRightAnswer.Name = "lbRightAnswer";
            this.lbRightAnswer.Size = new System.Drawing.Size(75, 110);
            this.lbRightAnswer.TabIndex = 14;
            this.lbRightAnswer.Text = "0";
            // 
            // lbPlayerAnswer
            // 
            this.lbPlayerAnswer.AutoSize = true;
            this.lbPlayerAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerAnswer.Font = new System.Drawing.Font("Urdu Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerAnswer.ForeColor = System.Drawing.Color.Blue;
            this.lbPlayerAnswer.Location = new System.Drawing.Point(970, 67);
            this.lbPlayerAnswer.Name = "lbPlayerAnswer";
            this.lbPlayerAnswer.Size = new System.Drawing.Size(75, 110);
            this.lbPlayerAnswer.TabIndex = 15;
            this.lbPlayerAnswer.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(847, 604);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(208, 78);
            this.btnResult.TabIndex = 16;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.Aqua;
            this.btnCheckAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.Location = new System.Drawing.Point(51, 229);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(250, 63);
            this.btnCheckAnswer.TabIndex = 17;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SlateGray;
            this.btnNext.Location = new System.Drawing.Point(655, 588);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(169, 110);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Urdu Typesetting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Maroon;
            this.lbTime.Location = new System.Drawing.Point(142, 107);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(57, 60);
            this.lbTime.TabIndex = 22;
            this.lbTime.Text = "30";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckAnswer);
            this.panel1.Controls.Add(this.txtbResult);
            this.panel1.Controls.Add(this.lbOperator);
            this.panel1.Controls.Add(this.lbNumber2);
            this.panel1.Controls.Add(this.lbNumber1);
            this.panel1.Location = new System.Drawing.Point(350, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 341);
            this.panel1.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::MathGame.Properties.Resources.vecteezy_web_button_icon_back_button_23629699;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 78);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::MathGame.Properties.Resources.reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Enabled = false;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(233, 588);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 110);
            this.btnReset.TabIndex = 20;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.BackgroundImage = global::MathGame.Properties.Resources.play;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(444, 588);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(169, 110);
            this.btnStartGame.TabIndex = 18;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pbImojiThinking
            // 
            this.pbImojiThinking.BackColor = System.Drawing.Color.Transparent;
            this.pbImojiThinking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImojiThinking.ErrorImage = null;
            this.pbImojiThinking.Image = global::MathGame.Properties.Resources.thinking;
            this.pbImojiThinking.InitialImage = null;
            this.pbImojiThinking.Location = new System.Drawing.Point(723, 292);
            this.pbImojiThinking.Name = "pbImojiThinking";
            this.pbImojiThinking.Size = new System.Drawing.Size(322, 196);
            this.pbImojiThinking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImojiThinking.TabIndex = 11;
            this.pbImojiThinking.TabStop = false;
            // 
            // pbBoyThinking
            // 
            this.pbBoyThinking.BackColor = System.Drawing.Color.Transparent;
            this.pbBoyThinking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBoyThinking.Image = ((System.Drawing.Image)(resources.GetObject("pbBoyThinking.Image")));
            this.pbBoyThinking.InitialImage = null;
            this.pbBoyThinking.Location = new System.Drawing.Point(12, 292);
            this.pbBoyThinking.Name = "pbBoyThinking";
            this.pbBoyThinking.Size = new System.Drawing.Size(322, 196);
            this.pbBoyThinking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBoyThinking.TabIndex = 10;
            this.pbBoyThinking.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MathGame.Properties.Resources.maths;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(360, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbRightAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImojiThinking);
            this.Controls.Add(this.pbBoyThinking);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayerAnswer);
            this.Controls.Add(this.lbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMathGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathGame";
            this.Load += new System.EventHandler(this.frmMathGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImojiThinking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoyThinking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.Label lbNumber2;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.TextBox txtbResult;
        private System.Windows.Forms.PictureBox pbBoyThinking;
        private System.Windows.Forms.PictureBox pbImojiThinking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRightAnswer;
        private System.Windows.Forms.Label lbPlayerAnswer;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}