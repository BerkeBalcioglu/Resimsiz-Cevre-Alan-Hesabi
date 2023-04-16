namespace Kullanıcıdan_alınan_değerlerle_uzunlukl_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //double uzunkenar = Convert.ToDouble(ukenar.Text);     // girilen değeri double a çevirir
            //double kisakenar = Convert.ToDouble(kkenar.Text);

            kisakenar = double.Parse(kkenar.Text);           //kullanıcının girdiği değeri alır 
            uzunkenar= double.Parse(ukenar.Text);

            double cevre = 2 * (kisakenar+uzunkenar);
            double alan = uzunkenar * kisakenar;

            cevre1.Text = cevre.ToString();      // .ToString metodu sayısal işlemi ekrana yazdırmak için kullanılır
            alan1.Text  = alan.ToString();
        }

        private void ukenar_Click(object sender, EventArgs e)
        {
            if (cevre1.Text== " ")      // kullanıcı birşey girmediyse 0 yazdır 
            {
                cevre1.Text = "0";
            }
        }

        private void textBoxk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxk_Leave(object sender, EventArgs e)   //textbox leav ettiğimizde çıkar
        {
            if (cevre1.Text== " ")      // kullanıcı birşey girmediyse 0 yazdır 
            {
                cevre1.Text = "0";
            }
        }

        private void textBoxu_Leave(object sender, EventArgs e)
        {
            if (cevre1.Text== " ")      // kullanıcı birşey girmediyse 0 yazdır 
            {
                cevre1.Text = "0";
            }
        }

        private void cevre_Click(object sender, EventArgs e)
        {

        }
    }
}