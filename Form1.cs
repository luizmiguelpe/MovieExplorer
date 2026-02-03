using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Web.WebView2;


namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        private readonly FilmeServico _filmeServico;
        private Filme _filmeAtual;
        

        public Form1()
        {
            InitializeComponent();
            _filmeServico = new FilmeServico();
            

            this.BackColor = Color.FromArgb(30, 30, 30);
            txt_pesquisar.Text = "Digite o nome do filme";
            txt_pesquisar.ForeColor = Color.Gray;

            txt_pesquisar.GotFocus += (s, e) =>
            {
                if (txt_pesquisar.Text == "Digite o nome do filme")
                {
                    txt_pesquisar.Text = "";
                    txt_pesquisar.ForeColor = Color.White;
                }
            };

            txt_pesquisar.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt_pesquisar.Text))
                {
                    txt_pesquisar.Text = "Digite o nome do filme";
                    txt_pesquisar.ForeColor = Color.Gray;
                }
            };
        }

        private async void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string titulo = txt_pesquisar.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || titulo == "Digite o nome do filme")
            {
                MessageBox.Show("Por favor, insira um título de filme válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LimparCampos();

            try
            {
                btn_pesquisar.Enabled = false;
                btn_pesquisar.Text = "Pesquisando...";
                Cursor = Cursors.WaitCursor;

                var filme = await _filmeServico.PesquisarFilmesAsync(titulo);

                if (filme != null)
                {
                    ExibirFilme(filme);
                    _filmeAtual = filme;
                }
                else
                {
                    MessageBox.Show("Filme não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar filme: {ex.Message}");
            }
            finally
            {
                btn_pesquisar.Enabled = true;
                btn_pesquisar.Text = "Pesquisar";
                Cursor = Cursors.Default;
            }
        }

        private void LimparCampos()
        {
            lbl_titulo.Text = lbl_ano.Text = 
            lbl_genero.Text = lbl_diretor.Text = lbl_atores.Text = lbl_avaliacao.Text = "";
            rtb_sinopse.Clear();
            pb_poster.Image = null;
            _filmeAtual = null;
        }

        private void ExibirFilme(Filme filme)
        {
            _filmeAtual = filme;
            lbl_titulo.Text = $"🎬 {filme.Titulo}";
            lbl_ano.Text = $"Ano: {filme.Ano}";
            lbl_genero.Text = $"Gênero: {filme.Genero}";
            lbl_diretor.Text = $"Diretor: {filme.Diretor}";
            lbl_atores.Text = $"Atores: {filme.Atores}";
            lbl_avaliacao.Text = $"IMDb: {filme.Avaliacao}";
            rtb_sinopse.Text = filme.Sinopse;

            if (!string.IsNullOrEmpty(filme.PosterUrl) && filme.PosterUrl != "N/A")
            {
                try { pb_poster.Load(filme.PosterUrl); }
                catch { pb_poster.Image = null; }
            }
        }

        private async void btn_trailer_Click(object sender, EventArgs e)
        {
            if (_filmeAtual == null)
                return;
            try
            {
                pnl_filme.Visible = false;
                flp_catalogo.Visible = false;
                webView.Visible = true;
                btn_voltar.Visible = true;

                if (webView.CoreWebView2 == null)
                {
                    var env = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync();
                    await webView.EnsureCoreWebView2Async(env);
                }

                string url = $"https://www.youtube.com/results?search_query={Uri.EscapeDataString(_filmeAtual.Titulo + " trailer")}";
                webView.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o trailer: {ex.Message}");
            }
        }

        private async void btn_assistir_Click(object sender, EventArgs e)
        {

            if (_filmeAtual == null)
                return;

            try
            {
                pnl_filme.Visible = false;
                flp_catalogo.Visible = false;
                webView.Visible = true;
                btn_voltar.Visible = true;

                if (webView.CoreWebView2 == null)
                    await webView.EnsureCoreWebView2Async(null);

                string url = $"https://www.youtube.com/results?search_query={Uri.EscapeDataString(_filmeAtual.Titulo + " trailer")}";
                webView.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o player: {ex.Message}");
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            webView.Visible = false;
            webView.CoreWebView2?.Stop();
            pnl_filme.Visible = true;
            flp_catalogo.Visible = true;
            btn_voltar.Visible = false;
            
        } 
    }
}
