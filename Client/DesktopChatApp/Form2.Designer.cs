namespace DesktopChatApp
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Location = new Point(28, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3918133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.6081848F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 208F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Size = new Size(506, 499);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(55, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 171);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SIGN UP";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 2;
            textBox3.UseSystemPasswordChar = true;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Leave += textBox1_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 136);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 0;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 86);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 5;
            label1.Text = "Registration Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Location = new Point(190, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Location = new Point(206, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 25);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider5.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 545);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label label4;
        private TextBox textBox3;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}