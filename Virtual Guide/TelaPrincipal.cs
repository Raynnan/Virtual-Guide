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

        private string apiKey = "Sua_Chave_APi_Aqui"; // Chave da API do Google Gemini

        private Mscc.GenerativeAI.Content systemInstruction = new Content("Você é um assistente pessoal"); //Defina o comportamento do seu modelo por aqui...

        public TelaPrincipal()
        {

            InitializeComponent();

            googleAI = new GoogleAI(apiKey: apiKey);

            modelo = googleAI.GenerativeModel(model: Model.Gemini20Flash, systemInstruction: systemInstruction); //Alterado para Gemini 2.0 Flash

            modelo.UseGoogleSearch = true; // Habilita a pesquisa no Google

            chat = modelo.StartChat();

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string prompt = txtCampo.Text; // Obtém o texto do campo de entrada
            
            if(txtCampo.Text == "") //Verifica se a mensagem enviada não é vazia
            {
                MessageBox.Show("Digite uma mensagem antes de enviar.");
                return;
            }

            txtCampo.Text = ""; // Limpa o campo de entrada

            rtbResp.AppendText($"Você: {prompt}\n"); // Adiciona com quebra de linha

            GenerateContentResponse resposta = await chat.SendMessage(prompt); // Declaração explícita do tipo

            if (resposta != null && !string.IsNullOrEmpty(resposta.Text)) // Verifica se a resposta não é nula ou vazia
            {
                rtbResp.AppendText($"Virtual-Guide: {resposta.Text}\n"); // Adiciona com quebra de linha
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
