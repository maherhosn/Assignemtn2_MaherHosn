﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        CharPage, //add new page
        Leaderbaord,
        Characters,
        Items
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
