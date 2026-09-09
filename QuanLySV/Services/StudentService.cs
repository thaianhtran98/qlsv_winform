using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using QuanLySV.Helpers;
using QuanLySV.Models;
using System.Data;
using System.Collections;

namespace QuanLySV.Services
{
	public class StudentService
	{
		public static ArrayList FillStudent(int status = -1, int sex = -1)
		{
			ArrayList students = new ArrayList();
			string sql = "SELECT STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, " +
				"DATEOFISSUE, LOCALOFISSUE, LOCAL, PLACEOFRESIDENCE, NUMBERPHONE, STATUS " +
				"FROM STUDENT ";

			ArrayList conditions = new ArrayList();
			ArrayList parameters = new ArrayList();

			if (status != -1)
			{
				conditions.Add("STATUS = :STATUS");
				parameters.Add(new OracleParameter(":STATUS", status));
			}

			if (sex != -1)
			{
				conditions.Add("SEX = :SEX");
				parameters.Add(new OracleParameter(":SEX", sex));
			}

			if (conditions.Count > 0)
			{
				sql += "WHERE " + string.Join(" AND ", conditions.ToArray()) + " ";
			}

			sql += "ORDER BY STUDENTID";

			OracleParameter[] paramArray = parameters.Count > 0
				? (OracleParameter[])parameters.ToArray(typeof(OracleParameter))
				: null;

			DataTable dt = OracleHelper.ExecuteQuery(sql, paramArray);

			if (dt.Rows.Count > 0)
			{
				Student student = null;
				foreach (DataRow row in dt.Rows)
				{
					student = new Student
					{
						StudentId = row["STUDENTID"].ToString(),
						Name = row["NAME"]?.ToString(),
						Sex = row["SEX"] != DBNull.Value ? Convert.ToInt32(row["SEX"]) : Student.FEMALE,
						BirthOfDate = row["BIRTHOFDATE"] != DBNull.Value ? Convert.ToDateTime(row["BIRTHOFDATE"]) : DateTime.Now,
						BirthLocal = row["BIRTHLOCAL"]?.ToString(),
						VneId = row["VNEID"]?.ToString(),
						DateOfIssue = row["DATEOFISSUE"] != DBNull.Value ? Convert.ToDateTime(row["DATEOFISSUE"]) : DateTime.Now,
						LocalOfIssue = row["LOCALOFISSUE"]?.ToString(),
						Local = row["LOCAL"]?.ToString(),
						PlaceOfResidence = row["PLACEOFRESIDENCE"]?.ToString(),
						NumberPhone = row["NUMBERPHONE"]?.ToString(),
						Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : Student.ACTIVE
					};

					students.Add(student);
				}
			}

			return students;
		}

		public static Student GetStudentByStudentId(string studentId)
		{
			Student student = null;
			string sql = "SELECT STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, " +
				"DATEOFISSUE, LOCALOFISSUE, LOCAL, PLACEOFRESIDENCE, NUMBERPHONE, STATUS " +
				"FROM STUDENT WHERE STUDENTID = :STUDENTID AND STATUS = :STATUS";

			OracleParameter[] parameters = new OracleParameter[]
			{
				new OracleParameter(":STUDENTID", studentId),
				new OracleParameter(":STATUS", Student.ACTIVE)
               };

			DataTable dt = OracleHelper.ExecuteQuery(sql, parameters);
			if (dt.Rows.Count > 0)
			{
				DataRow row = dt.Rows[0];
				// Map
				student = new Student
				{
					StudentId = row["STUDENTID"].ToString(),
					Name = row["NAME"]?.ToString(),
					Sex = row["SEX"] != DBNull.Value ? Convert.ToInt32(row["SEX"]) : Student.FEMALE,
					BirthOfDate = row["BIRTHOFDATE"] != DBNull.Value ? Convert.ToDateTime(row["BIRTHOFDATE"]) : DateTime.Now,
					BirthLocal = row["BIRTHLOCAL"]?.ToString(),
					VneId = row["VNEID"]?.ToString(),
					DateOfIssue = row["DATEOFISSUE"] != DBNull.Value ? Convert.ToDateTime(row["DATEOFISSUE"]) : DateTime.Now,
					LocalOfIssue = row["LOCALOFISSUE"]?.ToString(),
					Local = row["LOCAL"]?.ToString(),
					PlaceOfResidence = row["PLACEOFRESIDENCE"]?.ToString(),
					NumberPhone = row["NUMBERPHONE"]?.ToString(),
					Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : Student.ACTIVE
				};
			}

			return student;
		}

		public static bool InsertStudent(Student student)
		{
			string sql = "INSERT INTO STUDENT (STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, DATEOFISSUE, LOCALOFISSUE, LOCAL, PLACEOFRESIDENCE, NUMBERPHONE, STATUS) " +
				  "VALUES (:STUDENTID, :NAME, :SEX, :BIRTHOFDATE, :BIRTHLOCAL, :VNEID, :DATEOFISSUE, :LOCALOFISSUE, :LOCAL, :PLACEOFRESIDENCE, :NUMBERPHONE, :STATUS)";

			OracleParameter[] parameters = new OracleParameter[]
			{
			    new OracleParameter(":STUDENTID", student.StudentId),
			    new OracleParameter(":NAME", student.Name),
			    new OracleParameter(":SEX", student.Sex),
			    new OracleParameter(":BIRTHOFDATE", student.BirthOfDate),
			    new OracleParameter(":BIRTHLOCAL", student.BirthLocal),
			    new OracleParameter(":VNEID", student.VneId),
			    new OracleParameter(":DATEOFISSUE", student.DateOfIssue),
			    new OracleParameter(":LOCALOFISSUE", student.LocalOfIssue),
			    new OracleParameter(":LOCAL", student.Local),
			    new OracleParameter(":PLACEOFRESIDENCE", student.PlaceOfResidence),
			    new OracleParameter(":NUMBERPHONE", student.NumberPhone),
			    new OracleParameter(":STATUS", student.Status)
			};
			
			int result = OracleHelper.ExecuteNonQuery(sql, parameters);
			return result > 0;
		}

		public static bool UpdateStudent(string studentId, Student student)
		{
			string sql = "UPDATE STUDENT SET " +
				"STUDENTID = :STUDENTID, " +
				"NAME = :NAME, " +
				"SEX = :SEX, " +
				"BIRTHOFDATE = :BIRTHOFDATE, " +
				"BIRTHLOCAL = :BIRTHLOCAL, " +
				"VNEID = :VNEID, " +
				"DATEOFISSUE = :DATEOFISSUE, " +
				"LOCALOFISSUE = :LOCALOFISSUE, " +
				"LOCAL = :LOCAL, " +
				"PLACEOFRESIDENCE = :PLACEOFRESIDENCE, " +
				"NUMBERPHONE = :NUMBERPHONE, " +
				"STATUS = :STATUS " +
				"WHERE STUDENTID = :STUDENTID_OLD";

			OracleParameter[] parameters = new OracleParameter[]
			{
			    new OracleParameter(":STUDENTID", student.StudentId),
			    new OracleParameter(":NAME", student.Name),
			    new OracleParameter(":SEX", student.Sex),
			    new OracleParameter(":BIRTHOFDATE", student.BirthOfDate),
			    new OracleParameter(":BIRTHLOCAL", student.BirthLocal),
			    new OracleParameter(":VNEID", student.VneId),
			    new OracleParameter(":DATEOFISSUE", student.DateOfIssue),
			    new OracleParameter(":LOCALOFISSUE", student.LocalOfIssue),
			    new OracleParameter(":LOCAL", student.Local),
			    new OracleParameter(":PLACEOFRESIDENCE", student.PlaceOfResidence),
			    new OracleParameter(":NUMBERPHONE", student.NumberPhone),
			    new OracleParameter(":STUDENTID_OLD", studentId),
			    new OracleParameter(":STATUS", student.Status)
			};

			int result = OracleHelper.ExecuteNonQuery(sql, parameters);
			return result > 0;
		}

		public static bool DeleteStudent(string studentId)
		{
			string sql = "UPDATE STUDENT SET STATUS = :STATUS WHERE STUDENTID = :STUDENTID";
			OracleParameter[] parameters = new OracleParameter[]
			{
			    new OracleParameter(":STATUS", Student.INACTIVE),
			    new OracleParameter(":STUDENTID", studentId)
			};
			int result = OracleHelper.ExecuteNonQuery(sql, parameters);
			return result > 0;
		}
	}
}
