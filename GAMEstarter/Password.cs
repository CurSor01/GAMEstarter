using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMEstarter
{
    class Password
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
}
