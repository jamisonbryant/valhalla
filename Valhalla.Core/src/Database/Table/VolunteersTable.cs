using Valhalla.Database.Driver.SQLite;

namespace Valhalla
{
    /// <summary>
    /// Represents the volunteers table in the application database.
    /// </summary>
    public class VolunteersTable : SqliteTable
    {
        public VolunteersTable()
        {
            // Set table name
            name = "volunteers";

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
                true,                                   // Is nullable?
                true,                                   // Is primary key?
                true                                    // Is auto-increment?
            ));

            fields.Add(new SqliteField(
                "first_name",                           // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "last_name",                            // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "email",                                // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "primary_phone",                        // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "alternate_phone",                      // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "street_address_1",                     // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "street_address_2",                     // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "city",                                 // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "state",                                // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "zip_code",                             // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "account_type",                         // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "account_status",                       // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "creation_date",                        // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            fields.Add(new SqliteField(
                "last_active",                          // Field name
                SqliteField.FieldType.TEXT              // Data type
            ));

            var isCdoField = new SqliteField(
                "is_cdo",                               // Field name
                SqliteField.FieldType.INTEGER           // Data type
            );

            // Add fields to field list
            fields.Add(isCdoField);
        }
    }
}
