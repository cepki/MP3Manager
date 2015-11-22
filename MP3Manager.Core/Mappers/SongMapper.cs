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

    public static class SongMapper
    {
        public static dto::SongDTO Map(data::Song song)
        {
            return new dto::SongDTO
            {
                Id = song.Id,
                Title = song.Title,
                SongUrl = song.SongUrl,
                Author = AuthorMapper.Map(song.Author)
            };
        }

        public static data::Song Map(dto::SongDTO song)
        {
            return new data::Song
            {
                Id = song.Id,
                Title = song.Title,
                SongUrl = song.SongUrl,
                AuthorID = song.AuthorID
            };
        }

        public static ICollection<dto::SongDTO> Map(ICollection<data::Song> songs)
        {
            return songs.Select(x => new dto::SongDTO() 
            {
                Id = x.Id,
                Title = x.Title,
                SongUrl = x.SongUrl,

                Author = AuthorMapper.Map(x.Author),
                Playlists = PlaylistMapper.Map(x.Playlists)
            }).ToList<dto::SongDTO>();
        }

        public static ICollection<data::Song> Map(ICollection<dto::SongDTO> songs)
        {
            return songs.Select(x => new data::Song()
            {
                Id = x.Id,
                Title = x.Title,
                SongUrl = x.SongUrl,

                Author = AuthorMapper.Map(x.Author),
                Playlists = PlaylistMapper.Map(x.Playlists)
            }).ToList<data::Song>();
        }
    }
}
