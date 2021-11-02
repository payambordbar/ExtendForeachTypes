namespace ExtendForeachTypes;

public static class GetEnumeratorExtensions
{
    public static IEnumerator<int> GetEnumerator(this int number)
    {
        if (number >= 0)
        {
            for (int i = 0; i < number; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (int i = number; i < 0; i++)
            {
                yield return i;
            }
        }
    }

    public static IEnumerator<int> GetEnumerator(this (int start, int end) range)
    {
        if (range.end >= range.start)
        {
            for (int i = range.start; i < range.end; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (int i = range.start; i > range.end; i--)
            {
                yield return i;
            }
        }
    }

    public static IEnumerator<int> GetEnumerator(this (int start, int end, int step) range)
    {
        if (range.step <= 0) throw new ArgumentOutOfRangeException(nameof(range.step));

        if (range.end >= range.start)
        {
            for (int i = range.start; i < range.end; i += range.step)
            {
                yield return i;
            }
        }
        else
        {
            for (int i = range.start; i > range.end; i -= range.step)
            {
                yield return i;
            }
        }
    }

    public static IEnumerator<int> GetEnumerator(this Range range)
    {
        if (range.Start.IsFromEnd || range.End.IsFromEnd) throw new NotSupportedException();
        if (range.End.Value >= range.Start.Value)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (int i = range.Start.Value; i > range.End.Value; i--)
            {
                yield return i;
            }
        }
    }

    public static IEnumerator<char> GetEnumerator(this (char start, char end) range)
    {

        if (range.end >= range.start)
        {
            for (char i = range.start; i < range.end; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (char i = range.start; i > range.end; i--)
            {
                yield return i;
            }
        }
    }
}
