using exercises;

namespace tests;

public class QuestionTest
{
    [Fact]
    public void OneShouldReturnFalse()
    {
        Assert.False(Question.One());
    }
    
    [Fact]
    public void TwoShouldReturnDotnet()
    {
        Assert.Equal(".NET", Question.Two());
    }
}