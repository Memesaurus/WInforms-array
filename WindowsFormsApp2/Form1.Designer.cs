namespace WindowsFormsApp2
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
            this.InputLbl = new System.Windows.Forms.Label();
            this.NChangeTxtBox = new System.Windows.Forms.TextBox();
            this.GenerateArrayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLbl
            // 
            this.InputLbl.AutoSize = true;
            this.InputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLbl.Location = new System.Drawing.Point(158, 115);
            this.InputLbl.Name = "InputLbl";
            this.InputLbl.Size = new System.Drawing.Size(397, 24);
            this.InputLbl.TabIndex = 18;
            this.InputLbl.Text = "Введите количество элементов в массиве";
            // 
            // NChangeTxtBox
            // 
            this.NChangeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NChangeTxtBox.Location = new System.Drawing.Point(561, 110);
            this.NChangeTxtBox.Name = "NChangeTxtBox";
            this.NChangeTxtBox.Size = new System.Drawing.Size(21, 29);
            this.NChangeTxtBox.TabIndex = 19;
            this.NChangeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateArrayBtn
            // 
            this.GenerateArrayBtn.Location = new System.Drawing.Point(230, 163);
            this.GenerateArrayBtn.Name = "GenerateArrayBtn";
            this.GenerateArrayBtn.Size = new System.Drawing.Size(325, 231);
            this.GenerateArrayBtn.TabIndex = 20;
            this.GenerateArrayBtn.Text = "Создать массив";
            this.GenerateArrayBtn.UseVisualStyleBackColor = true;
            this.GenerateArrayBtn.Click += new System.EventHandler(this.GenerateArrayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateArrayBtn);
            this.Controls.Add(this.NChangeTxtBox);
            this.Controls.Add(this.InputLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLbl;
        private System.Windows.Forms.TextBox NChangeTxtBox;
        private System.Windows.Forms.Button GenerateArrayBtn;
    }
}