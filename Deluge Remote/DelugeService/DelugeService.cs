using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService
{
    public class DelugeService
    {
        private static DelugeService _instance;

        public static DelugeService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DelugeService();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
    }
}
