using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace StudentEvaluationApp
{
    internal class ClassDBhelper
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Loui\\Documents\\VS\\DB\\TestDB.accdb");

        private OleDbCommand cmd;
        private OleDbDataReader r;
        private OleDbDataAdapter dataAdapter;

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
        public DataTable ShowProgramList()
        {
            DataTable dt = new DataTable();

            try 
            {
                OpenCon();
                cmd = new OleDbCommand("select * from tblProgram", con);
                dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);
            }
            catch(Exception e)
            { 
                MessageBox.Show(e.ToString()); 
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }
    }
}
