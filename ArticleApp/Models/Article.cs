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
        [Required(ErrorMessage = "제목을 입력해 주세요.")]
        public string Title { get; set; }

        /// <summary>
        /// 내용
        /// </summary>
        [Required(ErrorMessage = "내용을 입력해 주세요.")]
        public string Content { get; set; }

        /// <summary>
        /// 공지글로 올리기
        /// </summary>
        public bool IsPinned { get; set; }

        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
    }
}
