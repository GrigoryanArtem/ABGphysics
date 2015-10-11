namespace ABGphysics
{
    partial class _mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_mainForm));
            this._mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this._mainPictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this._menuMain = new System.Windows.Forms.MenuStrip();
            this._menuView = new System.Windows.Forms.ToolStripMenuItem();
            this._menuControlPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).BeginInit();
            this._mainSplitContainer.Panel1.SuspendLayout();
            this._mainSplitContainer.Panel2.SuspendLayout();
            this._mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainPictureBox)).BeginInit();
            this._menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainSplitContainer
            // 
            this._mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this._mainSplitContainer.Name = "_mainSplitContainer";
            // 
            // _mainSplitContainer.Panel1
            // 
            this._mainSplitContainer.Panel1.Controls.Add(this._mainPictureBox);
            // 
            // _mainSplitContainer.Panel2
            // 
            this._mainSplitContainer.Panel2.Controls.Add(this.richTextBox);
            this._mainSplitContainer.Size = new System.Drawing.Size(936, 345);
            this._mainSplitContainer.SplitterDistance = 656;
            this._mainSplitContainer.TabIndex = 0;
            // 
            // _mainPictureBox
            // 
            this._mainPictureBox.BackColor = System.Drawing.Color.White;
            this._mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this._mainPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this._mainPictureBox.Name = "_mainPictureBox";
            this._mainPictureBox.Size = new System.Drawing.Size(656, 345);
            this._mainPictureBox.TabIndex = 0;
            this._mainPictureBox.TabStop = false;
            this._mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._mainPictureBox_MouseDown);
            this._mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this._mainPictureBox_MouseMove);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(276, 81);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // _menuMain
            // 
            this._menuMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this._menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuView});
            this._menuMain.Location = new System.Drawing.Point(0, 0);
            this._menuMain.Name = "_menuMain";
            this._menuMain.Size = new System.Drawing.Size(936, 24);
            this._menuMain.TabIndex = 1;
            this._menuMain.Text = "_menuMain";
            // 
            // _menuView
            // 
            this._menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuControlPanel});
            this._menuView.Name = "_menuView";
            this._menuView.Size = new System.Drawing.Size(43, 20);
            this._menuView.Text = "ВИД";
            // 
            // _menuControlPanel
            // 
            this._menuControlPanel.Checked = true;
            this._menuControlPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this._menuControlPanel.Name = "_menuControlPanel";
            this._menuControlPanel.Size = new System.Drawing.Size(183, 22);
            this._menuControlPanel.Text = "Панель управления";
            this._menuControlPanel.Click += new System.EventHandler(this.панельУправленияToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(936, 369);
            this.Controls.Add(this._mainSplitContainer);
            this.Controls.Add(this._menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_mainForm";
            this.Text = "ABGphysics";
            this.Load += new System.EventHandler(this._mainForm_Load);
            this._mainSplitContainer.Panel1.ResumeLayout(false);
            this._mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).EndInit();
            this._mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mainPictureBox)).EndInit();
            this._menuMain.ResumeLayout(false);
            this._menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer _mainSplitContainer;
        private System.Windows.Forms.MenuStrip _menuMain;
        private System.Windows.Forms.PictureBox _mainPictureBox;
        private System.Windows.Forms.ToolStripMenuItem _menuView;
        private System.Windows.Forms.ToolStripMenuItem _menuControlPanel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

