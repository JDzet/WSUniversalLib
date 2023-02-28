namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int count, int width, int lenght, int productType, int materialType) 
        {
            double[] prodTyp = { 1.1, 2.5, 8.43 };
            double[] matType = { 0.3, 0.12 };


            double ret = (count * (width * lenght) * prodTyp[productType - 1]);
            double brak = (ret * (matType[materialType - 1] / 100))+ret;
            ret = Math.Ceiling(brak);
            
            return Convert.ToInt32(ret);
        } 

    }
}