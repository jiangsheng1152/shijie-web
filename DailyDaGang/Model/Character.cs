using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LiteDB;

namespace DailyDaGang.Model;

public class Character
{
    [BsonId]
    public int Id { get; set; }
    
    [Required]
    [DisplayName("名字")]
    public string Name { get; set; }
    
    [DisplayName("性别")]
    public string Gender { get; set; }
    
    [DisplayName("年龄")]
    public int Age { get; set; }
    
    [DisplayName("性格特点")]
    public string Personality { get; set; }
    
    public int[] LabelTagIds { get; set; }
    
    [BsonIgnore]
    public LabelTag[] LabelTags { get; set; }
}