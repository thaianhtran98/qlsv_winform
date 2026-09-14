using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySV.Helpers;
using QuanLySV.Models;

namespace QuanLySV.Services
{
	public class AcademicService
	{
		// =============================================
		// CLASS
		// =============================================
		public static ArrayList FillClass()
		{
			ArrayList list = new ArrayList();
			string sql = "SELECT CLASSID, CLASSNAME, DESCRIPTION, STATUS FROM CLASS WHERE STATUS = :STATUS ORDER BY CLASSID";
			OracleParameter[] parameters = { new OracleParameter(":STATUS", ClassInfo.ACTIVE) };

			DataTable dt = OracleHelper.ExecuteQuery(sql, parameters);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(new ClassInfo
				{
					ClassId = row["CLASSID"].ToString(),
					ClassName = row["CLASSNAME"].ToString(),
					Description = row["DESCRIPTION"]?.ToString(),
					Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : ClassInfo.ACTIVE
				});
			}
			return list;
		}

		public static bool InsertClass(ClassInfo item)
		{
			string sql = "INSERT INTO CLASS (CLASSID, CLASSNAME, DESCRIPTION, STATUS) VALUES (:CLASSID, :CLASSNAME, :DESCRIPTION, :STATUS)";
			OracleParameter[] parameters =
			{
				new OracleParameter(":CLASSID", item.ClassId),
				new OracleParameter(":CLASSNAME", item.ClassName),
				new OracleParameter(":DESCRIPTION", (object)item.Description ?? DBNull.Value),
				new OracleParameter(":STATUS", item.Status)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		public static bool UpdateClass(string oldId, ClassInfo item)
		{
			string sql = "UPDATE CLASS SET CLASSNAME = :CLASSNAME, DESCRIPTION = :DESCRIPTION, STATUS = :STATUS WHERE CLASSID = :OLDID";
			OracleParameter[] parameters =
			{
				new OracleParameter(":CLASSNAME", item.ClassName),
				new OracleParameter(":DESCRIPTION", (object)item.Description ?? DBNull.Value),
				new OracleParameter(":STATUS", item.Status),
				new OracleParameter(":OLDID", oldId)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		public static bool DeleteClass(string classId)
		{
			string sql = "UPDATE CLASS SET STATUS = :STATUS WHERE CLASSID = :CLASSID";
			OracleParameter[] parameters =
			{
				new OracleParameter(":STATUS", ClassInfo.INACTIVE),
				new OracleParameter(":CLASSID", classId)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		// =============================================
		// SCHOOL YEAR
		// =============================================
		public static ArrayList FillSchoolYear()
		{
			ArrayList list = new ArrayList();
			string sql = "SELECT SCHOOLYEARID, SCHOOLYEARNAME, START_YEAR, END_YEAR, STATUS FROM SCHOOL_YEAR WHERE STATUS = :STATUS ORDER BY START_YEAR DESC";
			OracleParameter[] parameters = { new OracleParameter(":STATUS", SchoolYear.ACTIVE) };

			DataTable dt = OracleHelper.ExecuteQuery(sql, parameters);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(new SchoolYear
				{
					SchoolYearId = row["SCHOOLYEARID"].ToString(),
					SchoolYearName = row["SCHOOLYEARNAME"].ToString(),
					StartYear = row["START_YEAR"] != DBNull.Value ? Convert.ToInt32(row["START_YEAR"]) : 0,
					EndYear = row["END_YEAR"] != DBNull.Value ? Convert.ToInt32(row["END_YEAR"]) : 0,
					Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : SchoolYear.ACTIVE
				});
			}
			return list;
		}

		public static bool InsertSchoolYear(SchoolYear item)
		{
			string sql = "INSERT INTO SCHOOL_YEAR (SCHOOLYEARID, SCHOOLYEARNAME, START_YEAR, END_YEAR, STATUS) VALUES (:SCHOOLYEARID, :SCHOOLYEARNAME, :START_YEAR, :END_YEAR, :STATUS)";
			OracleParameter[] parameters =
			{
				new OracleParameter(":SCHOOLYEARID", item.SchoolYearId),
				new OracleParameter(":SCHOOLYEARNAME", item.SchoolYearName),
				new OracleParameter(":START_YEAR", item.StartYear),
				new OracleParameter(":END_YEAR", item.EndYear),
				new OracleParameter(":STATUS", item.Status)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		public static bool UpdateSchoolYear(string oldId, SchoolYear item)
		{
			string sql = "UPDATE SCHOOL_YEAR SET SCHOOLYEARNAME = :SCHOOLYEARNAME, START_YEAR = :START_YEAR, END_YEAR = :END_YEAR, STATUS = :STATUS WHERE SCHOOLYEARID = :OLDID";
			OracleParameter[] parameters =
			{
				new OracleParameter(":SCHOOLYEARNAME", item.SchoolYearName),
				new OracleParameter(":START_YEAR", item.StartYear),
				new OracleParameter(":END_YEAR", item.EndYear),
				new OracleParameter(":STATUS", item.Status),
				new OracleParameter(":OLDID", oldId)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		public static bool DeleteSchoolYear(string schoolYearId)
		{
			string sql = "UPDATE SCHOOL_YEAR SET STATUS = :STATUS WHERE SCHOOLYEARID = :SCHOOLYEARID";
			OracleParameter[] parameters =
			{
				new OracleParameter(":STATUS", SchoolYear.INACTIVE),
				new OracleParameter(":SCHOOLYEARID", schoolYearId)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		// =============================================
		// SUBJECT
		// =============================================
		public static ArrayList FillSubject()
		{
			ArrayList list = new ArrayList();
			string sql = "SELECT SUBJECTID, SUBJECTNAME, CREDITS, DESCRIPTION, STATUS FROM SUBJECT WHERE STATUS = :STATUS ORDER BY SUBJECTID";
			OracleParameter[] parameters = { new OracleParameter(":STATUS", Subject.ACTIVE) };

			DataTable dt = OracleHelper.ExecuteQuery(sql, parameters);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(new Subject
				{
					SubjectId = row["SUBJECTID"].ToString(),
					SubjectName = row["SUBJECTNAME"].ToString(),
					Credits = row["CREDITS"] != DBNull.Value ? Convert.ToInt32(row["CREDITS"]) : 0,
					Description = row["DESCRIPTION"]?.ToString(),
					Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : Subject.ACTIVE
				});
			}
			return list;
		}

		public static bool InsertSubject(Subject item)
		{
			string sql = "INSERT INTO SUBJECT (SUBJECTID, SUBJECTNAME, CREDITS, DESCRIPTION, STATUS) VALUES (:SUBJECTID, :SUBJECTNAME, :CREDITS, :DESCRIPTION, :STATUS)";
			OracleParameter[] parameters =
			{
				new OracleParameter(":SUBJECTID", item.SubjectId),
				new OracleParameter(":SUBJECTNAME", item.SubjectName),
				new OracleParameter(":CREDITS", item.Credits),
				new OracleParameter(":DESCRIPTION", (object)item.Description ?? DBNull.Value),
				new OracleParameter(":STATUS", item.Status)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		public static bool UpdateSubject(string oldId, Subject item)
		{
			string sql = "UPDATE SUBJECT SET SUBJECTNAME = :SUBJECTNAME, CREDITS = :CREDITS, DESCRIPTION = :DESCRIPTION, STATUS = :STATUS WHERE SUBJECTID = :OLDID";
			OracleParameter[] parameters =
			{
				new OracleParameter(":SUBJECTNAME", item.SubjectName),
				new OracleParameter(":CREDITS", item.Credits),
				new OracleParameter(":DESCRIPTION", (object)item.Description ?? DBNull.Value),
				new OracleParameter(":STATUS", item.Status),
				new OracleParameter(":OLDID", oldId)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		public static bool DeleteSubject(string subjectId)
		{
			string sql = "UPDATE SUBJECT SET STATUS = :STATUS WHERE SUBJECTID = :SUBJECTID";
			OracleParameter[] parameters =
			{
				new OracleParameter(":STATUS", Subject.INACTIVE),
				new OracleParameter(":SUBJECTID", subjectId)
			};
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}

		// =============================================
		// STUDENT ACADEMIC
		// =============================================

		public static ArrayList FillStudentAcademic(string studentId)
		{
			ArrayList list = new ArrayList();
			string sql = @"
                SELECT 
                    sa.ACADEMICID, sa.STUDENTID,
                    sa.CLASSID,      c.CLASSNAME,
                    sa.SCHOOLYEARID, sy.SCHOOLYEARNAME,
                    sa.SUBJECTID,    sub.SUBJECTNAME,
                    sa.SCORE, sa.SCORE_LETTER, sa.SEMESTER, sa.NOTE, sa.STATUS
                FROM STUDENT_ACADEMIC sa
                LEFT JOIN CLASS       c   ON sa.CLASSID      = c.CLASSID
                LEFT JOIN SCHOOL_YEAR sy  ON sa.SCHOOLYEARID = sy.SCHOOLYEARID
                LEFT JOIN SUBJECT     sub ON sa.SUBJECTID    = sub.SUBJECTID
                WHERE sa.STUDENTID = :STUDENTID AND sa.STATUS = :STATUS
                ORDER BY sa.ACADEMICID";

			OracleParameter[] parameters =
			{
			 new OracleParameter(":STUDENTID", studentId),
			 new OracleParameter(":STATUS", StudentAcademic.ACTIVE)
		  };

			DataTable dt = OracleHelper.ExecuteQuery(sql, parameters);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(new StudentAcademic
				{
					AcademicId = row["ACADEMICID"] != DBNull.Value ? Convert.ToInt64(row["ACADEMICID"]) : 0,
					StudentId = row["STUDENTID"].ToString(),
					ClassId = row["CLASSID"]?.ToString(),
					ClassName = row["CLASSNAME"]?.ToString(),
					SchoolYearId = row["SCHOOLYEARID"]?.ToString(),
					SchoolYearName = row["SCHOOLYEARNAME"]?.ToString(),
					SubjectId = row["SUBJECTID"]?.ToString(),
					SubjectName = row["SUBJECTNAME"]?.ToString(),
					Score = row["SCORE"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["SCORE"]) : null,
					ScoreLetter = row["SCORE_LETTER"]?.ToString(),
					Semester = row["SEMESTER"] != DBNull.Value ? Convert.ToInt32(row["SEMESTER"]) : 0,
					Note = row["NOTE"]?.ToString(),
					Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : StudentAcademic.ACTIVE
				});
			}
			return list;
		}

		public static bool InsertStudentAcademic(StudentAcademic academic)
		{
			try
			{
				string sql = @"INSERT INTO STUDENT_ACADEMIC 
					(STUDENTID, CLASSID, SCHOOLYEARID, SUBJECTID, SCORE, SCORE_LETTER, SEMESTER, NOTE, STATUS)
					VALUES (:STUDENTID, :CLASSID, :SCHOOLYEARID, :SUBJECTID, :SCORE, :SCORE_LETTER, :SEMESTER, :NOTE, :STATUS)";

				OracleParameter[] parameters =
				{
					new OracleParameter(":STUDENTID",    academic.StudentId),
					new OracleParameter(":CLASSID",      (object)academic.ClassId ?? DBNull.Value),
					new OracleParameter(":SCHOOLYEARID", (object)academic.SchoolYearId ?? DBNull.Value),
					new OracleParameter(":SUBJECTID",    (object)academic.SubjectId ?? DBNull.Value),
					new OracleParameter(":SCORE",        academic.Score.HasValue ? (object)academic.Score.Value : DBNull.Value),
					new OracleParameter(":SCORE_LETTER", (object)academic.ScoreLetter ?? DBNull.Value),
					new OracleParameter(":SEMESTER",     academic.Semester > 0 ? (object)academic.Semester : DBNull.Value),
					new OracleParameter(":NOTE",         (object)academic.Note ?? DBNull.Value),
					new OracleParameter(":STATUS",       StudentAcademic.ACTIVE)
				};

				return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
			}
			catch (OracleException ex)
			{
				if (ex.Number == 2291)
				{
					System.Windows.Forms.MessageBox.Show(
						string.Format("Lỗi ràng buộc khóa ngoại (ORA-02291):\nMã sinh viên ({0}), lớp, năm học hoặc môn học chưa tồn tại trong CSDL.\nVui lòng lưu hồ sơ sinh viên trước khi thêm thông tin học tập.", academic.StudentId),
						"Lỗi ràng buộc dữ liệu", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show("Lỗi Oracle: " + ex.Message, "Lỗi CSDL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}
				return false;
			}
		}

		public static bool UpdateStudentAcademic(StudentAcademic academic)
		{
			try
			{
				string sql = @"UPDATE STUDENT_ACADEMIC SET
					CLASSID      = :CLASSID,
					SCHOOLYEARID = :SCHOOLYEARID,
					SUBJECTID    = :SUBJECTID,
					SCORE        = :SCORE,
					SCORE_LETTER = :SCORE_LETTER,
					SEMESTER     = :SEMESTER,
					NOTE         = :NOTE
					WHERE ACADEMICID = :ACADEMICID";

				OracleParameter[] parameters =
				{
					new OracleParameter(":CLASSID",      (object)academic.ClassId ?? DBNull.Value),
					new OracleParameter(":SCHOOLYEARID", (object)academic.SchoolYearId ?? DBNull.Value),
					new OracleParameter(":SUBJECTID",    (object)academic.SubjectId ?? DBNull.Value),
					new OracleParameter(":SCORE",        academic.Score.HasValue ? (object)academic.Score.Value : DBNull.Value),
					new OracleParameter(":SCORE_LETTER", (object)academic.ScoreLetter ?? DBNull.Value),
					new OracleParameter(":SEMESTER",     academic.Semester > 0 ? (object)academic.Semester : DBNull.Value),
					new OracleParameter(":NOTE",         (object)academic.Note ?? DBNull.Value),
					new OracleParameter(":ACADEMICID",   academic.AcademicId)
				};

				return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
			}
			catch (OracleException ex)
			{
				if (ex.Number == 2291)
				{
					System.Windows.Forms.MessageBox.Show(
						string.Format("Lỗi ràng buộc khóa ngoại (ORA-02291):\nMã sinh viên ({0}), lớp, năm học hoặc môn học không hợp lệ trong CSDL.", academic.StudentId),
						"Lỗi ràng buộc dữ liệu", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show("Lỗi Oracle: " + ex.Message, "Lỗi CSDL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}
				return false;
			}
		}

		public static bool DeleteStudentAcademic(long academicId)
		{
			string sql = "UPDATE STUDENT_ACADEMIC SET STATUS = :STATUS WHERE ACADEMICID = :ACADEMICID";
			OracleParameter[] parameters =
			{
			 new OracleParameter(":STATUS",     StudentAcademic.INACTIVE),
			 new OracleParameter(":ACADEMICID", academicId)
		  };
			return OracleHelper.ExecuteNonQuery(sql, parameters) > 0;
		}
	}
}
