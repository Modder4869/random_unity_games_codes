using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserMailData {
    [Key(0)]
    public MailType MailType { get; set; }
    [Key(1)]
    public int Sender { get; set; }
    [Key(2)]
    public int[] ItemIds { get; set; }
    [Key(3)]
    public int[] ItemCounts { get; set; }
    [Key(4)]
    public StringUsageType TitleType { get; set; }
    [Key(5)]
    public string[] Title { get; set; }
    [Key(6)]
    public StringUsageType DescriptionType { get; set; }
    [Key(7)]
    public string[] Description { get; set; }
    [Key(8)]
    public DateTime ExpireTime { get; set; }
    [Key(9)]
    public DateTime SendTime { get; set; }
    [Key(10)]
    public StringUsageType[] TitleValueTypes { get; set; }
    [Key(11)]
    public string[] TitleValues { get; set; }
    [Key(12)]
    public StringUsageType[] DescriptionValueTypes { get; set; }
    [Key(13)]
    public string[] DescriptionValues { get; set; }
}
