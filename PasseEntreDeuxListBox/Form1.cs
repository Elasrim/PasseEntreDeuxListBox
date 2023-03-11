namespace PasseEntreDeuxListBox
{
    public partial class Form1 : Form
    {
        private object lbClientsFidele;

        public Form1()
        {
            InitializeComponent();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if (tbClients.Text.Trim() != "")
            {
                lbClients.Items.Add(tbClients.Text.Trim());
                tbClients.Text = "";

            }
            else
                MessageBox.Show("Veillez Entre Le nom De Client", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);


        }

        private void btPasseADroite_Click(object sender, EventArgs e)
        {
            if (lbClients.SelectedItem != null)
            {
                LbClientsFidele.Items.Add(lbClients.SelectedItem);
                lbClients.Items.Remove(lbClients.SelectedItem);
            }
            else
                MessageBox.Show("Selectionnez un Personne S'il Vous Plait", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btPasseAGauche_Click(object sender, EventArgs e)
        {
            if (LbClientsFidele.SelectedItem != null)
            {
                lbClients.Items.Add(LbClientsFidele.SelectedItem);
                LbClientsFidele.Items.Remove(LbClientsFidele.SelectedItem);
            }
            else
                MessageBox.Show("Selectionnez un Personne S'il Vous Plait", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btPasseTousAdroit_Click(object sender, EventArgs e)
        {

            if (lbClients.Items.Count != 0)
            {
                foreach (var item in lbClients.Items)
                {
                    LbClientsFidele.Items.Add(item);
                }

                lbClients.Items.Clear();
            }
            else
                MessageBox.Show("La liste Client est vide", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbClients.Items.Count != 0)
            {
                foreach (var i in LbClientsFidele.Items)
                {
                    lbClients.Items.Add(i);
                }
                LbClientsFidele.Items.Clear();
            }
            else
                MessageBox.Show("La liste Client est vide", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}