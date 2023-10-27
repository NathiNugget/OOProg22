
public class MysticNumbers
{
    #region Methods
    public int ThreeNumbers(int a, int b, int c)
    {
        int result;

        if (b > a)
        {
            result = b;
            if (c > b)
            {
                result = c;
            }
        }
        else
        {
            result = a;
            if (c > a)
            {
                result = c;
            }
        }

        return result;
    }

    public int TwoNumbers( int a, int b)
    {
        if (b > a)
        {
            return b; 
        }
        return a;
    }

    #endregion
}
