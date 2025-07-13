namespace MoneyExtension;

public static class MoneyExtensions
{
    public static int ToCents(this decimal amount)
    {
        var text = amount
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");

        if (string.IsNullOrEmpty(text))
            return 0;

        int.TryParse(text, out var result);
        return result;
    }
}
