using System.Runtime.Serialization.Formatters.Binary;

namespace FileManager_2._0
{
    public partial class AdmissionForm : Form
    {
        AuthorizationSetings authorizationSetings;
        public AdmissionForm()
        {
            InitializeComponent();
            authorizationSetings = new AuthorizationSetings();
            passwordTextBox.PasswordChar = '♥';

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("configs.dat", FileMode.OpenOrCreate))
            {
                authorizationSetings = (AuthorizationSetings)formatter.Deserialize(fs);
            }

        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            authorizationSetings.login = loginRichTextBox.Text;
            authorizationSetings.password = passwordTextBox.Text;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("configs.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, authorizationSetings);

            }
            authorizationSetings.password = Crypter.Decrypt(authorizationSetings.password);
            authorizationSetings.login = Crypter.Decrypt(authorizationSetings.login);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string inputLogin = loginRichTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            if(inputPassword == authorizationSetings.password && inputLogin == authorizationSetings.login)
            {
                this.Hide();
                new MainForm().Show();

            }
            else
            {
                MessageBox.Show("введенные данные неверны");
                loginRichTextBox.Text = "";
                passwordTextBox.Text = "";
            }

        }
        private void AdmissionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
