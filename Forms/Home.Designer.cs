namespace ScapeRoomProject
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.gb_01 = new System.Windows.Forms.GroupBox();
            this.lbStatus_1 = new System.Windows.Forms.Label();
            this.btDesarmar_1 = new System.Windows.Forms.Button();
            this.lbTimerBomb = new System.Windows.Forms.Label();
            this.resposta_6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.resposta_12 = new System.Windows.Forms.Label();
            this.resposta_11 = new System.Windows.Forms.Label();
            this.resposta_10 = new System.Windows.Forms.Label();
            this.resposta_9 = new System.Windows.Forms.Label();
            this.resposta_8 = new System.Windows.Forms.Label();
            this.resposta_7 = new System.Windows.Forms.Label();
            this.resposta_1 = new System.Windows.Forms.Label();
            this.resposta_2 = new System.Windows.Forms.Label();
            this.resposta_3 = new System.Windows.Forms.Label();
            this.resposta_4 = new System.Windows.Forms.Label();
            this.resposta_5 = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.btMensagem = new System.Windows.Forms.Button();
            this.bombTimer = new System.Windows.Forms.Timer(this.components);
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.lbStatus_2 = new System.Windows.Forms.Label();
            this.btDesarmar_2 = new System.Windows.Forms.Button();
            this.gb_01.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.gb_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_01
            // 
            this.gb_01.BackColor = System.Drawing.Color.Transparent;
            this.gb_01.Controls.Add(this.lbStatus_1);
            this.gb_01.Controls.Add(this.btDesarmar_1);
            this.gb_01.ForeColor = System.Drawing.Color.White;
            this.gb_01.Location = new System.Drawing.Point(24, 24);
            this.gb_01.Margin = new System.Windows.Forms.Padding(15);
            this.gb_01.Name = "gb_01";
            this.gb_01.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.gb_01.Size = new System.Drawing.Size(120, 120);
            this.gb_01.TabIndex = 0;
            this.gb_01.TabStop = false;
            this.gb_01.Text = "Módulo 01";
            // 
            // lbStatus_1
            // 
            this.lbStatus_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus_1.ForeColor = System.Drawing.Color.Red;
            this.lbStatus_1.Location = new System.Drawing.Point(2, 18);
            this.lbStatus_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbStatus_1.Name = "lbStatus_1";
            this.lbStatus_1.Size = new System.Drawing.Size(115, 26);
            this.lbStatus_1.TabIndex = 3;
            this.lbStatus_1.Text = "ARMADO";
            this.lbStatus_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDesarmar_1
            // 
            this.btDesarmar_1.BackColor = System.Drawing.SystemColors.Control;
            this.btDesarmar_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDesarmar_1.ForeColor = System.Drawing.Color.Black;
            this.btDesarmar_1.Location = new System.Drawing.Point(13, 57);
            this.btDesarmar_1.Name = "btDesarmar_1";
            this.btDesarmar_1.Size = new System.Drawing.Size(94, 50);
            this.btDesarmar_1.TabIndex = 1;
            this.btDesarmar_1.Text = "DESARMAR";
            this.btDesarmar_1.UseVisualStyleBackColor = false;
            this.btDesarmar_1.Click += new System.EventHandler(this.desarmarModulo);
            // 
            // lbTimerBomb
            // 
            this.lbTimerBomb.BackColor = System.Drawing.Color.Transparent;
            this.lbTimerBomb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimerBomb.Font = new System.Drawing.Font("Microsoft PhagsPa", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerBomb.ForeColor = System.Drawing.Color.Red;
            this.lbTimerBomb.Location = new System.Drawing.Point(47, 452);
            this.lbTimerBomb.Name = "lbTimerBomb";
            this.lbTimerBomb.Size = new System.Drawing.Size(247, 97);
            this.lbTimerBomb.TabIndex = 13;
            this.lbTimerBomb.Text = "60:00";
            this.lbTimerBomb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTimerBomb.Click += new System.EventHandler(this.iniciarAtividade);
            // 
            // resposta_6
            // 
            this.resposta_6.Location = new System.Drawing.Point(21, 221);
            this.resposta_6.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_6.Name = "resposta_6";
            this.resposta_6.Size = new System.Drawing.Size(180, 23);
            this.resposta_6.TabIndex = 19;
            this.resposta_6.Text = "RESPOSTA DO MODULO 06";
            this.resposta_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_6.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1450, 2);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tempo restante:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.resposta_12);
            this.groupBox13.Controls.Add(this.resposta_11);
            this.groupBox13.Controls.Add(this.resposta_10);
            this.groupBox13.Controls.Add(this.resposta_9);
            this.groupBox13.Controls.Add(this.resposta_8);
            this.groupBox13.Controls.Add(this.resposta_7);
            this.groupBox13.Controls.Add(this.resposta_1);
            this.groupBox13.Controls.Add(this.resposta_2);
            this.groupBox13.Controls.Add(this.resposta_3);
            this.groupBox13.Controls.Add(this.resposta_4);
            this.groupBox13.Controls.Add(this.resposta_5);
            this.groupBox13.Controls.Add(this.resposta_6);
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(324, 422);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(454, 256);
            this.groupBox13.TabIndex = 22;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Respostas";
            // 
            // resposta_12
            // 
            this.resposta_12.Location = new System.Drawing.Point(217, 221);
            this.resposta_12.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_12.Name = "resposta_12";
            this.resposta_12.Size = new System.Drawing.Size(180, 23);
            this.resposta_12.TabIndex = 30;
            this.resposta_12.Text = "RESPOSTA DO MODULO 12";
            this.resposta_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_12.Visible = false;
            // 
            // resposta_11
            // 
            this.resposta_11.Location = new System.Drawing.Point(217, 182);
            this.resposta_11.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_11.Name = "resposta_11";
            this.resposta_11.Size = new System.Drawing.Size(180, 23);
            this.resposta_11.TabIndex = 29;
            this.resposta_11.Text = "RESPOSTA DO MODULO 11";
            this.resposta_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_11.Visible = false;
            // 
            // resposta_10
            // 
            this.resposta_10.Location = new System.Drawing.Point(217, 143);
            this.resposta_10.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_10.Name = "resposta_10";
            this.resposta_10.Size = new System.Drawing.Size(180, 23);
            this.resposta_10.TabIndex = 28;
            this.resposta_10.Text = "RESPOSTA DO MODULO 10";
            this.resposta_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_10.Visible = false;
            // 
            // resposta_9
            // 
            this.resposta_9.Location = new System.Drawing.Point(217, 104);
            this.resposta_9.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_9.Name = "resposta_9";
            this.resposta_9.Size = new System.Drawing.Size(180, 23);
            this.resposta_9.TabIndex = 27;
            this.resposta_9.Text = "RESPOSTA DO MODULO 09";
            this.resposta_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_9.Visible = false;
            // 
            // resposta_8
            // 
            this.resposta_8.Location = new System.Drawing.Point(217, 65);
            this.resposta_8.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_8.Name = "resposta_8";
            this.resposta_8.Size = new System.Drawing.Size(180, 23);
            this.resposta_8.TabIndex = 26;
            this.resposta_8.Text = "RESPOSTA DO MODULO 08";
            this.resposta_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_8.Visible = false;
            // 
            // resposta_7
            // 
            this.resposta_7.Location = new System.Drawing.Point(217, 26);
            this.resposta_7.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_7.Name = "resposta_7";
            this.resposta_7.Size = new System.Drawing.Size(180, 23);
            this.resposta_7.TabIndex = 25;
            this.resposta_7.Text = "RESPOSTA DO MODULO 07";
            this.resposta_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_7.Visible = false;
            // 
            // resposta_1
            // 
            this.resposta_1.Location = new System.Drawing.Point(21, 26);
            this.resposta_1.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_1.Name = "resposta_1";
            this.resposta_1.Size = new System.Drawing.Size(180, 23);
            this.resposta_1.TabIndex = 24;
            this.resposta_1.Text = "RESPOSTA DO MODULO 01";
            this.resposta_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_1.Visible = false;
            // 
            // resposta_2
            // 
            this.resposta_2.Location = new System.Drawing.Point(21, 65);
            this.resposta_2.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_2.Name = "resposta_2";
            this.resposta_2.Size = new System.Drawing.Size(180, 23);
            this.resposta_2.TabIndex = 23;
            this.resposta_2.Text = "RESPOSTA DO MODULO 02";
            this.resposta_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_2.Visible = false;
            // 
            // resposta_3
            // 
            this.resposta_3.Location = new System.Drawing.Point(21, 104);
            this.resposta_3.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_3.Name = "resposta_3";
            this.resposta_3.Size = new System.Drawing.Size(180, 23);
            this.resposta_3.TabIndex = 22;
            this.resposta_3.Text = "RESPOSTA DO MODULO 03";
            this.resposta_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_3.Visible = false;
            // 
            // resposta_4
            // 
            this.resposta_4.Location = new System.Drawing.Point(21, 143);
            this.resposta_4.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_4.Name = "resposta_4";
            this.resposta_4.Size = new System.Drawing.Size(180, 23);
            this.resposta_4.TabIndex = 21;
            this.resposta_4.Text = "RESPOSTA DO MODULO 04";
            this.resposta_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_4.Visible = false;
            // 
            // resposta_5
            // 
            this.resposta_5.Location = new System.Drawing.Point(21, 182);
            this.resposta_5.Margin = new System.Windows.Forms.Padding(8);
            this.resposta_5.Name = "resposta_5";
            this.resposta_5.Size = new System.Drawing.Size(180, 23);
            this.resposta_5.TabIndex = 20;
            this.resposta_5.Text = "RESPOSTA DO MODULO 05";
            this.resposta_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resposta_5.Visible = false;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(-3, 698);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1450, 2);
            this.label15.TabIndex = 23;
            // 
            // btMensagem
            // 
            this.btMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMensagem.Location = new System.Drawing.Point(47, 565);
            this.btMensagem.Name = "btMensagem";
            this.btMensagem.Size = new System.Drawing.Size(247, 74);
            this.btMensagem.TabIndex = 24;
            this.btMensagem.Text = "NOVA MENSAGEM";
            this.btMensagem.UseVisualStyleBackColor = true;
            this.btMensagem.Visible = false;
            this.btMensagem.Click += new System.EventHandler(this.verMensagem);
            // 
            // bombTimer
            // 
            this.bombTimer.Interval = 1000;
            // 
            // gb_2
            // 
            this.gb_2.BackColor = System.Drawing.Color.Transparent;
            this.gb_2.Controls.Add(this.lbStatus_2);
            this.gb_2.Controls.Add(this.btDesarmar_2);
            this.gb_2.ForeColor = System.Drawing.Color.White;
            this.gb_2.Location = new System.Drawing.Point(174, 24);
            this.gb_2.Margin = new System.Windows.Forms.Padding(15);
            this.gb_2.Name = "gb_2";
            this.gb_2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.gb_2.Size = new System.Drawing.Size(120, 120);
            this.gb_2.TabIndex = 25;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "Módulo 02";
            // 
            // lbStatus_2
            // 
            this.lbStatus_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus_2.ForeColor = System.Drawing.Color.Red;
            this.lbStatus_2.Location = new System.Drawing.Point(2, 18);
            this.lbStatus_2.Margin = new System.Windows.Forms.Padding(0);
            this.lbStatus_2.Name = "lbStatus_2";
            this.lbStatus_2.Size = new System.Drawing.Size(115, 26);
            this.lbStatus_2.TabIndex = 3;
            this.lbStatus_2.Text = "ARMADO";
            this.lbStatus_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDesarmar_2
            // 
            this.btDesarmar_2.BackColor = System.Drawing.SystemColors.Control;
            this.btDesarmar_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDesarmar_2.ForeColor = System.Drawing.Color.Black;
            this.btDesarmar_2.Location = new System.Drawing.Point(13, 57);
            this.btDesarmar_2.Name = "btDesarmar_2";
            this.btDesarmar_2.Size = new System.Drawing.Size(94, 50);
            this.btDesarmar_2.TabIndex = 1;
            this.btDesarmar_2.Text = "DESARMAR";
            this.btDesarmar_2.UseVisualStyleBackColor = false;
            this.btDesarmar_2.Click += new System.EventHandler(this.desarmarModulo);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScapeRoomProject.Properties.Resources.imagemFundo;
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.btMensagem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTimerBomb);
            this.Controls.Add(this.gb_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scape Room";
            this.gb_01.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_01;
        private System.Windows.Forms.Button btDesarmar_1;
        private System.Windows.Forms.Label lbTimerBomb;
        private System.Windows.Forms.Label resposta_6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.Label resposta_12;
        private System.Windows.Forms.Label resposta_11;
        private System.Windows.Forms.Label resposta_10;
        private System.Windows.Forms.Label resposta_9;
        private System.Windows.Forms.Label resposta_8;
        private System.Windows.Forms.Label resposta_7;
        private System.Windows.Forms.Label resposta_1;
        private System.Windows.Forms.Label resposta_2;
        private System.Windows.Forms.Label resposta_3;
        private System.Windows.Forms.Label resposta_4;
        private System.Windows.Forms.Label resposta_5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btMensagem;
        private System.Windows.Forms.Label lbStatus_1;
        private System.Windows.Forms.Timer bombTimer;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.Label lbStatus_2;
        private System.Windows.Forms.Button btDesarmar_2;
    }
}

