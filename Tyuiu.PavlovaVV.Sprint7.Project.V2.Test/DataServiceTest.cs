using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.PavlovaVV.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromFileData()
        {
            string path = @"C:\Users\leroc\source\repos\Tyuiu.PavlovaVV.Sprint7\Tyuiu.PavlovaVV.Sprint7.Project.V2\База данных_pvv.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
