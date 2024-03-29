﻿using System.Collections.Generic;

namespace GardenMarket.Models
{
    public class Characteristic
    {
        public Characteristic()
        {
            CharacteristicCategories = new List<CharacteristicCategory>();
            CharacteristicTypes = new List<CharacteristicType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Display { get; set; }
        public IReadOnlyList<CharacteristicCategory> CharacteristicCategories { get; set; }
        public IReadOnlyList<CharacteristicType> CharacteristicTypes { get; set; }
    }
}