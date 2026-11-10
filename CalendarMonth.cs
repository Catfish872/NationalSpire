namespace NationalSpire;

internal static class CalendarMonth
{
    internal const int Slots = 35;
    private static DateOnly First(DateOnly date) => new(date.Year,date.Month,1);
    private static int Offset(DateOnly first) => ((int)first.DayOfWeek + 6) % 7;
    private static bool MoveFirstWeek(DateOnly first)
    {
        int offset=Offset(first);
        int spill=offset+DateTime.DaysInMonth(first.Year,first.Month)-Slots;
        return spill>0 && 7-offset<spill;
    }

    internal static DateOnly GridStart(DateOnly month)
    {
        var first=First(month);
        return first.AddDays(-Offset(first)+(MoveFirstWeek(first) ? 7 : 0));
    }

    // A partial sixth week belongs to one page. On a tie keep the beginning of the month.
    internal static DateOnly Owner(DateOnly date)
    {
        var first=First(date);
        int index=date.DayNumber-GridStart(first).DayNumber;
        return index<0 ? first.AddMonths(-1) : index>=Slots ? first.AddMonths(1) : first;
    }

    internal static int Distance(DateOnly from,DateOnly to) => (to.Year-from.Year)*12+to.Month-from.Month;
}
