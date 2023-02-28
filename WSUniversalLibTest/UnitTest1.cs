using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_Quantity_For_Product_Correct_Data()
        {
            // arrange
            int x = 15;
            int y = 20;
            int z = 45;
            int v = 3;
            int b = 1;
            int expected = 114147;

            //act
            int actual = Calculation.GetQuantityForProduct(x, y, z, v, b);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Get_Quantity_For_Product_Correct_Data2() 
        {
            int x = 15;
            int y = 20;
            int z = 45;
            int v = 1;
            int b = -1;
            int expected = 14895;

            //act
            int actual = Calculation.GetQuantityForProduct(x, y, z, v, b);

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}