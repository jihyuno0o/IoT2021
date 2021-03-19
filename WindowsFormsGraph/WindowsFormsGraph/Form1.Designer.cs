
namespace WindowsFormsGraph
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
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.CanvasDraw = new System.Windows.Forms.PictureBox();
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(20, 17);
            this.sbLabel1.Text = "-.-";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDraw,
            this.mnuErase});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // mnuDraw
            // 
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(180, 22);
            this.mnuDraw.Text = "그리기";
            this.mnuDraw.Click += new System.EventHandler(this.mnuDraw_Click);
            // 
            // CanvasDraw
            // 
            this.CanvasDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasDraw.ContextMenuStrip = this.contextMenuStrip1;
            this.CanvasDraw.Location = new System.Drawing.Point(0, -5);
            this.CanvasDraw.Name = "CanvasDraw";
            this.CanvasDraw.Size = new System.Drawing.Size(800, 430);
            this.CanvasDraw.TabIndex = 3;
            this.CanvasDraw.TabStop = false;
            this.CanvasDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasDraw_MouseDown_1);
            this.CanvasDraw.Resize += new System.EventHandler(this.CanvasDraw_Resize);
            // 
            // mnuErase
            // 
            this.mnuErase.Name = "mnuErase";
            this.mnuErase.Size = new System.Drawing.Size(180, 22);
            this.mnuErase.Text = "모두 지우기";
            this.mnuErase.Click += new System.EventHandler(this.mnuErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CanvasDraw);
            this.Controls.Add(this.statusBar);
            this.Name = "Form1";
            this.Text = "그림판";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.PictureBox CanvasDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
    }
}

