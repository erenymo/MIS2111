using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week__0
{
    internal sealed class TouchscreenDevice:Laptop,IDisposable
    {
        public float ScreenSize;
        public TouchscreenDevice(float screenSize,string name, float price) : base(name, price)
        {
            this.ScreenSize = screenSize;
        }

        public sealed override void Report()
        {
            //Console.WriteLine("Hello from laptop");

            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Product price: {Price}");
            Console.WriteLine($"Screensize: {ScreenSize}");
        }

        ~TouchscreenDevice()
        {
            ReleaseUnmanagedResources();
        }

        private void ReleaseUnmanagedResources()
        {
            Console.WriteLine("Touchscreenclass resources released");
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
}
