namespace DailyDaGang.Core;

public static class MenuInfo
{
    public static List<MenuValue> MenuList =
    [
        new ("1","主页",1,"/")
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