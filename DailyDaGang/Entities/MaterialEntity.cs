using System.ComponentModel;
using DailyDaGang.Core;
using DailyDaGang.Enums;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 材料表
    /// </summary>
    [SugarTable]
    public class MaterialEntity:EntityBase
    {
        [DisplayName("材料级别")]
        public LevelStatus MaterLevelStatus { set; get; }
    }
}
