namespace TacheEnvironnement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 87);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 55F);
            label1.Location = new Point(74, -2);
            label1.Name = "label1";
            label1.Size = new Size(249, 86);
            label1.TabIndex = 1;
            label1.Text = "Tasks";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(-8, 193);
            panel2.MinimumSize = new Size(400, 445);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 575);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Arial Rounded MT Bold", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 772);
            label3.Name = "label3";
            label3.Size = new Size(395, 70);
            label3.TabIndex = 2;
            label3.Text = "Task Completed : 10/10";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Arial Rounded MT Bold", 15F);
            textBox1.Location = new Point(11, 153);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Placeholder";
            textBox1.Size = new Size(122, 24);
            textBox1.TabIndex = 7;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 841);
            panel3.TabIndex = 8;
            panel3.Click += panel3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 15F);
            button1.Location = new Point(265, 147);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(388, 835);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Task Manager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel3;
        private Button button1;
    }
}
