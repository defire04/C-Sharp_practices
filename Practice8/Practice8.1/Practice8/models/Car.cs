
using System.Collections.Generic;


namespace Practice8.models
{
    class Car
    {
        private string brand;
        private string color;
        private int maxSpeed;
        private int yearOfIssue;

        public Car(string brand, string color, int maxSpeed, int yearOfIssue)
        {

            this.brand = brand;
            this.color = color;
            this.maxSpeed = maxSpeed;
            this.yearOfIssue = yearOfIssue;

        }

        public string getBrand()
        {
            return brand;
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public int getMaxSpeed()
        {
            return maxSpeed;
        }

        public void setMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public int getYearOfIssue()
        {
            return yearOfIssue;
        }

        public void setYearOfIssue(int yearOfIssue)
        {
            this.yearOfIssue = yearOfIssue;
        }

        public override string ToString()
        {
            return this.brand + " " + this.color + " " + this.maxSpeed + " " + this.yearOfIssue;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Car car = (Car)obj;
            return this.maxSpeed == car.maxSpeed && this.yearOfIssue == car.yearOfIssue
                && this.brand.Equals(car.brand) && this.color.Equals(car.color);
        }

        public override int GetHashCode()
        {
            int hashCode = -713860742;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(brand);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(color);
            hashCode = hashCode * -1521134295 + maxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + yearOfIssue.GetHashCode();
            return hashCode;
        }
    }
}