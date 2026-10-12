namespace gul_satisi
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(758, 199);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Gül növü (gül adı)";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Satış sayı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Qiyməti";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Yekun qiyməti";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(23, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 238);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gül məlumatları";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(93, 34);
            textBox2.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(19, 163);
            maskedTextBox1.Mask = "000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(93, 34);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(256, 156);
            button1.Name = "button1";
            button1.Size = new Size(85, 48);
            button1.TabIndex = 6;
            button1.Text = "Satış et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 34);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 125);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 2;
            label3.Text = "Qiymət";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 125);
            label2.Name = "label2";
            label2.Size = new Size(43, 28);
            label2.TabIndex = 1;
            label2.Text = "Say";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 41);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Gül növü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(520, 218);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 3;
            label4.Text = "Toplam gəlir:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(644, 218);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 4;
            label5.Text = "0.00";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dibçək;
            pictureBox2.Location = new Point(529, 290);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.ForeColor = Color.White;
            button2.Location = new Point(581, 391);
            button2.Name = "button2";
            button2.Size = new Size(66, 32);
            button2.TabIndex = 9;
            button2.Text = "Çıxış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(754, 496);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
    }
}
