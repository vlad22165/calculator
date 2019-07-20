namespace Calculator
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
            this.add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.Asin = new System.Windows.Forms.Button();
            this.Acos = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.atan = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.log2 = new System.Windows.Forms.Button();
            this.log10 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.pow2x = new System.Windows.Forms.Button();
            this.negativx = new System.Windows.Forms.Button();
            this.pow10x = new System.Windows.Forms.Button();
            this.div1x = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.averagearifm = new System.Windows.Forms.Button();
            this.averagegeom = new System.Windows.Forms.Button();
            this.integer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(73, 143);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Calculate_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(411, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(259, 143);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(75, 23);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.Calculate_click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(73, 200);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.Calculate_click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(259, 200);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Calculate_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Первый аргумент";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Второй аргумент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат";
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(73, 282);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(259, 282);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 12;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(420, 143);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 13;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // Asin
            // 
            this.Asin.Location = new System.Drawing.Point(550, 143);
            this.Asin.Name = "Asin";
            this.Asin.Size = new System.Drawing.Size(75, 23);
            this.Asin.TabIndex = 14;
            this.Asin.Text = "arcsin";
            this.Asin.UseVisualStyleBackColor = true;
            this.Asin.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // Acos
            // 
            this.Acos.Location = new System.Drawing.Point(420, 193);
            this.Acos.Name = "Acos";
            this.Acos.Size = new System.Drawing.Size(75, 23);
            this.Acos.TabIndex = 15;
            this.Acos.Text = "arccos";
            this.Acos.UseVisualStyleBackColor = true;
            this.Acos.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // ctan
            // 
            this.ctan.Location = new System.Drawing.Point(550, 193);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(75, 23);
            this.ctan.TabIndex = 17;
            this.ctan.Text = "ctan";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // atan
            // 
            this.atan.Location = new System.Drawing.Point(685, 143);
            this.atan.Name = "atan";
            this.atan.Size = new System.Drawing.Size(75, 23);
            this.atan.TabIndex = 19;
            this.atan.Text = "arctan";
            this.atan.UseVisualStyleBackColor = true;
            this.atan.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(685, 193);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(75, 23);
            this.e.TabIndex = 21;
            this.e.Text = "e^x";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(813, 143);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 23;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // log2
            // 
            this.log2.Location = new System.Drawing.Point(813, 193);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(75, 23);
            this.log2.TabIndex = 25;
            this.log2.Text = "log2";
            this.log2.UseVisualStyleBackColor = true;
            this.log2.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // log10
            // 
            this.log10.Location = new System.Drawing.Point(927, 143);
            this.log10.Name = "log10";
            this.log10.Size = new System.Drawing.Size(75, 23);
            this.log10.TabIndex = 27;
            this.log10.Text = "log10";
            this.log10.UseVisualStyleBackColor = true;
            this.log10.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(927, 193);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 23);
            this.x2.TabIndex = 29;
            this.x2.Text = "x^2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // pow2x
            // 
            this.pow2x.Location = new System.Drawing.Point(1062, 143);
            this.pow2x.Name = "pow2x";
            this.pow2x.Size = new System.Drawing.Size(75, 23);
            this.pow2x.TabIndex = 31;
            this.pow2x.Text = "2^x";
            this.pow2x.UseVisualStyleBackColor = true;
            this.pow2x.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // negativx
            // 
            this.negativx.Location = new System.Drawing.Point(1062, 193);
            this.negativx.Name = "negativx";
            this.negativx.Size = new System.Drawing.Size(75, 23);
            this.negativx.TabIndex = 33;
            this.negativx.Text = "–x";
            this.negativx.UseVisualStyleBackColor = true;
            this.negativx.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // pow10x
            // 
            this.pow10x.Location = new System.Drawing.Point(411, 282);
            this.pow10x.Name = "pow10x";
            this.pow10x.Size = new System.Drawing.Size(75, 23);
            this.pow10x.TabIndex = 35;
            this.pow10x.Text = "10^x";
            this.pow10x.UseVisualStyleBackColor = true;
            this.pow10x.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // div1x
            // 
            this.div1x.Location = new System.Drawing.Point(541, 282);
            this.div1x.Name = "div1x";
            this.div1x.Size = new System.Drawing.Size(75, 23);
            this.div1x.TabIndex = 37;
            this.div1x.Text = "1/x";
            this.div1x.UseVisualStyleBackColor = true;
            this.div1x.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(685, 282);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(75, 23);
            this.Abs.TabIndex = 39;
            this.Abs.Text = "|x|";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.OneArgumentCalculate_click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(813, 282);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 41;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Calculate_click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(927, 282);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 43;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.Calculate_click);
            // 
            // averagearifm
            // 
            this.averagearifm.Location = new System.Drawing.Point(1062, 282);
            this.averagearifm.Name = "averagearifm";
            this.averagearifm.Size = new System.Drawing.Size(75, 23);
            this.averagearifm.TabIndex = 45;
            this.averagearifm.Text = "averagearifm";
            this.averagearifm.UseVisualStyleBackColor = true;
            this.averagearifm.Click += new System.EventHandler(this.Calculate_click);
            // 
            // averagegeom
            // 
            this.averagegeom.Location = new System.Drawing.Point(541, 362);
            this.averagegeom.Name = "averagegeom";
            this.averagegeom.Size = new System.Drawing.Size(75, 23);
            this.averagegeom.TabIndex = 47;
            this.averagegeom.Text = "averagegeom";
            this.averagegeom.UseVisualStyleBackColor = true;
            this.averagegeom.Click += new System.EventHandler(this.Calculate_click);
            // 
            // integer
            // 
            this.integer.Location = new System.Drawing.Point(685, 362);
            this.integer.Name = "integer";
            this.integer.Size = new System.Drawing.Size(75, 23);
            this.integer.TabIndex = 49;
            this.integer.Text = "деление на y";
            this.integer.UseVisualStyleBackColor = true;
            this.integer.Click += new System.EventHandler(this.Calculate_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 511);
            this.Controls.Add(this.integer);
            this.Controls.Add(this.averagegeom);
            this.Controls.Add(this.averagearifm);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.div1x);
            this.Controls.Add(this.pow10x);
            this.Controls.Add(this.negativx);
            this.Controls.Add(this.pow2x);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.log10);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.e);
            this.Controls.Add(this.atan);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.Acos);
            this.Controls.Add(this.Asin);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button Asin;
        private System.Windows.Forms.Button Acos;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button atan;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button log2;
        private System.Windows.Forms.Button log10;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button pow2x;
        private System.Windows.Forms.Button negativx;
        private System.Windows.Forms.Button pow10x;
        private System.Windows.Forms.Button div1x;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button averagearifm;
        private System.Windows.Forms.Button averagegeom;
        private System.Windows.Forms.Button integer;
    }
}

