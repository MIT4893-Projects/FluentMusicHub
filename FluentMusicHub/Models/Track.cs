using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMusicHub.Models
{
    class Track
    {
        /// <summary>
        /// Artist's informations about this track.
        /// </summary>
        public readonly string Artist;

        /// <summary>
        /// Title of this track (track's name).
        /// </summary>
        public readonly string Title;

        /// <summary>
        /// Create a new track with a title and an artist name.
        /// </summary>
        /// <param name="title">Track's title.</param>
        /// <param name="artist">Track's artist name.</param>
        public Track(string title, string artist = "")
        {
            Artist = artist;
            Title = title;
        }
    }
}
