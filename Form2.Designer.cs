namespace MillionaireGame
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.конфигурацијаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерирајПрашањаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatGTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eAPIKEYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.музикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.почниСоКвизотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.избериПрашањаЗаКвизотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПрограматаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заАвторотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заАвторотToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.излезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конфигурацијаToolStripMenuItem,
            this.почниСоКвизотToolStripMenuItem,
            this.заПрограматаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // конфигурацијаToolStripMenuItem
            // 
            this.конфигурацијаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерирајПрашањаToolStripMenuItem,
            this.изToolStripMenuItem,
            this.музикаToolStripMenuItem});
            this.конфигурацијаToolStripMenuItem.Name = "конфигурацијаToolStripMenuItem";
            this.конфигурацијаToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.конфигурацијаToolStripMenuItem.Text = "Конфигурација";
            // 
            // генерирајПрашањаToolStripMenuItem
            // 
            this.генерирајПрашањаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatGTPToolStripMenuItem,
            this.eAPIKEYToolStripMenuItem});
            this.генерирајПрашањаToolStripMenuItem.Name = "генерирајПрашањаToolStripMenuItem";
            this.генерирајПрашањаToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.генерирајПрашањаToolStripMenuItem.Text = "Генерирање  прашања со AI";
            this.генерирајПрашањаToolStripMenuItem.Click += new System.EventHandler(this.генерирајПрашањаToolStripMenuItem_Click);
            // 
            // chatGTPToolStripMenuItem
            // 
            this.chatGTPToolStripMenuItem.Name = "chatGTPToolStripMenuItem";
            this.chatGTPToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.chatGTPToolStripMenuItem.Text = "OpenAI";
            this.chatGTPToolStripMenuItem.Click += new System.EventHandler(this.chatGTPToolStripMenuItem_Click);
            // 
            // eAPIKEYToolStripMenuItem
            // 
            this.eAPIKEYToolStripMenuItem.Name = "eAPIKEYToolStripMenuItem";
            this.eAPIKEYToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eAPIKEYToolStripMenuItem.Text = "Едитирање API KEY";
            this.eAPIKEYToolStripMenuItem.Click += new System.EventHandler(this.eAPIKEYToolStripMenuItem_Click);
            // 
            // изToolStripMenuItem
            // 
            this.изToolStripMenuItem.Name = "изToolStripMenuItem";
            this.изToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.изToolStripMenuItem.Text = "Едитирање на прашања";
            this.изToolStripMenuItem.Click += new System.EventHandler(this.изToolStripMenuItem_Click);
            // 
            // музикаToolStripMenuItem
            // 
            this.музикаToolStripMenuItem.Name = "музикаToolStripMenuItem";
            this.музикаToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.музикаToolStripMenuItem.Text = "Музика";
            this.музикаToolStripMenuItem.Visible = false;
            this.музикаToolStripMenuItem.Click += new System.EventHandler(this.музикаToolStripMenuItem_Click);
            // 
            // почниСоКвизотToolStripMenuItem
            // 
            this.почниСоКвизотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.избериПрашањаЗаКвизотToolStripMenuItem});
            this.почниСоКвизотToolStripMenuItem.Name = "почниСоКвизотToolStripMenuItem";
            this.почниСоКвизотToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.почниСоКвизотToolStripMenuItem.Text = "Квиз";
            this.почниСоКвизотToolStripMenuItem.Click += new System.EventHandler(this.почниСоКвизотToolStripMenuItem_Click);
            // 
            // избериПрашањаЗаКвизотToolStripMenuItem
            // 
            this.избериПрашањаЗаКвизотToolStripMenuItem.Name = "избериПрашањаЗаКвизотToolStripMenuItem";
            this.избериПрашањаЗаКвизотToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.избериПрашањаЗаКвизотToolStripMenuItem.Text = "Избери прашања и почни го квизот";
            this.избериПрашањаЗаКвизотToolStripMenuItem.Click += new System.EventHandler(this.избериПрашањаЗаКвизотToolStripMenuItem_Click);
            // 
            // заПрограматаToolStripMenuItem
            // 
            this.заПрограматаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацииToolStripMenuItem,
            this.заАвторотToolStripMenuItem,
            this.заАвторотToolStripMenuItem1,
            this.излезToolStripMenuItem});
            this.заПрограматаToolStripMenuItem.Name = "заПрограматаToolStripMenuItem";
            this.заПрограматаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.заПрограматаToolStripMenuItem.Text = "Помош";
            // 
            // информацииToolStripMenuItem
            // 
            this.информацииToolStripMenuItem.Name = "информацииToolStripMenuItem";
            this.информацииToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.информацииToolStripMenuItem.Text = "Информации за квизот";
            this.информацииToolStripMenuItem.Click += new System.EventHandler(this.информацииToolStripMenuItem_Click);
            // 
            // заАвторотToolStripMenuItem
            // 
            this.заАвторотToolStripMenuItem.Name = "заАвторотToolStripMenuItem";
            this.заАвторотToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.заАвторотToolStripMenuItem.Text = "Инструкции за апликацијата";
            this.заАвторотToolStripMenuItem.Click += new System.EventHandler(this.заАвторотToolStripMenuItem_Click);
            // 
            // заАвторотToolStripMenuItem1
            // 
            this.заАвторотToolStripMenuItem1.Name = "заАвторотToolStripMenuItem1";
            this.заАвторотToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.заАвторотToolStripMenuItem1.Text = "За Авторот ...";
            this.заАвторотToolStripMenuItem1.Click += new System.EventHandler(this.заАвторотToolStripMenuItem1_Click);
            // 
            // излезToolStripMenuItem
            // 
            this.излезToolStripMenuItem.Name = "излезToolStripMenuItem";
            this.излезToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.излезToolStripMenuItem.Text = "Излез";
            this.излезToolStripMenuItem.Click += new System.EventHandler(this.излезToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(349, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MillionaireGame.Properties.Resources.Koj_saka_da_bide_milioner_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Кој сака да биде милионер  ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem конфигурацијаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генерирајПрашањаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem музикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заПрограматаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заАвторотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заАвторотToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem излезToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem почниСоКвизотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatGTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem избериПрашањаЗаКвизотToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem eAPIKEYToolStripMenuItem;
    }
}