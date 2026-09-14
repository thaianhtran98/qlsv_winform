using System;
using System.Collections;
using System.Data;
using QuanLySV.Models;
using QuanLySV.Services;

namespace QuanLySV.Adapters
{
	public class StudentAdapter
	{
		// =============================================
		// DB ──► DataTable (Fill)
		// =============================================

		public void Fill(DataTable table, int status = -1, int sex = -1)
		{
			table.Rows.Clear();

			ArrayList students = StudentService.FillStudent(status, sex);
			foreach (Student s in students)
			{
				DataRow row = table.NewRow();
				MapStudentToRow(s, row);
				table.Rows.Add(row);
			}

			// Đánh dấu tất cả row là Unchanged (không phải Added)
			table.AcceptChanges();
		}

		// =============================================
		// DataTable ──► DB (SaveChanges)
		// =============================================

		public SaveResult SaveChanges(DataTable changes)
		{
			SaveResult result = new SaveResult();
			if (changes == null || changes.Rows.Count == 0) return result;

			foreach (DataRow row in changes.Rows)
			{
				try
				{
					switch (row.RowState)
					{
						case DataRowState.Added:
							Student newSv = MapRowToStudent(row);
							string addErr;
							bool added = StudentService.InsertStudent(newSv, out addErr);
							if (added) result.Success++;
							else { result.Failed++; result.Errors.Add("Thêm mới " + row["STUDENTID"] + " thất bại: " + addErr); }
							break;

						case DataRowState.Modified:
							// Lấy STUDENTID gốc (trước khi đổi) để WHERE clause đúng
							string oldId = row["STUDENTID", DataRowVersion.Original].ToString();
							Student updSv = MapRowToStudent(row);
							string updErr;
							bool updated = StudentService.UpdateStudent(oldId, updSv, out updErr);
							if (updated) result.Success++;
							else { result.Failed++; result.Errors.Add("Cập nhật " + row["STUDENTID"] + " thất bại: " + updErr); }
							break;

						case DataRowState.Deleted:
							string delId = row["STUDENTID", DataRowVersion.Original].ToString();
							bool deleted = StudentService.DeleteStudent(delId);
							if (deleted) result.Success++;
							else { result.Failed++; result.Errors.Add("Xóa " + delId + " thất bại"); }
							break;
					}
				}
				catch (Exception ex)
				{
					result.Failed++;
					result.Errors.Add(ex.Message);
				}
			}
			return result;
		}

		public bool SaveStudent(DataRow row, bool isNew, string oldId, out string errorMessage)
		{
			errorMessage = null;
			if (row == null)
			{
				errorMessage = "Không có dữ liệu sinh viên cần lưu.";
				return false;
			}

			Student student = MapRowToStudent(row);

			if (isNew)
			{
				bool added = StudentService.InsertStudent(student, out errorMessage);
				if (added)
				{
					row.AcceptChanges();
					return true;
				}
				return false;
			}
			else
			{
				if (row.RowState == DataRowState.Unchanged)
				{
					return true;
				}

				string originalId = !string.IsNullOrWhiteSpace(oldId) ? oldId : row["STUDENTID", DataRowVersion.Original].ToString();
				bool updated = StudentService.UpdateStudent(originalId, student, out errorMessage);
				if (updated)
				{
					row.AcceptChanges();
					return true;
				}
				return false;
			}
		}

		// =============================================
		// Helper: Map Student ↔ DataRow
		// =============================================

		public void MapStudentToRow(Student s, DataRow row)
		{
			row["STUDENTID"] = s.StudentId ?? "";
			row["NAME"] = (object)s.Name ?? DBNull.Value;
			row["SEX"] = s.Sex;
			row["BIRTHOFDATE"] = s.BirthOfDate;
			row["BIRTHLOCAL"] = (object)s.BirthLocal ?? DBNull.Value;
			row["VNEID"] = (object)s.VneId ?? DBNull.Value;
			row["DATEOFISSUE"] = s.DateOfIssue;
			row["LOCALOFISSUE"] = (object)s.LocalOfIssue ?? DBNull.Value;
			row["LOCAL"] = (object)s.Local ?? DBNull.Value;
			row["PLACEOFRESIDENCE"] = (object)s.PlaceOfResidence ?? DBNull.Value;
			row["NUMBERPHONE"] = (object)s.NumberPhone ?? DBNull.Value;
			row["STATUS"] = s.Status;
		}

		public static Student MapRowToStudent(DataRow row)
		{
			string phone = row["NUMBERPHONE"] != DBNull.Value ? row["NUMBERPHONE"].ToString() : null;
			if (!string.IsNullOrEmpty(phone))
			{
				string digitsOnly = phone.Replace("-", "").Trim();
				if (digitsOnly.Length == 0) phone = null;
			}

			return new Student
			{
				StudentId = row["STUDENTID"]?.ToString()?.Trim(),
				Name = row["NAME"] != DBNull.Value ? row["NAME"].ToString()?.Trim() : null,
				Sex = row["SEX"] != DBNull.Value ? Convert.ToInt32(row["SEX"]) : Student.FEMALE,
				BirthOfDate = row["BIRTHOFDATE"] != DBNull.Value ? Convert.ToDateTime(row["BIRTHOFDATE"]) : DateTime.Now,
				BirthLocal = row["BIRTHLOCAL"] != DBNull.Value ? row["BIRTHLOCAL"].ToString()?.Trim() : null,
				VneId = row["VNEID"] != DBNull.Value ? row["VNEID"].ToString()?.Trim() : null,
				DateOfIssue = row["DATEOFISSUE"] != DBNull.Value ? Convert.ToDateTime(row["DATEOFISSUE"]) : DateTime.Now,
				LocalOfIssue = row["LOCALOFISSUE"] != DBNull.Value ? row["LOCALOFISSUE"].ToString()?.Trim() : null,
				Local = row["LOCAL"] != DBNull.Value ? row["LOCAL"].ToString()?.Trim() : null,
				PlaceOfResidence = row["PLACEOFRESIDENCE"] != DBNull.Value ? row["PLACEOFRESIDENCE"].ToString()?.Trim() : null,
				NumberPhone = phone,
				Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : Student.ACTIVE
			};
		}
	}
}
