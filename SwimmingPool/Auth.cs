using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingPool
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void AuthStartBtn_Click(object sender, EventArgs e)
        {
            bool IsCorrect = false;
            try
            {
                if (!string.IsNullOrEmpty(LoginInput.Text))
                {
                    if (!string.IsNullOrEmpty(PasswordInput.Text))
                    {
                        string Query = "select UserLogin, UserPassword from Users where UserLogin = @0 and UserPassword = @1";
                        DB.Select(Query, new List<string>() { LoginInput.Text, PasswordInput.Text });

                        if (DB.ds.Tables[0].Rows.Count > 0)
                        {
                            Service service = new Service();
                            IsCorrect = true;
                            service.CleanTextControl(new List<Control> { LoginInput, PasswordInput });
                            Main main = new Main(this);
                            main.Show();
                            Hide();
                        }
                        
                        if (!IsCorrect)
                        {
                            throw new Exception("Неправильный логин или пароль!");
                        }
                    }
                    else
                    {
                        throw new ArgumentNullException(PasswordInput.Text, "Логин не может быть пустым!");
                    }
                }
                else
                {
                    throw new ArgumentNullException(LoginInput.Text, "Логин не может быть пустым!"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PasswordShower_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void ShowPassword()
        {
            if (PasswordShower.Checked == true)
            {
                PasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
        }
    }
}
