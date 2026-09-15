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
			foreach (StudentAcademic item in list)
			{
				DataRow row = table.NewRow();
				row["ACADEMICID"] = item.AcademicId.ToString() ?? "";
				row["STUDENTID"] = item.StudentId ?? "";
				row["CLASSID"] = item.ClassId ?? "";
				row["CLASSNAME"] = item.ClassName ?? "";
				row["SCHOOLYEARID"] = item.SchoolYearId ?? "";
				row["SCHOOLYEARNAME"] = item.SchoolYearName ?? "";
				row["SUBJECTID"] = item.SubjectId ?? "";
				row["SUBJECTNAME"] = item.SubjectName ?? "";
				row["SCORE"] = item.Score?.ToString() ?? "";
				row["SCORE_LETTER"] = item.ScoreLetter ?? "";
				row["SEMESTER"] = item.Semester.ToString() ?? "";
				row["NOTE"] = item.Note ?? "";
				row["STATUS"] = item.Status.ToString() ?? "";

				table.Rows.Add(row);
			}
			table.AcceptChanges();
		}

	}
}
