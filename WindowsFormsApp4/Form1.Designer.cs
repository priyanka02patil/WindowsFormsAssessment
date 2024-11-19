namespace WindowsFormsApp4
{
    partial class FormCity
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
            this.labelCityName = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.labelListOfCity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(93, 69);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(124, 20);
            this.labelCityName.TabIndex = 0;
            this.labelCityName.Text = "Enter City Name";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(249, 137);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(220, 144);
            this.listBox.TabIndex = 1;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(249, 69);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(283, 26);
            this.textBoxCity.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 49);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(445, 344);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 49);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labelListOfCity
            // 
            this.labelListOfCity.AutoSize = true;
            this.labelListOfCity.Location = new System.Drawing.Point(93, 137);
            this.labelListOfCity.Name = "labelListOfCity";
            this.labelListOfCity.Size = new System.Drawing.Size(98, 20);
            this.labelListOfCity.TabIndex = 5;
            this.labelListOfCity.Text = "List Of Cities";
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelListOfCity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelCityName);
            this.Name = "FormCity";
            this.Text = "City Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labelListOfCity;
    }
}

