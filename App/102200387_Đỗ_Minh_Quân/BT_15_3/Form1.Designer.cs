namespace BT_15_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BurgerPMB = new System.Windows.Forms.Button();
            this.BurgerPMG = new System.Windows.Forms.Button();
            this.BurgerPMT = new System.Windows.Forms.Button();
            this.BurgerPMC = new System.Windows.Forms.Button();
            this.TVCola = new System.Windows.Forms.Button();
            this.GVCola = new System.Windows.Forms.Button();
            this.GRPhan = new System.Windows.Forms.Button();
            this.CGTender = new System.Windows.Forms.Button();
            this.KhoaiTayChien = new System.Windows.Forms.Button();
            this.Pepsi = new System.Windows.Forms.Button();
            this.SevenUp = new System.Windows.Forms.Button();
            this.Cafe = new System.Windows.Forms.Button();
            this.Coca = new System.Windows.Forms.Button();
            this.Lipton = new System.Windows.Forms.Button();
            this.Cam = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::BT_15_3.Properties.Resources.Paper_notes_svg;
            this.pictureBox1.Location = new System.Drawing.Point(37, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(159, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fastfood Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục món ăn";
            // 
            // BurgerPMB
            // 
            this.BurgerPMB.ForeColor = System.Drawing.Color.Red;
            this.BurgerPMB.Location = new System.Drawing.Point(49, 191);
            this.BurgerPMB.Name = "BurgerPMB";
            this.BurgerPMB.Size = new System.Drawing.Size(177, 34);
            this.BurgerPMB.TabIndex = 3;
            this.BurgerPMB.Text = "Burger Phô mai Bò";
            this.BurgerPMB.UseVisualStyleBackColor = true;
            this.BurgerPMB.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // BurgerPMG
            // 
            this.BurgerPMG.ForeColor = System.Drawing.Color.Red;
            this.BurgerPMG.Location = new System.Drawing.Point(49, 231);
            this.BurgerPMG.Name = "BurgerPMG";
            this.BurgerPMG.Size = new System.Drawing.Size(177, 34);
            this.BurgerPMG.TabIndex = 4;
            this.BurgerPMG.Text = "Burger Phô mai Gà";
            this.BurgerPMG.UseVisualStyleBackColor = true;
            this.BurgerPMG.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // BurgerPMT
            // 
            this.BurgerPMT.ForeColor = System.Drawing.Color.Red;
            this.BurgerPMT.Location = new System.Drawing.Point(49, 271);
            this.BurgerPMT.Name = "BurgerPMT";
            this.BurgerPMT.Size = new System.Drawing.Size(177, 34);
            this.BurgerPMT.TabIndex = 5;
            this.BurgerPMT.Text = "Burger Phô mai Tôm";
            this.BurgerPMT.UseVisualStyleBackColor = true;
            this.BurgerPMT.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // BurgerPMC
            // 
            this.BurgerPMC.ForeColor = System.Drawing.Color.Red;
            this.BurgerPMC.Location = new System.Drawing.Point(49, 310);
            this.BurgerPMC.Name = "BurgerPMC";
            this.BurgerPMC.Size = new System.Drawing.Size(177, 34);
            this.BurgerPMC.TabIndex = 6;
            this.BurgerPMC.Text = "Burger Phô mai Cá";
            this.BurgerPMC.UseVisualStyleBackColor = true;
            this.BurgerPMC.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // TVCola
            // 
            this.TVCola.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TVCola.Location = new System.Drawing.Point(270, 191);
            this.TVCola.Name = "TVCola";
            this.TVCola.Size = new System.Drawing.Size(177, 34);
            this.TVCola.TabIndex = 7;
            this.TVCola.Text = "Tôm viên Cola";
            this.TVCola.UseVisualStyleBackColor = true;
            this.TVCola.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // GVCola
            // 
            this.GVCola.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GVCola.Location = new System.Drawing.Point(270, 231);
            this.GVCola.Name = "GVCola";
            this.GVCola.Size = new System.Drawing.Size(177, 34);
            this.GVCola.TabIndex = 8;
            this.GVCola.Text = "Gà viên Cola";
            this.GVCola.UseVisualStyleBackColor = true;
            this.GVCola.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // GRPhan
            // 
            this.GRPhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GRPhan.Location = new System.Drawing.Point(270, 271);
            this.GRPhan.Name = "GRPhan";
            this.GRPhan.Size = new System.Drawing.Size(177, 34);
            this.GRPhan.TabIndex = 9;
            this.GRPhan.Text = "Gà rán phần";
            this.GRPhan.UseVisualStyleBackColor = true;
            this.GRPhan.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // CGTender
            // 
            this.CGTender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CGTender.Location = new System.Drawing.Point(270, 311);
            this.CGTender.Name = "CGTender";
            this.CGTender.Size = new System.Drawing.Size(177, 34);
            this.CGTender.TabIndex = 10;
            this.CGTender.Text = "Cơm gà Tender";
            this.CGTender.UseVisualStyleBackColor = true;
            this.CGTender.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // KhoaiTayChien
            // 
            this.KhoaiTayChien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KhoaiTayChien.Location = new System.Drawing.Point(487, 311);
            this.KhoaiTayChien.Name = "KhoaiTayChien";
            this.KhoaiTayChien.Size = new System.Drawing.Size(213, 34);
            this.KhoaiTayChien.TabIndex = 11;
            this.KhoaiTayChien.Text = "Khoai tây chiên";
            this.KhoaiTayChien.UseVisualStyleBackColor = true;
            this.KhoaiTayChien.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // Pepsi
            // 
            this.Pepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pepsi.ForeColor = System.Drawing.Color.Green;
            this.Pepsi.Location = new System.Drawing.Point(487, 191);
            this.Pepsi.Name = "Pepsi";
            this.Pepsi.Size = new System.Drawing.Size(88, 34);
            this.Pepsi.TabIndex = 12;
            this.Pepsi.Text = "Pepsi";
            this.Pepsi.UseVisualStyleBackColor = true;
            this.Pepsi.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // SevenUp
            // 
            this.SevenUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenUp.ForeColor = System.Drawing.Color.Green;
            this.SevenUp.Location = new System.Drawing.Point(487, 231);
            this.SevenUp.Name = "SevenUp";
            this.SevenUp.Size = new System.Drawing.Size(88, 34);
            this.SevenUp.TabIndex = 13;
            this.SevenUp.Text = "7 up";
            this.SevenUp.UseVisualStyleBackColor = true;
            this.SevenUp.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // Cafe
            // 
            this.Cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cafe.ForeColor = System.Drawing.Color.Green;
            this.Cafe.Location = new System.Drawing.Point(487, 271);
            this.Cafe.Name = "Cafe";
            this.Cafe.Size = new System.Drawing.Size(88, 34);
            this.Cafe.TabIndex = 14;
            this.Cafe.Text = "Cafe";
            this.Cafe.UseVisualStyleBackColor = true;
            this.Cafe.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // Coca
            // 
            this.Coca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coca.ForeColor = System.Drawing.Color.Green;
            this.Coca.Location = new System.Drawing.Point(612, 191);
            this.Coca.Name = "Coca";
            this.Coca.Size = new System.Drawing.Size(88, 34);
            this.Coca.TabIndex = 15;
            this.Coca.Text = "Coca";
            this.Coca.UseVisualStyleBackColor = true;
            this.Coca.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // Lipton
            // 
            this.Lipton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lipton.ForeColor = System.Drawing.Color.Green;
            this.Lipton.Location = new System.Drawing.Point(612, 231);
            this.Lipton.Name = "Lipton";
            this.Lipton.Size = new System.Drawing.Size(88, 34);
            this.Lipton.TabIndex = 16;
            this.Lipton.Text = "Lipton";
            this.Lipton.UseVisualStyleBackColor = true;
            this.Lipton.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // Cam
            // 
            this.Cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cam.ForeColor = System.Drawing.Color.Green;
            this.Cam.Location = new System.Drawing.Point(612, 271);
            this.Cam.Name = "Cam";
            this.Cam.Size = new System.Drawing.Size(88, 34);
            this.Cam.TabIndex = 17;
            this.Cam.Text = "Cam";
            this.Cam.UseVisualStyleBackColor = true;
            this.Cam.Click += new System.EventHandler(this.foodDrinkClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(49, 368);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 34);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "🚦  xóa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5",
            "Bàn 6",
            "Bàn 7",
            "Bàn 8",
            "Bàn 9",
            "Bàn 10"});
            this.comboBox1.Location = new System.Drawing.Point(270, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(612, 368);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(88, 34);
            this.orderButton.TabIndex = 21;
            this.orderButton.Text = "🛒 Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 207);
            this.dataGridView1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Cam);
            this.Controls.Add(this.Lipton);
            this.Controls.Add(this.Coca);
            this.Controls.Add(this.Cafe);
            this.Controls.Add(this.SevenUp);
            this.Controls.Add(this.Pepsi);
            this.Controls.Add(this.KhoaiTayChien);
            this.Controls.Add(this.CGTender);
            this.Controls.Add(this.GRPhan);
            this.Controls.Add(this.GVCola);
            this.Controls.Add(this.TVCola);
            this.Controls.Add(this.BurgerPMC);
            this.Controls.Add(this.BurgerPMT);
            this.Controls.Add(this.BurgerPMG);
            this.Controls.Add(this.BurgerPMB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BurgerPMB;
        private System.Windows.Forms.Button BurgerPMG;
        private System.Windows.Forms.Button BurgerPMT;
        private System.Windows.Forms.Button BurgerPMC;
        private System.Windows.Forms.Button TVCola;
        private System.Windows.Forms.Button GVCola;
        private System.Windows.Forms.Button GRPhan;
        private System.Windows.Forms.Button CGTender;
        private System.Windows.Forms.Button KhoaiTayChien;
        private System.Windows.Forms.Button Pepsi;
        private System.Windows.Forms.Button SevenUp;
        private System.Windows.Forms.Button Cafe;
        private System.Windows.Forms.Button Coca;
        private System.Windows.Forms.Button Lipton;
        private System.Windows.Forms.Button Cam;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

