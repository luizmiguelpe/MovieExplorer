namespace ProjetoFinal
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Panel pnl_filme;
        private System.Windows.Forms.PictureBox pb_poster;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_diretor;
        private System.Windows.Forms.Label lbl_atores;
        private System.Windows.Forms.Label lbl_avaliacao;
        private System.Windows.Forms.RichTextBox rtb_sinopse;
        private System.Windows.Forms.Button btn_trailer;
        private System.Windows.Forms.Button btn_assistir;
        private System.Windows.Forms.FlowLayoutPanel flp_catalogo;
        private System.Windows.Forms.Button btn_voltar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.pnl_filme = new System.Windows.Forms.Panel();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_diretor = new System.Windows.Forms.Label();
            this.lbl_atores = new System.Windows.Forms.Label();
            this.lbl_avaliacao = new System.Windows.Forms.Label();
            this.rtb_sinopse = new System.Windows.Forms.RichTextBox();
            this.btn_trailer = new System.Windows.Forms.Button();
            this.btn_assistir = new System.Windows.Forms.Button();
            this.flp_catalogo = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnl_filme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pesquisar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_pesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txt_pesquisar.Location = new System.Drawing.Point(40, 25);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(500, 32);
            this.txt_pesquisar.TabIndex = 0;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(560, 25);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(120, 30);
            this.btn_pesquisar.TabIndex = 1;
            this.btn_pesquisar.Text = "🔎 Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // pnl_filme
            // 
            this.pnl_filme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_filme.Controls.Add(this.pb_poster);
            this.pnl_filme.Controls.Add(this.lbl_titulo);
            this.pnl_filme.Controls.Add(this.lbl_ano);
            this.pnl_filme.Controls.Add(this.lbl_genero);
            this.pnl_filme.Controls.Add(this.lbl_diretor);
            this.pnl_filme.Controls.Add(this.lbl_atores);
            this.pnl_filme.Controls.Add(this.lbl_avaliacao);
            this.pnl_filme.Controls.Add(this.rtb_sinopse);
            this.pnl_filme.Controls.Add(this.btn_trailer);
            this.pnl_filme.Controls.Add(this.btn_assistir);
            this.pnl_filme.Location = new System.Drawing.Point(40, 80);
            this.pnl_filme.Name = "pnl_filme";
            this.pnl_filme.Size = new System.Drawing.Size(860, 460);
            this.pnl_filme.TabIndex = 2;
            // 
            // pb_poster
            // 
            this.pb_poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_poster.Location = new System.Drawing.Point(20, 20);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(200, 300);
            this.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_poster.TabIndex = 0;
            this.pb_poster.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(240, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(600, 25);
            this.lbl_titulo.TabIndex = 1;
            // 
            // lbl_ano
            // 
            this.lbl_ano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_ano.ForeColor = System.Drawing.Color.White;
            this.lbl_ano.Location = new System.Drawing.Point(240, 55);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(600, 20);
            this.lbl_ano.TabIndex = 2;
            // 
            // lbl_genero
            // 
            this.lbl_genero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(240, 80);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(600, 20);
            this.lbl_genero.TabIndex = 3;
            // 
            // lbl_diretor
            // 
            this.lbl_diretor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_diretor.ForeColor = System.Drawing.Color.White;
            this.lbl_diretor.Location = new System.Drawing.Point(240, 105);
            this.lbl_diretor.Name = "lbl_diretor";
            this.lbl_diretor.Size = new System.Drawing.Size(600, 20);
            this.lbl_diretor.TabIndex = 4;
            // 
            // lbl_atores
            // 
            this.lbl_atores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_atores.ForeColor = System.Drawing.Color.White;
            this.lbl_atores.Location = new System.Drawing.Point(240, 130);
            this.lbl_atores.Name = "lbl_atores";
            this.lbl_atores.Size = new System.Drawing.Size(600, 20);
            this.lbl_atores.TabIndex = 5;
            // 
            // lbl_avaliacao
            // 
            this.lbl_avaliacao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_avaliacao.ForeColor = System.Drawing.Color.White;
            this.lbl_avaliacao.Location = new System.Drawing.Point(240, 155);
            this.lbl_avaliacao.Name = "lbl_avaliacao";
            this.lbl_avaliacao.Size = new System.Drawing.Size(600, 20);
            this.lbl_avaliacao.TabIndex = 6;
            // 
            // rtb_sinopse
            // 
            this.rtb_sinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtb_sinopse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sinopse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtb_sinopse.ForeColor = System.Drawing.Color.White;
            this.rtb_sinopse.Location = new System.Drawing.Point(240, 190);
            this.rtb_sinopse.Name = "rtb_sinopse";
            this.rtb_sinopse.ReadOnly = true;
            this.rtb_sinopse.Size = new System.Drawing.Size(600, 130);
            this.rtb_sinopse.TabIndex = 7;
            this.rtb_sinopse.Text = "";
            // 
            // btn_trailer
            // 
            this.btn_trailer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_trailer.FlatAppearance.BorderSize = 0;
            this.btn_trailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trailer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_trailer.ForeColor = System.Drawing.Color.White;
            this.btn_trailer.Location = new System.Drawing.Point(240, 340);
            this.btn_trailer.Name = "btn_trailer";
            this.btn_trailer.Size = new System.Drawing.Size(180, 40);
            this.btn_trailer.TabIndex = 8;
            this.btn_trailer.Text = "🎥 Assistir Trailer";
            this.btn_trailer.UseVisualStyleBackColor = false;
            this.btn_trailer.Click += new System.EventHandler(this.btn_trailer_Click);
            // 
            // btn_assistir
            // 
            this.btn_assistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_assistir.FlatAppearance.BorderSize = 0;
            this.btn_assistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assistir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_assistir.ForeColor = System.Drawing.Color.White;
            this.btn_assistir.Location = new System.Drawing.Point(440, 340);
            this.btn_assistir.Name = "btn_assistir";
            this.btn_assistir.Size = new System.Drawing.Size(180, 40);
            this.btn_assistir.TabIndex = 9;
            this.btn_assistir.Text = "📺 Assistir Filme";
            this.btn_assistir.UseVisualStyleBackColor = false;
            this.btn_assistir.Click += new System.EventHandler(this.btn_assistir_Click);
            // 
            // flp_catalogo
            // 
            this.flp_catalogo.AutoScroll = true;
            this.flp_catalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flp_catalogo.Location = new System.Drawing.Point(40, 80);
            this.flp_catalogo.Name = "flp_catalogo";
            this.flp_catalogo.Size = new System.Drawing.Size(860, 460);
            this.flp_catalogo.TabIndex = 3;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(40, 550);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(100, 35);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "⬅️ Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Visible = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.Black;
            this.webView.Location = new System.Drawing.Point(40, 80);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(860, 460);
            this.webView.TabIndex = 5;
            this.webView.Visible = false;
            this.webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.pnl_filme);
            this.Controls.Add(this.flp_catalogo);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.webView);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🎬 Plataforma de Filmes Online";
            this.pnl_filme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

