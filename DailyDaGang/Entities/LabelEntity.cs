using AntDesign;
using DailyDaGang.Core;
using DailyDaGang.Enums;
using SqlSugar;
using System.ComponentModel;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 标签表
    /// </summary>
    [SugarTable]
    public class LabelEntity:EntityBase
    {
        [SugarColumn(IsNullable = true)] // 关键：添加此特性
        [DisplayName("标签描述")]
        public string? Description { set; get; }

        [DisplayName("标签类型")]
        public LabelStatus LabelStatus { get; set; }

        [DisplayName("颜色")]
        public TagColor LabelColor { set; get; } = TagColor.BlueInverse;
    }
}
