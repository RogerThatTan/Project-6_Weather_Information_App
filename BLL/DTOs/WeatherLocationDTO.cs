﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WeatherLocationDTO : WeatherDTO
    {   
        public int LocationId { get; set; }
        public LocationDTO Location { get; set; }
    }
}
