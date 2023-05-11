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
            catch (Exception e) { MessageBox.Show("Test Con: "+e.Message.ToString()); }
            finally { con.Close(); }

            return toReturn;
        }
        //---------------------------------------------------------------- ArrayList form
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
        public ArrayList CurriculumVerList()
        {
            ArrayList list = new ArrayList();

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select curricuDescription from tblCurriculumVer where isDel = false", con);
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
        public ArrayList ProgramList()
        {
            ArrayList list = new ArrayList();

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select programCode from tblProgram where isDel = false", con);
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
        public ArrayList YearList()
        {
            ArrayList list = new ArrayList();

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select yearDes from tblYear where isDel = false", con);
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
        public ArrayList SemList()
        {
            ArrayList list = new ArrayList();

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select semDes from tblSem where isDel = false", con);
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
        //---------------------------------------------------------------- ArrayList form
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
                MessageBox.Show("insert to program"+e.ToString());
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
                MessageBox.Show("insert curriculum"+e.Message.ToString());
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

                cmd = new OleDbCommand("update tblCurriculumVer set isDel = true where curricuVerID = " + id, con);

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
        
        public DataTable ShowCourseList()
        {
            DataTable dt = new DataTable();

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"select courseID, courseCode, courseName, courseDes, unit
                    from tblCourse where isDel = false", con);
                dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);

                dataAdapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("show course list "+e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }
        public void InsertToCourse
            (string courseCode, string courseName, string courseDes, int units)
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"insert into tblCourse(courseCode, courseName, courseDes, unit)
                    values(@courseCode, @courseName, @courseDes, @units)", con);

                cmd.Parameters.AddWithValue("@courseCode", courseCode);
                cmd.Parameters.AddWithValue("@courseName", courseName);
                cmd.Parameters.AddWithValue("@courseDes", courseDes);
                cmd.Parameters.AddWithValue("@units", units);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("insert curriculum" + e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        public void EditAtCourse
            (string courseCode, string courseName, string courseDes, int units, int id)
        {
            try
            {
                OpenCon();
                
                cmd = new OleDbCommand
                    ("update tblCourse set courseCode = '"+courseCode
                    +"', courseName = '"+courseName
                    +"', courseDes = '"+courseDes
                    +"', unit = " + units
                    +" where courseID = "+id, con);

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
        public void DelAtCourse(string id)
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand("update tblCourse set isDel = true where courseID ="+id, con);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("course del:"+e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        //---------------------------------------------------------------- Course form
        //---------------------------------------------------------------- Student Reg form
        public string GetCvID(string cvDes) 
        {
            string cvID = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select curricuVerID from tblCurriculumVer where curricuDescription = '" + cvDes +"'",con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cvID = dr.GetInt32(0).ToString();
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong when selecting the curriculum version.");
            }
            finally
            {
                CloseCon();
            }

            return cvID;
        }
        public string GetProgramID(string programCode)
        {
            string programID = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select programID from tblProgram where programCode = '" + programCode + "'", con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    programID = dr.GetInt32(0).ToString();
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong when selecting the program.");
            }
            finally
            {
                CloseCon();
            }

            return programID;
        }
        public string GetYearID(string yearDes)
        {
            string programID = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select yearID from tblYear where yearDes = '" + yearDes + "'", con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    programID = dr.GetInt32(0).ToString();
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong when selecting the program.");
            }
            finally
            {
                CloseCon();
            }

            return programID;
        }
        public string GetSemID(string semDes)
        {
            string semID = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select semID from tblSem where semDes = '" + semDes + "'", con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    semID = dr.GetInt32(0).ToString();
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("");
            }
            finally
            {
                CloseCon();
            }

            return semID;
        }
        public void InsertToStudent
            (
                string studNum, string fname, string lname, string mname,
                string suffix, string gender, string address, string contactNum,
                string pgname, string pgconNum, string lastSchoolAt, string bdate,
                string curricuVerID, string programID, string yearID, string semID
            )
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"insert into tblStudentInfo
                    (
                        studentNum, firstName, lastName, middleName,
                        suffix, gender, address, contactNum,
                        parentGuardianName, parentGuardianContactNum, lastSchoolAttended, birthDate,
                        curricuVerID, programID, yearID, semID
                    )
                    values
                    (
                        @studentNum, @firstName, @lastName, @middleName,
                        @suffix, @gender, @address, @contactNum,
                        @parentGuardinaName, @parentGuardianContactNum, @lastSchoolAttended, @birthDate,
                        @curricuVerID, @programID, @yearID, @semID
                    )", con);

                cmd.Parameters.AddWithValue("@studentNum", studNum);
                cmd.Parameters.AddWithValue("@firstName", fname);
                cmd.Parameters.AddWithValue("@lastName", lname);
                cmd.Parameters.AddWithValue("@middleName", mname);

                cmd.Parameters.AddWithValue("@suffix", suffix);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contactNum", contactNum);

                cmd.Parameters.AddWithValue("@parentGuardinaName", pgname);
                cmd.Parameters.AddWithValue("@parentGuardianContactNum", pgconNum);
                cmd.Parameters.AddWithValue("@lastSchoolAttended", lastSchoolAt);
                cmd.Parameters.AddWithValue("@birthDate", bdate);

                cmd.Parameters.AddWithValue("@curricuVerID", curricuVerID);
                cmd.Parameters.AddWithValue("@programID", programID);
                cmd.Parameters.AddWithValue("@yearID", yearID);
                cmd.Parameters.AddWithValue("@semID", semID);

                cmd.ExecuteNonQuery();

                cmd.Dispose();

                MessageBox.Show("Student information saved.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Insert to studentInfo: " + e.ToString());
            }
            finally
            {
                CloseCon();
            }
        }
        //---------------------------------------------------------------- Student Reg form
    }
}
