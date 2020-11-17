using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Established { get; set; }
        public List<Building> cityBuildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            this.cityBuildings.Add(building);
        }
    }
}