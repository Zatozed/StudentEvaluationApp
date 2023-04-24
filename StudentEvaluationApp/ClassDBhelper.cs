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

        public OleDbConnectionStringBuilder connectionStringBuilder;
        public OleDbConnection con;

        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private OleDbDataAdapter dataAdapter;

        public ClassDBhelper()
        {
            connectionStringBuilder = new OleDbConnectionStringBuilder(Properties.Settings.Default.ConString);
            con = new OleDbConnection(connectionStringBuilder.ConnectionString);
        }

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
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    toReturn = dr.GetInt32(0);

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
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
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s.Add(dr.GetString(0));
                }

                dr.DisposeAsync();
                dr.Close();
                cmd.Dispose();
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

                cmd.Dispose();
                dataAdapter.Dispose();
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
                cmd = new OleDbCommand("insert into tblProgram(programCode, ProgramName) values(@code, @p_name)", con);

                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@p_name", p_name);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
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
                cmd = new OleDbCommand("update tblProgram set programCode = '"+ code +"', programName = '"+ p_name +"' where programID ="+id, con);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
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
                cmd = new OleDbCommand("update tblProgram set isDel=true where programID = @id" , con);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
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

        //---------------------------------------------------------------- Curriculum form
        public DataTable ShowCurricuVerList()
        {
            DataTable dt = new DataTable();

            try
            {
                OpenCon();
                cmd = new OleDbCommand("select curricuVerID, curricuDescription from tblCurriculumVer where isDel = false", con);
                dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);

                cmd.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }
        public void InsertToCurricuVer(string cv) 
        {
            try 
            {
                OpenCon();

                cmd = new OleDbCommand("insert into tblCurriculumVer(curricuDescription) values(@cv)", con);

                cmd.Parameters.AddWithValue("@cv", cv);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally 
            {
                CloseCon();
            }
        }
        public void EditAtCurricuVer(string id, string cv) 
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand("update tblCurriculumVer set curricuDescription = '"+ cv +"' where curricuVerID = " + id, con);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        public void DelAtCurricuver(string id) 
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand("update tblCurriculumVer set isDel = true where curricuVerID = @id", con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        //---------------------------------------------------------------- Curriculum form
        //---------------------------------------------------------------- Course form
        public ArrayList CurriculumVerList() 
        {
            ArrayList list = new ArrayList();

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select curricuDescription from tblCurriculumVer", con);
                dr = cmd.ExecuteReader();
                while(dr.Read()) 
                {
                    list.Add(dr.GetString(0));
                }

                dr.DisposeAsync();
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }

            return list;
        }
        public ArrayList ProgramList()
        {
            ArrayList list = new ArrayList();

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select programCode from tblProgram", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr.GetString(0));
                }

                dr.DisposeAsync();
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }

            return list;
        }
        public DataTable ShowCourseList()
        {
            DataTable dt = new DataTable();

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"select 
                    tblCourse.courseID, 
                    tblCourse.courseCode, 
                    tblCourse.courseDescription,
                    tblCourse.units,
                    tblCourse.courseComponent,
                    tblCourse.prereqCourseID,
                    tblProgram.programID, 
                    tblProgram.programCode, 
                    tblCurriculumVer.curricuVerID, 
                    tblCurriculumVer.curricuDescription
                    from ((tblCourse 
                    inner join tblProgram on tblCourse.programID = tblProgram.programID)
                    inner join tblCurriculumVer on tblCourse.curricuVerID = tblCurriculumVer.curricuVerID)", con);
                dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);

                dataAdapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }
        //---------------------------------------------------------------- Course form
    }
}
