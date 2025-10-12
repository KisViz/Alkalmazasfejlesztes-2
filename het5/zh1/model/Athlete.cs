using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;

namespace zh1.model
{
    public class SafeInt32Converter : Int32Converter
    {
        public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (int.TryParse(text, out var variable))
            {
                return variable;
            }

            return 0;
        }
    }
    internal class Athlete
    {
        //        ID,Name,Sex,Age,Height,Weight,Nationality
        //        1,A Dijiang, M,24,180,80, CHN
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public int Age { get; set; }

        [TypeConverter(typeof(SafeInt32Converter))]
        public int Height { get; set; }
        public int Weight { get; set; }
        public string? Nationality { get; set; }
    }
}
