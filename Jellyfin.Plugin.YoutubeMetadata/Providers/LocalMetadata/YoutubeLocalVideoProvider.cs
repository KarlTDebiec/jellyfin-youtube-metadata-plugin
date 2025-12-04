using MediaBrowser.Controller.Entities;
using MediaBrowser.Model.IO;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.YoutubeMetadata.Providers
{
    public class YoutubeLocalVideoProvider : AbstractYoutubeLocalProvider<YoutubeLocalVideoProvider, Video>
    {
        public YoutubeLocalVideoProvider(IFileSystem fileSystem, ILogger<YoutubeLocalVideoProvider> logger) : base(fileSystem, logger) { }

        /// <summary>
        /// Providers name, this appears in the library metadata settings.
        /// </summary>
        public override string Name => Constants.PluginName;

        internal override MediaBrowser.Controller.Providers.MetadataResult<Video> GetMetadataImpl(YTDLData jsonObj)
        {
            return Utils.YTDLJsonToVideo(jsonObj);
        }
    }
}
