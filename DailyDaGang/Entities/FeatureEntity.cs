using System.ComponentModel;
using DailyDaGang.Core;
using DailyDaGang.Enums;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 特性表
    /// </summary>
    [SugarTable]
    public class FeatureEntity:EntityBase
    {
        [DisplayName("特性")]
        public RootSourceStatus RootStatus { set; get; }

        [DisplayName("特性描述")]
        public string FeatureDescription { set; get; }
    }
}
