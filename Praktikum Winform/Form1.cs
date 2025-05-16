using Npgsql;

namespace Praktikum_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            Database db = new Database();
            List<User> listDataAdmin = db.GetDataAdmin();
            foreach (var admin in listDataAdmin)
            {
                try
                {
                    if (username == admin.username && password == admin.password)
                    {
                        MessageBox.Show("Login Berhasil",$"Selamat Datang Bang {admin.username}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Form2 form2 = new Form2(admin.username);
                        form2.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login Gagal", $"{ex.ToString()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else
                //{
                //    MessageBox.Show("Username atau Password Salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

            //if (UsernameBox.Text == listuser[0].username && PasswordBox.Text == listuser[0].password)
            //{
            //    MessageBox.Show("Selamat Datang Admin Tercinta","Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();

            //    Form2 form2 = new Form2(UsernameBox.Text);
            //    form2.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Username atau Password Salah", "Login Gagal",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

class User
{
    public string username { get; set; }
    public string password { get; set; }
}
public class Database
{
    NpgsqlConnection conn;
    public Database()
    {
        string connStr = "Server=localhost;Port=5432;User Id=postgres;Password=lubia2341;Database=pbo;";
        conn = new NpgsqlConnection(connStr);
        conn.Open();
    }
    internal List<User> GetDataAdmin()
    {
        List<User> listuser = new List<User>();
        string query = "SELECT * FROM users";
        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User
                    {
                        username = (string)reader["username"],
                        password = (string)reader["password"]

                        //usernameUser =reader.GetString(o)
                    };
                    listuser.Add(user);
                }
                return listuser;
                //User user = new User
                //{
                //    username = reader["username"].ToString()!, //masi ada kemungkinan null
                //    password = (string)reader["password"] //tidak ada kemungkinan null, pasti string
                //};
                //listuser.Add(user);
            }
            //return listuser;
        }
    }
}