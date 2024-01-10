namespace LoLAceept

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btninstrucoes = new Button();
            radioativar = new CheckBox();
            checkBox2 = new CheckBox();
            radiodesativar = new CheckBox();
            checkBox1 = new CheckBox();
            btnaltaresoluçao = new RadioButton();
            btnbaixaresoluçao = new RadioButton();
            SuspendLayout();
            // 
            // btninstrucoes
            // 
            btninstrucoes.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btninstrucoes.Location = new Point(12, 123);
            btninstrucoes.Name = "btninstrucoes";
            btninstrucoes.Size = new Size(72, 21);
            btninstrucoes.TabIndex = 5;
            btninstrucoes.Text = "Leia!";
            btninstrucoes.UseVisualStyleBackColor = true;
            btninstrucoes.Click += btninstrucoes_Click;
            // 
            // radioativar
            // 
            radioativar.AutoSize = true;
            radioativar.BackColor = Color.DarkTurquoise;
            radioativar.Cursor = Cursors.Hand;
            radioativar.FlatStyle = FlatStyle.Flat;
            radioativar.Location = new Point(22, 21);
            radioativar.Name = "radioativar";
            radioativar.Size = new Size(62, 19);
            radioativar.TabIndex = 7;
            radioativar.Text = "Ativado";
            radioativar.UseVisualStyleBackColor = false;
            radioativar.CheckedChanged += checkativar_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(22, 44);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radiodesativar
            // 
            radiodesativar.BackColor = Color.DarkTurquoise;
            radiodesativar.Cursor = Cursors.Hand;
            radiodesativar.FlatStyle = FlatStyle.Flat;
            radiodesativar.Location = new Point(22, 44);
            radiodesativar.Name = "radiodesativar";
            radiodesativar.Size = new Size(82, 19);
            radiodesativar.TabIndex = 8;
            radiodesativar.Text = "Desativado";
            radiodesativar.UseVisualStyleBackColor = false;
            radiodesativar.CheckedChanged += checkdesativar;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.DarkTurquoise;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(22, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Sempre Ativo";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnaltaresoluçao
            // 
            btnaltaresoluçao.AutoSize = true;
            btnaltaresoluçao.BackColor = SystemColors.ControlLight;
            btnaltaresoluçao.Cursor = Cursors.Hand;
            btnaltaresoluçao.Location = new Point(241, 21);
            btnaltaresoluçao.Name = "btnaltaresoluçao";
            btnaltaresoluçao.Size = new Size(43, 19);
            btnaltaresoluçao.TabIndex = 10;
            btnaltaresoluçao.Text = "720";
            btnaltaresoluçao.UseVisualStyleBackColor = false;
            btnaltaresoluçao.CheckedChanged += btaltaresoliçao;
            // 
            // btnbaixaresoluçao
            // 
            btnbaixaresoluçao.AutoSize = true;
            btnbaixaresoluçao.BackColor = SystemColors.ControlLight;
            btnbaixaresoluçao.Cursor = Cursors.Hand;
            btnbaixaresoluçao.Location = new Point(241, 46);
            btnbaixaresoluçao.Name = "btnbaixaresoluçao";
            btnbaixaresoluçao.Size = new Size(43, 19);
            btnbaixaresoluçao.TabIndex = 11;
            btnbaixaresoluçao.Text = "580";
            btnbaixaresoluçao.UseVisualStyleBackColor = false;
            btnbaixaresoluçao.CheckedChanged += btnbaixaresoluçao_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.foto2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(296, 156);
            Controls.Add(btnbaixaresoluçao);
            Controls.Add(btnaltaresoluçao);
            Controls.Add(checkBox1);
            Controls.Add(radiodesativar);
            Controls.Add(checkBox2);
            Controls.Add(radioativar);
            Controls.Add(btninstrucoes);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "LoLAccept";
            TextChanged += Email;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btninstrucoes;
        private CheckBox radioativar;
        private CheckBox checkBox2;
        private CheckBox radiodesativar;
        private CheckBox checkBox1;
        private RadioButton btnaltaresoluçao;
        private RadioButton btnbaixaresoluçao;
        
    }
}