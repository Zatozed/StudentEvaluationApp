using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;

namespace StudentEvaluationApp
{
    internal class ClassDBhelper
    {
        private OleDbConnection con = new OleDbConnection("C:\\Users\\Loui\\Documents\\VS\\DB\\TestDB.accdb");

        private OleDbCommand cmd;
        private OleDbDataReader r;
        private OleDbDataAdapter adp;

        public void OpenCon()
        {
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }

        public int TestCon()
        {
            int toReturn = 0;

            try
            {
                con.Open();
                cmd = new OleDbCommand("select 1", con);
                r = cmd.ExecuteReader();

                if (r.Read())
                    toReturn = r.GetInt32(0);
            }
            catch (Exception e) { MessageBox.Show(e.Message.ToString()); }
            finally { con.Close(); }

            return toReturn;
        }

        public ArrayList StudNoAutoComplete()
        {
            ArrayList s = new ArrayList();

            try
            {
                con.Open();
                cmd = new OleDbCommand("select [Student No] from tblStudent", con);
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    s.Add(r.GetString(0));
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message.ToString()); }
            finally { con.Close(); }

            return s;
        }

        public string GetStudentName(string studNum)
        {
            string s = "";

            try
            {
                con.Open();
                cmd = new OleDbCommand("select [First Name], [Last Name], [Middle Name] from tblStudent where [Student No] = '" + studNum + "' ", con);
                r = cmd.ExecuteReader();

                if (r.Read())
                {
                    s = r.GetString(0) + r.GetString(1) + r.GetString(2);
                }
            }
            catch (Exception e) { MessageBox.Show("GetStudentName: " + e.Message.ToString()); }
            finally { con.Close(); }

            return s;
        }
    }
}
