namespace WindowsFormsApp2
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
            this.InitialArrayLbl = new System.Windows.Forms.Label();
            this.DeleteElementsBtn = new System.Windows.Forms.Button();
            this.OutputArrayLbl = new System.Windows.Forms.Label();
            this.FlagsortBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.MaxElementBtn = new System.Windows.Forms.Button();
            this.MoveBtn = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClockwiseRadio = new System.Windows.Forms.RadioButton();
            this.AnticlockwiseRadio = new System.Windows.Forms.RadioButton();
            this.NChangeTextBox = new System.Windows.Forms.TextBox();
            this.KChangeTextbox = new System.Windows.Forms.TextBox();
            this.NInputlbl = new System.Windows.Forms.Label();
            this.KInputLbl = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitialArrayLbl
            // 
            this.InitialArrayLbl.AutoSize = true;
            this.InitialArrayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitialArrayLbl.Location = new System.Drawing.Point(244, 46);
            this.InitialArrayLbl.Name = "InitialArrayLbl";
            this.InitialArrayLbl.Size = new System.Drawing.Size(0, 26);
            this.InitialArrayLbl.TabIndex = 0;
            // 
            // DeleteElementsBtn
            // 
            this.DeleteElementsBtn.Location = new System.Drawing.Point(9, 89);
            this.DeleteElementsBtn.Name = "DeleteElementsBtn";
            this.DeleteElementsBtn.Size = new System.Drawing.Size(151, 102);
            this.DeleteElementsBtn.TabIndex = 1;
            this.DeleteElementsBtn.Text = "Удалить элементы, большие среднего арифметического";
            this.DeleteElementsBtn.UseVisualStyleBackColor = true;
            this.DeleteElementsBtn.Click += new System.EventHandler(this.DeleteElementsBtn_Click);
            // 
            // OutputArrayLbl
            // 
            this.OutputArrayLbl.AutoSize = true;
            this.OutputArrayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputArrayLbl.Location = new System.Drawing.Point(244, 395);
            this.OutputArrayLbl.Name = "OutputArrayLbl";
            this.OutputArrayLbl.Size = new System.Drawing.Size(0, 26);
            this.OutputArrayLbl.TabIndex = 7;
            // 
            // FlagsortBtn
            // 
            this.FlagsortBtn.Location = new System.Drawing.Point(637, 89);
            this.FlagsortBtn.Name = "FlagsortBtn";
            this.FlagsortBtn.Size = new System.Drawing.Size(151, 102);
            this.FlagsortBtn.TabIndex = 8;
            this.FlagsortBtn.Text = "Сортировка методом пузырька с флагом";
            this.FlagsortBtn.UseVisualStyleBackColor = true;
            this.FlagsortBtn.Click += new System.EventHandler(this.FlagsortBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(166, 89);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(151, 102);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Добавить N элементов, наичная с индекса K";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MaxElementBtn
            // 
            this.MaxElementBtn.Location = new System.Drawing.Point(480, 89);
            this.MaxElementBtn.Name = "MaxElementBtn";
            this.MaxElementBtn.Size = new System.Drawing.Size(151, 102);
            this.MaxElementBtn.TabIndex = 10;
            this.MaxElementBtn.Text = "Найти максимальный четный элемент и его индекс";
            this.MaxElementBtn.UseVisualStyleBackColor = true;
            this.MaxElementBtn.Click += new System.EventHandler(this.MaxElementBtn_Click);
            // 
            // MoveBtn
            // 
            this.MoveBtn.Location = new System.Drawing.Point(323, 89);
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(151, 102);
            this.MoveBtn.TabIndex = 11;
            this.MoveBtn.Text = "Сдвинуть массив циклически на N элементов влево";
            this.MoveBtn.UseVisualStyleBackColor = true;
            this.MoveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(239, 269);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(151, 102);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Выход из программы";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClockwiseRadio
            // 
            this.ClockwiseRadio.AutoSize = true;
            this.ClockwiseRadio.Checked = true;
            this.ClockwiseRadio.Location = new System.Drawing.Point(673, 197);
            this.ClockwiseRadio.Name = "ClockwiseRadio";
            this.ClockwiseRadio.Size = new System.Drawing.Size(109, 17);
            this.ClockwiseRadio.TabIndex = 13;
            this.ClockwiseRadio.TabStop = true;
            this.ClockwiseRadio.Text = "По возрастанию";
            this.ClockwiseRadio.UseVisualStyleBackColor = true;
            // 
            // AnticlockwiseRadio
            // 
            this.AnticlockwiseRadio.AutoSize = true;
            this.AnticlockwiseRadio.Location = new System.Drawing.Point(673, 220);
            this.AnticlockwiseRadio.Name = "AnticlockwiseRadio";
            this.AnticlockwiseRadio.Size = new System.Drawing.Size(93, 17);
            this.AnticlockwiseRadio.TabIndex = 14;
            this.AnticlockwiseRadio.Text = "По убыванию";
            this.AnticlockwiseRadio.UseVisualStyleBackColor = true;
            // 
            // NChangeTextBox
            // 
            this.NChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NChangeTextBox.Location = new System.Drawing.Point(438, 206);
            this.NChangeTextBox.Name = "NChangeTextBox";
            this.NChangeTextBox.Size = new System.Drawing.Size(21, 29);
            this.NChangeTextBox.TabIndex = 15;
            this.NChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KChangeTextbox
            // 
            this.KChangeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KChangeTextbox.Location = new System.Drawing.Point(438, 240);
            this.KChangeTextbox.Name = "KChangeTextbox";
            this.KChangeTextbox.Size = new System.Drawing.Size(21, 29);
            this.KChangeTextbox.TabIndex = 16;
            this.KChangeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NInputlbl
            // 
            this.NInputlbl.AutoSize = true;
            this.NInputlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NInputlbl.Location = new System.Drawing.Point(325, 211);
            this.NInputlbl.Name = "NInputlbl";
            this.NInputlbl.Size = new System.Drawing.Size(107, 24);
            this.NInputlbl.TabIndex = 17;
            this.NInputlbl.Text = "Введите N";
            // 
            // KInputLbl
            // 
            this.KInputLbl.AutoSize = true;
            this.KInputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KInputLbl.Location = new System.Drawing.Point(325, 242);
            this.KInputLbl.Name = "KInputLbl";
            this.KInputLbl.Size = new System.Drawing.Size(105, 24);
            this.KInputLbl.TabIndex = 18;
            this.KInputLbl.Text = "Введите K";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(396, 269);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(151, 102);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.KInputLbl);
            this.Controls.Add(this.NInputlbl);
            this.Controls.Add(this.KChangeTextbox);
            this.Controls.Add(this.NChangeTextBox);
            this.Controls.Add(this.AnticlockwiseRadio);
            this.Controls.Add(this.ClockwiseRadio);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MoveBtn);
            this.Controls.Add(this.MaxElementBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FlagsortBtn);
            this.Controls.Add(this.OutputArrayLbl);
            this.Controls.Add(this.DeleteElementsBtn);
            this.Controls.Add(this.InitialArrayLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InitialArrayLbl;
        private System.Windows.Forms.Button DeleteElementsBtn;
        private System.Windows.Forms.Label OutputArrayLbl;
        private System.Windows.Forms.Button FlagsortBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button MaxElementBtn;
        private System.Windows.Forms.Button MoveBtn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton ClockwiseRadio;
        private System.Windows.Forms.RadioButton AnticlockwiseRadio;
        private System.Windows.Forms.TextBox NChangeTextBox;
        private System.Windows.Forms.TextBox KChangeTextbox;
        private System.Windows.Forms.Label NInputlbl;
        private System.Windows.Forms.Label KInputLbl;
        private System.Windows.Forms.Button BackButton;
    }
}