using LiteDB;

namespace DailyDaGang.Model;

public class DaGang
{
    [BsonId]
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string LongContent { get; set; }
    
    public int[] StoryEventIds { get; set; }
    
    [BsonIgnore]
    public List<StoryEvent> StoryEvents { get; set; }
}