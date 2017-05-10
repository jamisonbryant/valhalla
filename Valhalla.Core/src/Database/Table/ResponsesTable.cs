using Valhalla.Database.Driver.SQLite;

namespace Valhalla.Database.Table
{
    /// <summary>
    /// Represents the responses table in the application database.
    /// </summary>
    public class ResponsesTable : SqliteTable
    {
        public ResponsesTable()
        {
            // Set table name
            name = "responses";

            // Define table fields
            DefineFields();
        }

        /// <summary>
        /// Defines the structure and properties for the fields of the table.
        /// </summary>
        private void DefineFields()
        {
            fields.Add(new SqliteField(
                "id",                                   // Field name
                SqliteField.FieldType.INTEGER,          // Data type
                true,                                   // Not nullable?
                true,                                   // Primary key?
                true                                    // Auto-increment?
            ));

            fields.Add(new SqliteField(
                "response_text",                        // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "receive_time",                         // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "eta",                                  // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            //fields.Add(new SqliteField(
            //    "is_dcdo",                              // Field name
            //    SqliteField.FieldType.INTEGER           // Data type
            //));

            fields.Add(new SqliteField(
                "is_first_on_scene",                    // Field name
                SqliteField.FieldType.INTEGER           // Data type
            ));

            fields.Add(new SqliteField(
                "volunteer_id",                         // Field name
                SqliteField.FieldType.INTEGER           // Data type
            ));

            fields.Add(new SqliteField(
                "incident_id",                          // Field name
                SqliteField.FieldType.INTEGER           // Data type
            ));
        }
    }
}
