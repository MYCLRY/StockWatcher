
namespace StockWatcher
{
    partial class frmSetting
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
            this.labelForRefresh = new System.Windows.Forms.Label();
            this.comboBoxForRefresh = new System.Windows.Forms.ComboBox();
            this.labelForList = new System.Windows.Forms.Label();
            this.textBoxStockList = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForRefresh
            // 
            this.labelForRefresh.AutoSize = true;
            this.labelForRefresh.Location = new System.Drawing.Point(9, 14);
            this.labelForRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForRefresh.Name = "labelForRefresh";
            this.labelForRefresh.Size = new System.Drawing.Size(101, 12);
            this.labelForRefresh.TabIndex = 3;
            this.labelForRefresh.Text = "刷新间隔（秒）：";
            // 
            // comboBoxForRefresh
            // 
            this.comboBoxForRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForRefresh.Items.AddRange(new object[] {
            "3",
            "5",
            "8",
            "10",
            "15",
            "30",
            "60",
            "180",
            "300",
            "480",
            "600",
            "900",
            "1800",
            "3600"});
            this.comboBoxForRefresh.Location = new System.Drawing.Point(109, 12);
            this.comboBoxForRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxForRefresh.Name = "comboBoxForRefresh";
            this.comboBoxForRefresh.Size = new System.Drawing.Size(114, 20);
            this.comboBoxForRefresh.TabIndex = 4;
            // 
            // labelForList
            // 
            this.labelForList.AutoSize = true;
            this.labelForList.Location = new System.Drawing.Point(9, 46);
            this.labelForList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForList.Name = "labelForList";
            this.labelForList.Size = new System.Drawing.Size(137, 12);
            this.labelForList.TabIndex = 5;
            this.labelForList.Text = "监控列表（一行一个）：";
            // 
            // textBoxStockList
            // 
            this.textBoxStockList.Location = new System.Drawing.Point(11, 63);
            this.textBoxStockList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStockList.Multiline = true;
            this.textBoxStockList.Name = "textBoxStockList";
            this.textBoxStockList.Size = new System.Drawing.Size(212, 175);
            this.textBoxStockList.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(137, 243);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "保存设置";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 282);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxStockList);
            this.Controls.Add(this.labelForList);
            this.Controls.Add(this.comboBoxForRefresh);
            this.Controls.Add(this.labelForRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelForRefresh;
        private System.Windows.Forms.ComboBox comboBoxForRefresh;
        private System.Windows.Forms.Label labelForList;
        private System.Windows.Forms.TextBox textBoxStockList;
        private System.Windows.Forms.Button buttonSave;
    }
}