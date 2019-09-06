namespace adHelper
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGetImgCss = new System.Windows.Forms.TextBox();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabpgPtoCss = new System.Windows.Forms.TabPage();
            this.tabpgHtml = new System.Windows.Forms.TabPage();
            this.txtGetImgHtml = new System.Windows.Forms.TextBox();
            this.tabpgSetting = new System.Windows.Forms.TabPage();
            this.gbSet1 = new System.Windows.Forms.GroupBox();
            this.cbxIsMerge = new System.Windows.Forms.CheckBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.txtGlobalClass = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.txtRemMultiple = new System.Windows.Forms.TextBox();
            this.tabCtrlMain.SuspendLayout();
            this.tabpgPtoCss.SuspendLayout();
            this.tabpgHtml.SuspendLayout();
            this.tabpgSetting.SuspendLayout();
            this.gbSet1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGetImgCss
            // 
            this.txtGetImgCss.AllowDrop = true;
            this.txtGetImgCss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGetImgCss.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGetImgCss.Location = new System.Drawing.Point(2, 4);
            this.txtGetImgCss.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtGetImgCss.Multiline = true;
            this.txtGetImgCss.Name = "txtGetImgCss";
            this.txtGetImgCss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGetImgCss.Size = new System.Drawing.Size(612, 404);
            this.txtGetImgCss.TabIndex = 0;
            this.txtGetImgCss.WordWrap = false;
            this.txtGetImgCss.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtGetImgCss_DragDrop);
            this.txtGetImgCss.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtGetImgCss_DragEnter);
            this.txtGetImgCss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGetImgCss_KeyDown);
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabpgPtoCss);
            this.tabCtrlMain.Controls.Add(this.tabpgHtml);
            this.tabCtrlMain.Controls.Add(this.tabpgSetting);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(624, 442);
            this.tabCtrlMain.TabIndex = 1;
            // 
            // tabpgPtoCss
            // 
            this.tabpgPtoCss.Controls.Add(this.txtGetImgCss);
            this.tabpgPtoCss.Location = new System.Drawing.Point(4, 26);
            this.tabpgPtoCss.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabpgPtoCss.Name = "tabpgPtoCss";
            this.tabpgPtoCss.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabpgPtoCss.Size = new System.Drawing.Size(616, 412);
            this.tabpgPtoCss.TabIndex = 0;
            this.tabpgPtoCss.Text = "CSS";
            this.tabpgPtoCss.UseVisualStyleBackColor = true;
            // 
            // tabpgHtml
            // 
            this.tabpgHtml.Controls.Add(this.txtGetImgHtml);
            this.tabpgHtml.Location = new System.Drawing.Point(4, 26);
            this.tabpgHtml.Name = "tabpgHtml";
            this.tabpgHtml.Size = new System.Drawing.Size(616, 412);
            this.tabpgHtml.TabIndex = 2;
            this.tabpgHtml.Text = "HTML";
            this.tabpgHtml.UseVisualStyleBackColor = true;
            // 
            // txtGetImgHtml
            // 
            this.txtGetImgHtml.AllowDrop = true;
            this.txtGetImgHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGetImgHtml.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGetImgHtml.Location = new System.Drawing.Point(0, 0);
            this.txtGetImgHtml.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtGetImgHtml.Multiline = true;
            this.txtGetImgHtml.Name = "txtGetImgHtml";
            this.txtGetImgHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGetImgHtml.Size = new System.Drawing.Size(616, 412);
            this.txtGetImgHtml.TabIndex = 1;
            this.txtGetImgHtml.WordWrap = false;
            // 
            // tabpgSetting
            // 
            this.tabpgSetting.Controls.Add(this.gbSet1);
            this.tabpgSetting.Location = new System.Drawing.Point(4, 26);
            this.tabpgSetting.Name = "tabpgSetting";
            this.tabpgSetting.Size = new System.Drawing.Size(616, 412);
            this.tabpgSetting.TabIndex = 1;
            this.tabpgSetting.Text = "设置";
            this.tabpgSetting.UseVisualStyleBackColor = true;
            // 
            // gbSet1
            // 
            this.gbSet1.Controls.Add(this.cbxIsMerge);
            this.gbSet1.Controls.Add(this.lab1);
            this.gbSet1.Controls.Add(this.txtGlobalClass);
            this.gbSet1.Controls.Add(this.lab2);
            this.gbSet1.Controls.Add(this.lab3);
            this.gbSet1.Controls.Add(this.cboxUnit);
            this.gbSet1.Controls.Add(this.txtRemMultiple);
            this.gbSet1.Location = new System.Drawing.Point(16, 16);
            this.gbSet1.Name = "gbSet1";
            this.gbSet1.Size = new System.Drawing.Size(216, 192);
            this.gbSet1.TabIndex = 6;
            this.gbSet1.TabStop = false;
            this.gbSet1.Text = "公 共";
            // 
            // cbxIsMerge
            // 
            this.cbxIsMerge.AutoSize = true;
            this.cbxIsMerge.Location = new System.Drawing.Point(69, 113);
            this.cbxIsMerge.Name = "cbxIsMerge";
            this.cbxIsMerge.Size = new System.Drawing.Size(87, 21);
            this.cbxIsMerge.TabIndex = 6;
            this.cbxIsMerge.Text = "多图则组合";
            this.cbxIsMerge.UseVisualStyleBackColor = true;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(28, 26);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 17);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "单位:";
            // 
            // txtGlobalClass
            // 
            this.txtGlobalClass.Location = new System.Drawing.Point(69, 82);
            this.txtGlobalClass.Name = "txtGlobalClass";
            this.txtGlobalClass.Size = new System.Drawing.Size(121, 23);
            this.txtGlobalClass.TabIndex = 5;
            this.txtGlobalClass.Text = "cimg";
            this.txtGlobalClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(5, 56);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(58, 17);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "rem倍数:";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(16, 85);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(47, 17);
            this.lab3.TabIndex = 4;
            this.lab3.Text = "公共类:";
            // 
            // cboxUnit
            // 
            this.cboxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.Items.AddRange(new object[] {
            "rem",
            "px",
            "em",
            "%"});
            this.cboxUnit.Location = new System.Drawing.Point(69, 22);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(121, 25);
            this.cboxUnit.TabIndex = 1;
            this.cboxUnit.SelectedIndexChanged += new System.EventHandler(this.cboxUnit_SelectedIndexChanged);
            // 
            // txtRemMultiple
            // 
            this.txtRemMultiple.Location = new System.Drawing.Point(69, 53);
            this.txtRemMultiple.Name = "txtRemMultiple";
            this.txtRemMultiple.Size = new System.Drawing.Size(121, 23);
            this.txtRemMultiple.TabIndex = 3;
            this.txtRemMultiple.Text = "100";
            this.txtRemMultiple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabCtrlMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "mainForm";
            this.Text = "adHelper";
            this.tabCtrlMain.ResumeLayout(false);
            this.tabpgPtoCss.ResumeLayout(false);
            this.tabpgPtoCss.PerformLayout();
            this.tabpgHtml.ResumeLayout(false);
            this.tabpgHtml.PerformLayout();
            this.tabpgSetting.ResumeLayout(false);
            this.gbSet1.ResumeLayout(false);
            this.gbSet1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetImgCss;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabpgPtoCss;
        private System.Windows.Forms.TabPage tabpgSetting;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.TextBox txtRemMultiple;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox txtGlobalClass;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.GroupBox gbSet1;
        private System.Windows.Forms.CheckBox cbxIsMerge;
        private System.Windows.Forms.TabPage tabpgHtml;
        private System.Windows.Forms.TextBox txtGetImgHtml;
    }
}

