using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal class Car
    {
        #region Properties
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion

        #region Constractors
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("1");
        }

        public Car(int id, string model):this(id, model, 290)
        {
           Console.WriteLine("2");
        }

        public Car(int id):this(id,"Audi")
        {
            Console.WriteLine("3");
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id is {Id} :: Model is {Model} :: Speed is {Speed}";
        }
        #endregion
    }
}
