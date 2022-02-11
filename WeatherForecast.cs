// This source code (WeatherForecast.cs) is Copyright © M. NURHAD BAROKAH Pte, Ltd..
// You MAY NOT copied, reproduced, published, distributed or transmitted
// to or stored in any manner without priorwritten consent from M. NURHAD BAROKAH Pte, Ltd..

using System;

namespace StyleCopNET5
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}