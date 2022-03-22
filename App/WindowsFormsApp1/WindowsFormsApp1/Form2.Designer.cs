namespace WindowsFormsApp1
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
            this.myLogin1 = new MyLogin.MyLogin();
            this.SuspendLayout();
            // 
            // myLogin1
            // 
            this.myLogin1.Location = new System.Drawing.Point(45, 44);
            this.myLogin1.Name = "myLogin1";
            this.myLogin1.Password = "Password";
            this.myLogin1.Size = new System.Drawing.Size(390, 137);
            this.myLogin1.TabIndex = 0;
            this.myLogin1.User = "User";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 618);
            this.Controls.Add(this.myLogin1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private MyLogin.MyLogin myLogin1;
    }
}