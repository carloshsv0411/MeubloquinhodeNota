﻿namespace MeubloquinhodeNota
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
            buttonAbrir = new Button();
            buttonSalvar = new Button();
            buttonEncriptar = new Button();
            buttonDesencriptar = new Button();
            labelNomeDoArquivo = new Label();
            textBoxConteudo = new TextBox();
            SuspendLayout();
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(12, 12);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(75, 23);
            buttonAbrir.TabIndex = 0;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(93, 12);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += button2_Click;
            // 
            // buttonEncriptar
            // 
            buttonEncriptar.Location = new Point(174, 12);
            buttonEncriptar.Name = "buttonEncriptar";
            buttonEncriptar.Size = new Size(75, 23);
            buttonEncriptar.TabIndex = 2;
            buttonEncriptar.Text = "Encriptar";
            buttonEncriptar.UseVisualStyleBackColor = true;
            buttonEncriptar.Click += buttonEncriptar_Click;
            // 
            // buttonDesencriptar
            // 
            buttonDesencriptar.Location = new Point(255, 12);
            buttonDesencriptar.Name = "buttonDesencriptar";
            buttonDesencriptar.Size = new Size(84, 23);
            buttonDesencriptar.TabIndex = 3;
            buttonDesencriptar.Text = "Desencriptar";
            buttonDesencriptar.UseVisualStyleBackColor = true;
            buttonDesencriptar.Click += buttonDesencriptar_Click;
            // 
            // labelNomeDoArquivo
            // 
            labelNomeDoArquivo.AutoSize = true;
            labelNomeDoArquivo.Location = new Point(354, 16);
            labelNomeDoArquivo.Name = "labelNomeDoArquivo";
            labelNomeDoArquivo.Size = new Size(104, 15);
            labelNomeDoArquivo.TabIndex = 4;
            labelNomeDoArquivo.Text = "'nome do arquivo'";
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConteudo.Location = new Point(12, 41);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.Size = new Size(482, 309);
            textBoxConteudo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxConteudo);
            Controls.Add(labelNomeDoArquivo);
            Controls.Add(buttonDesencriptar);
            Controls.Add(buttonEncriptar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbrir;
        private Button buttonSalvar;
        private Button buttonEncriptar;
        private Button buttonDesencriptar;
        private Label labelNomeDoArquivo;
        private TextBox textBoxConteudo;
    }
}
