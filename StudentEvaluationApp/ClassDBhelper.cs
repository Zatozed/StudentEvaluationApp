using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace StudentEvaluationApp
{
    internal class ClassDBhelper
    {

        public OleDbConnectionStringBuilder connectionStringBuilder;
        public OleDbConnection con;

        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private OleDbDataAdapter dataAdapter;

        public ArrayList bagsakGradeCourseArrList = new ArrayList();

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
                MessageBox.Show("Something went wrong. Code: CVL01");
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

                cmd = new OleDbCommand("select yearLvl from tblYear", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr.GetInt32(0));
                }

                dr.DisposeAsync();
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()+"Something went wrong. Error code: FSR20-CDBHYL145");
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

                cmd = new OleDbCommand("select sem from tblSem", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr.GetInt32(0));
                }

                dr.DisposeAsync();
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error code: SL175");
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
        //---------------------------------------------------------------- Manage Curriculum form
        public DataTable ShowCourseListNoDes()
        {
            DataTable dt = new DataTable();

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"select courseID, courseCode, courseName, unit
                    from tblCourse where isDel = false", con);
                dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);

                dataAdapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("show course list " + e.Message.ToString());
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }
        //---------------------------------------------------------------- Manage Curriculum form
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

                cmd = new OleDbCommand("select yearID from tblYear where yearLvl = " + yearDes + "", con);

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
                MessageBox.Show("Something went wrong when selecting the year level. Error code: GYI594");
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

                cmd = new OleDbCommand("select semID from tblSem where sem = " + semDes + "", con);

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
                MessageBox.Show("Something went wrong when selecting the sem. Error code: GSI626");
            }
            finally
            {
                CloseCon();
            }

            return semID;
        }
        public string GetStudRecentID()
        {
            string studID = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand("select top 1 studentID from tblStudentInfo order by studentID desc", con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    studID = dr.GetInt32(0).ToString();
                }

                dr.Close();
                dr.DisposeAsync();
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

            return studID;
        }
        public DataTable GetCourseWithCurricuVerIDListWhereCvProgramSemYearMatch
            (string cvID, string programID, string semID, string yearID)
        {
            DataTable list = new DataTable();

            try
            {
                OpenCon();

                cmd = new OleDbCommand(
                    "select ID from tblCourse_Curriculum where curricuVerID = "+ cvID
                    + " and semID = " + semID
                    + " and yearID = " + yearID
                    + " and programID =" + programID
                    , con);

                dataAdapter = new OleDbDataAdapter(cmd);

                dataAdapter.Fill(list);

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
        public void InsertToStudentPermanentRecord(string studID, string curricuID)
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"insert into tblStudentPermanentRecord
                    (studentID, course_curricuID)
                    values
                    (@studID, @curricuID)
"
                    , con);

                cmd.Parameters.AddWithValue("@studID", studID);
                cmd.Parameters.AddWithValue("@curricuID", curricuID);

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
//        public void InsertToStudentPermanentRecord(string studID, string curricuID)
//        {
//            try
//            {
//                OpenCon();

//                cmd = new OleDbCommand
//                    (@"insert into tblStudentPermanentRecord
//                    (studentID, course_curricuID)
//                    values
//                    (@studID, @curricuID)
//"
//                    , con);

//                cmd.Parameters.AddWithValue("@studID", studID);
//                cmd.Parameters.AddWithValue("@curricuID", curricuID);

//                cmd.ExecuteNonQuery();

//                cmd.Dispose();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show("insert curriculum" + e.Message.ToString());
//            }
//            finally
//            {
//                CloseCon();
//            }
//        }
        //---------------------------------------------------------------- Student Reg form
        //---------------------------------------------------------------- Student Input grades form
        public DataTable GetStudInfo(string studId)
        {
            DataTable dt = new DataTable();

            try
            {
                OpenCon();

                cmd = new OleDbCommand(
                    @"select top 1
                    studentNum, firstName, lastName, middleName,
                    curricuVerID, programID, yearID, semID
                    from tblStudentInfo
                    where studentID = " + studId
                    , con);

                dataAdapter = new OleDbDataAdapter(cmd);

                dataAdapter.Fill(dt);

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
        public string GetCurriculumVersionByID(string cvID)
        {
            string s = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("select top 1 curricuDescription from tblCurriculumVer where curricuVerID = "
                    + cvID, con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr.GetString(0);
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error Code: GTCVDES01");
            }
            finally
            {
                CloseCon();
            }

            return s;
        }
        public string GetProgramDesByID(string programID)
        {
            string s = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("select top 1 programCode from tblProgram where programID = "
                    + programID, con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr.GetString(0);
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error Code: GTPDES01");
            }
            finally
            {
                CloseCon();
            }

            return s;
        }
        public int GetYearByID(string yearID)
        {
            int s = 0;

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("select top 1 yearLvl from tblyear where yearID = "
                    + yearID, con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr.GetInt32(0);
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error Code: GYBI921");
            }
            finally
            {
                CloseCon();
            }

            return s;
        }
        public int GetSemByID(string semID)
        {
            int s = 0;

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("select top 1 sem from tblSem where semID = "
                    + semID, con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr.GetInt32(0);
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error Code: GSBI955");
            }
            finally
            {
                CloseCon();
            }

            return s;
        }
        public DataTable ShowCourseAndGrade(string studID) 
        {
            DataTable dt = new DataTable();
            try
            {
                OpenCon();

                cmd = new OleDbCommand(
                    @"SELECT 
                    tblStudentPermanentRecord.recordID, 
                    tblStudentPermanentRecord.studentID, 
                    tblCourse.courseCode,
                    tblCourse.courseName, 
                    tblStudentPermanentRecord.grade1stTake, 
                    tblStudentPermanentRecord.grade2ndTake, 
                    tblStudentPermanentRecord.grade3rdTake, 
                    tblCourse_Curriculum.prereqID
                    FROM 
                    (tblCourse 
                    INNER JOIN tblCourse_Curriculum 
                    ON tblCourse.[courseID] = tblCourse_Curriculum.[courseID]) 
                    INNER JOIN tblStudentPermanentRecord 
                    ON tblCourse_Curriculum.[ID] = tblStudentPermanentRecord.[course_curricuID]
                    where studentID ="
                    + studID
                    , con);

                dataAdapter = new OleDbDataAdapter(cmd);

                dataAdapter.Fill(dt);

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error code: CDBH1019");
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }
        public void UpdateStudentPermanentRecord(string recordID, double g1, double g2, double g3)
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    (@"update tblStudentPermanentRecord 
                    set 
                    grade1stTake = " + g1
                    + ",grade2ndTake = " + g2
                    + ",grade3rdTake = " + g3
                    + " where recordID = " + recordID
                    , con);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error code: USPR1033");
            }
            finally
            {
                CloseCon();
            }
        }
        public void UpdateStudentSemYearStudentInfo(string studID, string yearID, string semID)
        {
            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("update tblStudentInfo set yearID = "+yearID+", semID = " +semID+ " where studentID = "+studID
                    , con);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString() + "Something went wrong. Error code: USSY1061");
            }
            finally
            {
                CloseCon();
            }
        }
        //---------------------------------------------------------------- Student Input grades form
        //---------------------------------------------------------------- Evaluation Result form
        public string GetFullName(string studID)
        {
            string fn = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("select top 1 lastName, firstName, middleName from tblStudentInfo where studentID = " + studID
                    , con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    fn = dr.GetString(0) +", " +dr.GetString(1) + " " + dr.GetString(2);
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show( e.Message.ToString()+ "Something went wrong. Error Code: CDBH1120-");
            }
            finally
            {
                CloseCon();
            }

            return fn;
        }
        public string GetStudNum(string studID)
        {
            string sn = "";

            try
            {
                OpenCon();

                cmd = new OleDbCommand
                    ("select top 1 studentNum from tblStudentInfo where studentID = " + studID
                    , con);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    sn = dr.GetString(0);
                }

                dr.Close();
                dr.DisposeAsync();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. Error Code: CDBHGSN1120-");
            }
            finally
            {
                CloseCon();
            }

            return sn;
        }
        public DataTable ShowCourseWithCurricuVerListWhereCvProgramSemYearMatch
            (string cvID, string programID, string semID, string yearID)
        {
            DataTable list = new DataTable();

            try
            {
                OpenCon();

                cmd = new OleDbCommand(
                    @"SELECT 
                    tblCourse.courseCode, 
                    tblCourse.courseName, 
                    tblCourse.courseDes, 
                    tblCourse.unit, 
                    tblCourse_Curriculum.cash, 
                    tblCourse_Curriculum.lowMonthly, 
                    tblCourse_Curriculum.curricuVerID, 
                    tblCourse_Curriculum.programID, 
                    tblCourse_Curriculum.semID, 
                    tblCourse_Curriculum.yearID
                    FROM 
                    tblCourse 
                    INNER JOIN 
                    tblCourse_Curriculum 
                    ON tblCourse.[courseID] = tblCourse_Curriculum.[courseID]
                    where
                    tblCourse_Curriculum.curricuVerID = " + cvID
                    + " and tblCourse_Curriculum.semID = " + semID
                    + " and tblCourse_Curriculum.yearID = " + yearID
                    + " and tblCourse_Curriculum.programID = " + programID
                    , con);

                dataAdapter = new OleDbDataAdapter(cmd);

                dataAdapter.Fill(list);

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
        public DataTable GetSemYearFromStudentInfo(string studID)
        {
            {
                DataTable list = new DataTable();

                try
                {
                    OpenCon();

                    cmd = new OleDbCommand(
                        "select top 1 semID, yearID from tblStudentInfo where studentID = " + studID
                        , con);

                    dataAdapter = new OleDbDataAdapter(cmd);

                    dataAdapter.Fill(list);

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
        }
        //---------------------------------------------------------------- Evaluation Result form
    }
}
