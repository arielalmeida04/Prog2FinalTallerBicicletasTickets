namespace Prog2FinalTallerBicicletasTickets
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
            this.bttCrearTicket = new System.Windows.Forms.Button();
            this.bttClietne = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttEliminarServicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttAgregarServicio = new System.Windows.Forms.Button();
            this.txbTiempo = new System.Windows.Forms.TextBox();
            this.txbExtra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFeriado = new System.Windows.Forms.RadioButton();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttCrearTicket
            // 
            this.bttCrearTicket.Location = new System.Drawing.Point(111, 198);
            this.bttCrearTicket.Name = "bttCrearTicket";
            this.bttCrearTicket.Size = new System.Drawing.Size(178, 35);
            this.bttCrearTicket.TabIndex = 1;
            this.bttCrearTicket.Text = "Crear Ticket";
            this.bttCrearTicket.UseVisualStyleBackColor = true;
            this.bttCrearTicket.Click += new System.EventHandler(this.bttCrearTicket_Click);
            // 
            // bttClietne
            // 
            this.bttClietne.Location = new System.Drawing.Point(41, 32);
            this.bttClietne.Name = "bttClietne";
            this.bttClietne.Size = new System.Drawing.Size(120, 35);
            this.bttClietne.TabIndex = 2;
            this.bttClietne.Text = "Crear Cliente";
            this.bttClietne.UseVisualStyleBackColor = true;
            this.bttClietne.Click += new System.EventHandler(this.bttClietne_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 108);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 4;
            // 
            // bttEliminarServicio
            // 
            this.bttEliminarServicio.Location = new System.Drawing.Point(111, 353);
            this.bttEliminarServicio.Name = "bttEliminarServicio";
            this.bttEliminarServicio.Size = new System.Drawing.Size(178, 35);
            this.bttEliminarServicio.TabIndex = 5;
            this.bttEliminarServicio.Text = "Eliminar Servicio";
            this.bttEliminarServicio.UseVisualStyleBackColor = true;
            this.bttEliminarServicio.Click += new System.EventHandler(this.bttEliminarServicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttClietne);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTickets);
            this.groupBox2.Controls.Add(this.rbFeriado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bttCrearTicket);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbExtra);
            this.groupBox2.Controls.Add(this.txbTiempo);
            this.groupBox2.Controls.Add(this.bttAgregarServicio);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.bttEliminarServicio);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bttAgregarServicio
            // 
            this.bttAgregarServicio.Location = new System.Drawing.Point(16, 32);
            this.bttAgregarServicio.Name = "bttAgregarServicio";
            this.bttAgregarServicio.Size = new System.Drawing.Size(81, 46);
            this.bttAgregarServicio.TabIndex = 6;
            this.bttAgregarServicio.Text = "Agregar Servicio";
            this.bttAgregarServicio.UseVisualStyleBackColor = true;
            this.bttAgregarServicio.Click += new System.EventHandler(this.bttAgregarServicio_Click);
            // 
            // txbTiempo
            // 
            this.txbTiempo.Location = new System.Drawing.Point(200, 32);
            this.txbTiempo.Name = "txbTiempo";
            this.txbTiempo.Size = new System.Drawing.Size(100, 20);
            this.txbTiempo.TabIndex = 7;
            // 
            // txbExtra
            // 
            this.txbExtra.Location = new System.Drawing.Point(200, 58);
            this.txbExtra.Name = "txbExtra";
            this.txbExtra.Size = new System.Drawing.Size(100, 20);
            this.txbExtra.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tiempo en horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Extra";
            // 
            // rbFeriado
            // 
            this.rbFeriado.AutoSize = true;
            this.rbFeriado.Location = new System.Drawing.Point(316, 59);
            this.rbFeriado.Name = "rbFeriado";
            this.rbFeriado.Size = new System.Drawing.Size(60, 17);
            this.rbFeriado.TabIndex = 11;
            this.rbFeriado.TabStop = true;
            this.rbFeriado.Text = "Feriado";
            this.rbFeriado.UseVisualStyleBackColor = true;
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.Location = new System.Drawing.Point(16, 239);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(360, 108);
            this.lbTickets.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttCrearTicket;
        private System.Windows.Forms.Button bttClietne;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttEliminarServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttAgregarServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbExtra;
        private System.Windows.Forms.TextBox txbTiempo;
        private System.Windows.Forms.RadioButton rbFeriado;
        private System.Windows.Forms.ListBox lbTickets;
    }
}

