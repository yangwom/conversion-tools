using Xunit;
using FluentAssertions;
using conversion_tools;
using System;

namespace conversion_tools.Test;

public class TestFirstRequirement{
    [Theory]
    [InlineData("1", 1)]
    public void TestConvertStrToInt(string entry, int expected)
    {
        var instance = new ConversionTools();
        
        instance.strVariable = entry;
    

        instance.ConvertStrToInt();

        instance.intVariable.Should().Be(expected);


    
    }
}

public class TestSecondRequirement{
    [Theory]
    [InlineData("1.0", 1.0)]
    public void TestConvertStrToDouble(string entry, double expected)
    {
       var instace = new ConversionTools;

       instace.strVariable = entry;

       instace.ConvertStrToDouble();

       instace.doubleVariable.Should().Be(expected);
    }
}

public class TestThirdRequirement{
    [Theory]
    [InlineData(1, "1")]
    public void TestConvertIntToStr(int entry, string expected)
    {
        throw new NotImplementedException();
    }
}

public class TestFourthRequirement{
    [Theory]
    [InlineData(4.1, "4.1")]
    public void TestConvertDoubleToStr(double entry, string expected)
    {
        throw new NotImplementedException();
    }
}
