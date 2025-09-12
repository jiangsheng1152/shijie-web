using System.ComponentModel;
using DailyDaGang.Core;
using DailyDaGang.Enums;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 技能表
    /// </summary>
    [SugarTable]
    public class SkillEntity:EntityBase
    {
        [DisplayName("技能描述")]
        public string Description { set; get; }

        [DisplayName("技能等级")]
        public GradeStatus? GradeStatus { set; get; }

        [DisplayName("技能类型")]
        public SkillStatus SkillStatus { set; get; }

        [Navigate(typeof(SkillLabelEntity), nameof(SkillLabelEntity.SkillId), nameof(SkillLabelEntity.LabelId))]
        [DisplayName("标签")]
        public List<LabelEntity>? Labels { set; get; }
    }
}
