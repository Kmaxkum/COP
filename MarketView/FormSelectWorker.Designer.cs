namespace MarketView
{
    partial class FormSelectWorker
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
            this.groupBoxMoney = new System.Windows.Forms.GroupBox();
            this.checkBoxIntern = new System.Windows.Forms.CheckBox();
            this.checkWorker = new System.Windows.Forms.CheckBox();
            this.checkDeputy = new System.Windows.Forms.CheckBox();
            this.checkDirector = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMoney
            // 
            this.groupBoxMoney.Controls.Add(this.checkBoxIntern);
            this.groupBoxMoney.Controls.Add(this.checkWorker);
            this.groupBoxMoney.Controls.Add(this.checkDeputy);
            this.groupBoxMoney.Controls.Add(this.checkDirector);
            this.groupBoxMoney.Location = new System.Drawing.Point(26, 25);
            this.groupBoxMoney.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMoney.Name = "groupBoxMoney";
            this.groupBoxMoney.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMoney.Size = new System.Drawing.Size(312, 213);
            this.groupBoxMoney.TabIndex = 1;
            this.groupBoxMoney.TabStop = false;
            this.groupBoxMoney.Text = "Варинаты работников";
            // 
            // checkBoxIntern
            // 
            this.checkBoxIntern.AutoSize = true;
            this.checkBoxIntern.Location = new System.Drawing.Point(48, 156);
            this.checkBoxIntern.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIntern.Name = "checkBoxIntern";
            this.checkBoxIntern.Size = new System.Drawing.Size(79, 21);
            this.checkBoxIntern.TabIndex = 3;
            this.checkBoxIntern.Text = "Стажер";
            this.checkBoxIntern.UseVisualStyleBackColor = true;
            // 
            // checkWorker
            // 
            this.checkWorker.AutoSize = true;
            this.checkWorker.Location = new System.Drawing.Point(48, 116);
            this.checkWorker.Margin = new System.Windows.Forms.Padding(4);
            this.checkWorker.Name = "checkWorker";
            this.checkWorker.Size = new System.Drawing.Size(99, 21);
            this.checkWorker.TabIndex = 2;
            this.checkWorker.Text = "Сотрутдик";
            this.checkWorker.UseVisualStyleBackColor = true;
            // 
            // checkDeputy
            // 
            this.checkDeputy.AutoSize = true;
            this.checkDeputy.Location = new System.Drawing.Point(48, 74);
            this.checkDeputy.Margin = new System.Windows.Forms.Padding(4);
            this.checkDeputy.Name = "checkDeputy";
            this.checkDeputy.Size = new System.Drawing.Size(190, 21);
            this.checkDeputy.TabIndex = 1;
            this.checkDeputy.Text = "Заместитель директора";
            this.checkDeputy.UseVisualStyleBackColor = true;
            // 
            // checkDirector
            // 
            this.checkDirector.AutoSize = true;
            this.checkDirector.Location = new System.Drawing.Point(48, 35);
            this.checkDirector.Margin = new System.Windows.Forms.Padding(4);
            this.checkDirector.Name = "checkDirector";
            this.checkDirector.Size = new System.Drawing.Size(95, 21);
            this.checkDirector.TabIndex = 0;
            this.checkDirector.Text = "Директор";
            this.checkDirector.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(94, 271);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(148, 55);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Выполнить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormSelectWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 352);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBoxMoney);
            this.Name = "FormSelectWorker";
            this.Text = "Выбор работника";
            this.groupBoxMoney.ResumeLayout(false);
            this.groupBoxMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMoney;
        private System.Windows.Forms.CheckBox checkWorker;
        private System.Windows.Forms.CheckBox checkDeputy;
        private System.Windows.Forms.CheckBox checkDirector;
        private System.Windows.Forms.CheckBox checkBoxIntern;
        private System.Windows.Forms.Button buttonSend;
    }
}