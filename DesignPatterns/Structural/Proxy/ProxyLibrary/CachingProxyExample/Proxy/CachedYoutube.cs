using System.Collections.Generic;
using System.Linq;
using ProxyLibrary.CachingProxyExample.Common;
using ProxyLibrary.CachingProxyExample.ThirdParty;

namespace ProxyLibrary.CachingProxyExample.Proxy
{
    /// <summary>
    /// To save some bandwidth, we can cache request results and keep them in memory (for some time).
    /// But it may be impossible to put such code directly into the service class.
    /// For example, it could have been provided as part of a third party library and/or defined as 'final'.
    /// That's why we put the caching code into a new proxy class which implements the same interface as the service class.
    /// It delegates to the service object only when the real requests have to be sent.
    /// </summary>
    public class CachedYoutube : IYoutubeOperations
    {
        private readonly Youtube youtubeService;
        private readonly Dictionary<int, Video> contentCache;
        private readonly Dictionary<int, VideoMetaData> metadataCache;

        public CachedYoutube(Youtube youtubeService)
        {
            this.youtubeService = youtubeService;

            contentCache = new Dictionary<int, Video>();
            metadataCache = new Dictionary<int, VideoMetaData>();
        }
        
        public VideoMetaData GetVideoMetadata(int id)
        {
            if (!metadataCache.TryGetValue(id, out var metaData))
            {
                metaData = youtubeService.GetVideoMetadata(id);
                metadataCache.Add(metaData.Id, metaData);
            }

            return metaData;
        }

        public Video DownloadVideo(int id)
        {
            if (!contentCache.TryGetValue(id, out var video))
            {
                video = youtubeService.DownloadVideo(id);
                contentCache.Add(video.Id, video);
            }

            return video;
        }

        public IEnumerable<VideoMetaData> ShowHomepage()
        {
            // Naive logic - prepare the homepage using only cached data.
            IEnumerable<VideoMetaData> metadataForHomepage = metadataCache.Values;

            if (!metadataForHomepage.Any())
            {
                // Nothing is cached on our side yet.
                // Send a network request to the Youtube in order to get enough information for showing the homepage.
                metadataForHomepage = youtubeService.ShowHomepage();
                foreach (var videoMetadata in metadataForHomepage)
                {
                    metadataCache.Add(videoMetadata.Id, videoMetadata);
                }
            }
            
            return metadataForHomepage;

        }
    }
}