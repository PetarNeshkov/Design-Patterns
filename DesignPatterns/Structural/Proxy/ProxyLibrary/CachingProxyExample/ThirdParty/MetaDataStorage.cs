using System;
using System.Collections.Generic;
using ProxyLibrary.CachingProxyExample.Common;

namespace ProxyLibrary.CachingProxyExample.ThirdParty
{
    public class MetaDataStorage
    {
        private readonly Dictionary<int, VideoMetaData> videos;
        
        public MetaDataStorage()
        {
            videos = new Dictionary<int, VideoMetaData>
            {
                { 1, new VideoMetaData() { Id = 1, Name = "Video 1", Description = "Video 1 description", } },
                { 2, new VideoMetaData { Id = 2, Name = "Video 2", Description = "Video 2 description", } },
                { 3, new VideoMetaData { Id = 3, Name = "Video 3", Description = "Video 3 description", } },
            };
        }

        public IEnumerable<VideoMetaData> GetAll()
        {
            Console.WriteLine("Getting metadata for all videos from metadata storage...");

            return videos.Values;
        }

        public VideoMetaData GetById(int id)
        {
            Console.WriteLine($"Getting metadata for the video with ID: {id} from the metadata storage...");

            if (!videos.TryGetValue(id, out var videoMetadata))
            {
                throw new ArgumentException($"ID: {id} is unknown to metadata storage.");
            }
            
            return videoMetadata;
        }
    }
}