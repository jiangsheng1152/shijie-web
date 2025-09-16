using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DailyDaGang.Enums;
using LiteDB;

namespace DailyDaGang.Model;

public class Character
{
    [BsonId]
    public int Id { get; set; }
    
    [Required]
    [DisplayName("名字")]
    public string Name { get; set; }
    
    [Required]
    [DisplayName("性别")]
    public string Gender { get; set; }
    
    [Required]
    [DisplayName("年龄")]
    public int Age { get; set; }
    
    [Required]
    [DisplayName("性格特点")]
    public string Personality { get; set; }
    
    public int[] LabelTagIds { get; set; }=[0,1,2,3,4,5,6,7,8,9,10];
    
    [BsonIgnore]
    public LabelTag[] LabelTags { get; set; }

    [DisplayName("战力设计")]
    public CombatPower CombatPower { get; set; } = new();
}

public class CombatPower
{
    [DisplayName("体系")]
    public RootSourceStatus SourceStatus { get; set; }
    
    [DisplayName("魔力值")]
    public int MagicData { set; get; }
    
    [DisplayName("气力值")]
    public int ForceData { set; get; }
    
    [DisplayName("精神力")]
    public int MentalData { set; get; }
}