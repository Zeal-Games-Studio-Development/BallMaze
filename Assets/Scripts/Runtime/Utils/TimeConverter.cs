namespace ZealMVC.Runtime.Utils
{
    public struct TimeConverter
    {
        public static (int, int) ToMinutesSeconds (float input)
        {
            int total = (int)input;
            int minutes = total / 60;
            int seconds = total % 60;
            return (minutes, seconds);
        }
    }
}
