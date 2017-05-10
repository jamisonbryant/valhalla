namespace Valhalla.Database.Driver.SQLite
{
    /// <summary>
    /// Represents a field in an SQLite table.
    /// </summary>
    public class SqliteField
    {
        ////////////////////////////////////////////////////////////////////////
        // ENUMS
        ////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// List of valid field types
        /// </summary>
        public enum FieldType { INTEGER, TEXT, BLOB, REAL, NUMERIC }

        ////////////////////////////////////////////////////////////////////////
        // FIELDS
        ////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Field name
        /// </summary>
        private string name;

        /// <summary>
        /// Field data type
        /// </summary>
        private FieldType type;

        /// <summary>
        /// Can the field be null?
        /// </summary>
        private bool isNotNull;

        /// <summary>
        /// Does the field define a primary key?
        /// </summary>
        private bool isPrimaryKey;

        /// <summary>
        /// Does the field auto-increment?
        /// </summary>
        private bool isAutoIncrement;

        /// <summary>
        /// Is the field value required to be unique?
        /// </summary>
        private bool isUnique;

        /// <summary>
        /// Default value of the field
        /// </summary>
        private object defaultValue;

        ////////////////////////////////////////////////////////////////////////
        // CONSTRUCTORS
        ////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Class constructor
        /// </summary>
        public SqliteField(string name, FieldType type, bool isNotNull = true,
            bool isPrimaryKey = false, bool isAutoIncrement = false,
            bool isUnique = false, object defaultValue = null)
        {
            this.name = name;
            this.type = type;
            this.isNotNull = isNotNull;
            this.isPrimaryKey = isPrimaryKey;
            this.isAutoIncrement = isAutoIncrement;
            this.isUnique = isUnique;
            this.defaultValue = defaultValue;
        }

        /// <summary>
        /// Generates the SQL string for the field definition.
        /// </summary>
        /// <returns>SQL string</returns>
        public string ToSqlString()
        {
            // Identify string representation of field type from field
            // type class property (too bad we can't convert an enum entry
            // directly to a string...)
            string fieldType = "";

            switch (type) {
                case FieldType.BLOB:
                    fieldType = "BLOB";
                    break;

                case FieldType.INTEGER:
                    fieldType = "INTEGER";
                    break;

                case FieldType.NUMERIC:
                    fieldType = "NUMERIC";
                    break;

                case FieldType.REAL:
                    fieldType = "REAL";
                    break;

                case FieldType.TEXT:
                    fieldType = "TEXT";
                    break;
            }

            // If the default field value is a string, it must be surrounded by
            // quotes in the SQL string in order to avoid a syntax error.
            if (defaultValue != null) {
                if (defaultValue is string) {
                    defaultValue = "'" + defaultValue + "'";
                }
            }

            /// Return the formatted string
            return string.Format("`{0}` {1} {2} {3} {4} {5} {6}",
                name,
                fieldType,
                (isNotNull ? "NOT NULL" : ""),
                (isPrimaryKey ? "PRIMARY KEY" : ""),
                (isAutoIncrement ? "AUTOINCREMENT" : ""),
                (isUnique ? "UNIQUE" : ""),
                (defaultValue != null ? "DEFAULT " + defaultValue : "")
            );
        }
    }
}