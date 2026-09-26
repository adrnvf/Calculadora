namespace Calculadora
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
            lblResultado = new Label();
            btnZero = new Button();
            btnUm = new Button();
            button1 = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMutiplicacao = new Button();
            btnIgual = new Button();
            btnC = new Button();
            btnCe = new Button();
            btnPorcentagem = new Button();
            btnDivisao = new Button();
            btnVirgula = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(34, 49);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 21;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(72, 205);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(40, 23);
            btnZero.TabIndex = 42;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(29, 176);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(37, 23);
            btnUm.TabIndex = 43;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // button1
            // 
            button1.Location = new Point(72, 176);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 44;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(121, 176);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(39, 23);
            btnTres.TabIndex = 45;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(30, 147);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(36, 23);
            btnQuatro.TabIndex = 46;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(72, 147);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(40, 23);
            btnCinco.TabIndex = 47;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(121, 147);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(39, 23);
            btnSeis.TabIndex = 48;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(29, 118);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(37, 23);
            btnSete.TabIndex = 49;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(72, 118);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(40, 23);
            btnOito.TabIndex = 50;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(118, 118);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(42, 23);
            btnNove.TabIndex = 51;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(166, 176);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(41, 23);
            btnAdicao.TabIndex = 52;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(166, 147);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(41, 23);
            btnSubtracao.TabIndex = 53;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnMutiplicacao
            // 
            btnMutiplicacao.Location = new Point(168, 118);
            btnMutiplicacao.Name = "btnMutiplicacao";
            btnMutiplicacao.Size = new Size(39, 23);
            btnMutiplicacao.TabIndex = 54;
            btnMutiplicacao.Text = "x";
            btnMutiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(166, 205);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(41, 23);
            btnIgual.TabIndex = 55;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(29, 89);
            btnC.Name = "btnC";
            btnC.Size = new Size(37, 23);
            btnC.TabIndex = 56;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnCe
            // 
            btnCe.Location = new Point(72, 89);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(40, 23);
            btnCe.TabIndex = 57;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            btnCe.Click += btnCe_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.Location = new Point(118, 89);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(42, 23);
            btnPorcentagem.TabIndex = 58;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = true;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(166, 89);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(41, 23);
            btnDivisao.TabIndex = 59;
            btnDivisao.Text = "-/-";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(121, 205);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(39, 23);
            btnVirgula.TabIndex = 60;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(30, 49);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(177, 23);
            txtResultado.TabIndex = 61;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 270);
            Controls.Add(txtResultado);
            Controls.Add(btnVirgula);
            Controls.Add(btnDivisao);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnCe);
            Controls.Add(btnC);
            Controls.Add(btnIgual);
            Controls.Add(btnMutiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(button1);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Controls.Add(lblResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResultado;
        private Button btnZero;
        private Button btnUm;
        private Button button1;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMutiplicacao;
        private Button btnIgual;
        private Button btnC;
        private Button btnCe;
        private Button btnPorcentagem;
        private Button btnDivisao;
        private Button btnVirgula;
        private TextBox txtResultado;
    }
}
