namespace Virtual_Guide
{
    partial class Apresentação
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
            btnFechar = new Button();
            btnIniciar = new Button();
            label2 = new Label();
            btnSobre = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("SimSun", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(447, 105);
            label1.TabIndex = 0;
            label1.Text = "Olá! 👋 Seja bem-vindo(a) ao VirtualGuide, seu assistente virtual inteligente.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.AppWorkspace;
            btnFechar.Dock = DockStyle.Bottom;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(0, 463);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(447, 49);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.AppWorkspace;
            btnIniciar.Dock = DockStyle.Bottom;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(0, 414);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(447, 49);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("SimSun", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 105);
            label2.Name = "label2";
            label2.Size = new Size(447, 123);
            label2.TabIndex = 3;
            label2.Text = "Estou aqui para responder suas perguntas e te ajudar com o que precisar.😊";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSobre
            // 
            btnSobre.BackColor = SystemColors.AppWorkspace;
            btnSobre.Dock = DockStyle.Bottom;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSobre.Location = new Point(0, 512);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(447, 49);
            btnSobre.TabIndex = 4;
            btnSobre.Text = "Sobre o Virtual Guide";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // Apresentação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(447, 561);
            Controls.Add(label2);
            Controls.Add(btnIniciar);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Controls.Add(btnSobre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Apresentação";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apresentação";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnFechar;
        private Button btnIniciar;
        private Label label2;
        private Button btnSobre;
    }
}