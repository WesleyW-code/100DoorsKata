using NUnit.Framework;


namespace _100DoorsKataTests
{
    [TestFixture]
    public class Testing100DoorsKata
    {
        // Different one character basic test cases
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("@",HundredDoorsKata.Hundred.DoorManipulator("#"));
            Assert.AreEqual("H", HundredDoorsKata.Hundred.DoorManipulator("@"));
            Assert.AreEqual("#", HundredDoorsKata.Hundred.DoorManipulator("H"));
        }

        // If there are 5 closed doors - test.
        [Test]
        public void DoorManipulator_with5DoorsClosed()
        {
            Assert.AreEqual("@HH#H", HundredDoorsKata.Hundred.DoorManipulator("#####"));
        }

        // If there are 3 closed doors - test.
        [Test]
        public void DoorManipulator_with3DoorsClosed()
        {
            Assert.AreEqual("@HH", HundredDoorsKata.Hundred.DoorManipulator("###"));
        }
        // If there are 5 open doors - test.
        [Test]
        public void DoorManipulator_with5DoorsOpen()
        {
            Assert.AreEqual("H##@#", HundredDoorsKata.Hundred.DoorManipulator("@@@@@"));
        }

        // If there are 3 open doors - test.
        [Test]
        public void DoorManipulator_with3DoorsOpen()
        {
            Assert.AreEqual("H##", HundredDoorsKata.Hundred.DoorManipulator("@@@"));
        }

    }
}