using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Security.Cryptography;
using System.IO;

namespace BrowSec
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private static SQLiteConnection sqliteConnection;
        private static string pathToChrome = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\");
        private string pathToChromeDb = pathToChrome + "log.sqlite";

        private static string pathToOpera = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\");
        private string pathToOperaDb = pathToOpera + "log.sqlite";

        private static string pathToBrave = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\brave\\");
        private string pathToBraveDb = pathToBrave + "log.sqlite";

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);

 
        }

        private void extractPasswordAndDisplay(string pathOfBrowser,string pathToDb)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ORIGIN_URL", typeof(string));
            table.Columns.Add("ACTION_URL", typeof(string));
            table.Columns.Add("USERNAME", typeof(string));
            table.Columns.Add("PASSWORD_VALUE", typeof(string));

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 300;

            File.Copy(pathOfBrowser + "Login Data", pathToDb, true);

            sqliteConnection = new SQLiteConnection(@"Data Source=" + pathToDb);
            sqliteConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from logins", sqliteConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
                table.Rows.Add(
                reader["origin_url"],
                reader["action_url"],
                reader["username_value"],
                Encoding.ASCII.GetString(Unprotect((byte[])reader["password_value"]))
                );
            sqliteConnection.Close();
           
        }

        public static byte[] Unprotect(byte[] data)
        {
            try
            {
                //Decrypt the data using DataProtectionScope.CurrentUser.
                return ProtectedData.Unprotect(data, null, DataProtectionScope.LocalMachine);
            }
            catch (CryptographicException e)
            {
               return null;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            extractPasswordAndDisplay(pathToChrome,pathToChromeDb);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            extractPasswordAndDisplay(pathToOpera, pathToOperaDb);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            extractPasswordAndDisplay(pathToBrave, pathToBraveDb);
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach(string name in files)
                {
                    if(name.Contains("Login Da"))
                    {
                        extractPasswordAndDisplay(folderBrowserDialog1.SelectedPath+"\\", folderBrowserDialog1.SelectedPath + "\\log.sqlite");
                            break;
                    }
                }
            }
        }
    }
}
