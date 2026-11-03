namespace WinFormsApp1
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            btnfish = new Button();
            btnpoint = new Button();
            button12 = new Button();
            button2 = new Button();
            button122 = new Button();
            button12342 = new Button();
            SuspendLayout();
            // 
            // btnfish
            // 
            btnfish.BackColor = Color.Transparent;
            btnfish.FlatStyle = FlatStyle.Flat;
            btnfish.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfish.Location = new Point(108, 181);
            btnfish.Name = "btnfish";
            btnfish.Size = new Size(173, 252);
            btnfish.TabIndex = 0;
            btnfish.Text = "낚시용품";
            btnfish.UseVisualStyleBackColor = false;
            btnfish.Click += btnfish_Click;
            // 
            // btnpoint
            // 
            btnpoint.BackColor = Color.Transparent;
            btnpoint.FlatStyle = FlatStyle.Flat;
            btnpoint.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnpoint.Location = new Point(480, 82);
            btnpoint.Name = "btnpoint";
            btnpoint.Size = new Size(165, 138);
            btnpoint.TabIndex = 0;
            btnpoint.Text = "서해포인트";
            btnpoint.UseVisualStyleBackColor = false;
            btnpoint.Click += btnpoint_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(732, 82);
            button12.Name = "button12";
            button12.Size = new Size(165, 138);
            button12.TabIndex = 0;
            button12.Text = "동해포인트";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(480, 254);
            button2.Name = "button2";
            button2.Size = new Size(165, 138);
            button2.TabIndex = 0;
            button2.Text = "남해포인트";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button122
            // 
            button122.BackColor = Color.Transparent;
            button122.FlatStyle = FlatStyle.Flat;
            button122.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button122.Location = new Point(732, 254);
            button122.Name = "button122";
            button122.Size = new Size(165, 138);
            button122.TabIndex = 0;
            button122.Text = "물때확인하는곳";
            button122.UseVisualStyleBackColor = false;
            button122.Click += button122_Click;
            // 
            // button12342
            // 
            button12342.BackColor = Color.Transparent;
            button12342.FlatStyle = FlatStyle.Flat;
            button12342.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12342.Location = new Point(595, 427);
            button12342.Name = "button12342";
            button12342.Size = new Size(165, 138);
            button12342.TabIndex = 0;
            button12342.Text = "낚시 포인트 사이트";
            button12342.UseVisualStyleBackColor = false;
            button12342.Click += button12342_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1005, 620);
            Controls.Add(button12342);
            Controls.Add(button122);
            Controls.Add(button2);
            Controls.Add(button12);
            Controls.Add(btnpoint);
            Controls.Add(btnfish);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
        }

        #endregion

        private Button btnfish;
        private Button btnpoint;
        private Button button12;
        private Button button2;
        private Button button122;
        private Button button12342;
    }
}