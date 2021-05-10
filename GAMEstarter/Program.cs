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
    public class Settings
    {
        public Color Ucolor, Dcolor, Fcolor;
        public bool Clock;
        public string ChildColor, ChildStart;

        public List<Color> Ucolors = new List<Color>()
        {
            Color.FromArgb(21,101,192),
            Color.FromArgb(233,47,47),
            Color.FromArgb(255,199,0),
            Color.FromArgb(71,150,93),
            Color.FromArgb(115,113,226),
            Color.FromArgb(47,191,233),
            Color.FromArgb(214,158,233),
            Color.FromArgb(196,238,231),
            Color.FromArgb(255,255,255)
        };

        public List<Color> Dcolors = new List<Color>()
        {
            Color.FromArgb(18,84,171),
            Color.FromArgb(199,33,33),
            Color.FromArgb(222,180,30),
            Color.FromArgb(54,97,61),
            Color.FromArgb(59,85,152),
            Color.FromArgb(67,146,194),
            Color.FromArgb(68,227,084),
            Color.FromArgb(174,193,221),
            Color.FromArgb(203,203,203)
        };

        public List<string> ColorList = new List<string>()
        {
            "#3F51B5", "#009688", "#FF5722", "#607D8B",
            "#FF9800", "#9C27B0", "#2196F3", "#EA676C",
            "#E41A4A", "#5978BB", "#018790", "#B71C46",
            "#00B0AD", "#EA4833", "#EF937E", "#F37521",
            "#A12059", "#8BC240", "#0094BC", "#E4126B",
            "#43B76E", "#7BCFE9",

            //Пали смерью храбрых. Вечная память 
            //"#C7DC5B", "#721D47", "#0E3441", "#126881", "#364D5B",
        };

        public List<Color> Fcolors = new List<Color>()
        {
            Color.WhiteSmoke, SystemColors.ControlText
        };

        public void getSettings()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey key = currentUserKey.OpenSubKey("GameSTARTER\\Settings");

                string txtcolor = key.GetValue("colors").ToString();
                Clock = Convert.ToBoolean(key.GetValue("clock"));
                ChildColor = key.GetValue("child_color").ToString();
                ChildStart = key.GetValue("child_start").ToString();
                key.Close();

                string[] listcolors = txtcolor.Split(' ');
                Ucolor = Ucolors[Convert.ToInt32(listcolors[0])];
                Dcolor = Dcolors[Convert.ToInt32(listcolors[1])];
                Fcolor = Fcolors[Convert.ToInt32(listcolors[2])];
            }
            catch
            {
                setSettings();
            }
        }

        public void setSettings()
        {
            Clock = true;
            ChildColor = "";

            string listcolors = "0 0 0";

            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey key = currentUserKey.CreateSubKey("GameSTARTER\\Settings");
            key.SetValue("colors", listcolors);
            key.SetValue("clock", true);
            key.SetValue("child_color", "");
            key.SetValue("child-start", "");
            key.Close();
        }
    }

    public class Password
    {
        public static string rules = @"Критерии надёжного пароля:
•  длина пароля - минимум 6 символов;
•  содержит и строчные и прописные символы;
•  цифр должно быть не более половины от всех символов пароля;
•  должен содержать минимум 1 символ из набора: ! @ # $ % ^.";

        public static int checkPass(string password)
        {
            int value = 100;
            if (password == "") return value = 0;

            int cntUp = 0, cntnum = 0, cntletter = 0, cntmain = 0;
            string mainchar = @"!@#$%^";

            if (password.Length <= 6) value -= 40;

            for (int i = 0; i <= password.Length - 1; i++)
            {
                if (password[i] == password.ToUpper()[i]) cntUp++;

                if (char.IsNumber(password[i])) cntnum++;
                if (char.IsLetter(password[i])) cntletter++;

                if (mainchar.IndexOf(password[i]) != -1) cntmain++;
            }

            if (cntUp < cntletter) value -= 20;
            if (cntnum > (cntnum + cntletter) / 2) value -= 20;
            if (cntmain == 0) value -= 20;

            return value;
        }
    }

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
            catch { }

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

            Application.Run(new Form1());
        }
    }
}
