namespace MilionaireGame
{
    partial class QuestionGeneratorAI
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
            this.btnGenerateQuestions = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtProgressLog = new System.Windows.Forms.TextBox();
            this.lstQuestions = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Izlez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateQuestions
            // 
            this.btnGenerateQuestions.Location = new System.Drawing.Point(12, 1);
            this.btnGenerateQuestions.Name = "btnGenerateQuestions";
            this.btnGenerateQuestions.Size = new System.Drawing.Size(160, 23);
            this.btnGenerateQuestions.TabIndex = 0;
            this.btnGenerateQuestions.Text = "Генерирај прашања со AI";
            this.btnGenerateQuestions.UseVisualStyleBackColor = true;
            this.btnGenerateQuestions.Click += new System.EventHandler(this.btnGenerateQuestions_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(28, 373);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(745, 23);
            this.progressBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(203, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 2;
            // 
            // txtProgressLog
            // 
            this.txtProgressLog.Location = new System.Drawing.Point(28, 45);
            this.txtProgressLog.Multiline = true;
            this.txtProgressLog.Name = "txtProgressLog";
            this.txtProgressLog.Size = new System.Drawing.Size(745, 118);
            this.txtProgressLog.TabIndex = 3;
            // 
            // lstQuestions
            // 
            this.lstQuestions.HideSelection = false;
            this.lstQuestions.Location = new System.Drawing.Point(28, 170);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(745, 197);
            this.lstQuestions.TabIndex = 4;
            this.lstQuestions.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(245, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Прекини со генерирањето на прашањата";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Izlez
            // 
            this.Izlez.Location = new System.Drawing.Point(698, 415);
            this.Izlez.Name = "Izlez";
            this.Izlez.Size = new System.Drawing.Size(75, 23);
            this.Izlez.TabIndex = 6;
            this.Izlez.Text = "Излез";
            this.Izlez.UseVisualStyleBackColor = true;
            this.Izlez.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // QuestionGeneratorAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Izlez);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.txtProgressLog);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGenerateQuestions);
            this.Name = "QuestionGeneratorAI";
            this.Text = "AI Генератор на прашања";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateQuestions;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtProgressLog;
        private System.Windows.Forms.ListView lstQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Izlez;
        // private System.Windows.Forms.Button button1;
    }
}