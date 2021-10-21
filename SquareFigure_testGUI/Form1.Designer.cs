namespace SquareFigure_testGUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFigureSelect = new System.Windows.Forms.ComboBox();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.calcSq = new System.Windows.Forms.Button();
            this.labelSq = new System.Windows.Forms.Label();
            this.sqRezult = new System.Windows.Forms.Label();
            this.labeltypeTriangle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFigureSelect
            // 
            this.comboBoxFigureSelect.FormattingEnabled = true;
            this.comboBoxFigureSelect.Items.AddRange(new object[] {
            "Круг",
            "Треугольник"});
            this.comboBoxFigureSelect.Location = new System.Drawing.Point(34, 23);
            this.comboBoxFigureSelect.Name = "comboBoxFigureSelect";
            this.comboBoxFigureSelect.Size = new System.Drawing.Size(147, 21);
            this.comboBoxFigureSelect.TabIndex = 0;
            this.comboBoxFigureSelect.Text = " Треугольник";
            this.comboBoxFigureSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigureSelect_SelectedIndexChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(31, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(127, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Длинна стороны А(мм.)";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(34, 76);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(147, 20);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(34, 121);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(147, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(31, 105);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(127, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Длинна стороны B(мм.)";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(34, 170);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(147, 20);
            this.textBoxC.TabIndex = 6;
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(31, 154);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(127, 13);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "Длинна стороны C(мм.)";
            // 
            // calcSq
            // 
            this.calcSq.Location = new System.Drawing.Point(34, 214);
            this.calcSq.Name = "calcSq";
            this.calcSq.Size = new System.Drawing.Size(147, 23);
            this.calcSq.TabIndex = 7;
            this.calcSq.Text = "Площадь фигуры";
            this.calcSq.UseVisualStyleBackColor = true;
            this.calcSq.Click += new System.EventHandler(this.calcSq_Click);
            // 
            // labelSq
            // 
            this.labelSq.AutoSize = true;
            this.labelSq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSq.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSq.Location = new System.Drawing.Point(228, 23);
            this.labelSq.Name = "labelSq";
            this.labelSq.Size = new System.Drawing.Size(184, 25);
            this.labelSq.TabIndex = 8;
            this.labelSq.Text = "Площадь фигуры";
            // 
            // sqRezult
            // 
            this.sqRezult.AutoSize = true;
            this.sqRezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqRezult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sqRezult.Location = new System.Drawing.Point(292, 121);
            this.sqRezult.Name = "sqRezult";
            this.sqRezult.Size = new System.Drawing.Size(29, 31);
            this.sqRezult.TabIndex = 9;
            this.sqRezult.Text = "0";
            // 
            // labeltypeTriangle
            // 
            this.labeltypeTriangle.AutoSize = true;
            this.labeltypeTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltypeTriangle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labeltypeTriangle.Location = new System.Drawing.Point(202, 214);
            this.labeltypeTriangle.Name = "labeltypeTriangle";
            this.labeltypeTriangle.Size = new System.Drawing.Size(0, 20);
            this.labeltypeTriangle.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.labeltypeTriangle);
            this.Controls.Add(this.sqRezult);
            this.Controls.Add(this.labelSq);
            this.Controls.Add(this.calcSq);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.comboBoxFigureSelect);
            this.Name = "Form1";
            this.Text = "Плошадь фигур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFigureSelect;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Button calcSq;
        private System.Windows.Forms.Label labelSq;
        private System.Windows.Forms.Label sqRezult;
        private System.Windows.Forms.Label labeltypeTriangle;
    }
}

