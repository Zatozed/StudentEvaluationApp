using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Xml.Linq;

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
        //---------------------------------------------------------------- Program form
        public DataTable ShowProgramList()
        {
            DataTable dt = new DataTable();

            try 
            {
                OpenCon();
                cmd = new OleDbCommand("select programID, programCode, programName from tblProgram where isDel = false", con);
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
        public void InsertToProgram(string code, string p_name)
        {
            try
            {
                OpenCon();
                cmd = new OleDbCommand("insert into tblProgram(programCode, ProgramName) values(code, p_name)"
                    , con);

                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@p_name", p_name);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        public void EditAtProgram(string code, string p_name, string id) 
        {
            try
            {
                OpenCon();
                cmd = new OleDbCommand("update tblProgram set programCode = @c where programID = @id"
                    , con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@p_name", p_name);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        public void DeleteAtProgram(string id) 
        {
            try
            {
                OpenCon();
                cmd = new OleDbCommand("update tblProgram set isDel=true where programID = @id"
                    , con);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        //---------------------------------------------------------------- Program form
    }
}
