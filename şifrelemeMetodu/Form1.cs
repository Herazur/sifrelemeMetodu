namespace şifrelemeMetodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Sifrele(string metin)
        {
            Random ri = new Random();
            int sayi;
            string tmp = "";
            for (int i = metin.Length-1;i>=0;i--)
            {
                if (metin[i] == 'a' || metin[i] == 'e' || metin[i] == 'i' || metin[i] == 'ı' || metin[i] == 'u' || metin[i] == 'ü' || metin[i] == 'o' || metin[i] == 'ö')
                {
                    sayi = ri.Next(1, 10);
                    tmp += sayi.ToString();

                }
                else
                tmp += metin[i];
            }
            return tmp;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle, sifrelicumle;
            cumle = textBox1.Text;
            sifrelicumle = Sifrele(cumle);
            textBox2.Text = sifrelicumle;
        }
    }
}