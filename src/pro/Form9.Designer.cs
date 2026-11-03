namespace WinFormsApp1
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            btnone = new Button();
            btnlu = new Button();
            btnjji = new Button();
            SuspendLayout();
            // 
            // btnone
            // 
            btnone.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnone.ForeColor = Color.DeepSkyBlue;
            btnone.Location = new Point(82, 271);
            btnone.Name = "btnone";
            btnone.Size = new Size(216, 99);
            btnone.TabIndex = 0;
            btnone.Text = "원투 낚시";
            btnone.UseVisualStyleBackColor = true;
            btnone.Click += btnone_Click;
            // 
            // btnlu
            // 
            btnlu.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnlu.ForeColor = Color.DeepSkyBlue;
            btnlu.Location = new Point(387, 271);
            btnlu.Name = "btnlu";
            btnlu.Size = new Size(216, 99);
            btnlu.TabIndex = 0;
            btnlu.Text = "루어 낚시";
            btnlu.UseVisualStyleBackColor = true;
            btnlu.Click += btnlu_Click;
            // 
            // btnjji
            // 
            btnjji.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnjji.ForeColor = Color.DeepSkyBlue;
            btnjji.Location = new Point(678, 271);
            btnjji.Name = "btnjji";
            btnjji.Size = new Size(216, 99);
            btnjji.TabIndex = 0;
            btnjji.Text = "찌 낚시";
            btnjji.UseVisualStyleBackColor = true;
            btnjji.Click += btnjji_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1005, 620);
            Controls.Add(btnjji);
            Controls.Add(btnlu);
            Controls.Add(btnone);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
        }

        #endregion

        private Button btnone;
        private Button btnlu;
        private Button btnjji;
    }
}