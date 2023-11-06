using CountPathApp;
using System;
using Xunit;

public class CountingPathsTests
{
    [Fact]
    public void CountPath_CountValidPaths_ShouldReturnSix()
    {
        int validPaths = CountPath.CountValidPaths(2, 2);
        Assert.Equal(6, validPaths);
    }

    [Fact]
    public void CountPath_GenerateRoutes_ShouldReturnTrue()
    {
        List<string> routes = CountPath.GenerateRoutes(2, 2);
        List<string> expectedRoutes = new List<string> { "EENN", "ENEN", "ENNE", "NEEN", "NENE", "NNEE" };

        Assert.Equal(expectedRoutes, routes);
    }
    [Fact]
    public void CountPath_GenerateRoutes_ShouldReturnFalse ()
    {
        List<string> routes = CountPath.GenerateRoutes(2, 2);
        List<string> expectedRoutes = new List<string> { "EENN", "ENEN", "ENNE", "NEEN", "NENE", "TEST" };

        Assert.NotEqual(expectedRoutes, routes);
    }

}