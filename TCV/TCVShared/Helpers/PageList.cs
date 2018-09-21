using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TCVShared.Helpers
{
    public class PagedModel
    {
        private static readonly SelectList pagesList;

        static PagedModel()
        {
            var pages = new SortedList<int, string>();
            for (int i = 5; i <= 50; i += 5)
                pages.Add(i, string.Format("{0} rows", i));

            pagesList = new SelectList(pages, "Key", "Value");
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public object Master { get; set; }

        public string Group { get; set; }
        public string Filter { get; set; }
        public string Search { get; set; }

        [Display(Name = "Hiển thị")]
        public int PageSize { get; set; }
        public int CurPage { get; set; }
        public int TotalRows { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalRows / PageSize); }
        }

        public SelectList PageSelectList
        {
            get { return pagesList; }
        }

        public PagedModel()
        {
            CurPage = 1;
            PageSize = 15;
        }
    }

    public class PagedList<T> : PagedModel
    {
        public List<T> Content { get; set; }

        public void Clone(PagedModel other)
        {
            this.Filter = other.Filter;

            this.PageSize = other.PageSize;
            this.CurPage = other.CurPage;
            this.TotalRows = other.TotalRows;

            this.Id = other.Id;
            this.Name = other.Name;
        }
    }
}
