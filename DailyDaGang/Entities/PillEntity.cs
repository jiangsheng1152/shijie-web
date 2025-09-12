using System.ComponentModel;
using DailyDaGang.Core;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 丹药类
    /// </summary>
    [SugarTable]
    public class PillEntity:EntityBase
    {
        [DisplayName("丹药作用")]
        public string Description { set; get; }

        [Navigate(typeof(PillMaterialEntity), nameof(PillMaterialEntity.PillId), nameof(PillMaterialEntity.MaterialId))]
        [DisplayName("所需材料")]
        public List<MaterialEntity> Materials { set; get; }
    }
}
