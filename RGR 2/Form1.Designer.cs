
namespace RGR_2
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
            this.tb_rows = new System.Windows.Forms.TextBox();
            this.tb_cols = new System.Windows.Forms.TextBox();
            this.tb_rnd_start = new System.Windows.Forms.TextBox();
            this.tb_rnd_end = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_runClick = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_rows
            // 
            this.tb_rows.BackColor = System.Drawing.Color.BurlyWood;
            this.tb_rows.Location = new System.Drawing.Point(605, 665);
            this.tb_rows.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_rows.Name = "tb_rows";
            this.tb_rows.Size = new System.Drawing.Size(169, 35);
            this.tb_rows.TabIndex = 0;
            this.tb_rows.TextChanged += new System.EventHandler(this.tb_rows_TextChanged);
            // 
            // tb_cols
            // 
            this.tb_cols.BackColor = System.Drawing.Color.BurlyWood;
            this.tb_cols.Location = new System.Drawing.Point(605, 723);
            this.tb_cols.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_cols.Name = "tb_cols";
            this.tb_cols.Size = new System.Drawing.Size(169, 35);
            this.tb_cols.TabIndex = 1;
            // 
            // tb_rnd_start
            // 
            this.tb_rnd_start.BackColor = System.Drawing.Color.BurlyWood;
            this.tb_rnd_start.Location = new System.Drawing.Point(849, 716);
            this.tb_rnd_start.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_rnd_start.Name = "tb_rnd_start";
            this.tb_rnd_start.Size = new System.Drawing.Size(95, 35);
            this.tb_rnd_start.TabIndex = 2;
            this.tb_rnd_start.TextChanged += new System.EventHandler(this.tb_rnd_start_TextChanged);
            // 
            // tb_rnd_end
            // 
            this.tb_rnd_end.BackColor = System.Drawing.Color.BurlyWood;
            this.tb_rnd_end.Location = new System.Drawing.Point(1025, 716);
            this.tb_rnd_end.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_rnd_end.Name = "tb_rnd_end";
            this.tb_rnd_end.Size = new System.Drawing.Size(95, 35);
            this.tb_rnd_end.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 671);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество строк:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 729);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество столбцов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(972, 722);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 722);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(799, 658);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Диапазон случайных значений";
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv1.Location = new System.Drawing.Point(31, 15);
            this.dgv1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 72;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(931, 590);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1200, 594);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Задания";
            // 
            // Tb_runClick
            // 
            this.Tb_runClick.AutoSize = true;
            this.Tb_runClick.Location = new System.Drawing.Point(1200, 640);
            this.Tb_runClick.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Tb_runClick.Name = "Tb_runClick";
            this.Tb_runClick.Size = new System.Drawing.Size(134, 34);
            this.Tb_runClick.TabIndex = 11;
            this.Tb_runClick.TabStop = true;
            this.Tb_runClick.Text = "Задание 1";
            this.Tb_runClick.UseVisualStyleBackColor = true;
            this.Tb_runClick.CheckedChanged += new System.EventHandler(this.Tb_runClick_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1200, 690);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 34);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Задание 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1200, 740);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(134, 34);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Задание 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1200, 790);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(134, 34);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Задание 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1200, 840);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(134, 34);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Задание 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // tb_output
            // 
            this.tb_output.BackColor = System.Drawing.Color.BurlyWood;
            this.tb_output.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_output.Location = new System.Drawing.Point(1003, 72);
            this.tb_output.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(354, 406);
            this.tb_output.TabIndex = 16;
            this.tb_output.TextChanged += new System.EventHandler(this.tb_output_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(1129, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 76);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выполнить задание";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1003, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Вывод значений:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(31, 631);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 143);
            this.button2.TabIndex = 19;
            this.button2.Text = "Создать  массив";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Location = new System.Drawing.Point(45, 838);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 58);
            this.button3.TabIndex = 20;
            this.button3.Text = "Сохранить файл";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BurlyWood;
            this.button4.Location = new System.Drawing.Point(270, 840);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 58);
            this.button4.TabIndex = 21;
            this.button4.Text = "Открыть из файла";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.BurlyWood;
            this.button5.Location = new System.Drawing.Point(972, 490);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 76);
            this.button5.TabIndex = 22;
            this.button5.Text = "Вернуть массив";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Tb_runClick);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_rnd_end);
            this.Controls.Add(this.tb_rnd_start);
            this.Controls.Add(this.tb_cols);
            this.Controls.Add(this.tb_rows);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Программа Дениса Захаренко";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rows;
        private System.Windows.Forms.TextBox tb_cols;
        private System.Windows.Forms.TextBox tb_rnd_start;
        private System.Windows.Forms.TextBox tb_rnd_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Tb_runClick;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
    }
}

