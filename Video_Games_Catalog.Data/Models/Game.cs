using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Video_Games_Catalog.Data.Models
{
    public class Game
    {
        [Key]
        public Int32 GameId { get; set; }
        [Required]
        [MaxLength(50)]
        public string GameName { get; set; }
        [MaxLength(200)]
        public string GameDetail { get; set; }
        [Required]
        public float Price { get; set; }
        [MaxLength(50)]
        public string AuthorName { get; set; }
        [MaxLength(100)]
        public string GameImage { get; set; }

        public DateTime? CreatedDate { get; set; }
        [MaxLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        [MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}