using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProjekt.Models
{
    public class TestRepository : ITestRepository
    {
        public IEnumerable<TestModel> GetItems()
        {
            return new List<TestModel>
            {
                new TestModel {ProductName="Oculus Rift", ProductDesc="Oculus Rift is a virtual reality headset (VR headset) that is designed to connect to a high-powered PC to enable advanced computations and graphics rendering.", ProductPrice=449},
                new TestModel {ProductName="Oculis Quest 2", ProductDesc="Oculus Quest 2 is our most advanced all-in-one VR system yet. Every detail has been engineered to make virtual worlds adapt to your movements, letting you explore awe-inspiring games and experiences with unparalleled freedom. No PC or console required", ProductPrice=349},
            };

        }
    }
}
