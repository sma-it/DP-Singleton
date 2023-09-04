﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsCheckedOut = false;
        }
    }
}
