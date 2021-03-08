
namespace FileCopyApp
{
    partial class FrmMain
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
            this.LblSource = new System.Windows.Forms.Label();
            this.LblTarget = new System.Windows.Forms.Label();
            this.Txtsource = new System.Windows.Forms.TextBox();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.BtnSource = new System.Windows.Forms.Button();
            this.BtnTarget = new System.Windows.Forms.Button();
            this.BtnAsyncCopy = new System.Windows.Forms.Button();
            this.BtnSyncCopy = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PrbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(6, 10);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(57, 12);
            this.LblSource.TabIndex = 0;
            this.LblSource.Text = "Source : ";
            // 
            // LblTarget
            // 
            this.LblTarget.AutoSize = true;
            this.LblTarget.Location = new System.Drawing.Point(10, 36);
            this.LblTarget.Name = "LblTarget";
            this.LblTarget.Size = new System.Drawing.Size(53, 12);
            this.LblTarget.TabIndex = 0;
            this.LblTarget.Text = "Target : ";
            // 
            // Txtsource
            // 
            this.Txtsource.Location = new System.Drawing.Point(65, 6);
            this.Txtsource.Name = "Txtsource";
            this.Txtsource.Size = new System.Drawing.Size(344, 21);
            this.Txtsource.TabIndex = 1;
            // 
            // TxtTarget
            // 
            this.TxtTarget.Location = new System.Drawing.Point(65, 33);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(344, 21);
            this.TxtTarget.TabIndex = 3;
            // 
            // BtnSource
            // 
            this.BtnSource.Location = new System.Drawing.Point(415, 6);
            this.BtnSource.Name = "BtnSource";
            this.BtnSource.Size = new System.Drawing.Size(46, 21);
            this.BtnSource.TabIndex = 2;
            this.BtnSource.Text = "...";
            this.BtnSource.UseVisualStyleBackColor = true;
            this.BtnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // BtnTarget
            // 
            this.BtnTarget.Location = new System.Drawing.Point(415, 33);
            this.BtnTarget.Name = "BtnTarget";
            this.BtnTarget.Size = new System.Drawing.Size(46, 21);
            this.BtnTarget.TabIndex = 4;
            this.BtnTarget.Text = "...";
            this.BtnTarget.UseVisualStyleBackColor = true;
            this.BtnTarget.Click += new System.EventHandler(this.BtnTarget_Click);
            // 
            // BtnAsyncCopy
            // 
            this.BtnAsyncCopy.Location = new System.Drawing.Point(14, 73);
            this.BtnAsyncCopy.Name = "BtnAsyncCopy";
            this.BtnAsyncCopy.Size = new System.Drawing.Size(95, 35);
            this.BtnAsyncCopy.TabIndex = 5;
            this.BtnAsyncCopy.Text = "Async Copy";
            this.BtnAsyncCopy.UseVisualStyleBackColor = true;
            this.BtnAsyncCopy.Click += new System.EventHandler(this.BtnAsyncCopy_Click);
            // 
            // BtnSyncCopy
            // 
            this.BtnSyncCopy.Location = new System.Drawing.Point(190, 73);
            this.BtnSyncCopy.Name = "BtnSyncCopy";
            this.BtnSyncCopy.Size = new System.Drawing.Size(95, 35);
            this.BtnSyncCopy.TabIndex = 6;
            this.BtnSyncCopy.Text = "Sync Copy";
            this.BtnSyncCopy.UseVisualStyleBackColor = true;
            this.BtnSyncCopy.Click += new System.EventHandler(this.BtnSyncCopy_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(366, 73);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 35);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PrbCopy
            // 
            this.PrbCopy.Location = new System.Drawing.Point(14, 114);
            this.PrbCopy.Name = "PrbCopy";
            this.PrbCopy.Size = new System.Drawing.Size(447, 28);
            this.PrbCopy.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 154);
            this.Controls.Add(this.PrbCopy);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSyncCopy);
            this.Controls.Add(this.BtnAsyncCopy);
            this.Controls.Add(this.BtnTarget);
            this.Controls.Add(this.BtnSource);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.Txtsource);
            this.Controls.Add(this.LblTarget);
            this.Controls.Add(this.LblSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async File Copy App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Label LblTarget;
        private System.Windows.Forms.TextBox Txtsource;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Button BtnSource;
        private System.Windows.Forms.Button BtnTarget;
        private System.Windows.Forms.Button BtnAsyncCopy;
        private System.Windows.Forms.Button BtnSyncCopy;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ProgressBar PrbCopy;
    }
}

