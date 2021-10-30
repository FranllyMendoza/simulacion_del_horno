
namespace simulacion_del_horno.ventanas
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simular_incineracion_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combustible_comboBox = new System.Windows.Forms.ComboBox();
            this.tiempo_textBox = new System.Windows.Forms.TextBox();
            this.material_gastado_textBox = new System.Windows.Forms.TextBox();
            this.limpiar_button = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.material_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "material :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "combustible :";
            // 
            // simular_incineracion_button
            // 
            this.simular_incineracion_button.Location = new System.Drawing.Point(175, 261);
            this.simular_incineracion_button.Name = "simular_incineracion_button";
            this.simular_incineracion_button.Size = new System.Drawing.Size(177, 47);
            this.simular_incineracion_button.TabIndex = 6;
            this.simular_incineracion_button.Text = "simular incineración";
            this.simular_incineracion_button.UseVisualStyleBackColor = true;
            this.simular_incineracion_button.Click += new System.EventHandler(this.simular_incineracion_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "tiempo de incineración :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "material gastado: ";
            // 
            // combustible_comboBox
            // 
            this.combustible_comboBox.FormattingEnabled = true;
            this.combustible_comboBox.Items.AddRange(new object[] {
            "madera ",
            "cascara ",
            "hoja seca ",
            "carbon vejetal"});
            this.combustible_comboBox.Location = new System.Drawing.Point(175, 121);
            this.combustible_comboBox.Name = "combustible_comboBox";
            this.combustible_comboBox.Size = new System.Drawing.Size(331, 33);
            this.combustible_comboBox.TabIndex = 10;
            // 
            // tiempo_textBox
            // 
            this.tiempo_textBox.Location = new System.Drawing.Point(214, 326);
            this.tiempo_textBox.Name = "tiempo_textBox";
            this.tiempo_textBox.Size = new System.Drawing.Size(292, 31);
            this.tiempo_textBox.TabIndex = 11;
            // 
            // material_gastado_textBox
            // 
            this.material_gastado_textBox.Location = new System.Drawing.Point(214, 379);
            this.material_gastado_textBox.Name = "material_gastado_textBox";
            this.material_gastado_textBox.Size = new System.Drawing.Size(292, 31);
            this.material_gastado_textBox.TabIndex = 12;
            // 
            // limpiar_button
            // 
            this.limpiar_button.Location = new System.Drawing.Point(175, 433);
            this.limpiar_button.Name = "limpiar_button";
            this.limpiar_button.Size = new System.Drawing.Size(177, 47);
            this.limpiar_button.TabIndex = 13;
            this.limpiar_button.Text = "limpiar resultado";
            this.limpiar_button.UseVisualStyleBackColor = true;
            this.limpiar_button.Click += new System.EventHandler(this.limpiar_button_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(175, 182);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 29);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 182);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 29);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "50%";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(399, 182);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(82, 29);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "100%";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(321, 182);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 29);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "75%";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "velocidad  :";
            // 
            // material_comboBox
            // 
            this.material_comboBox.FormattingEnabled = true;
            this.material_comboBox.Items.AddRange(new object[] {
            "guineos ",
            "platanos ",
            "salami "});
            this.material_comboBox.Location = new System.Drawing.Point(175, 70);
            this.material_comboBox.Name = "material_comboBox";
            this.material_comboBox.Size = new System.Drawing.Size(331, 33);
            this.material_comboBox.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 509);
            this.Controls.Add(this.material_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.limpiar_button);
            this.Controls.Add(this.material_gastado_textBox);
            this.Controls.Add(this.tiempo_textBox);
            this.Controls.Add(this.combustible_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simular_incineracion_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button simular_incineracion_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combustible_comboBox;
        private System.Windows.Forms.TextBox tiempo_textBox;
        private System.Windows.Forms.TextBox material_gastado_textBox;
        private System.Windows.Forms.Button limpiar_button;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox material_comboBox;
    }
}