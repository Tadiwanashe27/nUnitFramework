namespace FrameworkBuilding;

public class Tests1
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test] 
    public void Test2()
    {
        Assert.Fail();
    }
}
