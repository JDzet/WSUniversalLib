using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_Quantity_For_Product_Correct_Data() // ��������� ��������� ������
        {
            // arrange
            int count = 15;
            int width = 20;
            int lenght = 45;
            int productType = 3;
            int materialType = 1;

            int expected = 114147;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Negative_Value_Material_Type () // ������������� �������� ���� ���������
        {
            int count = 15;
            int width = 20;
            int lenght = 45;
            int productType = 3;
            int materialType = -1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Negative_Value_Product_Type() // ������������� �������� ���� ��������
        {
            int count = 15;
            int width = 20;
            int lenght = 45;
            int productType = -3;
            int materialType = 1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zero_Value_Product_Type() // ������� �������� ���� ��������
        {
            int count = 15;
            int width = 20;
            int lenght = 45;
            int productType = 0;
            int materialType = 1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zero_Value_Material_Type() // ������� �������� ���� ���������
        {
            int count = 15;
            int width = 20;
            int lenght = 45;
            int productType = 3;
            int materialType = 0;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zero_Value_Count() // ������� �������� ����������� �������
        {
            int count = 0;
            int width = 20;
            int lenght = 45;
            int productType = 3;
            int materialType = 1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zero_Value_Width() // ������� �������� ������ �������
        {
            int count = 10;
            int width = 0;
            int lenght = 45;
            int productType = 3;
            int materialType = 1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zero_Value_lenght() // ������� �������� ������ �������
        {
            int count = 10;
            int width = 45;
            int lenght = 0;
            int productType = 3;
            int materialType = 1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zero_Value_All() // ������� �������� ������ �������
        {
            int count = 0;
            int width = 0;
            int lenght = 0;
            int productType = 0;
            int materialType = 0;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Negative_Value_all() // ������� �������� ������ �������
        {
            int count = -10;
            int width = -45;
            int lenght = -8;
            int productType = -3;
            int materialType = -1;
            int expected = -1;

            //act
            int actual = Calculation.GetQuantityForProduct(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}