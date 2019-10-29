namespace MarketView
{
    partial class FormMain
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
            this.customersTreeView = new ClassLibraryControlView.ControlTreeView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonDiagram = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.controlWordDiagram1 = new ClassLibraryControlWordDiagram.ControlWordDiagram(this.components);
            this.componentJsonBackup1 = new ClassLibraryControlBackup.ComponentJsonBackup(this.components);
            this.componentWordReport1 = new ClassLibraryControlReport.ComponentWordReport(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersTreeView
            // 
            this.customersTreeView.Location = new System.Drawing.Point(16, 69);
            this.customersTreeView.Margin = new System.Windows.Forms.Padding(5);
            this.customersTreeView.Name = "customersTreeView";
            this.customersTreeView.SelectedTreeNode = null;
            this.customersTreeView.Size = new System.Drawing.Size(679, 470);
            this.customersTreeView.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(808, 69);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(135, 47);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem});
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.modelsToolStripMenuItem.Text = "Справочники";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.productToolStripMenuItem.Text = "Клиенты";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(808, 124);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(135, 47);
            this.buttonReport.TabIndex = 6;
            this.buttonReport.Text = "Составить отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.Location = new System.Drawing.Point(808, 179);
            this.buttonDiagram.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(135, 47);
            this.buttonDiagram.TabIndex = 7;
            this.buttonDiagram.Text = "Составить диаграмму";
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.buttonDiagram_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(808, 234);
            this.buttonBackup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(135, 47);
            this.buttonBackup.TabIndex = 8;
            this.buttonBackup.Text = "Бэкап";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // componentJsonBackup1
            // 
            this.componentJsonBackup1.OutputPath = null;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonDiagram);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.customersTreeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Магазин";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibraryControlView.ControlTreeView customersTreeView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonDiagram;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private ClassLibraryControlWordDiagram.ControlWordDiagram controlWordDiagram1;
        private ClassLibraryControlBackup.ComponentJsonBackup componentJsonBackup1;
        private ClassLibraryControlReport.ComponentWordReport componentWordReport1;
    }
}

