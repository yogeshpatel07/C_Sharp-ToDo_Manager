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
    public partial class TimeTableFrm : Form
    {
        string Qry = "", Todo = "New";
        public TimeTableFrm()
        {
            InitializeComponent();
        }

        private void txtTskNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Todo = "New";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            txtTskNo.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Todo = "Edit";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            txtTskNo.Enabled = true;
        }

        private void DoSomeThing()
        {

                
                string Qry1;
                long tskno = 0;

                try
                {
                    Qry = "select * from Time_Table;";
                    OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
                    OleDbCommand cmd = new OleDbCommand(Qry, con);
                    con.Open();
                    if (Todo == "New")
                    {
                        if (txtNtask.Text.Trim() == "")
                            MessageBox.Show("Task can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            if (checkTime() == false)
                            {
                                MessageBox.Show("There is already a task in this time.\nPlease Enter New time.", "Information", MessageBoxButtons.OK);

                              
                            }
                            else
                            {
                                tskno = findTaskNo();
                                Qry = "insert into Time_Table(Task_no,S_Time,E_Time,Task) values('";
                                Qry = Qry + tskno + "',#" + dtpStime.Value.ToShortTimeString() + "#,#" + dtpEtime.Value.ToShortTimeString() + "#,'" + txtNtask.Text + "');";
                                
                                cmd.CommandText = Qry;
                                int rv = cmd.ExecuteNonQuery();
                                if (rv > 0)
                                {
                                    MessageBox.Show("Task Added.", "Information", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Task Not Added.", "ERROR", MessageBoxButtons.OK);
                                }

                            }
                        }
                    }

                    if (Todo == "Edit")
                    {
                        if (txtTskNo.Text.Trim() == "" || long.TryParse(txtTskNo.Text, out tskno) == false)
                            MessageBox.Show("Task No. can not be empty or string.", "Information", MessageBoxButtons.OK);
                        if (txtNtask.Text.Trim() == "")
                            MessageBox.Show("New Task can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            Qry1 = "select  * from Time_Table where [Task_no]='" + txtTskNo.Text + "';";
                            cmd.CommandText = Qry1;
                            OleDbDataReader Dr = cmd.ExecuteReader();
                            if (Dr.HasRows)
                            {
                                Dr.Read();
                                try
                                {
                                    tskno = long.Parse(Dr.GetString(0));

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no such task nunber.", "ERROR", MessageBoxButtons.OK);
                            }
                            if (Dr != null)
                            {
                                Dr.Close();
                            }

                            Qry = "UPDATE Time_Table SET [Task]='" + txtNtask.Text + "' where [Task_no]='" + tskno + "';";

                            cmd.CommandText = Qry;
                            int rv = cmd.ExecuteNonQuery();
                            if (rv > 0)
                            {
                                MessageBox.Show("Task Edited.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Task Not Edited.", "ERROR", MessageBoxButtons.OK);
                            }
                            if (con != null)
                            {
                                con.Close();
                            }
                        }
                    }

                    if (Todo == "Delete")
                    {
                        if (txtTskNo.Text.Trim() == "" || long.TryParse(txtTskNo.Text, out tskno) == false)
                            MessageBox.Show("Task No. can not be empty or string.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            Qry1 = "select  * from Time_Table where [Task_no]='" + txtTskNo.Text + "';";

                            cmd.CommandText = Qry1;
                            OleDbDataReader Dr = cmd.ExecuteReader();
                            if (Dr.HasRows)
                            {
                                Dr.Read();
                                try
                                {
                                    tskno = long.Parse(Dr.GetString(0));

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no such task nunber.", "ERROR", MessageBoxButtons.OK);
                            }
                            if (Dr != null)
                            {
                                Dr.Close();
                            }

                            Qry = "Delete from Time_Table where [Task_no]='" + tskno + "';";

                            cmd.CommandText = Qry;
                            int rv = cmd.ExecuteNonQuery();
                            if (rv > 0)
                            {
                                MessageBox.Show("Task Deleted.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Task Not Deleted.", "ERROR", MessageBoxButtons.OK);
                            }
                            if (con != null)
                            {
                                con.Close();
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                gbNewTask.Visible = true;
        }

        private bool checkTime()
        {
            bool res = false;
            

            string stime = dtpStime.Value.ToShortTimeString();
            string etime = dtpEtime.Value.ToShortTimeString();
            string tskno;

            string Qry1 = "select  * from Time_Table where [S_Time] between #" + stime + "# and #" + etime + "#;";

            OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
            OleDbCommand cmd = new OleDbCommand(Qry1, con);
            con.Open();
            OleDbDataReader Dr = cmd.ExecuteReader();
            if (Dr.HasRows)
            {

                try
                {
                    Dr.Read();
                    tskno = Dr.GetString(0);
                    res = false;
                    return res;
                }
                catch (Exception)
                {
                    res = true;
                }
            }
            else
            {
                if (Dr != null)
                {
                    Dr.Close();
                }

                Qry1 = "select  * from Time_Table where [E_Time] between #" + stime + "# and #" + etime + "#;";
                cmd.CommandText = Qry1;

                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    try
                    {
                        Dr.Read();
                        tskno = Dr.GetString(0);
                        res = false;
                        return res;
                    }
                    catch (Exception)
                    {
                        res = true;
                    }
                }
                else
                {
                    res = true;
                }

            }
            if (Dr != null)
            {
                Dr.Close();
            }
            if (con != null)
            {
                con.Close();
            }

            return res;

        }

        private void TimeTableFrm_Load(object sender, EventArgs e)
        {
            
            Todo = "New";
            ShowData();
        }

        private long findTaskNo()
        {
            string Qry1 = "select  max(Task_no) from Time_Table;";

            long NewTskNo = 0;
            string DtNw ="1";

            if (long.TryParse(DtNw, out NewTskNo))
            {
                ;
            }
            else
            {
                return NewTskNo;
            }
            OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
            OleDbCommand cmd = new OleDbCommand(Qry1, con);
            con.Open();
            OleDbDataReader Dr = cmd.ExecuteReader();

            if (Dr.HasRows)
            {
                Dr.Read();
                try
                {
                    NewTskNo = long.Parse(Dr.GetString(0)) + 1;
                }
                catch (Exception)
                {
                    return NewTskNo;
                }
            }
            else
            {
                return NewTskNo;
            }
            if (Dr != null)
            {
                Dr.Close();
            }
            if (con != null)
                con.Close();

            return NewTskNo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void TimeTableFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginFrm.toDoFrm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSomeThing();
            ShowData();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Todo = "Delete";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            txtTskNo.Enabled = true;
        }

        private void ShowData()
        {
            string Clms = " [Task_no] as Task_No , [S_Time] as Starting_Time , [E_Time] as Ending_Time , ";
            Clms = Clms + "[Task] as Task_To_Do  ";
            Qry = "select " + Clms + " from Time_Table;";

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
                dGView.Columns[1].DefaultCellStyle.Format = "hh:mm:ss tt";
                dGView.Columns[2].DefaultCellStyle.Format = "hh:mm:ss tt";
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

    }
}
