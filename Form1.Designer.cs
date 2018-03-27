namespace SynFiles
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnSyn = new System.Windows.Forms.Button();
            this.btnStartSyn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStopSyn = new System.Windows.Forms.Button();
            this.logView = new System.Windows.Forms.ListView();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.txtSyn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(13, 13);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(96, 23);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "选择主文件夹";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnSyn
            // 
            this.btnSyn.Location = new System.Drawing.Point(13, 43);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.Size = new System.Drawing.Size(96, 23);
            this.btnSyn.TabIndex = 1;
            this.btnSyn.Text = "同步文件夹";
            this.btnSyn.UseVisualStyleBackColor = true;
            this.btnSyn.Click += new System.EventHandler(this.btnSyn_Click);
            // 
            // btnStartSyn
            // 
            this.btnStartSyn.Location = new System.Drawing.Point(13, 73);
            this.btnStartSyn.Name = "btnStartSyn";
            this.btnStartSyn.Size = new System.Drawing.Size(96, 23);
            this.btnStartSyn.TabIndex = 4;
            this.btnStartSyn.Text = "开始同步";
            this.btnStartSyn.UseVisualStyleBackColor = true;
            this.btnStartSyn.Click += new System.EventHandler(this.btnStartSyn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStopSyn
            // 
            this.btnStopSyn.Enabled = false;
            this.btnStopSyn.Location = new System.Drawing.Point(117, 72);
            this.btnStopSyn.Name = "btnStopSyn";
            this.btnStopSyn.Size = new System.Drawing.Size(75, 23);
            this.btnStopSyn.TabIndex = 5;
            this.btnStopSyn.Text = "停止同步";
            this.btnStopSyn.UseVisualStyleBackColor = true;
            this.btnStopSyn.Click += new System.EventHandler(this.btnStopSyn_Click);
            // 
            // logView
            // 
            this.logView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.logView.Location = new System.Drawing.Point(13, 102);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(688, 323);
            this.logView.TabIndex = 6;
            this.logView.UseCompatibleStateImageBehavior = false;
            this.logView.View = System.Windows.Forms.View.List;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(115, 15);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(586, 21);
            this.txtMain.TabIndex = 7;
            // 
            // txtSyn
            // 
            this.txtSyn.Location = new System.Drawing.Point(115, 45);
            this.txtSyn.Name = "txtSyn";
            this.txtSyn.Size = new System.Drawing.Size(586, 21);
            this.txtSyn.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 454);
            this.Controls.Add(this.txtSyn);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.logView);
            this.Controls.Add(this.btnStopSyn);
            this.Controls.Add(this.btnStartSyn);
            this.Controls.Add(this.btnSyn);
            this.Controls.Add(this.btnMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnSyn;
        private System.Windows.Forms.Button btnStartSyn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStopSyn;
        private System.Windows.Forms.ListView logView;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TextBox txtSyn;
    }
}

