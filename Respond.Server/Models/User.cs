﻿namespace EntityFrameworkPlayground.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Session> Sessions { get; set; }
        public List<Response> Responses { get; set; }
    }
}