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
    public partial class ToDoFrm : Form
    {
         string Qry = "select * from DAILY_TASKS;";

        public ToDoFrm()
        {
            InitializeComponent();
        }

        private void ToDoFrm_Load(object sender, EventArgs e)
        {
            lblUser.Text = "User:" + LoginFrm.Uname;
            dtpDate.Value = DateTime.Today;
            ShowData();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void rbDone_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void rbNotDone_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            string Clms = " [Task_no] as Task_No , [T_Date] as Task_Date , [S_Time] as Starting_Time , [E_Time] as Ending_Time , ";
            Clms = Clms + "[WantDo] as Want_to_Do , [T_Status] as Task_Status , [YouDone] as You_have_done , [Uname] as User_Name ";
            if (rbAll.Checked == true)
            {
                Qry = "select " + Clms + " from DAILY_TASKS where [T_Date]=#" + dtpDate.Text + "# and Uname='"+LoginFrm.Uname+"';";
            }
            else if (rbDone.Checked == true)
            {
                Qry = "select  " + Clms + " from DAILY_TASKS where [T_Date]=#" + dtpDate.Text + "# and Uname='" + LoginFrm.Uname + "' and [T_Status]='Done';";
            }
            else if (rbNotDone.Checked == true)
            {
                Qry = "select  " + Clms + " from DAILY_TASKS where [T_Date]=#" + dtpDate.Text + "# and Uname='" + LoginFrm.Uname + "' and [T_Status]='Not Done';";
            }
            else
            {
                ;
            }

            try
            {
                OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable Enq = new DataTable();
                da.Fill(Enq);
                dGView.DataSource = Enq;
                dGView.Columns[1].DefaultCellStyle.Format = "dd-MMM-yyyy";
                dGView.Columns[2].DefaultCellStyle.Format = "hh:mm:ss tt";
                dGView.Columns[3].DefaultCellStyle.Format = "hh:mm:ss tt";

                if (Enq != null)
                    Enq.Clone();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void ShowAllData()
        {
            string Clms = " [Task_no] as Task_No , [T_Date] as Task_Date , [S_Time] as Starting_Time , [E_Time] as Ending_Time , ";
            Clms = Clms + "[WantDo] as Want_to_Do , [T_Status] as Task_Status , [YouDone] as You_have_done , [Uname] as User_Name ";
            if (rbAllS.Checked == true)
            {
                Qry = "select " + Clms + " from DAILY_TASKS where Uname='" + LoginFrm.Uname + "';";
            }
            else if (rbDoneS.Checked == true)
            {
                Qry = "select  " + Clms + " from DAILY_TASKS where [T_Status]='Done' and Uname='" + LoginFrm.Uname + "';";
            }
            else if (rbNDoneS.Checked == true)
            {
                Qry = "select  " + Clms + " from DAILY_TASKS where [T_Status]='Not Done' and Uname='" + LoginFrm.Uname + "';";
            }
            else
            {
                ;
            }

            try
            {
                OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable Enq = new DataTable();
                da.Fill(Enq);
                dGView.DataSource = Enq;
                dGView.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
                dGView.Columns[2].DefaultCellStyle.Format = "hh:mm:ss tt";
                dGView.Columns[3].DefaultCellStyle.Format = "hh:mm:ss tt";

                if (Enq != null)
                    Enq.Clone();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }

        private void ToDoFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginFrm logFrm = new LoginFrm();
            logFrm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTask TskEditFrm = new EditTask();
            TskEditFrm.Show();
            LoginFrm.toDoFrm.Hide();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserFrm userFrm = new UserFrm();
            userFrm.Show();
            LoginFrm.toDoFrm.Hide();
        }

    }
}
