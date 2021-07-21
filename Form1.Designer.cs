
namespace Game__
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.VeryHard = new System.Windows.Forms.RadioButton();
            this.GameStart = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Checked = true;
            this.Easy.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Easy.Location = new System.Drawing.Point(20, 60);
            this.Easy.Margin = new System.Windows.Forms.Padding(4);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(176, 40);
            this.Easy.TabIndex = 0;
            this.Easy.TabStop = true;
            this.Easy.Text = "難度：初階";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Normal.Location = new System.Drawing.Point(20, 140);
            this.Normal.Margin = new System.Windows.Forms.Padding(4);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(176, 40);
            this.Normal.TabIndex = 1;
            this.Normal.Text = "難度：中階";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hard.Location = new System.Drawing.Point(20, 220);
            this.Hard.Margin = new System.Windows.Forms.Padding(4);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(176, 40);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "難度：高階";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // VeryHard
            // 
            this.VeryHard.AutoSize = true;
            this.VeryHard.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VeryHard.Location = new System.Drawing.Point(20, 300);
            this.VeryHard.Margin = new System.Windows.Forms.Padding(4);
            this.VeryHard.Name = "VeryHard";
            this.VeryHard.Size = new System.Drawing.Size(176, 40);
            this.VeryHard.TabIndex = 3;
            this.VeryHard.Text = "難度：煉獄";
            this.VeryHard.UseVisualStyleBackColor = true;
            // 
            // GameStart
            // 
            this.GameStart.FlatAppearance.BorderSize = 10;
            this.GameStart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStart.Location = new System.Drawing.Point(30, 361);
            this.GameStart.Margin = new System.Windows.Forms.Padding(4);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(155, 89);
            this.GameStart.TabIndex = 5;
            this.GameStart.Text = "Game Start";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Easy);
            this.splitContainer1.Panel1.Controls.Add(this.GameStart);
            this.splitContainer1.Panel1.Controls.Add(this.Normal);
            this.splitContainer1.Panel1.Controls.Add(this.Hard);
            this.splitContainer1.Panel1.Controls.Add(this.VeryHard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Size = new System.Drawing.Size(1285, 660);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "翻牌小遊戲";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton VeryHard;
        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

