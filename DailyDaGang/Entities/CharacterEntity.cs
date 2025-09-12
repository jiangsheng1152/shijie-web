using DailyDaGang.Core;
using SqlSugar;
using System.ComponentModel;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 角色表
    /// </summary>
    [SugarTable]
    public class CharacterEntity:EntityBase
    {
        [DisplayName("简单描述")]
        public string? Description { set; get; }

        [DisplayName("年龄")]
        public int Age { set; get; }

        [DisplayName("外貌")]
        public string? Appearance { set; get; }

        [Navigate(typeof(CharacterLabelEntity),nameof(CharacterLabelEntity.CharacterId),nameof(CharacterLabelEntity.LabelId))]
        [DisplayName("标签")]
        public List<LabelEntity> Labels { set; get; }
    }
}
