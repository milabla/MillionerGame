namespace MillionaireGame
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.panelRewards = new System.Windows.Forms.Panel();
            this.listBoxRewards = new System.Windows.Forms.ListBox();
            this.lblPointer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCallFriend = new System.Windows.Forms.Button();
            this.btnAskAudience = new System.Windows.Forms.Button();
            this.btn5050 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblQuestion.Location = new System.Drawing.Point(24, 55);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(379, 80);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Prasanje";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnA.Location = new System.Drawing.Point(28, 147);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(176, 34);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnB.Location = new System.Drawing.Point(238, 147);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(162, 34);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnC.Location = new System.Drawing.Point(28, 201);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(176, 35);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnD.Location = new System.Drawing.Point(238, 201);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(162, 35);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "button4";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrize.Location = new System.Drawing.Point(148, 22);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(118, 20);
            this.lblPrize.TabIndex = 5;
            this.lblPrize.Text = "Osvoen Iznos";
            // 
            // panelRewards
            // 
            this.panelRewards.Controls.Add(this.listBoxRewards);
            this.panelRewards.Location = new System.Drawing.Point(452, 84);
            this.panelRewards.Name = "panelRewards";
            this.panelRewards.Size = new System.Drawing.Size(164, 344);
            this.panelRewards.TabIndex = 9;
            // 
            // listBoxRewards
            // 
            this.listBoxRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRewards.FormattingEnabled = true;
            this.listBoxRewards.ItemHeight = 20;
            this.listBoxRewards.Location = new System.Drawing.Point(3, 12);
            this.listBoxRewards.Name = "listBoxRewards";
            this.listBoxRewards.Size = new System.Drawing.Size(148, 304);
            this.listBoxRewards.TabIndex = 0;
            // 
            // lblPointer
            // 
            this.lblPointer.AutoSize = true;
            this.lblPointer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointer.ForeColor = System.Drawing.Color.Red;
            this.lblPointer.Location = new System.Drawing.Point(605, 382);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(178, 20);
            this.lblPointer.TabIndex = 1;
            this.lblPointer.Text = "<== Тековно ниво: 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "(C)2025 Мила Блажевска 231100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MillionaireGame.Properties.Resources.koj_saka;
            this.pictureBox1.Location = new System.Drawing.Point(70, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 217);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCallFriend
            // 
            this.btnCallFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallFriend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCallFriend.Image = global::MillionaireGame.Properties.Resources.vik_prij;
            this.btnCallFriend.Location = new System.Drawing.Point(609, 22);
            this.btnCallFriend.Name = "btnCallFriend";
            this.btnCallFriend.Size = new System.Drawing.Size(87, 46);
            this.btnCallFriend.TabIndex = 8;
            this.btnCallFriend.UseVisualStyleBackColor = true;
            // 
            // btnAskAudience
            // 
            this.btnAskAudience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAskAudience.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAskAudience.Image = global::MillionaireGame.Properties.Resources.prasaj_pub;
            this.btnAskAudience.Location = new System.Drawing.Point(499, 22);
            this.btnAskAudience.Name = "btnAskAudience";
            this.btnAskAudience.Size = new System.Drawing.Size(93, 46);
            this.btnAskAudience.TabIndex = 7;
            this.btnAskAudience.UseVisualStyleBackColor = true;
            // 
            // btn5050
            // 
            this.btn5050.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5050.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn5050.Image = global::MillionaireGame.Properties.Resources._5050;
            this.btn5050.Location = new System.Drawing.Point(394, 22);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(91, 46);
            this.btn5050.TabIndex = 6;
            this.btn5050.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(462, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Се откажувам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPointer);
            this.Controls.Add(this.panelRewards);
            this.Controls.Add(this.btnCallFriend);
            this.Controls.Add(this.btnAskAudience);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Кој сака да биде милионер                                                        " +
    "                                                 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button btnAskAudience;
        private System.Windows.Forms.Button btnCallFriend;
        private System.Windows.Forms.Panel panelRewards;
        private System.Windows.Forms.Label lblPointer;
        private System.Windows.Forms.ListBox listBoxRewards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

