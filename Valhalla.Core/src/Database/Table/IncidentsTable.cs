using Valhalla.Database.Driver.SQLite;

namespace Valhalla.Database.Table
{
    /// <summary>
    /// Represents the incidents table in the application database.
    /// </summary>
    public class IncidentsTable : SqliteTable
    {
        public IncidentsTable()
        {
            // Set table name
            name = "incidents";

            // Define table fields
            DefineFields();
        }

        /// <summary>
        /// Defines the structure and properties for the fields of the table.
        /// </summary>
        private void DefineFields()
        {
            fields.Add(new SqliteField(
                "id",                               // Field name
                SqliteField.FieldType.INTEGER,      // Data type
                true,                               // Not nullable?
                true,                               // Primary key?
                true                                // Auto-increment?
            ));

            fields.Add(new SqliteField(
                "name",                             // Field name
                SqliteField.FieldType.TEXT          // Data type
            ));

            fields.Add(new SqliteField(
                "description",                      // Field name
                SqliteField.FieldType.TEXT          // Data type
            ));

            fields.Add(new SqliteField(
                "start_time",                       // Field name
                SqliteField.FieldType.TEXT          // Data type
            ));

            fields.Add(new SqliteField(
                "end_time",                         // Field name
                SqliteField.FieldType.TEXT          // Data type
            ));

            fields.Add(new SqliteField(
                "cdo_id",                           // Field name
                SqliteField.FieldType.INTEGER       // Data type
            ));
        }
    }
}
