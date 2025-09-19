using LiteDB;

namespace DailyDaGang.Core;

public static class Db
{
    private static readonly string _connStr = @"Filename=dagang.db;Connection=shared";

    /// <summary>
    /// 执行 LiteDB 操作，可返回结果
    /// </summary>
    public static TResult Execute<TResult>(Func<LiteDatabase, TResult> action)
    {
        if (action == null) throw new ArgumentNullException(nameof(action));
        using var db = new LiteDatabase(_connStr);
        return action(db);
    }

    /// <summary>
    /// 针对无返回值的操作，提供 Action 重载（内部调用上面的 Func）
    /// </summary>
    public static void Execute(Action<LiteDatabase> action)
    {
        if (action == null) throw new ArgumentNullException(nameof(action));
        using var db = new LiteDatabase(_connStr);
        action(db);
    }
    
    /// <summary>
    /// 获取列表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GetList<T>()
    {
        return Execute(x => x.GetCollection<T>().FindAll().ToList());
    }

    /// <summary>
    /// 插入或修改
    /// </summary>
    /// <param name="t"></param>
    /// <typeparam name="T"></typeparam>
    public static void UpdateOrInsert<T>(T t)
    {
        Execute(x => x.GetCollection<T>().Upsert(t));
    }

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <typeparam name="T"></typeparam>
    public static void Delete<T>(BsonValue id)
    {
        Execute(x => x.GetCollection<T>().Delete(id));
    }
}