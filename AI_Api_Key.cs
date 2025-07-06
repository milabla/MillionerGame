using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillionaireGame
{
    public partial class AI_Api_Key : Form
    {
        // Public property for getting and setting the API key
        public string ApiKey
        {
            get { return ApiKey; }
            set { ApiKey = value; }
        }

        public AI_Api_Key()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Label
            Label lblApiKey = new Label
            {
                Text = "Внесете го вашиот API клуч:",
                AutoSize = true,
                Location = new System.Drawing.Point(10, 20)
            };
            this.Controls.Add(lblApiKey);

            // TextBox
            TextBox txtApiKey = new TextBox
            {
                Name = "txtApiKey",
                Location = new System.Drawing.Point(10, 50),
                Width = 250
            };
            this.Controls.Add(txtApiKey);

            // OK Button
            Button btnOk = new Button
            {
                Text = "ОК",
                Location = new System.Drawing.Point(10, 90)
            };
            btnOk.Click += (sender, e) =>
            {
                ApiKey = txtApiKey.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            this.Controls.Add(btnOk);

            // Cancel Button
            Button btnCancel = new Button
            {
                Text = "Откажи",
                Location = new System.Drawing.Point(100, 90)
            };
            btnCancel.Click += (sender, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            this.Controls.Add(btnCancel);
        }
    }
}
