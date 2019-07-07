using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.Models.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
