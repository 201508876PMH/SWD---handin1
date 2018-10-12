using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MainMenu.Model
{

    public class AccountSettingsModel
    {


        public bool Check_if_usernames_are_not_the_same(string currentUsername, string newUsername)
        {
            if (currentUsername != newUsername)
            {
                return true;
            }

            return false;
        }

        //public bool Check_if_email_is_registered_to_user(string email)
        //{
        //    return true;
        //}

        public bool Check_if_emails_are_identical(string email, string repeatedEmail)
        {
            if (email == repeatedEmail)
            {
                return true;
            }

            return false;
        }

        public bool Check_if_current_password_matches_in_DB(string password)
        {
            return true;
        }

        public bool Check_if_new_password_matches_repeated_password(string newPassword, string repeatedPassword)
        {
            return true;
        }
    }
}
