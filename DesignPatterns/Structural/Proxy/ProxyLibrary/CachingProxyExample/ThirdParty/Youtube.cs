using System.Collections.Generic;
using ProxyLibrary.CachingProxyExample.Common;

namespace ProxyLibrary.CachingProxyExample.ThirdParty
{
    /// <summary>
    /// The concrete implementation of a service connector.
    /// Methods of this class can request information from YouTube.
    /// The speed of the request depends on a user's internet connection as well as YouTube's.
    /// The application will slow down if a lot of requests are fired at the same time,
    /// even if they all request the same information.
    /// </summary>
    public class Youtube : IYoutubeOperations
    {
        private readonly ContentStorage contentStorage;
        private readonly MetaDataStorage metadataStorage;

        public Youtube()
        {
            contentStorage = new();
            metadataStorage = new();
        }

        public VideoMetaData GetVideoMetadata(int id)
            => metadataStorage.GetById(id);

        public Video DownloadVideo(int id)
            => contentStorage.GetById(id);

        public IEnumerable<VideoMetaData> ShowHomepage()
            => metadataStorage.GetAll();
    }
}