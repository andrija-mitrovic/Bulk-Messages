using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;


namespace BulkSMS.Validation
{
    public class Valid
    {
        public static void EmailValidation(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            var foo = new EmailAddressAttribute();
            bool bar = false;
            string pom = tb.Text.ToString().Trim(' ');
            bar = foo.IsValid(pom);
            if (bar)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Email not valid please enter again...", "Attention!");
            }
        }
        public static void DecimalValidating(object sender, CancelEventArgs e)
        {
            decimal num;
            TextBox tb = sender as TextBox;
            if (decimal.TryParse(tb.Text, out num) && num > 0)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                MessageBox.Show("In this field must be a number higher then ziro ...", "Attention!");
            }
        }
        public static void TextValidating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.Trim();
            if (tb.Text == "")
            {
                MessageBox.Show("This field cannot be empty ...", "Attention!");
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }
        public static void _KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
