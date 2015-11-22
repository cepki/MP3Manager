using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Manager.Core.Mappers
{
    using data = MP3Manager.Data;
    using dto = MP3Manager.Core.Models;

    public static class PlaylistMapper
    {
       public static data::Playlist Map(dto::PlaylistDTO playlist)
       {
           return new data::Playlist
           {
               Id = playlist.Id,
               Name = playlist.Name,
               DateCreated = playlist.DateCreated,
               
               
               Songs = SongMapper.Map(playlist.Songs)
           };
       }

       public static dto::PlaylistDTO Map(data::Playlist playlist)
       {
           return new dto::PlaylistDTO
           {
               Id = playlist.Id,
               Name = playlist.Name,
               DateCreated = playlist.DateCreated,

               Songs = SongMapper.Map(playlist.Songs);
           };
       }

       public static ICollection<dto::PlaylistDTO> Map(ICollection<data::Playlist> playlists)
       {
           return playlists.Select(x => new dto::PlaylistDTO()
           {
               Id = x.Id,
               Name = x.Name,
               DateCreated = x.DateCreated,

               Songs = SongMapper.Map(x.Songs)
           }).ToList<dto::PlaylistDTO>();
       }

       public static ICollection<data::Playlist> Map(ICollection<dto::PlaylistDTO> playlists)
       {
           return playlists.Select(x => new data::Playlist()
           {
               Id = x.Id,
               Name = x.Name,
               DateCreated = x.DateCreated,

               Songs = SongMapper.Map(x.Songs)
           }).ToList<data::Playlist>();
       }

    }
}
