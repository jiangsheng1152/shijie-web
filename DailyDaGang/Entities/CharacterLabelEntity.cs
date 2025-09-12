using DailyDaGang.Core;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 人物标签关系表
    /// </summary>
    [SugarTable]
    public class CharacterLabelEntity
    {
        public int CharacterId { set; get; }

        public int LabelId { set; get; }
    }
}
