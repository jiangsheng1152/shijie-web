using SqlSugar;

namespace DailyDaGang.Core
{
    public class BaseRepository<T> : SimpleClient<T> where T : class, new()
    {
        public BaseRepository(ISqlSugarClient db):base(db)
        {
            base.Context = db;
        }
    }
}
