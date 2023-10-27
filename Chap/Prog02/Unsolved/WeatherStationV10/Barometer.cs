/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public string WeatherDescription
    {
        get
        {
            if (Pressure < 980)
            {
                return "Stormy"; 
            }
            else if (980 <= Pressure && Pressure <= 1000)
            {
                return "Rainy"; 
            }
            else if (Pressure >= 1000 && Pressure <= 1020)
            {
                return "Changing"; 
            }
            else if (Pressure >= 1020 &&  Pressure <= 1040)
            {
                return "Fair"; 
            }
            else if (Pressure > 1040)
            {
                return "Very dry"; 
            }
            return "Weather is extreme right now"; 
        }
    }
    #endregion

    #region Constructor
    public Barometer(int i)
    {
        Pressure = i;
    }
    #endregion
}
