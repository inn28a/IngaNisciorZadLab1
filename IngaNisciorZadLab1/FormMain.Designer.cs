namespace IngaNisciorZadLab1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonBottom = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.textTimer = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listOfItemsTextBox = new System.Windows.Forms.RichTextBox();
            this.endOfGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 200);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(89, 47);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(743, 200);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(97, 47);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(361, 9);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(96, 43);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "^";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonBottom
            // 
            this.buttonBottom.Location = new System.Drawing.Point(361, 536);
            this.buttonBottom.Name = "buttonBottom";
            this.buttonBottom.Size = new System.Drawing.Size(96, 53);
            this.buttonBottom.TabIndex = 3;
            this.buttonBottom.Text = "v";
            this.buttonBottom.UseVisualStyleBackColor = true;
            this.buttonBottom.Click += new System.EventHandler(this.buttonBottom_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(33, 536);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 43);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textTimer
            // 
            this.textTimer.Location = new System.Drawing.Point(702, 9);
            this.textTimer.Name = "textTimer";
            this.textTimer.Size = new System.Drawing.Size(85, 22);
            this.textTimer.TabIndex = 9;
            this.textTimer.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(514, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(216, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(158, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(642, 381);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 172);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(150, 55);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listOfItemsTextBox
            // 
            this.listOfItemsTextBox.Location = new System.Drawing.Point(968, 9);
            this.listOfItemsTextBox.Name = "listOfItemsTextBox";
            this.listOfItemsTextBox.Size = new System.Drawing.Size(150, 580);
            this.listOfItemsTextBox.TabIndex = 10;
            this.listOfItemsTextBox.Text = "";
            // 
            // endOfGameButton
            // 
            this.endOfGameButton.Enabled = false;
            this.endOfGameButton.Location = new System.Drawing.Point(12, 9);
            this.endOfGameButton.Name = "endOfGameButton";
            this.endOfGameButton.Size = new System.Drawing.Size(908, 580);
            this.endOfGameButton.TabIndex = 11;
            this.endOfGameButton.Text = "button1";
            this.endOfGameButton.UseVisualStyleBackColor = true;
            this.endOfGameButton.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 626);
            this.Controls.Add(this.endOfGameButton);
            this.Controls.Add(this.listOfItemsTextBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textTimer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBottom);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonBottom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox listOfItemsTextBox;
        private System.Windows.Forms.Button endOfGameButton;
    }
}

