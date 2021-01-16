using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApp.Models
{
    [Table("Articles")]
    public class Article
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 제목
        /// </summary>
        [Required]
        public string Title { get; set; }

        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
    }
}
