using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserAlbumData))]
public interface IUserAlbumData {}
