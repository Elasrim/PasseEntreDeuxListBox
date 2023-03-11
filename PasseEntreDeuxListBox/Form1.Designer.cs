namespace PasseEntreDeuxListBox
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
            lbClients = new ListBox();
            LbClientsFidele = new ListBox();
            btPasseADroite = new Button();
            btPasseAGauche = new Button();
            btPasseTousAdroit = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            tbClients = new TextBox();
            btAjouter = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbClients
            // 
            lbClients.FormattingEnabled = true;
            lbClients.ItemHeight = 32;
            lbClients.Location = new Point(60, 170);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(286, 356);
            lbClients.TabIndex = 0;
            // 
            // LbClientsFidele
            // 
            LbClientsFidele.FormattingEnabled = true;
            LbClientsFidele.ItemHeight = 32;
            LbClientsFidele.Location = new Point(603, 170);
            LbClientsFidele.Name = "LbClientsFidele";
            LbClientsFidele.Size = new Size(286, 356);
            LbClientsFidele.TabIndex = 1;
            // 
            // btPasseADroite
            // 
            btPasseADroite.Location = new Point(424, 170);
            btPasseADroite.Name = "btPasseADroite";
            btPasseADroite.Size = new Size(86, 62);
            btPasseADroite.TabIndex = 2;
            btPasseADroite.Text = ">";
            btPasseADroite.UseVisualStyleBackColor = true;
            btPasseADroite.Click += btPasseADroite_Click;
            // 
            // btPasseAGauche
            // 
            btPasseAGauche.Location = new Point(424, 270);
            btPasseAGauche.Name = "btPasseAGauche";
            btPasseAGauche.Size = new Size(86, 62);
            btPasseAGauche.TabIndex = 3;
            btPasseAGauche.Text = "<";
            btPasseAGauche.UseVisualStyleBackColor = true;
            btPasseAGauche.Click += btPasseAGauche_Click;
            // 
            // btPasseTousAdroit
            // 
            btPasseTousAdroit.Location = new Point(424, 369);
            btPasseTousAdroit.Name = "btPasseTousAdroit";
            btPasseTousAdroit.Size = new Size(86, 62);
            btPasseTousAdroit.TabIndex = 4;
            btPasseTousAdroit.Text = ">>";
            btPasseTousAdroit.UseVisualStyleBackColor = true;
            btPasseTousAdroit.Click += btPasseTousAdroit_Click;
            // 
            // button4
            // 
            button4.Location = new Point(424, 464);
            button4.Name = "button4";
            button4.Size = new Size(86, 62);
            button4.TabIndex = 5;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(391, 593);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 6;
            button5.Text = "Fermer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 45);
            label1.Name = "label1";
            label1.Size = new Size(67, 32);
            label1.TabIndex = 7;
            label1.Text = "Nom";
            // 
            // tbClients
            // 
            tbClients.Location = new Point(275, 48);
            tbClients.Name = "tbClients";
            tbClients.Size = new Size(393, 39);
            tbClients.TabIndex = 8;
            // 
            // btAjouter
            // 
            btAjouter.Location = new Point(689, 41);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new Size(150, 46);
            btAjouter.TabIndex = 9;
            btAjouter.Text = "Ajouter";
            btAjouter.UseVisualStyleBackColor = true;
            btAjouter.Click += btAjouter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 135);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 10;
            label2.Text = "Clients";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 135);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 11;
            label3.Text = "Clients Fideles";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 713);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btAjouter);
            Controls.Add(tbClients);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btPasseTousAdroit);
            Controls.Add(btPasseAGauche);
            Controls.Add(btPasseADroite);
            Controls.Add(LbClientsFidele);
            Controls.Add(lbClients);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbClients;
        private ListBox LbClientsFidele;
        private Button btPasseADroite;
        private Button btPasseAGauche;
        private Button btPasseTousAdroit;
        private Button button4;
        private Button button5;
        private Label label1;
        private TextBox tbClients;
        private Button btAjouter;
        private Label label2;
        private Label label3;
    }
}