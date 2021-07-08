using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongListAPI.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string SongName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Artist { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Url { get; set; }

        [Column(TypeName = "int")]
        public int Rating { get; set; }

        public bool Favourite { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public Song()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
