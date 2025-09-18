using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LiteDB;

namespace DailyDaGang.Model;

public class Knowledge
{
    [BsonId]
    public int Id { get; set; }
    
    [Required]
    [DisplayName("标题")]
    public string Title { get; set; }
    
    [DisplayName("内容")]
    public string Content { get; set; }
}