namespace deltalicznik {
    using System;
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox2_Leave(object sender, EventArgs e) {
            zdarzenie();
        }
        private bool czyliczba(string ciag) {
            foreach (char c in ciag) {
                if (!char.IsNumber(c)) {
                    return false;
                }
            }
            return true;
        }
        private void zdarzenie() {
            if (textBox1.Text.Length > 0& textBox2.Text.Length > 0& textBox3.Text.Length > 0) {
                if (czyliczba(textBox1.Text) & czyliczba(textBox2.Text) & czyliczba(textBox3.Text)) {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = Convert.ToDouble(textBox3.Text);
                    double delta = (b * b) - 4 * a * c;
                    textBox4.Text = delta.ToString();
                }
                else {
                    MessageBox.Show("podaj odpowiednie wartosci","b³¹d",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
            else {
                return;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            zdarzenie();
        }

        private void textBox3_Leave(object sender, EventArgs e) {
            zdarzenie();
        }

        
    }
}