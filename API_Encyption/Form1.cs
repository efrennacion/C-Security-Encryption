using System.Text;

namespace API_Encyption
{
    public partial class Form1 : Form
    {
        AuthEncDec auth;
        private byte[] _key = Encoding.UTF8.GetBytes("sEq763CWuMxf5yRZSa7br1GneG6uqZjv");
        private byte[] _iv = Encoding.UTF8.GetBytes("76sQsZxgUZfNGMd4");
        public static bool enableEncryption;

        public Form1()
        {
            InitializeComponent();
            auth = new AuthEncDec();
            auth.Encryption(true);
        }

        private void btnGenToken_Click(object sender, EventArgs e)
        {
            string genToken = auth.GenerateToken(txtInput.Text);
            encDecResult.Text = genToken;
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            string enc = auth.Encrypt(txtInput.Text, _key, _iv);
            encDecResult.Text = enc;
        }

        private void btnEncryptBool_Click_1(object sender, EventArgs e)
        {
            string enc = auth.EncryptBool(txtInput.Text);
            encDecResult.Text = enc;
        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
            string dec = auth.Decrypt(txtInput.Text, _key, _iv);
            encDecResult.Text = dec;
        }
    }
}