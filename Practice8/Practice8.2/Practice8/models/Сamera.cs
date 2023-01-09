
namespace Practice8.models
{
    class Camera
    {
        public int NumberOfMegapixels { get; set; }

        public Camera(int numberOfMegapixels)
        {
            this.NumberOfMegapixels = numberOfMegapixels;
        }

        public override string ToString()
        {
            return "Camera: " + this.NumberOfMegapixels;
        }
    }
}
