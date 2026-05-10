using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PostGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Order { get; set; }
    [Key(3)]
    public string BackGround { get; set; }
    [Key(4)]
    public string Spine { get; set; }
    [Key(5)]
    public string Icon { get; set; }
    [Key(6)]
    public string NickName { get; set; }
    [Key(7)]
    public string UserId { get; set; }
    [Key(8)]
    public string Desc { get; set; }
    [Key(9)]
    public string HashTag1 { get; set; }
    [Key(10)]
    public string HashTag2 { get; set; }
    [Key(11)]
    public string Like { get; set; }
    [Key(12)]
    public int CommentNum { get; set; }
    [Key(13)]
    public string VideoBG { get; set; }
    [Key(14)]
    public string VideoBGM { get; set; }
    [Key(15)]
    public int CommentGroup { get; set; }
    [Key(16)]
    public bool UseBlack { get; set; }
}
