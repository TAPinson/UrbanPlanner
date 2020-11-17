using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
        private string _designer = "Travis Pinson";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                double answer = Width * Depth * (3 * Stories);
                return answer;
            }
        }

        public string Owner
        {
            get
            {
                return _owner;
            }
        }

        public string Designer
        {
            get
            {
                return _designer;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        public DateTime DateConstructed
        {
            get
            {
                return _dateConstructed;
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void AddStories(int stories)
        {
            Stories = stories;
        }

        public void AddWidth(int width)
        {
            Width = width;
        }

        public void AddDepth(int depth)
        {
            Depth = depth;
        }

    }

}