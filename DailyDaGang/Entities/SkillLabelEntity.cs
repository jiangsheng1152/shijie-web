using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 技能标签表
    /// </summary>
    [SugarTable]
    public class SkillLabelEntity
    {
        public int SkillId { set; get; }

        public int LabelId { set; get; }
    }
}
