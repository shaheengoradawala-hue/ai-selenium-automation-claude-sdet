public class BaseTest
{
    protected IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = DriverFactory.InitDriver();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
