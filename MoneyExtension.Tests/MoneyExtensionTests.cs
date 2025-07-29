namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToCents()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(cents, 27998);
    }
}
