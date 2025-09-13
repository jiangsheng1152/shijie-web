using System.ComponentModel;
using AntDesign;
using DailyDaGang.Enums;
using LiteDB;

namespace DailyDaGang.Model;

public class LabelTag
{
    [BsonId]
    public int Id { get; set; }
    
    [DisplayName("标签名")]
    public string Name { get; set; }
    
    [DisplayName("类型")]
    public LabelStatus  Status { get; set; }
    
    [DisplayName("颜色")]
    public TagColor Color { get; set; }
}