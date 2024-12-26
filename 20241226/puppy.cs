using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226
{
    internal class puppy
    {
        public int ID { get; set; }  //puppy的ID,車牌
        public string Name { get; set; }  //puppy名字
        public string Breed { get; set; }  //puppy品種
        public double Age { get; set; } //puppy年齡
        public string Color { get; set; } //puppy顏色
        public double Weight { get; set; } //體重
        private string _tail; //尾巴
        public string tail
        {
            get { return tail; }
            set { this.tail = value; }
        }

        //建構子函式1
        public Puppy() { }

        //建構子函式2
        public Puppy(int CID, string CName, string CBreed, double CAge, string CColor, double CWeight, string Ctail)
        {
            ID = CID;
            Name = CName;
            Breed = CBreed;
            Age = CAge;
            Color = CColor;
            Weight = CWeight;
            tail = Ctail;

        }

        public void CallMyPuppyName()
        {
            Console.WriteLine("ID is:　" + this.ID.ToString());
            Console.WriteLine("Name is :　" + this.Name.ToString());
            Console.WriteLine("Breed is：　" + this.Breed.ToString());
            Console.WriteLine("Age is：　" + this.Age.ToString());
            Console.WriteLine("Color is：　" + this.Color.ToString());
            Console.WriteLine("Weight is：　" + this.Weight.ToString());
            Console.WriteLine("tail is :　" + this.tail.ToString());
            //類推..把所有屬性印出來.
        }
    }
}