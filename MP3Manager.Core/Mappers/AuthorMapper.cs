using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Manager.Core.Mappers;

namespace MP3Manager.Core.Mappers
{
    using dto = MP3Manager.Core.Models;
    using data = MP3Manager.Data;

    public static class AuthorMapper
    {
        public static dto::AuthorDTO Map(data::Author author)
        {
            return new dto::AuthorDTO
            {
                Id = author.Id,
                Name = author.Name,
                PhotoUrl = author.PhotoUrl,

                Songs = SongMapper.Map(author.Songs)
            };
        }

        public static data::Author Map(dto::AuthorDTO author)
        {
            return new data::Author()
            {
                Id = author.Id,
                Name = author.Name,
                PhotoUrl = author.PhotoUrl,
                
                Songs = SongMapper.Map(author.Songs);
            };
        }

        public static ICollection<dto::AuthorDTO> Map(ICollection<dto::AuthorDTO> authors)
        {
            return authors.Select(x => new dto::AuthorDTO()
            {
                Id = x.Id,
                Name = x.Name,
                PhotoUrl = x.PhotoUrl,
                Songs = SongMapper.Map(x.Songs)
            }).ToList<dto::AuthorDTO>();
        }

        public static ICollection<data::Author> Map(ICollection<dto::AuthorDTO> authors)
        {
            return authors.Select(x => new data::Author()
            {
                Id = x.Id,
                Name = x.Name,
                PhotoUrl = x.PhotoUrl,
                Songs = SongMapper.Map(x.Songs)
            }).ToList<data::Author>();
        }

    }
}
