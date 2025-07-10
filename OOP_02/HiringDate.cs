namespace OOP_02
{
    #region Q2
    /*2.	Develop a Class to represent the Hiring Date Data:
    ⮚      consisting of fields to hold the day, month and Years.
    */

    public class HiringDate
    {

        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }


    }
    #endregion
}
