namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlTextBoxTemplate1 = new ClassLibraryControlInput.ControlTextBoxTemplate();
            this.controlComboBox1 = new ClassLibraryControlSelected.ControlComboBox();
            this.controlListBoxOutput1 = new ClassLibraryControlOutputLists.ControlListBoxOutput();
            this.componentRestore1 = new ClassLibraryControlRestore.ComponentRestore(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonDiagram = new System.Windows.Forms.Button();
            this.controlWordDiagram1 = new ClassLibraryControlWordDiagram.ControlWordDiagram(this.components);
            this.controlPDFReporter1 = new ClassLibraryControlPDFReporter.ControlPDFReporter(this.components);
            this.buttonPDF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(145, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(147, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // controlTextBoxTemplate1
            // 
            this.controlTextBoxTemplate1.Location = new System.Drawing.Point(437, 146);
            this.controlTextBoxTemplate1.Mail = null;
            this.controlTextBoxTemplate1.Name = "controlTextBoxTemplate1";
            this.controlTextBoxTemplate1.Size = new System.Drawing.Size(268, 28);
            this.controlTextBoxTemplate1.TabIndex = 4;
            // 
            // controlComboBox1
            // 
            this.controlComboBox1.Location = new System.Drawing.Point(136, 146);
            this.controlComboBox1.Name = "controlComboBox1";
            this.controlComboBox1.SelectedIndex = -1;
            this.controlComboBox1.Size = new System.Drawing.Size(177, 48);
            this.controlComboBox1.TabIndex = 2;
            // 
            // controlListBoxOutput1
            // 
            this.controlListBoxOutput1.Location = new System.Drawing.Point(317, 208);
            this.controlListBoxOutput1.Name = "controlListBoxOutput1";
            this.controlListBoxOutput1.Pattern = null;
            this.controlListBoxOutput1.Size = new System.Drawing.Size(251, 230);
            this.controlListBoxOutput1.TabIndex = 5;
            // 
            // componentRestore1
            // 
            this.componentRestore1.Path = null;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(630, 219);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(630, 249);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 7;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.Location = new System.Drawing.Point(630, 304);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(75, 23);
            this.buttonDiagram.TabIndex = 8;
            this.buttonDiagram.Text = "Diagram";
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.buttonDiagram_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(630, 354);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(75, 23);
            this.buttonPDF.TabIndex = 9;
            this.buttonPDF.Text = "Reporded";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(147, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.buttonDiagram);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.controlListBoxOutput1);
            this.Controls.Add(this.controlTextBoxTemplate1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlComboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ClassLibraryControlSelected.ControlComboBox controlComboBox1;
        private System.Windows.Forms.Label label2;
        private ClassLibraryControlInput.ControlTextBoxTemplate controlTextBoxTemplate1;
        private ClassLibraryControlOutputLists.ControlListBoxOutput controlListBoxOutput1;
        private ClassLibraryControlRestore.ComponentRestore componentRestore1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonDiagram;
        private ClassLibraryControlWordDiagram.ControlWordDiagram controlWordDiagram1;
        private ClassLibraryControlPDFReporter.ControlPDFReporter controlPDFReporter1;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Label label3;
    }
}

