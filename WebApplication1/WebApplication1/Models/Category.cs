﻿using MyApp.Models;

namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public List<Item>? Items { get; set; }
    }
}
