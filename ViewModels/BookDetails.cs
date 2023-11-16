using Shop1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Shop1.ViewModels
{
    public class BookDetails
    {
        public System.Guid Book_id { get; set; }
        [Required]
        [DisplayName("Название книги")]
        [StringLength(100, MinimumLength = 2)]
        public string Book_name { get; set; }
        [Required]
        [DisplayName("Жанр")]
        [StringLength(100, MinimumLength = 2)]
        public string Genres { get; set; }
        [Required]
        [DisplayName("Автор")]
        [StringLength(100, MinimumLength = 2)]
        public string Authors { get; set; }
        [Required]
        [DisplayName("Издательство")]
        public string Pub_house { get; set; }
        [Required]
        [DisplayName("Возрастное ограничение")]
        [StringLength(4, MinimumLength = 2)]
        public string Book_age_categ { get; set; }
        [Required]
        [DisplayName("Количество книг на складе")]
        public int Book_count { get; set; }
        [Required]
        [DisplayName("Цена")]
        public int Book_price { get; set; }
        //public string Book_name { get; set; }
        //public string Book_age_categ { get; set; }
        //public int Book_count { get; set; }
        //public int Book_price { get; set; }
        //public string Genres  { get; set; }
        //public string Authors { get; set; }
        //public string Pub_house { get; set; }
    }
}