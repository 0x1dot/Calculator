using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public Main()
        {
            InitializeComponent();
            SendMessage(txtPanel.Handle, 0x1501, 1, "0x1dot :)");
        }
        private string İslemgonder()
        {
            if (txtPanel.Text.Contains("+") == true)
            {
                var sp = txtPanel.Text.Split('+');
                if (sp[1] == "" || sp[0].Contains("E") == true)
                    return "";
                txtPanel.Text = (double.Parse(sp[0]) + double.Parse(sp[1])).ToString();
                return "+";
            }
            else if (txtPanel.Text.Contains("*") == true)
            {
                var sp = txtPanel.Text.Split('*');
                if (sp[1] == "")
                    return "";
                txtPanel.Text = (double.Parse(sp[0]) * double.Parse(sp[1])).ToString();
                return "-";
            }
            else if (txtPanel.Text.Contains("-") == true)
            {
                var sp = txtPanel.Text.Split('-');
                if (sp[1] == "" || sp[0].Contains("E") == true)
                    return "";
                txtPanel.Text = (double.Parse(sp[0]) - double.Parse(sp[1])).ToString();
                return "*";
            }
            else if (txtPanel.Text.Contains("/") == true)
            {
                var sp = txtPanel.Text.Split('/');
                if (sp[1] == "")
                    return "";
                if (sp[0].ToString() == "0" && sp[1].ToString() == "0")
                {
                    txtPanel.Text = "";
                    MessageBox.Show("Sıfıra Bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "hata";
                }

                txtPanel.Text = (double.Parse(sp[0]) / double.Parse(sp[1])).ToString();
                return "/";
            }
            else return "";
        }
        private void Hesap_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnBackSpace":
                    if (txtPanel.Text.Length > 0)
                        txtPanel.Text = txtPanel.Text.Remove(txtPanel.Text.Length - 1);
                    break;
                case "btnDelete":
                    var currentPosition = txtPanel.SelectionStart;
                    if (txtPanel.Text.Length > 0)
                        txtPanel.Text = txtPanel.Text.Remove(currentPosition,1);

                    break;
                case "btnKok":
                    if (İslemgonder() == "" && txtPanel.Text.Length == 0)
                        return;
                    var kok = Math.Sqrt(double.Parse(txtPanel.Text));
                    txtPanel.Text = kok.ToString();
                    break;
                case "btnClear":
                    txtPanel.Text = "";
                    break;
                case "btnKare":
                    if (İslemgonder() == "" && txtPanel.Text.Length == 0)
                        return;
                    var kare = double.Parse(txtPanel.Text) * double.Parse(txtPanel.Text);
                    txtPanel.Text = kare.ToString();
                    break;
                case "btn0":
                    txtPanel.Text += "0";
                    break;
                case "btn1":
                    txtPanel.Text += "1";
                    break;
                case "btn2":
                    txtPanel.Text += "2";
                    break;
                case "btn3":
                    txtPanel.Text += "3";
                    break;
                case "btn4":
                    txtPanel.Text += "4";
                    break;
                case "btn5":
                    txtPanel.Text += "5";
                    break;
                case "btn6":
                    txtPanel.Text += "6";
                    break;
                case "btn7":
                    txtPanel.Text += "7";
                    break;
                case "btn8":
                    txtPanel.Text += "8";
                    break;
                case "btn9":
                    txtPanel.Text += "9";
                    break;
                case "btnVirgul":
                    if (txtPanel.Text.Length > 0)
                        txtPanel.Text += ",";
                    break;
                case "btnEsittir":
                    if (txtPanel.Text.Length == 0) return;
                    if (İslemgonder() == "hata")
                        if (İslemgonder() == "")
                            return;
                    var esittir = double.Parse(txtPanel.Text);
                    txtPanel.Text = esittir.ToString();
                    break;
                case "btnBolme":
                    if (txtPanel.Text.Length > 0)
                        if (txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "+" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "-" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "*" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "/")
                            txtPanel.Text = txtPanel.Text.Remove(txtPanel.Text.Length - 1);
                    İslemgonder();
                    if (txtPanel.Text.Length != 0)
                        txtPanel.Text += "/";
                    break;
                case "btnTopla":
                    if (txtPanel.Text.Length > 0)
                        if (txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "+" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "-" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "*" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "/")
                            txtPanel.Text = txtPanel.Text.Remove(txtPanel.Text.Length - 1);
                    İslemgonder();
                    if (txtPanel.Text.Length != 0)
                        txtPanel.Text += "+";
                    break;
                case "btnCikartma":
                    if (txtPanel.Text.Length > 0)
                        if (txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "+" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "-" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "*" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "/")
                            txtPanel.Text = txtPanel.Text.Remove(txtPanel.Text.Length - 1);
                    İslemgonder();
                    if (txtPanel.Text.Length != 0)
                        txtPanel.Text += "-";
                    break;
                case "btnCarpma":
                    if (txtPanel.Text.Length > 0)
                        if (txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "+" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "-" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "*" || txtPanel.Text.Substring(txtPanel.Text.Length - 1) == "/")
                            txtPanel.Text = txtPanel.Text.Remove(txtPanel.Text.Length - 1);
                    İslemgonder();
                    if (txtPanel.Text.Length != 0)
                        txtPanel.Text += "*";
                    break;
            }
        }

        private void txtPanel_TextChanged(object sender, EventArgs e)
        {
            btnTopla.Enabled = true;
            btnCikartma.Enabled = true;
            btnCarpma.Enabled = true;
            btnBolme.Enabled = true;
            var sss = "";
            if (!(txtPanel.Text.Length < 1))
                sss = txtPanel.Text.Substring(txtPanel.Text.Length - 1);
            switch (sss)
            {
                case "+":
                    btnTopla.Enabled = false;
                    btnCikartma.Enabled = true;
                    btnCarpma.Enabled = true;
                    btnBolme.Enabled = true;
                    break;
                case "-":
                    btnTopla.Enabled = true;
                    btnCikartma.Enabled = false;
                    btnCarpma.Enabled = true;
                    btnBolme.Enabled = true;
                    break;
                case "*":
                    btnTopla.Enabled = true;
                    btnCikartma.Enabled = true;
                    btnCarpma.Enabled = false;
                    btnBolme.Enabled = true;
                    break;
                case "/":
                    btnTopla.Enabled = true;
                    btnCikartma.Enabled = true;
                    btnCarpma.Enabled = true;
                    btnBolme.Enabled = false;
                    break;
            }

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    Hesap_Click(btn0, new EventArgs());
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    Hesap_Click(btn1, new EventArgs());
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    Hesap_Click(btn2, new EventArgs());
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    Hesap_Click(btn3, new EventArgs());
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    Hesap_Click(btn4, new EventArgs());
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    Hesap_Click(btn5, new EventArgs());
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    Hesap_Click(btn6, new EventArgs());
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    Hesap_Click(btn7, new EventArgs());
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    Hesap_Click(btn8, new EventArgs());
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    Hesap_Click(btn9, new EventArgs());
                    break;
                case Keys.Back:
                    Hesap_Click(btnBackSpace, new EventArgs());
                    break;
                case Keys.Delete:
                    Hesap_Click(new Button() { Name = "btnDelete" }, new EventArgs());
                    break;
                case (Keys.Add):
                    Hesap_Click(btnTopla, new EventArgs());
                    break;
                case Keys.Subtract:
                    Hesap_Click(btnCikartma, new EventArgs());
                    break;
                case Keys.Multiply:
                    Hesap_Click(btnCarpma, new EventArgs());
                    break;
                case Keys.Divide:
                    Hesap_Click(btnBolme, new EventArgs());
                    break;
                case Keys.Enter:
                    Hesap_Click(btnEsittir, new EventArgs());
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                    Hesap_Click(btnVirgul, new EventArgs());
                    break;
                default:
                    break;
            }
        }
    }
}
