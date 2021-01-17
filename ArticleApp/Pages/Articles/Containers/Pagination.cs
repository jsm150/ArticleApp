using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ArticleApp.Pages.Articles.Containers
{
    public class Pagination
    {
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public int ButtonSize { get; set; } = 3;
        public int ButtonFirstIdx => (PageIndex / ButtonSize) * ButtonSize;
        public int ButtonLastIdx => ButtonFirstIdx + ButtonSize - 1;
        public int ButtonEndIdx => (int)Math.Ceiling(DataCount / (double)PageSize) - 1;
        public int DataCount { get; set; }
        public Func<Task> OnChanged { get; set; }

        public void OnClick(int idx)
        {
            PageIndex = idx switch
            {
                var i when i > ButtonEndIdx => ButtonEndIdx,
                var i when i < 0 => 0,
                _ => idx
            };
            OnChanged?.Invoke();
        }
    }
}
