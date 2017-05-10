using System.Collections.Generic;
using System.Linq;

namespace Valhalla.Database.Driver.SQLite
{
    /// <summary>
    /// Represents a table in an SQLite database.
    /// </summary>
    public abstract class SqliteTable
    {
        /// <summary>
        /// Table name
        /// </summary>
        protected string name;

        /// <summary>
        /// List of table  fields
        /// </summary>
        protected List<SqliteField> fields = new List<SqliteField>();

        /// <summary>
        /// Returns the table sqlinition as a SQL statement
        /// </summary>
        /// <returns>SQL sqlinition of the table</returns>
        public string ToSqlString()
        {
            string sql = "";

            if (!string.IsNullOrEmpty(name)) {
                sql = string.Format("CREATE TABLE `{0}` ", name);

                // Add fields to table definition, if any
                if (fields.Count() != 0) {
                    List<string> fieldSql = new List<string>();

                    foreach (var field in fields) {
                        fieldSql.Add(field.ToSqlString().TrimEnd());
                    }

                    sql += string.Format("({0});", string.Join(", ", fieldSql));
                }
            }

            return sql;
        }
    }
}
