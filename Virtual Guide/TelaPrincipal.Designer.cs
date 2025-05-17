namespace Virtual_Guide
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCampo = new TextBox();
            btnEnviar = new Button();
            btnFechar = new Button();
            BtnNovo = new Button();
            rtbResp = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("SimSun", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(988, 75);
            label1.TabIndex = 0;
            label1.Text = "Virtual Guide";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCampo
            // 
            txtCampo.Dock = DockStyle.Bottom;
            txtCampo.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCampo.Location = new Point(0, 524);
            txtCampo.Multiline = true;
            txtCampo.Name = "txtCampo";
            txtCampo.PlaceholderText = "Peça algo ao Virtual Guide: ";
            txtCampo.Size = new Size(988, 125);
            txtCampo.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("SimSun", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(851, 535);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(125, 48);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("SimSun", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(851, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(125, 48);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Font = new Font("SimSun", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnNovo.Location = new Point(12, 12);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(125, 48);
            BtnNovo.TabIndex = 6;
            BtnNovo.Text = "Novo Chat";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // rtbResp
            // 
            rtbResp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbResp.Location = new Point(0, 66);
            rtbResp.Name = "rtbResp";
            rtbResp.Size = new Size(988, 424);
            rtbResp.TabIndex = 7;
            rtbResp.Text = "";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(988, 649);
            Controls.Add(rtbResp);
            Controls.Add(BtnNovo);
            Controls.Add(btnFechar);
            Controls.Add(btnEnviar);
            Controls.Add(txtCampo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstResposta;
        private TextBox txtCampo;
        private Button btnEnviar;
        private Button btnFechar;
        private Button BtnNovo;
        private RichTextBox rtbResp;
    }
}