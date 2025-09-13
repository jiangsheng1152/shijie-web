namespace DailyDaGang.Core;

public static class MenuInfo
{
    public static List<MenuValue> MenuList =
    [
        new ("1","主页",1,"/"),
        new ("2","事件",2,"/story-event"),
        new ("3","角色",3,"/character")
    ];
}

public class MenuValue
{
    public MenuValue(string key, string title, int order, string url)
    {
        Key = key;
        Title = title;
        Order = order;
        Url = url;
    }
    public string Key { set; get; }
    public string Title { set; get; }
    public int Order { set; get; }
    public string Url { set; get; }
}