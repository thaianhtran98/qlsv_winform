using System;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace QuanLySV.Helpers
{
	public static class OracleHelper
	{
		private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
		
		public static DataTable ExecuteQuery(string query, OracleParameter[] parameters = null)
		{
			DataTable dataTable = new DataTable();

			using (OracleConnection conn = new OracleConnection(ConnectionString))
			{
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					cmd.BindByName = true;

					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
					{
						conn.Open();
						adapter.Fill(dataTable);
					}
				}
			}

			return dataTable;
		}

		public static int ExecuteNonQuery(string query, OracleParameter[] parameters = null)
		{
			using (OracleConnection conn = new OracleConnection(ConnectionString))
			{
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					cmd.BindByName = true;

					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					conn.Open();
					return cmd.ExecuteNonQuery();
				}
			}
		}

		public static object ExecuteScalar(string query, OracleParameter[] parameters = null)
		{
			using (OracleConnection conn = new OracleConnection(ConnectionString))
			{
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					cmd.BindByName = true;

					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					conn.Open();
					return cmd.ExecuteScalar();
				}
			}
		}
	}
}
