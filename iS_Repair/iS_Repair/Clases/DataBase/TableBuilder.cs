using System;

namespace iS_Repair.Clases.DataBase
{
    public class TableBuilder
    {
        private string _strFields;

        public string Fields {
            get { return _strFields; }
            set { _strFields = value; }
        }

        private string _strTableName;

        public string TableName {
            get { return _strTableName; }
            set { _strTableName = value; }
        }


        public TableBuilder(string strTableName,string strFields)
        {
            this.Fields = strFields;
            this.TableName = strTableName;
        }

        public string QueryTable()
        {
            string query = "CREATE TABLE IF NOT EXISTS " +
                           TableName + "(" + Fields + ")";
            return query;
        }

        private String[] FieldsNotType()
        {
            string pre_array = Fields.Replace(" ",",");
            string[] array = pre_array.Split(',');
            string[] fields = new string[array.Length / 2];
            int j = 0;
            for (int i = 0; i < array.Length; i+=2)
            {
                fields[j] = array[i];
                j++;
            }
            return fields;
        }

        private string FieldsComma(bool b)
        {
            string comm = "";
            string[] fields = FieldsNotType();
            for (int i = 0; i < fields.Length; i++)
            {
                comm += ((b)?"@":"") +fields[i];
                if (i < fields.Length - 1)
                    comm += ",";
            }
            return comm;
        }

        public string QueryInsert()
        {
            string query = "INSERT INTO "+TableName+
                           "VALUES(" +FieldsComma(true)+ ")";
            return query;
        }

        public string QueryDelete(string where)
        {
            return "DELETE FROM "+TableName+" WHERE " + where;
        }

        public string QuerySelect(string strFields)
        {
            return "SELECT " + strFields + " FROM " + TableName;
        }

        public string QuerySelect(string strFields , string strWhere)
        {
            return "SELECT " +strFields+" FROM "+TableName+" WHERE " + strWhere;
        }
    }
}
