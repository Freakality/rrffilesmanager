﻿using System;

namespace RRFFilesManager.Abstractions
{
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Group Group { get; set; }
        public override string ToString() =>  $"{Name}";
    }
}
