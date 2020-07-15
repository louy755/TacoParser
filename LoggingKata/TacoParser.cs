using System;
using System.IO;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');
           
            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("Info is less then the require Please try again later", exception: null);
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            //Done grab the latitude from your array at index 0
            var lat = double.Parse(cells[0]);
            //Done grab the longitude from your array at index 1
            var lon = double.Parse(cells[1]);
            //Done grab the name from your array at index 2
            var locName = cells[2];

            //Done  Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            //Done You'll need to create a TacoBell class

            //Done that conforms to ITrackable

            // With the name and point set correctly
            var newPoint = new Point();
            newPoint.Latitude = lat;
            newPoint.Longitude = lon;

            //Done Then, you'll need an instance of the TacoBell class
            var locAdd = new TacoBell();
            locAdd.Name = locName;
            locAdd.Location = newPoint;
            

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return locAdd;
        }

        public static double ConvertToMiles(double distance)
        {
            return Math.Round(distance / 1609.34, 2);
        }
    }
}