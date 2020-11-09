using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Assist
{
    public partial class LoginFrm : Form
    {
        public static string DataPathF = Environment.CurrentDirectory;
        //public static string DataPathF = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + DataPathF + "\\MyToDo\\DataBase\\MyDb.accdb;Persist Security Info=False";

        public static string Uname="";
        public static OleDbConnection con = new OleDbConnection(ConStr);
        public static OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader Dr = null;
        public static ToDoFrm toDoFrm = null;// new ToDoFrm();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string epass = Encrypt(TxtPWord.Text);
                string Qry = "select * from Login where uname='" + TxtUName.Text + "' and password='" + epass + "'";

                
                cmd.CommandText = Qry;
                cmd.Connection = con;
                con.Open();
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    MessageBox.Show("Login Successfull...", "information", MessageBoxButtons.OK);
                    LoginFrm.Uname = TxtUName.Text;
                    // ToDoFrm toDoFrm = new ToDoFrm();
                    toDoFrm.Show();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password.", "information", MessageBoxButtons.OK);

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (Dr != null)
                Dr.Close();
            if (con != null)
                con.Close();
        }

        private string Encrypt(string name)
        {

            string z = "", dbn;
            char ch;
            int i, nm;
            for (i = 0; i < name.Length; i++)
            {
                ch = name[i];
                nm = (int)ch;
                dbn = DecToBin(nm);
                z = z + dbn + ",";
            }

            return z;
        }

        private string Descrypt(string num)
        {
            string z = "";
            int c;
            long nm, q;
            string c1;
            char v;
            string[] bins = new string[20];
            bins = num.Split(',');
            for (c = bins.GetLowerBound(0); c < bins.GetUpperBound(0); c++)
            {
                nm = long.Parse(bins[c]);
                c1 = BinToDec(nm);
                q = long.Parse(c1);
                v = (char)q;
                z = z + v;
            }
            return z;
        }
        private string DecToBin(int n)
        {
            int i;
            int[] a = new int[20];
            string rs = "";
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                rs = rs + a[i];
            }
            return rs;
        }

        private string BinToDec(long num)
        {
            long decVal = 0, baseVal = 1, rem;
            string rt = "";
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            rt = rt + decVal;
            return rt;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            TxtUName.Text = "";
            TxtPWord.Text = "";
        }

        private void btnNewAc_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtUName.Text.Trim()=="")
                {
                    MessageBox.Show("User name can not be empty.", "Information", MessageBoxButtons.OK);
                }
                else if (TxtPWord.Text.Trim() == "")
                {
                    MessageBox.Show("Password can not be empty.", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    string epass = Encrypt(TxtPWord.Text);
                    string Qry = "insert into Login values('" + TxtUName.Text + "','" + epass + "');";


                    cmd.CommandText = Qry;
                    cmd.Connection = con;
                    con.Open();
                    int rv = cmd.ExecuteNonQuery();
                    if (rv <= 0)
                    {
                        MessageBox.Show("Account Not Created...", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Account Created...", "Information", MessageBoxButtons.OK);
                    }

                }

            }
            catch (Exception ex)
            {
               
                MessageBox.Show("This Username is already Exist.\nEnter other Username.\n\n"+ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (con != null)
                con.Close();
        }

        private void LoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            toDoFrm = new ToDoFrm();
        }
    }
}
