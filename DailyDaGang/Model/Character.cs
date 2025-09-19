using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DailyDaGang.Core;
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
    
    public int[]? LabelTagIds { get; set; }
    
    [BsonIgnore]
    public LabelTag[] LabelTags { get; set; }

    [DisplayName("战力设计")]
    public CombatPower? CombatPower { get; set; }

    public Character()
    {
        if (LabelTagIds is { Length: > 0 })
            LabelTags = Db.Execute(db => db.GetCollection<LabelTag>().Find(x => LabelTagIds.Contains(x.Id))).ToArray();
    }
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