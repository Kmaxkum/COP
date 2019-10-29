namespace MarketView
{
    partial class FormCustomerAdd
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.controlSumBox = new ClassLibraryControlInput.ControlTextBox();
            this.controlComboBox = new ClassLibraryControlSelected.ControlComboBox();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(115, 15);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(279, 22);
            this.textBoxFIO.TabIndex = 0;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(17, 23);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(72, 17);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "ФИО";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(17, 68);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 17);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(17, 113);
            this.labelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(86, 17);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Сумма";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(295, 148);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(175, 148);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // controlSumBox
            // 
            this.controlSumBox.Location = new System.Drawing.Point(111, 113);
            this.controlSumBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlSumBox.Name = "controlSumBox";
            this.controlSumBox.Size = new System.Drawing.Size(284, 27);
            this.controlSumBox.TabIndex = 8;
            // 
            // controlComboBox
            // 
            this.controlComboBox.Location = new System.Drawing.Point(115, 68);
            this.controlComboBox.Name = "controlComboBox";
            this.controlComboBox.SelectedIndex = -1;
            this.controlComboBox.Size = new System.Drawing.Size(279, 28);
            this.controlComboBox.TabIndex = 9;
            // 
            // FormCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 191);
            this.Controls.Add(this.controlComboBox);
            this.Controls.Add(this.controlSumBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxFIO);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCustomerAdd";
            this.Text = "FormCustomerAdd";
            this.Load += new System.EventHandler(this.FormCustomerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private ClassLibraryControlInput.ControlTextBox controlSumBox;
        private ClassLibraryControlSelected.ControlComboBox controlComboBox;
    }
}