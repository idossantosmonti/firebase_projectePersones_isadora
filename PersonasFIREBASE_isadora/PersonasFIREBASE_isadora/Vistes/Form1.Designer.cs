namespace PersonasFIREBASE_isadora
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lsbPersones = new System.Windows.Forms.ListBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLlenguatges = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfessio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRang = new System.Windows.Forms.TextBox();
            this.nudEdat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDisponibilidadViaje = new System.Windows.Forms.ComboBox();
            this.nudAnysTreball = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnysTreball)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(543, 60);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(194, 57);
            this.add.TabIndex = 0;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_ClickAsync);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(543, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(194, 57);
            this.button8.TabIndex = 3;
            this.button8.Text = "DELETE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lsbPersones
            // 
            this.lsbPersones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsbPersones.FormattingEnabled = true;
            this.lsbPersones.HorizontalScrollbar = true;
            this.lsbPersones.ItemHeight = 21;
            this.lsbPersones.Location = new System.Drawing.Point(52, 43);
            this.lsbPersones.Name = "lsbPersones";
            this.lsbPersones.Size = new System.Drawing.Size(144, 361);
            this.lsbPersones.TabIndex = 4;
            this.lsbPersones.SelectedIndexChanged += new System.EventHandler(this.lsbPersones_SelectedIndexChanged);
            this.lsbPersones.DoubleClick += new System.EventHandler(this.lsbPersones_DoubleClick);
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(230, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(228, 23);
            this.txtNom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Edat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Llenguatges(separats per coma) -> PHP, Python";
            // 
            // txtLlenguatges
            // 
            this.txtLlenguatges.Enabled = false;
            this.txtLlenguatges.Location = new System.Drawing.Point(230, 162);
            this.txtLlenguatges.Multiline = true;
            this.txtLlenguatges.Name = "txtLlenguatges";
            this.txtLlenguatges.Size = new System.Drawing.Size(228, 57);
            this.txtLlenguatges.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Professió";
            // 
            // txtProfessio
            // 
            this.txtProfessio.Enabled = false;
            this.txtProfessio.Location = new System.Drawing.Point(230, 240);
            this.txtProfessio.Name = "txtProfessio";
            this.txtProfessio.Size = new System.Drawing.Size(228, 23);
            this.txtProfessio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rang Profesional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Anys";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rang";
            // 
            // txtRang
            // 
            this.txtRang.Enabled = false;
            this.txtRang.Location = new System.Drawing.Point(358, 320);
            this.txtRang.Name = "txtRang";
            this.txtRang.Size = new System.Drawing.Size(100, 23);
            this.txtRang.TabIndex = 18;
            // 
            // nudEdat
            // 
            this.nudEdat.Enabled = false;
            this.nudEdat.Location = new System.Drawing.Point(230, 109);
            this.nudEdat.Name = "nudEdat";
            this.nudEdat.Size = new System.Drawing.Size(228, 23);
            this.nudEdat.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Disponibilitat per viatjar";
            // 
            // cmbDisponibilidadViaje
            // 
            this.cmbDisponibilidadViaje.Enabled = false;
            this.cmbDisponibilidadViaje.FormattingEnabled = true;
            this.cmbDisponibilidadViaje.Location = new System.Drawing.Point(230, 373);
            this.cmbDisponibilidadViaje.Name = "cmbDisponibilidadViaje";
            this.cmbDisponibilidadViaje.Size = new System.Drawing.Size(228, 23);
            this.cmbDisponibilidadViaje.TabIndex = 23;
            // 
            // nudAnysTreball
            // 
            this.nudAnysTreball.Enabled = false;
            this.nudAnysTreball.Location = new System.Drawing.Point(241, 321);
            this.nudAnysTreball.Name = "nudAnysTreball";
            this.nudAnysTreball.Size = new System.Drawing.Size(111, 23);
            this.nudAnysTreball.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "*Per editar una persona, fes doble click sobre el seu nom a la llista.";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(836, 433);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudAnysTreball);
            this.Controls.Add(this.cmbDisponibilidadViaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudEdat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProfessio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLlenguatges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lsbPersones);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnysTreball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button add;
        private Button button8;
        private ListBox lsbPersones;
        private TextBox txtNom;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLlenguatges;
        private Label label4;
        private TextBox txtProfessio;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRang;
        private NumericUpDown nudEdat;
        private Label label8;
        private ComboBox cmbDisponibilidadViaje;
        private NumericUpDown nudAnysTreball;
        private Label label9;
    }
}