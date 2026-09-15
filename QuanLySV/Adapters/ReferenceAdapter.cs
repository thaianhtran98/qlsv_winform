using System;
using System.Collections;
using System.Data;
using QuanLySV.Models;
using QuanLySV.Services;

namespace QuanLySV.Adapters
{
	public class ReferenceAdapter
	{
		// =============================================
		// LỚP HỌC (CLASS)
		// =============================================
		public void FillClass(DataTable table)
		{
			table.Rows.Clear();
			ArrayList list = AcademicService.FillClass();
			foreach (ClassInfo item in list)
			{
				DataRow row = table.NewRow();
				row["CLASSID"] = item.ClassId ?? "";
				row["CLASSNAME"] = item.ClassName ?? "";
				row["DESCRIPTION"] = item.Description ?? "";
				row["STATUS"] = item.Status;
				table.Rows.Add(row);
			}
			table.AcceptChanges();
		}

		// =============================================
		// NĂM HỌC (SCHOOL_YEAR)
		// =============================================
		public void FillSchoolYear(DataTable table)
		{
			table.Rows.Clear();
			ArrayList list = AcademicService.FillSchoolYear();
			foreach (SchoolYear item in list)
			{
				DataRow row = table.NewRow();
				row["SCHOOLYEARID"] = item.SchoolYearId ?? "";
				row["SCHOOLYEARNAME"] = item.SchoolYearName ?? "";
				row["START_YEAR"] = item.StartYear;
				row["END_YEAR"] = item.EndYear;
				row["STATUS"] = item.Status;
				table.Rows.Add(row);
			}
			table.AcceptChanges();
		}

		// =============================================
		// MÔN HỌC (SUBJECT)
		// =============================================
		public void FillSubject(DataTable table)
		{
			table.Rows.Clear();
			ArrayList list = AcademicService.FillSubject();
			foreach (Subject item in list)
			{
				DataRow row = table.NewRow();
				row["SUBJECTID"] = item.SubjectId ?? "";
				row["SUBJECTNAME"] = item.SubjectName ?? "";
				row["CREDIT"] = item.Credits;
				row["DESCRIPTION"] = item.Description ?? "";
				row["STATUS"] = item.Status;
				table.Rows.Add(row);
			}
			table.AcceptChanges();
		}

		// =============================================
		// LƯU VÀ XÓA (CLASS, SCHOOL_YEAR, SUBJECT)
		// =============================================
		public bool SaveClass(ClassInfo item, bool isNew, string oldId = null)
		{
			if (isNew) return AcademicService.InsertClass(item);
			return AcademicService.UpdateClass(oldId ?? item.ClassId, item);
		}

		public bool DeleteClass(string classId)
		{
			return AcademicService.DeleteClass(classId);
		}

		public bool SaveSchoolYear(SchoolYear item, bool isNew, string oldId = null)
		{
			if (isNew) return AcademicService.InsertSchoolYear(item);
			return AcademicService.UpdateSchoolYear(oldId ?? item.SchoolYearId, item);
		}

		public bool DeleteSchoolYear(string schoolYearId)
		{
			return AcademicService.DeleteSchoolYear(schoolYearId);
		}

		public bool SaveSubject(Subject item, bool isNew, string oldId = null)
		{
			if (isNew)
				return AcademicService.InsertSubject(item);
			return AcademicService.UpdateSubject(oldId ?? item.SubjectId, item);
		}

		public bool DeleteSubject(string subjectId)
		{
			return AcademicService.DeleteSubject(subjectId);
		}
	}
}
