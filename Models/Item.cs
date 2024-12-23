﻿namespace Bill_o_Pro.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public float Price { get; set; }
        public float Tax { get; set; }
    }
}
