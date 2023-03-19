using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Midi;

namespace FluentMusicHub.Models
{
    class Playlist
    {
        /// <summary>
        /// This container stores all the tracks this playlist contains.
        /// </summary>
        public readonly List<Track> TrackList = new();

        /// <summary>
        /// Name of this playlist.
        /// </summary>
        public readonly string Name = "";

        /// <summary>
        /// Create a new empty playlist with its name.
        /// </summary>
        /// <param name="name">Name of the playlist.</param>
        public Playlist(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Create a new playlist with its name and an initialized list of tracks.
        /// </summary>
        /// <param name="name">Name of the playlist.</param>
        /// <param name="trackList">Initialized list of tracks to copy.</param>
        public Playlist(string name, List<Track> trackList) : this(name)
        {
            TrackList = trackList.GetRange(0, trackList.Count);
        }

        /// <summary>
        /// Add a track to this playlist.
        /// </summary>
        /// <param name="track"></param>
        public void AddTrack(Track track)
        {
            TrackList.Add(track);
        }

        /// <summary>
        /// Remove a track object from this playlist.
        /// </summary>
        /// <param name="track"></param>
        public void RemoveTrack(Track track)
        {
            TrackList.Remove(track);
        }

        /// <summary>
        /// Remove a track object from this playlist with its index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveTrack(int index)
        {
            TrackList.RemoveAt(index);
        }
    }
}
