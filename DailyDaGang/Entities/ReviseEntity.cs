using System.ComponentModel;
using DailyDaGang.Core;
using SqlSugar;

namespace DailyDaGang.Entities
{
    /// <summary>
    /// 修改
    /// </summary>
    [SugarTable]
    public class ReviseEntity:EntityBase
    {
        [DisplayName("描述")]
        public string Description { set; get; }
    }
}
