
using System.Collections.Generic;


namespace Practice8.models
{
    class Garage
    {
        private List<Car> carList = new List<Car>();
        private string owner;

        public Garage()
        {
        }

        public Garage(string owner)
        {
            this.owner = owner;
        }

        public List<Car> getCarList()
        {
            return carList;
        }

        public string getOwner()
        {
            return owner;
        }

        public void setOwner(string owner)
        {
            this.owner = owner;
        }
    }
}
