using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LiteDB;

namespace DailyDaGang.Model;

public class StoryEvent
{
    [BsonId]
    public int Id { get; set; }
    
    [Required]
    [DisplayName("事件名")]
    public string EventName { get; set; }
    
    [DisplayName("背景描述")]
    public string? BackDescription { set; get; }
    
    [DisplayName("事件全过程")]
    public string? EventDescription { get; set; }
    
    [DisplayName("事件结果")]
    public string? ResultDescription { set; get; }

    [DisplayName("圣罗纪元")]
    public int RecordYears { set; get; } = 4000;

    public int DaGangId { set; get; }
    
    [BsonIgnore]
    public DaGang? DaGang { set; get; }
}