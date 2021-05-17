using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEstarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string login = "", password = ""; string id = "", role = "";

            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey key = currentUserKey.OpenSubKey("GameSTARTER");
                login = key.GetValue("login").ToString();
                password = key.GetValue("password").ToString();
                key.Close();
            }
            catch
            {
                Application.Run(new Form1());
            }

            if (login != "" & password != "")
            {
                SqlConnection con = new SqlConnection(Form1.txtcon);
                con.Open();
                SqlCommand query1 = new SqlCommand(
                    String.Format("select id_user, role from users where [login] = '{0}' and [password] = '{1}'", login, password), con);
                SqlDataReader read = query1.ExecuteReader();

                while (read.Read())
                {
                    id = read["id_user"].ToString();
                    role = read["role"].ToString();
                }
                con.Close();
                if (id != "")
                {
                    if (role == "0")
                    {
                        FormCatalog frmCat = new FormCatalog();
                        //frmCat.usersBindingSource.Filter = "[id-user] = " + id;
                        Application.Run(frmCat);
                    }
                    else
                    {
                        FormDevBoard frmMain = new FormDevBoard();
                        frmMain.idCur = Convert.ToInt32(id);
                        Application.Run(frmMain);
                    }

                }
            }
        }
    }
}
