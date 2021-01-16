using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleApp.Models;
using Microsoft.AspNetCore.Components;

namespace ArticleApp.Pages.Articles
{
    public class DeleteModalParameterContainer
    {
        public bool IsDeleteModalOpen { get; set; } = true;
        public Article Model { get; set; }
    }
}
