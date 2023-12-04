using System.Collections.Generic;

namespace ProxyLibrary.CachingProxyExample.Common
{
    /// <summary>
    /// The interface of a remote service.
    /// </summary>
    public interface IYoutubeOperations
    {
        VideoMetaData GetVideoMetadata(int id);
        
        Video DownloadVideo(int id);
        
        IEnumerable<VideoMetaData> ShowHomepage();
    }
}