namespace Multiplos3E5Forms
{
    partial class Multiplos3E5
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
            this.btn_clique = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.lbl_info4 = new System.Windows.Forms.Label();
            this.lbl_info5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clique
            // 
            this.btn_clique.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_clique.Location = new System.Drawing.Point(685, 366);
            this.btn_clique.Name = "btn_clique";
            this.btn_clique.Size = new System.Drawing.Size(103, 64);
            this.btn_clique.TabIndex = 0;
            this.btn_clique.Text = "Clique aqui";
            this.btn_clique.UseVisualStyleBackColor = false;
            this.btn_clique.Click += new System.EventHandler(this.btn_clique_Click);
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(240, 121);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(298, 20);
            this.txt_Input.TabIndex = 1;
            this.txt_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(237, 56);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(359, 13);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Insira um número de 1 a 200 e  clique no botão do canto esquerdo da tela!";
            this.lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(237, 200);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(161, 13);
            this.lbl_info1.TabIndex = 3;
            this.lbl_info1.Text = "Se for múltiplo de 3 aparecerá X.";
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(237, 247);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(161, 13);
            this.lbl_info2.TabIndex = 4;
            this.lbl_info2.Text = "Se for múltiplo de 5 aparecerá Y.";
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Location = new System.Drawing.Point(237, 285);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(179, 13);
            this.lbl_info3.TabIndex = 5;
            this.lbl_info3.Text = "Se for múltiplo de 3 e 5 aparecerá Z.";
            // 
            // lbl_info4
            // 
            this.lbl_info4.AutoSize = true;
            this.lbl_info4.Location = new System.Drawing.Point(236, 328);
            this.lbl_info4.Name = "lbl_info4";
            this.lbl_info4.Size = new System.Drawing.Size(360, 13);
            this.lbl_info4.TabIndex = 6;
            this.lbl_info4.Text = "Se o número não for múltiplo de nenhum dos dois,  aparecerá no resultado.";
            this.lbl_info4.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_info5
            // 
            this.lbl_info5.AutoSize = true;
            this.lbl_info5.Location = new System.Drawing.Point(237, 366);
            this.lbl_info5.Name = "lbl_info5";
            this.lbl_info5.Size = new System.Drawing.Size(233, 13);
            this.lbl_info5.TabIndex = 7;
            this.lbl_info5.Text = "Se passar de 200 aparecerá \"Entrada inválida\".";
            // 
            // Multiplos3E5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_info5);
            this.Controls.Add(this.lbl_info4);
            this.Controls.Add(this.lbl_info3);
            this.Controls.Add(this.lbl_info2);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.btn_clique);
            this.Name = "Multiplos3E5";
            this.Text = "Multiplos3E5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clique;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.Label lbl_info4;
        private System.Windows.Forms.Label lbl_info5;
    }
}

