

namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormattedDateIsOkay()
    {
        string actualDate = "11/09/2022";
        string expectedDate = "2022-09-11";

        Assert.AreEqual(expectedDate, DateFormatter.ChangeFormat(actualDate));

    }
    [Test]
    public void FormattedDateIsNotOkay()
    {
        string wrongDate = "2022/09/11";
        string expectedDate = "2022-09-11";

        Assert.IsFalse(expectedDate.Equals(DateFormatter.ChangeFormat(wrongDate)));

    }

    [Test]

    public void FormattedDateIsNullOrEmpty()
    {
        string actualDate = "";

        Assert.IsNull(DateFormatter.ChangeFormat(actualDate));

    }

}