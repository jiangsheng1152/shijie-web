using DailyDaGang.Core;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 丹药材料关系表
    /// </summary>
    [SugarTable]
    public class PillMaterialEntity
    {
        public int PillId { set; get; }

        public int MaterialId { set; get; }
    }
}
