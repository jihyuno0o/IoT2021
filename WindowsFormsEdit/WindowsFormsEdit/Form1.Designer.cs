
namespace WindowsFormsEdit
{
    partial class formMemo
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
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSearchnext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewForecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewBackcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.Location = new System.Drawing.Point(0, 27);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMemo.Size = new System.Drawing.Size(800, 422);
            this.tbMemo.TabIndex = 1;
            this.tbMemo.TextChanged += new System.EventHandler(this.tbMemo_TextChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(103, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(103, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditSearch,
            this.mnuEditSearchnext,
            this.btnEditReplace});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEditSearch
            // 
            this.mnuEditSearch.Name = "mnuEditSearch";
            this.mnuEditSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuEditSearch.Size = new System.Drawing.Size(180, 22);
            this.mnuEditSearch.Text = "Search";
            this.mnuEditSearch.ToolTipText = "현재의 문서에서 특정한 문자열을 찾습니다.";
            this.mnuEditSearch.Click += new System.EventHandler(this.mnuEditSearch_Click);
            // 
            // mnuEditSearchnext
            // 
            this.mnuEditSearchnext.Name = "mnuEditSearchnext";
            this.mnuEditSearchnext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuEditSearchnext.Size = new System.Drawing.Size(180, 22);
            this.mnuEditSearchnext.Text = "Search Next";
            this.mnuEditSearchnext.Click += new System.EventHandler(this.mnuEditSearchnext_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewFont,
            this.mnuViewForecolor,
            this.mnuViewBackcolor});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "View";
            // 
            // mnuViewFont
            // 
            this.mnuViewFont.Name = "mnuViewFont";
            this.mnuViewFont.Size = new System.Drawing.Size(132, 22);
            this.mnuViewFont.Text = "Font";
            this.mnuViewFont.Click += new System.EventHandler(this.mnuViewFont_Click);
            // 
            // mnuViewForecolor
            // 
            this.mnuViewForecolor.Name = "mnuViewForecolor";
            this.mnuViewForecolor.Size = new System.Drawing.Size(132, 22);
            this.mnuViewForecolor.Text = "Fore Color";
            this.mnuViewForecolor.Click += new System.EventHandler(this.mnuViewForecolor_Click);
            // 
            // mnuViewBackcolor
            // 
            this.mnuViewBackcolor.Name = "mnuViewBackcolor";
            this.mnuViewBackcolor.Size = new System.Drawing.Size(132, 22);
            this.mnuViewBackcolor.Text = "Back Color";
            this.mnuViewBackcolor.Click += new System.EventHandler(this.mnuViewBackcolor_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2,
            this.sbLabel3,
            this.sbLabel4});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(63, 17);
            this.sbLabel1.Text = "FontName";
            // 
            // sbLabel2
            // 
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(53, 17);
            this.sbLabel2.Text = "FontSize";
            // 
            // sbLabel3
            // 
            this.sbLabel3.Name = "sbLabel3";
            this.sbLabel3.Size = new System.Drawing.Size(59, 17);
            this.sbLabel3.Text = "ForeColor";
            // 
            // sbLabel4
            // 
            this.sbLabel4.Name = "sbLabel4";
            this.sbLabel4.Size = new System.Drawing.Size(61, 17);
            this.sbLabel4.Text = "BackColor";
            // 
            // btnEditReplace
            // 
            this.btnEditReplace.Name = "btnEditReplace";
            this.btnEditReplace.Size = new System.Drawing.Size(180, 22);
            this.btnEditReplace.Text = "Search_Replace";
            this.btnEditReplace.Click += new System.EventHandler(this.btnEditReplace_Click);
            // 
            // formMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "formMemo";
            this.Text = "MyEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuViewFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripMenuItem mnuViewForecolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel3;
        private System.Windows.Forms.ToolStripMenuItem mnuViewBackcolor;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel4;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSearchnext;
        private System.Windows.Forms.ToolStripMenuItem btnEditReplace;
    }
}

