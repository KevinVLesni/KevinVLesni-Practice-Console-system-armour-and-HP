﻿using System;

namespace ConsoleApp15
{
    public class Product<T>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public T Energy { get; set; }

        public Product(string name, T volume, T energy)
        {
            // TODO: проверить входные параметры
            Name = name;
            Volume = volume;
            Energy = energy;
        }

    }
}
