using System.ComponentModel;
using DailyDaGang.Core;
using DailyDaGang.Enums;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 功法表
    /// </summary>
    [SugarTable]
    public class GongFaEntity:EntityBase
    {
        [DisplayName("功法描述")]
        public string GongFaDescription { set; get; }

        [DisplayName("能量类型")]
        public RootSourceStatus SourecStatus { set; get; }

        [Navigate(typeof(GongFaLabelEntity), nameof(GongFaLabelEntity.GongFaId), nameof(GongFaLabelEntity.LabelId))]
        [DisplayName("标签")]
        public List<LabelEntity> Labels { set; get; }

        public int? FirstPillId { set; get; }

        [DisplayName("初锋阶丹药")]
        [Navigate(NavigateType.OneToOne, nameof(FirstPillId))]
        public  PillEntity? FirstPill { set; get; }

        public int? SecondPillId { set; get; }

        [DisplayName("承级阶丹药")]
        [Navigate(NavigateType.OneToOne, nameof(SecondPillId))]
        public PillEntity? SecondPill { set; get; }

        public int? ThirdPillId { set; get; }

        [DisplayName("半神阶丹药")]
        [Navigate(NavigateType.OneToOne, nameof(ThirdPillId))]
        public PillEntity? ThirdPill { set; get; }
    }
}
