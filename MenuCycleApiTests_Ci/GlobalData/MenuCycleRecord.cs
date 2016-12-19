using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.GlobalData
{
    public class MenuCycleRecord
    {

        //This is context injection variable where you can use all around the project 
        public int _menuCycleId;
        public int _menuCycleItemId;
        public int itemvalue;
        public  List<int> idList = new List<int>();
        public List<string> href = new List<string>();
        public int _menuId;
        public List<string> Menuentiteherf = new List<string>();
        public List<string> groupItemhref = new List<string>();
        public int groupid { get; set; }
    }
}
