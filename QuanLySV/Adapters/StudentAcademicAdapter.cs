using System;
using System.Collections;
using System.Data;
using QuanLySV.Models;
using QuanLySV.Services;

namespace QuanLySV.Adapters
{
	public class StudentAcademicAdapter
	{
		// =============================================
		// DB ──► DataTable (Fill)
		// =============================================
		public void FillStudentAcademic(DataTable table, string studentId = null)
		{
			table.Rows.Clear();
			ArrayList list = AcademicService.FillStudentAcademic(studentId);
			DataRow row = null;
			foreach (StudentAcademic item in list)
			{
				row = table.NewRow();
				row["ACADEMICID"] = item.AcademicId.ToString();
				row["STUDENTID"] = item.StudentId ?? string.Empty;
				row["CLASSID"] = item.ClassId ?? string.Empty;
				row["CLASSNAME"] = item.ClassName ?? string.Empty;
				row["SCHOOLYEARID"] = item.SchoolYearId ?? string.Empty;
				row["SCHOOLYEARNAME"] = item.SchoolYearName ?? string.Empty;
				row["SUBJECTID"] = item.SubjectId ?? string.Empty;
				row["SUBJECTNAME"] = item.SubjectName ?? string.Empty;
				row["SCORE"] = item.Score.HasValue ? item.Score.Value.ToString() : string.Empty;
				row["SCORE_LETTER"] = item.ScoreLetter ?? string.Empty;
				row["SEMESTER"] = item.Semester.ToString();
				row["NOTE"] = item.Note ?? string.Empty;
				row["STATUS"] = item.Status.ToString();

				table.Rows.Add(row);
			}
			table.AcceptChanges();
		}

		public static StudentAcademic MapRowToStudentAcademic(DataRow row)
		{
			if (row == null)
			{
				return null;
			}

			decimal? scoreValue = null;
			object scoreObj = row["SCORE"];
			if (scoreObj != DBNull.Value && scoreObj != null)
			{
				string scoreStr = scoreObj.ToString();
				decimal tmpScore = 0;
				if (!string.IsNullOrWhiteSpace(scoreStr) && decimal.TryParse(scoreStr, out tmpScore))
				{
					scoreValue = tmpScore;
				}
			}

			long aid = 0;
			long.TryParse(row["ACADEMICID"]?.ToString(), out aid);

			return new StudentAcademic
			{
				AcademicId = aid,
				StudentId = row["STUDENTID"]?.ToString(),
				ClassId = row["CLASSID"]?.ToString(),
				ClassName = row["CLASSNAME"]?.ToString(),
				SchoolYearId = row["SCHOOLYEARID"]?.ToString(),
				SchoolYearName = row["SCHOOLYEARNAME"]?.ToString(),
				SubjectId = row["SUBJECTID"]?.ToString(),
				SubjectName = row["SUBJECTNAME"]?.ToString(),
				Semester = row["SEMESTER"] != DBNull.Value ? Convert.ToInt32(row["SEMESTER"]) : 0,
				Score = scoreValue,
				ScoreLetter = row["SCORE_LETTER"]?.ToString(),
				Note = row["NOTE"]?.ToString(),
				Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : 0
			};
		}
	}
}
