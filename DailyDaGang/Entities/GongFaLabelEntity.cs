using DailyDaGang.Core;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 功法标签关系表
    /// </summary>
    [SugarTable]
    public class GongFaLabelEntity:EntityBase
    {
        public int GongFaId { set; get; }

        public int LabelId { set; get; }
    }
}
