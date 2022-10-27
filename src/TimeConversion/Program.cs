/*
Given a time in

-hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock. 

*/

Console.WriteLine(TimeConversion("12:05:45AM"));

static string TimeConversion(string s)
{
    var ampm = s.Substring(s.Length - 2, 2);
    var hour = s.Substring(0, 2);
    var arr = s.Split(':');

    //Remove AM PM
    arr[2] = arr[2].Substring(0, 2);

    if ("12".Equals(hour) && "am".Equals(ampm.ToLower()))
    {
        arr[0] = "00";
    }

    if (!"12".Equals(hour) && "pm".Equals(ampm.ToLower()))
    {
        arr[0] = (int.Parse(arr[0]) + 12).ToString();
    }

    return string.Join(':', arr);
}