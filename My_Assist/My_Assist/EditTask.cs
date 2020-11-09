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
    public partial class EditTask : Form
    {
        string Qry = "", Todo = "New";
        public EditTask()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Todo = "New";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            gbEditTask.Visible = false;
            gbNewTask.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Todo = "Edit";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            gbEditTask.Visible = true;
            gbNewTask.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Todo = "Delete";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            gbEditTask.Visible = true;
            gbNewTask.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginFrm.toDoFrm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSomeThing();
        }

        private bool checkTime()
        {
            bool res = false;
          //  string stime = dtpStime.Value.ToString();
          //  string etime = dtpEtime.Value.ToString();

            string stime = dtpStime.Value.ToShortTimeString();
            string etime = dtpEtime.Value.ToShortTimeString();
            string tskno;

            string Qry1 = "select  * from DAILY_TASKS where [T_Date]=#" + dtpDate.Text + "# and Uname='" + LoginFrm.Uname + "' ";
            Qry1 = Qry1 + " and [S_Time] between #" + stime + "# and #" + etime + "#;";

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

                Qry1 = "select  * from DAILY_TASKS where [T_Date]=#" + dtpDate.Text + "# and Uname='" + LoginFrm.Uname + "' ";
                Qry1 = Qry1 + " and [E_Time] between #" + stime + "# and #" + etime + "#;";

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

        private long findTaskNo()
        {
            string Qry1 = "select  max(Task_no) from DAILY_TASKS where [T_Date]=#" + dtpDate.Text + "#  and [Uname]='" + LoginFrm.Uname + "';";
            long NewTskNo = 0;
            string DtNw = dtpDate.Value.ToString("ddMMyyyy") + "0";

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

        private void btnImport_Click(object sender, EventArgs e)
        {
            string Qry1= "select * from Time_Table;";
            OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
            OleDbCommand cmd = new OleDbCommand(Qry1, con);
            con.Open();
            OleDbDataReader Dr = cmd.ExecuteReader();

            if (Dr.HasRows)
            {
               
                try
                {
                    while(Dr.Read())
                    {
                        string ss = Dr.GetDateTime(2).ToString("hh.mm.ss tt");
                            
                        dtpStime.Text =Dr.GetDateTime(1).ToString("hh.mm.ss tt");
                        dtpEtime.Text = Dr.GetDateTime(2).ToString("hh.mm.ss tt");
                        txtNtask.Text = Dr.GetString(3);

                        Todo = "New";
                        DoSomeThing();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No Task Imported..", "Information", MessageBoxButtons.OK);
            }
            if (Dr != null)
            {
                Dr.Close();
            }
            if (con != null)
                con.Close();



        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            Qry = "";
            Todo = "New";
            dtpDate.Value = DateTime.Today;


        }

        private void btnEditTT_Click(object sender, EventArgs e)
        {
            TimeTableFrm timeFrm = new TimeTableFrm();
            timeFrm.Show();
            this.Close();
            LoginFrm.toDoFrm.Hide();


        }

        private void DoSomeThing()
        {

            {
                string Add = "yes";
                string Qry1;
                long tskno = 0;

                try
                {
                    Qry = "select * from DAILY_TASKS;";
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
                                if (MessageBox.Show("There is already a task in this time.\nDo you want to add more?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Add = "yes";
                                }
                                else
                                {
                                    Add = "No";
                                }
                            }

                            if (Add.Equals("yes"))
                            {
                                tskno = findTaskNo();
                                Qry = "insert into DAILY_TASKS(Task_no,T_Date,S_Time,E_Time,WantDo,T_Status,Uname) values('";
                                Qry = Qry + tskno + "',#" + dtpDate.Text + "#,#" + dtpStime.Value.ToShortTimeString() + "#,#" + dtpEtime.Value.ToShortTimeString() + "#,'" + txtNtask.Text + "','Not Done','" + LoginFrm.Uname + "');";

                                // dtpEtime.Value.ToString("hh:mm:ss tt");
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
                        if (txtYouDo.Text.Trim() == "")
                            MessageBox.Show("Your done task can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            Qry1 = "select  * from DAILY_TASKS where [Task_no]='" + txtTskNo.Text + "' and [Uname]='" + LoginFrm.Uname + "';";
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

                            string stat = "Not Done";
                            if (rbDone.Checked == true)
                            {
                                stat = "Done";
                            }

                            Qry = "UPDATE DAILY_TASKS SET [T_Status]='" + stat + "', [YouDone]='" + txtYouDo.Text + "' where [Task_no]='" + tskno + "' and [Uname]='" + LoginFrm.Uname + "';";

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
                            Qry1 = "select  * from DAILY_TASKS where [Task_no]='" + txtTskNo.Text + "' and [Uname]='" + LoginFrm.Uname + "';";
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

                            Qry = "Delete from DAILY_TASKS where [Task_no]='" + tskno + "' and [Uname]='" + LoginFrm.Uname + "';";

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
                gbEditTask.Visible = false;
                gbNewTask.Visible = true;
            }
        }
    }
}
