namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(cents, 27998);
    }
}
