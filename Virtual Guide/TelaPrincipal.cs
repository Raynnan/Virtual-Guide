using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mscc.GenerativeAI; // Importa o namespace da biblioteca Gemini

namespace Virtual_Guide
{

    public partial class TelaPrincipal : Form
    {

        private GoogleAI googleAI; // Declara uma variável para interagir com a API Gemini

        private GenerativeModel modelo; // Declara uma variável para o modelo generativo

        private ChatSession chat; // Declara uma variável para a sessão de chat

        private string apiKey = "SUA_CHAVE_API_AQUI..."; // Chave da API do Google Gemini

        public TelaPrincipal()
        {

            InitializeComponent();

            googleAI = new GoogleAI(apiKey: apiKey);

            modelo = googleAI.GenerativeModel(model: Model.Gemini20Flash); //Alterado para Gemini 2.0 Flash

            chat = modelo.StartChat();

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string prompt = txtCampo.Text; // Obtém o texto do campo de entrada

            txtCampo.Text = ""; // Limpa o campo de entrada

            rtbResp.AppendText($"Você: {prompt}\n"); // Adiciona com quebra de linha

            GenerateContentResponse resposta = await chat.SendMessage(prompt); // Declaração explícita do tipo

            if (resposta != null && !string.IsNullOrEmpty(resposta.Text))
            {
                rtbResp.AppendText($"Gemini: {resposta.Text}\n"); // Adiciona com quebra de linha
            }
            else
            {
                rtbResp.AppendText("Erro ao obter resposta.\n"); // Adiciona com quebra de linha
            }

            // Mantém a última mensagem visível (rolando para o final)
            rtbResp.ScrollToCaret();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            rtbResp.Clear();

            chat = modelo.StartChat();

        }
    }
}
