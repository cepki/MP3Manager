using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Manager.Core.Models
{
    public class SongDTO
    {
        public SongDTO()
        {
            this.Playlists = new Collection<PlaylistDTO>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string SongUrl { get; set; }
        public Nullable<int> AuthorID { get; set; }

        public AuthorDTO Author { get; set; }
        public ICollection<PlaylistDTO> Playlists { get; set; }
    }
}
