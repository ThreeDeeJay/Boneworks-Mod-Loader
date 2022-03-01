using System;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {
        //Really doesn't matter if you see any of this since there's nothing that needs to be secure, and im not using the license system from Keyauth

        static string name = "Boneworks";
        static string ownerid = "E5jrgE9r91";
        static string secret = "ab119b62d5cf5371f4c6aed5e3c134bce83c78d00b4f356a6fd89d267928c11f";
        static string version = "1.0";

        /*
Optional Functions:
KeyAuthApp.webhook("lfvbBrbFhIr", "?sellerkey=CUqDqlCIgl&type=resethash");
// send secure request to webhook which is impossible to crack into. the base link set on the website is https://keyauth.com/api/seller/, which nobody except you can see, so the final request is https://keyauth.com/api/seller/?sellerkey=CUqDqlCIgl&type=resethash
// byte[] result = KeyAuthApp.download("902901"); // downloads application file
// File.WriteAllBytes("C:\\Users\\mak\\Downloads\\KeyAuth-CSHARP-Example-main (5)\\KeyAuth-CSHARP-Example-main\\ConsoleExample\\bin\\Debug\\countkeys.txt", result);
MessageBox.Show(KeyAuthApp.var("123456")); // retrieve application variable
*/

        // KeyAuthApp.register("username", "password", "key");
        //KeyAuthApp.login("username", "password"); 

        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        public Login()
        {
            InitializeComponent();

			
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }

        }
    }
}

