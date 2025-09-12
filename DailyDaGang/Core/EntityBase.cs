using SqlSugar;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DailyDaGang.Core
{
    public class EntityBase
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [SugarColumn(Length = 100)]
        [DisplayName("名称")]
        public string? Name { get; set; }
    }
}
