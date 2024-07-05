using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Utility
{
    public class SqlSugarHelper
    {
        public static SqlSugarClient Db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=123; Database=postgres;Pooling=true;Minimum Pool Size=1;",
            DbType = DbType.PostgreSQL,
            IsAutoCloseConnection = true
        },
            db =>
            {
                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    Console.WriteLine(UtilMethods.GetNativeSql(sql, pars));
                };
            });
        public static string InitDateBase()
        {
            try
            {
                //创建数据库
                Db.DbMaintenance.CreateDatabase();
                //创建数据表
                string nspace = "Repository.Model";
                Type[] ass =Assembly.LoadFrom(AppContext.BaseDirectory+ "Repository.dll").GetTypes().Where(p=>p.Namespace==nspace).ToArray();
                Db.CodeFirst.SetStringDefaultLength(200).InitTables(ass);
                return "Ok";
            }
            catch(Exception ex)
            {
                return ex.Message; 
            }
        }
    }
}
