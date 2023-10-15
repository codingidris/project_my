namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenecekmi;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reqem_1_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "1";

        }

        private void reqem_2_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "2";
        }

        private void reqem_3_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "3";
        }

        private void reqem_4_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "4";
        }

        private void reqem_5_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "5";
        }

        private void reqem_6_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "6";
        }

        private void reqem_7_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "7";
        }

        private void reqem_8_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "8";
        }

        private void reqem_9_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekran_label.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekran_label.Text);
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekran_label.Text);
            int sonuc;
            switch (_islem)
            {


                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case 'x':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekran_label.Text = Convert.ToString(sonuc);
        }

        private void cixma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekran_label.Text);
        }

        private void vurma_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekran_label.Text);
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekran_label.Text);
        }

        private void ekrani_temizleme_Click(object sender, EventArgs e)
        {
            ekran_label.Text = "0";
        }
    }
}