namespace Forca.WinForms {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPalavra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelCabeca = new System.Windows.Forms.Label();
            this.labelCorpo = new System.Windows.Forms.Label();
            this.labelBraco1 = new System.Windows.Forms.Label();
            this.labelBraco2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalpite = new System.Windows.Forms.TextBox();
            this.labelPernas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConfirma);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.labelCabeca);
            this.panel1.Controls.Add(this.labelCorpo);
            this.panel1.Controls.Add(this.labelBraco1);
            this.panel1.Controls.Add(this.labelBraco2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPalpite);
            this.panel1.Controls.Add(this.labelPernas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 480);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelPalavra, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 57);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // labelPalavra
            // 
            this.labelPalavra.AutoSize = true;
            this.labelPalavra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.labelPalavra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPalavra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPalavra.Font = new System.Drawing.Font("Kristen ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPalavra.ForeColor = System.Drawing.Color.White;
            this.labelPalavra.Location = new System.Drawing.Point(3, 0);
            this.labelPalavra.Name = "labelPalavra";
            this.labelPalavra.Size = new System.Drawing.Size(489, 57);
            this.labelPalavra.TabIndex = 0;
            this.labelPalavra.Text = "J_GO_DA_FORC_";
            this.labelPalavra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "2023";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Jogo da Forca Top";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirma.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConfirma.Location = new System.Drawing.Point(246, 415);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(76, 38);
            this.btnConfirma.TabIndex = 14;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(29, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(169, 14);
            this.textBox4.TabIndex = 7;
            // 
            // labelCabeca
            // 
            this.labelCabeca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCabeca.AutoSize = true;
            this.labelCabeca.BackColor = System.Drawing.Color.Transparent;
            this.labelCabeca.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCabeca.ForeColor = System.Drawing.Color.White;
            this.labelCabeca.Location = new System.Drawing.Point(140, 36);
            this.labelCabeca.Name = "labelCabeca";
            this.labelCabeca.Size = new System.Drawing.Size(117, 81);
            this.labelCabeca.TabIndex = 9;
            this.labelCabeca.Text = "😧";
            this.labelCabeca.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCorpo
            // 
            this.labelCorpo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCorpo.AutoSize = true;
            this.labelCorpo.BackColor = System.Drawing.Color.Transparent;
            this.labelCorpo.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCorpo.ForeColor = System.Drawing.Color.White;
            this.labelCorpo.Location = new System.Drawing.Point(171, 82);
            this.labelCorpo.Name = "labelCorpo";
            this.labelCorpo.Size = new System.Drawing.Size(54, 89);
            this.labelCorpo.TabIndex = 10;
            this.labelCorpo.Text = "|";
            // 
            // labelBraco1
            // 
            this.labelBraco1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBraco1.AutoSize = true;
            this.labelBraco1.BackColor = System.Drawing.Color.Transparent;
            this.labelBraco1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBraco1.ForeColor = System.Drawing.Color.White;
            this.labelBraco1.Location = new System.Drawing.Point(134, 82);
            this.labelBraco1.Name = "labelBraco1";
            this.labelBraco1.Size = new System.Drawing.Size(64, 89);
            this.labelBraco1.TabIndex = 12;
            this.labelBraco1.Text = "/";
            // 
            // labelBraco2
            // 
            this.labelBraco2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBraco2.AutoSize = true;
            this.labelBraco2.BackColor = System.Drawing.Color.Transparent;
            this.labelBraco2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBraco2.ForeColor = System.Drawing.Color.White;
            this.labelBraco2.Location = new System.Drawing.Point(206, 82);
            this.labelBraco2.Name = "labelBraco2";
            this.labelBraco2.Size = new System.Drawing.Size(63, 89);
            this.labelBraco2.TabIndex = 11;
            this.labelBraco2.Text = "\\";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(29, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(17, 266);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informe o Palpite:";
            // 
            // txtPalpite
            // 
            this.txtPalpite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPalpite.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPalpite.Location = new System.Drawing.Point(171, 413);
            this.txtPalpite.Multiline = true;
            this.txtPalpite.Name = "txtPalpite";
            this.txtPalpite.Size = new System.Drawing.Size(39, 39);
            this.txtPalpite.TabIndex = 1;
            this.txtPalpite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPernas
            // 
            this.labelPernas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPernas.AutoSize = true;
            this.labelPernas.BackColor = System.Drawing.Color.Transparent;
            this.labelPernas.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPernas.ForeColor = System.Drawing.Color.White;
            this.labelPernas.Location = new System.Drawing.Point(134, 160);
            this.labelPernas.Name = "labelPernas";
            this.labelPernas.Size = new System.Drawing.Size(130, 89);
            this.labelPernas.TabIndex = 13;
            this.labelPernas.Text = "👖";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(552, 505);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(568, 544);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Jogo da Forca Top 2023";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtPalpite;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label labelCabeca;
        private Label labelCorpo;
        private Label labelBraco1;
        private Label labelBraco2;
        private Label labelPernas;
        private Button btnConfirma;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelPalavra;
    }
}