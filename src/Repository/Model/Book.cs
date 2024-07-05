using SqlSugar;

namespace Repository.Model
{
    [SugarTable("public.Books")]
    public  class Book
    {
        [SugarColumn(ColumnName = "Id", ColumnDataType = "int8", IsIdentity = true, IsPrimaryKey = true)]
        public long Id { get; set; }
        [SugarColumn(ColumnName = "Name", ColumnDataType = "varchar")]
        public string? Name { get; set; }
        [SugarColumn(ColumnName = "Author", ColumnDataType = "varchar")]
        public string? Author { get; set; }
        [SugarColumn(ColumnName = "PublishTime", ColumnDataType = "timestamptz", UpdateServerTime = true)]
        public DateTime? PublishTime { get; set; }
        [SugarColumn(ColumnName = "CreatedTime", ColumnDataType = "timestamptz", InsertServerTime = true)]
        public DateTime? CreatedTime { get; set; }
        [SugarColumn(ColumnName = "IsDeleted", ColumnDataType = "bool", DefaultValue = "false")]
        public bool IsDeleted { get; set; }

    }
}
