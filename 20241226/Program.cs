using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy DennisPuppy = new Puppy();
            //設定DennisCar的屬性值.
            DennisPuppy.Name = "Dennis";
            DennisPuppy.Breed = "米克斯";
            DennisPuppy.Age = 18;
            DennisPuppy.Color = "黑";
            DennisPuppy.Weight = 20;

            //類堆..所有屬性都要設.

            //最後,叫用DennisCar的方法PrintAllAttrib( )印出所有屬性參數.
            DennisPuppy.CallMyPuppyName;

            //===============================================
            //第二個 使用有參數的建構子設一台車MarysPuppy.
            //經由建構子函式2 來設定所有屬性
            Puppy MarysPuppy = new Puppy(2, "Tim", "米克斯", 21, "黃", 70);

            //最後,叫用 MarysPuppy的方法PrintAllAttrib( )印出所有屬性參數.
            MarysPuppy.CallMyPuppyName();
        }
    }
}
