using System;
namespace WebAPIforDrinks.Models
{
    public class Coffee
    {
        public string? Name { get; set; }
        public int Id { get; set; }

        public Coffee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

