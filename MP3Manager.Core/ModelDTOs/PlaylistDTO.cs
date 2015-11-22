using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Manager.Core.Models
{
    public class PlaylistDTO
    {
        public PlaylistDTO()
        {
            this.Songs = new Collection<SongDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<DateTime> DateCreated { get; set; }

        public ICollection<SongDTO> Songs { get; set; }
    }
}
