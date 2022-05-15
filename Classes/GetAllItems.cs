using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _7DaysToCheat.Classes
{
    public class GetAllItems : ItemClass
    {
        public static List<string> GetAllCurrentItems()
        {
            return itemNames;
        }
    }
}
