
namespace RungeKuttaVisualStudio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCalculate_Click = new System.Windows.Forms.Button();
            this.lblResultRK2 = new System.Windows.Forms.Label();
            this.lblResultRK4 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.TextBox();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ecuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate_Click
            // 
            this.btnCalculate_Click.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate_Click.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate_Click.Location = new System.Drawing.Point(202, 496);
            this.btnCalculate_Click.Name = "btnCalculate_Click";
            this.btnCalculate_Click.Size = new System.Drawing.Size(267, 70);
            this.btnCalculate_Click.TabIndex = 0;
            this.btnCalculate_Click.Text = "Calcular";
            this.btnCalculate_Click.UseVisualStyleBackColor = true;
            this.btnCalculate_Click.Click += new System.EventHandler(this.btnCalculate_Click_Click);
            // 
            // lblResultRK2
            // 
            this.lblResultRK2.AutoSize = true;
            this.lblResultRK2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRK2.Location = new System.Drawing.Point(14, 19);
            this.lblResultRK2.Name = "lblResultRK2";
            this.lblResultRK2.Size = new System.Drawing.Size(546, 52);
            this.lblResultRK2.TabIndex = 1;
            this.lblResultRK2.Text = "Ingrese los valores iniciales";
            this.lblResultRK2.Click += new System.EventHandler(this.lblResultRK2_Click);
            // 
            // lblResultRK4
            // 
            this.lblResultRK4.AutoSize = true;
            this.lblResultRK4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRK4.Location = new System.Drawing.Point(15, 176);
            this.lblResultRK4.Name = "lblResultRK4";
            this.lblResultRK4.Size = new System.Drawing.Size(165, 27);
            this.lblResultRK4.TabIndex = 2;
            this.lblResultRK4.Text = "Ingrese X inicial:";
            this.lblResultRK4.Click += new System.EventHandler(this.lblResultRK4_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(711, 9);
            this.chart.Margin = new System.Windows.Forms.Padding(1);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(796, 468);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Y inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el valor de Y a encontrar: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Colocar valor de h:";
            // 
            // X0
            // 
            this.X0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X0.Location = new System.Drawing.Point(212, 175);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(100, 28);
            this.X0.TabIndex = 8;
            this.X0.TextChanged += new System.EventHandler(this.X0_TextChanged);
            // 
            // Y0
            // 
            this.Y0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y0.Location = new System.Drawing.Point(212, 226);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(100, 28);
            this.Y0.TabIndex = 9;
            this.Y0.TextChanged += new System.EventHandler(this.Y0_TextChanged);
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(379, 278);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 28);
            this.X.TabIndex = 10;
            this.X.TextChanged += new System.EventHandler(this.X_TextChanged);
            // 
            // H
            // 
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(216, 331);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(100, 28);
            this.H.TabIndex = 11;
            this.H.TextChanged += new System.EventHandler(this.H_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RK1",
            "RK2",
            "RK4",
            "TODOS"});
            this.comboBox1.Location = new System.Drawing.Point(379, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 30);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Wheat;
            this.dataGridView1.Location = new System.Drawing.Point(709, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 179);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ecuacion
            // 
            this.Ecuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecuacion.Location = new System.Drawing.Point(212, 122);
            this.Ecuacion.Name = "Ecuacion";
            this.Ecuacion.Size = new System.Drawing.Size(194, 27);
            this.Ecuacion.TabIndex = 15;
            this.Ecuacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingresa Ecuacion:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Ecuacion);
            this.panel1.Controls.Add(this.btnCalculate_Click);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblResultRK2);
            this.panel1.Controls.Add(this.lblResultRK4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.H);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Y0);
            this.panel1.Controls.Add(this.X0);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 660);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seleccion de orden Runge-Kutta:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::RungeKuttaVisualStudio.Properties.Resources.Galileo_Sin_slogan_1_1024x359;
            this.pictureBox2.Location = new System.Drawing.Point(0, 589);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(668, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(695, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 664);
            this.panel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1517, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Metodo Runge-Kutta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate_Click;
        private System.Windows.Forms.Label lblResultRK2;
        private System.Windows.Forms.Label lblResultRK4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.TextBox Y0;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Ecuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}

