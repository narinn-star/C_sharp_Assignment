﻿namespace _20203179_이나린_과제3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선굵기LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선모양SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색변경CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.선굵기LToolStripMenuItem,
            this.선모양SToolStripMenuItem,
            this.색변경CToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(1, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 554);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.종료XToolStripMenuItem.Text = "종료(X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 선굵기LToolStripMenuItem
            // 
            this.선굵기LToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.굵기10ToolStripMenuItem,
            this.굵기5ToolStripMenuItem,
            this.굵기3ToolStripMenuItem,
            this.굵기1ToolStripMenuItem});
            this.선굵기LToolStripMenuItem.Name = "선굵기LToolStripMenuItem";
            this.선굵기LToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.선굵기LToolStripMenuItem.Text = "선 굵기(L)";
            // 
            // 굵기10ToolStripMenuItem
            // 
            this.굵기10ToolStripMenuItem.Name = "굵기10ToolStripMenuItem";
            this.굵기10ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.굵기10ToolStripMenuItem.Text = "굵기 10";
            this.굵기10ToolStripMenuItem.Click += new System.EventHandler(this.굵기10ToolStripMenuItem_Click);
            // 
            // 굵기5ToolStripMenuItem
            // 
            this.굵기5ToolStripMenuItem.Name = "굵기5ToolStripMenuItem";
            this.굵기5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.굵기5ToolStripMenuItem.Text = "굵기 5";
            this.굵기5ToolStripMenuItem.Click += new System.EventHandler(this.굵기5ToolStripMenuItem_Click);
            // 
            // 굵기3ToolStripMenuItem
            // 
            this.굵기3ToolStripMenuItem.Name = "굵기3ToolStripMenuItem";
            this.굵기3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.굵기3ToolStripMenuItem.Text = "굵기 3";
            this.굵기3ToolStripMenuItem.Click += new System.EventHandler(this.굵기3ToolStripMenuItem_Click);
            // 
            // 굵기1ToolStripMenuItem
            // 
            this.굵기1ToolStripMenuItem.Name = "굵기1ToolStripMenuItem";
            this.굵기1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.굵기1ToolStripMenuItem.Text = "굵기 1";
            this.굵기1ToolStripMenuItem.Click += new System.EventHandler(this.굵기1ToolStripMenuItem_Click);
            // 
            // 선모양SToolStripMenuItem
            // 
            this.선모양SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotToolStripMenuItem,
            this.dashDotToolStripMenuItem,
            this.solidToolStripMenuItem});
            this.선모양SToolStripMenuItem.Name = "선모양SToolStripMenuItem";
            this.선모양SToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.선모양SToolStripMenuItem.Text = "선 모양(S)";
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // dashDotToolStripMenuItem
            // 
            this.dashDotToolStripMenuItem.Name = "dashDotToolStripMenuItem";
            this.dashDotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dashDotToolStripMenuItem.Text = "DashDot";
            this.dashDotToolStripMenuItem.Click += new System.EventHandler(this.dashDotToolStripMenuItem_Click);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // 색변경CToolStripMenuItem
            // 
            this.색변경CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorLToolStripMenuItem});
            this.색변경CToolStripMenuItem.Name = "색변경CToolStripMenuItem";
            this.색변경CToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.색변경CToolStripMenuItem.Text = "색 변경(C)";
            // 
            // colorLToolStripMenuItem
            // 
            this.colorLToolStripMenuItem.Name = "colorLToolStripMenuItem";
            this.colorLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorLToolStripMenuItem.Text = "Color(L)";
            this.colorLToolStripMenuItem.Click += new System.EventHandler(this.colorLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "마우스 이벤트";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선굵기LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선모양SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색변경CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

