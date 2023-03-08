namespace PaintClase
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
            pbB = new PictureBox();
            pbC = new PictureBox();
            trackBar1 = new TrackBar();
            label1 = new Label();
            txtR = new TextBox();
            txtB = new TextBox();
            label2 = new Label();
            txtG = new TextBox();
            label3 = new Label();
            txtPapel = new PictureBox();
            btnGuardar = new Button();
            lblTP = new Label();
            btnPintar = new Button();
            btnBorrar = new Button();
            colorDialog1 = new ColorDialog();
            btnDib = new Button();
            guardar = new SaveFileDialog();
            Linea = new Button();
            Rec = new Button();
            Eli = new Button();
            ERellena = new Button();
            rbLinea = new RadioButton();
            rbCua = new RadioButton();
            rbRec = new RadioButton();
            rbElipse = new RadioButton();
            rbER = new RadioButton();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPapel).BeginInit();
            SuspendLayout();
            // 
            // pbB
            // 
            pbB.BackColor = Color.Black;
            pbB.Location = new Point(26, 74);
            pbB.Name = "pbB";
            pbB.Size = new Size(27, 27);
            pbB.TabIndex = 0;
            pbB.TabStop = false;
            pbB.Click += pbB_Click;
            // 
            // pbC
            // 
            pbC.BackColor = Color.RosyBrown;
            pbC.Location = new Point(70, 74);
            pbC.Name = "pbC";
            pbC.Size = new Size(27, 27);
            pbC.TabIndex = 1;
            pbC.TabStop = false;
            pbC.Click += pbC_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(25, 227);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 111);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 128);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 3;
            label1.Text = "R";
            // 
            // txtR
            // 
            txtR.Location = new Point(49, 125);
            txtR.Name = "txtR";
            txtR.Size = new Size(46, 23);
            txtR.TabIndex = 4;
            txtR.Text = "0";
            // 
            // txtB
            // 
            txtB.Location = new Point(49, 198);
            txtB.Name = "txtB";
            txtB.Size = new Size(46, 23);
            txtB.TabIndex = 6;
            txtB.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 201);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "B";
            // 
            // txtG
            // 
            txtG.Location = new Point(49, 163);
            txtG.Name = "txtG";
            txtG.Size = new Size(46, 23);
            txtG.TabIndex = 8;
            txtG.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 166);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 7;
            label3.Text = "G";
            // 
            // txtPapel
            // 
            txtPapel.BackColor = Color.White;
            txtPapel.Location = new Point(245, 41);
            txtPapel.Name = "txtPapel";
            txtPapel.Size = new Size(600, 320);
            txtPapel.TabIndex = 9;
            txtPapel.TabStop = false;
            txtPapel.Paint += txtPapel_Paint;
            txtPapel.MouseDown += txtPapel_MouseDown;
            txtPapel.MouseMove += txtPapel_MouseMove;
            txtPapel.MouseUp += txtPapel_MouseUp;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(112, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTP
            // 
            lblTP.AutoSize = true;
            lblTP.Location = new Point(32, 338);
            lblTP.Name = "lblTP";
            lblTP.Size = new Size(13, 15);
            lblTP.TabIndex = 11;
            lblTP.Text = "3";
            // 
            // btnPintar
            // 
            btnPintar.Location = new Point(26, 12);
            btnPintar.Name = "btnPintar";
            btnPintar.Size = new Size(75, 23);
            btnPintar.TabIndex = 12;
            btnPintar.Text = "Pintar";
            btnPintar.UseVisualStyleBackColor = true;
            btnPintar.Click += btnPintar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(26, 41);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnDib
            // 
            btnDib.Location = new Point(136, 257);
            btnDib.Name = "btnDib";
            btnDib.Size = new Size(75, 23);
            btnDib.TabIndex = 19;
            btnDib.Text = "Dibujar Fig";
            btnDib.UseVisualStyleBackColor = true;
            btnDib.Click += btnDib_Click;
            // 
            // Linea
            // 
            Linea.Location = new Point(408, 392);
            Linea.Name = "Linea";
            Linea.Size = new Size(75, 23);
            Linea.TabIndex = 20;
            Linea.Text = "Línea";
            Linea.UseVisualStyleBackColor = true;
            Linea.Click += Linea_Click;
            // 
            // Rec
            // 
            Rec.Location = new Point(503, 392);
            Rec.Name = "Rec";
            Rec.Size = new Size(75, 23);
            Rec.TabIndex = 21;
            Rec.Text = "Rectángulo";
            Rec.UseVisualStyleBackColor = true;
            Rec.Click += Rec_Click;
            // 
            // Eli
            // 
            Eli.Location = new Point(601, 392);
            Eli.Name = "Eli";
            Eli.Size = new Size(75, 23);
            Eli.TabIndex = 22;
            Eli.Text = "Elipse";
            Eli.UseVisualStyleBackColor = true;
            Eli.Click += Eli_Click;
            // 
            // ERellena
            // 
            ERellena.Location = new Point(692, 392);
            ERellena.Name = "ERellena";
            ERellena.Size = new Size(105, 23);
            ERellena.TabIndex = 23;
            ERellena.Text = "Elipse rellena";
            ERellena.UseVisualStyleBackColor = true;
            ERellena.Click += ERellena_Click;
            // 
            // rbLinea
            // 
            rbLinea.AutoSize = true;
            rbLinea.Location = new Point(134, 125);
            rbLinea.Name = "rbLinea";
            rbLinea.Size = new Size(53, 19);
            rbLinea.TabIndex = 24;
            rbLinea.TabStop = true;
            rbLinea.Text = "Línea";
            rbLinea.UseVisualStyleBackColor = true;
            // 
            // rbCua
            // 
            rbCua.AutoSize = true;
            rbCua.Location = new Point(134, 149);
            rbCua.Name = "rbCua";
            rbCua.Size = new Size(77, 19);
            rbCua.TabIndex = 25;
            rbCua.TabStop = true;
            rbCua.Text = "Cuadrado";
            rbCua.UseVisualStyleBackColor = true;
            // 
            // rbRec
            // 
            rbRec.AutoSize = true;
            rbRec.Location = new Point(134, 174);
            rbRec.Name = "rbRec";
            rbRec.Size = new Size(85, 19);
            rbRec.TabIndex = 26;
            rbRec.TabStop = true;
            rbRec.Text = "Rectángulo";
            rbRec.UseVisualStyleBackColor = true;
            // 
            // rbElipse
            // 
            rbElipse.AutoSize = true;
            rbElipse.Location = new Point(134, 198);
            rbElipse.Name = "rbElipse";
            rbElipse.Size = new Size(55, 19);
            rbElipse.TabIndex = 27;
            rbElipse.TabStop = true;
            rbElipse.Text = "Elipse";
            rbElipse.UseVisualStyleBackColor = true;
            // 
            // rbER
            // 
            rbER.AutoSize = true;
            rbER.Location = new Point(134, 223);
            rbER.Name = "rbER";
            rbER.Size = new Size(96, 19);
            rbER.TabIndex = 28;
            rbER.TabStop = true;
            rbER.Text = "Elipse Rellena";
            rbER.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 396);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 29;
            label4.Text = "Dibujar en tiempo real:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 450);
            Controls.Add(label4);
            Controls.Add(rbER);
            Controls.Add(rbElipse);
            Controls.Add(rbRec);
            Controls.Add(rbCua);
            Controls.Add(rbLinea);
            Controls.Add(ERellena);
            Controls.Add(Eli);
            Controls.Add(Rec);
            Controls.Add(Linea);
            Controls.Add(btnDib);
            Controls.Add(btnBorrar);
            Controls.Add(btnPintar);
            Controls.Add(lblTP);
            Controls.Add(btnGuardar);
            Controls.Add(txtPapel);
            Controls.Add(txtG);
            Controls.Add(label3);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtR);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(pbC);
            Controls.Add(pbB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPapel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbB;
        private PictureBox pbC;
        private TrackBar trackBar1;
        private Label label1;
        private TextBox txtR;
        private TextBox txtB;
        private Label label2;
        private TextBox txtG;
        private Label label3;
        private PictureBox txtPapel;
        private Button btnGuardar;
        private Label lblTP;
        private Button btnPintar;
        private Button btnBorrar;
        private ColorDialog colorDialog1;
        private Button btnDib;
        private SaveFileDialog guardar;
        private Button Linea;
        private Button Rec;
        private Button Eli;
        private Button ERellena;
        private RadioButton rbLinea;
        private RadioButton rbCua;
        private RadioButton rbRec;
        private RadioButton rbElipse;
        private RadioButton rbER;
        private Label label4;
    }
}