using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Manager.Core.Models
{
    public class AuthorDTO
    {
        public AuthorDTO()
        {
            this.Songs = new Collection<SongDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public ICollection<SongDTO> Songs { get; set; }
    }
}
