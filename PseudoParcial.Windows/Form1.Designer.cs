namespace PseudoParcial.Windows
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnCancelar = new Button();
            btnOk = new Button();
            txtAltura = new TextBox();
            label2 = new Label();
            txtRadio = new TextBox();
            label1 = new Label();
            dgvConos = new DataGridView();
            colRadio = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            colGeneratriz = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtAltura);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtRadio);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvConos);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(151, 143);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(47, 143);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(90, 62);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Altura";
            label2.Click += label1_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(90, 23);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 26);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Radio";
            label1.Click += label1_Click;
            // 
            // dgvConos
            // 
            dgvConos.AllowUserToAddRows = false;
            dgvConos.AllowUserToDeleteRows = false;
            dgvConos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConos.Columns.AddRange(new DataGridViewColumn[] { colRadio, colAltura, colGeneratriz, colArea, colVolumen });
            dgvConos.Dock = DockStyle.Fill;
            dgvConos.Location = new Point(0, 0);
            dgvConos.Name = "dgvConos";
            dgvConos.ReadOnly = true;
            dgvConos.RowTemplate.Height = 25;
            dgvConos.Size = new Size(800, 180);
            dgvConos.TabIndex = 0;
            // 
            // colRadio
            // 
            colRadio.HeaderText = "Radio";
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            // 
            // colGeneratriz
            // 
            colGeneratriz.HeaderText = "Generatriz";
            colGeneratriz.Name = "colGeneratriz";
            colGeneratriz.ReadOnly = true;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtAltura;
        private Label label2;
        private TextBox txtRadio;
        private DataGridView dgvConos;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colGeneratriz;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colVolumen;
        private ErrorProvider errorProvider1;
    }
}