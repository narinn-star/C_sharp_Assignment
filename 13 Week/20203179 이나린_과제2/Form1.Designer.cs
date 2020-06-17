namespace _20203179_이나린_과제2
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
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택ACtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FCtrlFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.색깔CCtrlShiftCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNOCtrlShiftOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.oFFFCtrlShiftFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식JToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들ToolStripMenuItem,
            this.열ToolStripMenuItem,
            this.저장SCtrlSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.끝내기ToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 새로만들ToolStripMenuItem
            // 
            this.새로만들ToolStripMenuItem.Name = "새로만들ToolStripMenuItem";
            this.새로만들ToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.새로만들ToolStripMenuItem.Text = "새로만들기 (N)      Ctrl+N";
            this.새로만들ToolStripMenuItem.Click += new System.EventHandler(this.새로만들ToolStripMenuItem_Click);
            // 
            // 열ToolStripMenuItem
            // 
            this.열ToolStripMenuItem.Name = "열ToolStripMenuItem";
            this.열ToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.열ToolStripMenuItem.Text = "열기 (O)               Ctrl+O";
            this.열ToolStripMenuItem.Click += new System.EventHandler(this.열ToolStripMenuItem_Click);
            // 
            // 저장SCtrlSToolStripMenuItem
            // 
            this.저장SCtrlSToolStripMenuItem.Name = "저장SCtrlSToolStripMenuItem";
            this.저장SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.저장SCtrlSToolStripMenuItem.Text = "저장 (S)                Ctrl+S";
            this.저장SCtrlSToolStripMenuItem.Click += new System.EventHandler(this.저장SCtrlSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기 (X)            Ctrl+X";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내기TCtrlTToolStripMenuItem,
            this.복사CCtrlCToolStripMenuItem,
            this.붙여넣기PCtrlPToolStripMenuItem,
            this.삭제DCtrlDToolStripMenuItem,
            this.toolStripMenuItem2,
            this.모두선택ACtrlAToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 잘라내기TCtrlTToolStripMenuItem
            // 
            this.잘라내기TCtrlTToolStripMenuItem.Name = "잘라내기TCtrlTToolStripMenuItem";
            this.잘라내기TCtrlTToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.잘라내기TCtrlTToolStripMenuItem.Text = "잘라내기 (T)      Ctrl+T";
            this.잘라내기TCtrlTToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TCtrlTToolStripMenuItem_Click);
            // 
            // 복사CCtrlCToolStripMenuItem
            // 
            this.복사CCtrlCToolStripMenuItem.Name = "복사CCtrlCToolStripMenuItem";
            this.복사CCtrlCToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.복사CCtrlCToolStripMenuItem.Text = "복사 (C)           Ctrl+C";
            this.복사CCtrlCToolStripMenuItem.Click += new System.EventHandler(this.복사CCtrlCToolStripMenuItem_Click);
            // 
            // 붙여넣기PCtrlPToolStripMenuItem
            // 
            this.붙여넣기PCtrlPToolStripMenuItem.Name = "붙여넣기PCtrlPToolStripMenuItem";
            this.붙여넣기PCtrlPToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.붙여넣기PCtrlPToolStripMenuItem.Text = "붙여넣기 (P)      Ctrl+P";
            this.붙여넣기PCtrlPToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기PCtrlPToolStripMenuItem_Click);
            // 
            // 삭제DCtrlDToolStripMenuItem
            // 
            this.삭제DCtrlDToolStripMenuItem.Name = "삭제DCtrlDToolStripMenuItem";
            this.삭제DCtrlDToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.삭제DCtrlDToolStripMenuItem.Text = "삭제 (D)           Ctrl+D";
            this.삭제DCtrlDToolStripMenuItem.Click += new System.EventHandler(this.삭제DCtrlDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 6);
            // 
            // 모두선택ACtrlAToolStripMenuItem
            // 
            this.모두선택ACtrlAToolStripMenuItem.Name = "모두선택ACtrlAToolStripMenuItem";
            this.모두선택ACtrlAToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.모두선택ACtrlAToolStripMenuItem.Text = "모두선택 (A)     Ctrl+A";
            this.모두선택ACtrlAToolStripMenuItem.Click += new System.EventHandler(this.모두선택ACtrlAToolStripMenuItem_Click);
            // 
            // 서식JToolStripMenuItem
            // 
            this.서식JToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴FCtrlFToolStripMenuItem,
            this.toolStripMenuItem3,
            this.색깔CCtrlShiftCToolStripMenuItem});
            this.서식JToolStripMenuItem.Name = "서식JToolStripMenuItem";
            this.서식JToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.서식JToolStripMenuItem.Text = "서식(J)";
            // 
            // 글꼴FCtrlFToolStripMenuItem
            // 
            this.글꼴FCtrlFToolStripMenuItem.Name = "글꼴FCtrlFToolStripMenuItem";
            this.글꼴FCtrlFToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.글꼴FCtrlFToolStripMenuItem.Text = "글꼴(F)            Ctrl+F";
            this.글꼴FCtrlFToolStripMenuItem.Click += new System.EventHandler(this.글꼴FCtrlFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 6);
            // 
            // 색깔CCtrlShiftCToolStripMenuItem
            // 
            this.색깔CCtrlShiftCToolStripMenuItem.Name = "색깔CCtrlShiftCToolStripMenuItem";
            this.색깔CCtrlShiftCToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.색깔CCtrlShiftCToolStripMenuItem.Text = "색깔(C)  Ctrl+Shift+C";
            this.색깔CCtrlShiftCToolStripMenuItem.Click += new System.EventHandler(this.색깔CCtrlShiftCToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNOCtrlShiftOToolStripMenuItem,
            this.toolStripMenuItem4,
            this.oFFFCtrlShiftFToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // oNOCtrlShiftOToolStripMenuItem
            // 
            this.oNOCtrlShiftOToolStripMenuItem.Name = "oNOCtrlShiftOToolStripMenuItem";
            this.oNOCtrlShiftOToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.oNOCtrlShiftOToolStripMenuItem.Text = "ON(O)    Ctrl+Shift+O";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(243, 6);
            // 
            // oFFFCtrlShiftFToolStripMenuItem
            // 
            this.oFFFCtrlShiftFToolStripMenuItem.Name = "oFFFCtrlShiftFToolStripMenuItem";
            this.oFFFCtrlShiftFToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.oFFFCtrlShiftFToolStripMenuItem.Text = "OFF(F)     Ctrl+Shift+F";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1141, 565);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 596);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "메모장";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식JToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TCtrlTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DCtrlDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ACtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FCtrlFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 색깔CCtrlShiftCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNOCtrlShiftOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem oFFFCtrlShiftFToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

