﻿namespace Festival.Web.ViewModels.TicketType
{
    public class DetailTicketTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int TicketsSold { get; set; }
    }
}
