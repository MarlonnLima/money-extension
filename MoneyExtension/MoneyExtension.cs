namespace MoneyExtension;

public static class MoneyExtensions
{
    public static int ToCents(this decimal amount)
    {
        var value = amount
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");

        if (string.IsNullOrEmpty(value))
            return 0;

        int.TryParse(value, out var result);
        return result;
    }
}
