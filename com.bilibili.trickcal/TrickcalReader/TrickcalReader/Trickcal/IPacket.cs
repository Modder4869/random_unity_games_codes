using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(SerializedPingPacket))]
[Union(1, typeof(SerializedNotificationPacket))]
[Union(2, typeof(SerializedRequestPacket))]
[Union(3, typeof(SerializedResponsePacket))]
[Union(4, typeof(SerializedServerErrorPacket))]
[Union(5, typeof(SerializedUnknownNotificationPacket))]
[Union(6, typeof(SerializedUnknownRequestPacket))]
[Union(7, typeof(SerializedUnknownResponsePacket))]
public interface IPacket {}
