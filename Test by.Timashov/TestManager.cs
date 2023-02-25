using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_by.Timashov
{
    class TestManager
    {
        public TestManager ()
        {
            saveAnswer[255] = 0;
        }

        public int spentTime = 0;


        public Dictionary<int, int> rightAnswer = new Dictionary<int, int>()
        { { 1, 3 }, {2, 1 }, { 3, 1 }, { 4, 1 },
            { 5, 1 }, { 6, 1}, { 7, 2 }, { 8, 2}, 
            {9,2 }, { 10, 2},  };
        public Dictionary<int, int> saveAnswer = new Dictionary<int, int>();

        public int page = 1;
        public int maxPage = 10;

        public bool[,] demoSelectedVariant = new bool[255,255];

        public void addDemoSelectedVariant (int page, byte variant)
        {
            for (byte i = 1; i <= 4; i++)
            {
                if (demoSelectedVariant[page, i] != demoSelectedVariant[page, variant])
                    demoSelectedVariant[page, i] = false;
            }

            demoSelectedVariant[page, variant] = true;
        }
    }
}
