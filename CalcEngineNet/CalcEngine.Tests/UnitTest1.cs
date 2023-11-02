using NUnit.Framework;
using CalcEngineNet;

public class Tests
{
    private CalcEngine engine;

    [SetUp]
    public void Setup()
    {
        engine = new CalcEngine();
    }

    [Test]
    public void InitialDisplay()
    {
        Assert.AreEqual("0", engine.GetDisplay());
    }

    [Test]
    public void InitialDisplayDot()
    {
        engine.ProcessKey(CalcKey.Dot);
        Assert.AreEqual("0.", engine.GetDisplay());
    }

    [Test]
    public void NumberKeys()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Zero);
        Assert.AreEqual("10", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Five);
        Assert.AreEqual("105", engine.GetDisplay());
    }

    [Test]
    public void AddOp()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Zero);
        Assert.AreEqual("10", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Add);
        Assert.AreEqual("10", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Seven);
        Assert.AreEqual("7", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("17", engine.GetDisplay());
    }

    [Test]
    public void MinusOp()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Four);
        Assert.AreEqual("4", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Eight);
        Assert.AreEqual("48", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Minus);
        Assert.AreEqual("48", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Seven);
        Assert.AreEqual("7", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("41", engine.GetDisplay());
    }

    [Test]
    public void MultiplyOp()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Nine);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Multiply);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Seven);
        Assert.AreEqual("7", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("63", engine.GetDisplay());
    }

    [Test]
    public void DivideOpInteger()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Eight);
        Assert.AreEqual("8", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Divide);
        Assert.AreEqual("8", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Four);
        Assert.AreEqual("4", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("2", engine.GetDisplay());
    }

    [Test]
    public void DivideOpDecimal()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Nine);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Divide);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Four);
        Assert.AreEqual("4", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("2.25", engine.GetDisplay());
    }

    [Test]
    public void DivideByZero()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Five);
        Assert.AreEqual("5", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Divide);
        Assert.AreEqual("5", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Zero);
        Assert.AreEqual("0", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("ERROR", engine.GetDisplay());
    }

    [Test]
    public void AddOpContinueEqual()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Add);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Two);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("5", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("7", engine.GetDisplay());
    }

    [Test]
    public void MinusOpContinueEqual()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("11", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Minus);
        Assert.AreEqual("11", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Two);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("7", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("5", engine.GetDisplay());
    }

    [Test]
    public void MultiplyOpContinueEqual()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Multiply);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Five);
        Assert.AreEqual("5", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("15", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("75", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("375", engine.GetDisplay());
    }

    [Test]
    public void DivideOpContinueEqual()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Two);
        Assert.AreEqual("12", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Divide);
        Assert.AreEqual("12", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Two);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("6", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("1.5", engine.GetDisplay());
    }

    [Test]
    public void ConsequtiveOps()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Five);
        Assert.AreEqual("5", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Add);
        Assert.AreEqual("5", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("8", engine.GetDisplay());
        // plus
        engine.ProcessKey(CalcKey.Add);
        Assert.AreEqual("8", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Two);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("10", engine.GetDisplay());
        // minus
        engine.ProcessKey(CalcKey.Minus);
        Assert.AreEqual("10", engine.GetDisplay());
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("9", engine.GetDisplay());
        // multiply
        engine.ProcessKey(CalcKey.Multiply);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Two);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("18", engine.GetDisplay());
        // divide
        engine.ProcessKey(CalcKey.Divide);
        Assert.AreEqual("18", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("6", engine.GetDisplay());
    }

    [Test]
    public void DisplayResultsEqual()
    {
        engine.Reset();
        Assert.AreEqual("0", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("0", engine.GetDisplay());
    }

    [Test]
    public void Op1Equal()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.Nine);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Divide);
        Assert.AreEqual("9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Six);
        Assert.AreEqual("6", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        // reuse op2 and ops mode from last calculation
        Assert.AreEqual("2", engine.GetDisplay());
    }

    [Test]
    public void DisplayResultFlipSign()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("-2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("2", engine.GetDisplay());
    }

    [Test]
    public void Op1FlipSign()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("-1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("-1", engine.GetDisplay());
    }

    [Test]
    public void Op2FlipSign()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("-3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.FlipSign);
        Assert.AreEqual("-3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("-2", engine.GetDisplay());
    }

    [Test]
    public void DisplayResultPercent()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("2", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Percent);
        Assert.AreEqual("0.02", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Percent);
        Assert.AreEqual("0.0002", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.Five);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("5.0002", engine.GetDisplay());
    }

    [Test]
    public void Op1Percent()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Percent);
        Assert.AreEqual("0.01", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Percent);
        Assert.AreEqual("0.0001", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Multiply);
        engine.ProcessKey(CalcKey.Five);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("0.0005", engine.GetDisplay());
    }

    [Test]
    public void Op2Percent()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Percent);
        Assert.AreEqual("0.03", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Percent);
        Assert.AreEqual("0.0003", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("1.0003", engine.GetDisplay());
    }

    [Test]
    public void DisplayResultDot()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.Six);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("7", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Dot);
        Assert.AreEqual("0.", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Six);
        Assert.AreEqual("0.6", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.Five);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("5.6", engine.GetDisplay());
    }

    [Test]
    public void Op1Dot()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        Assert.AreEqual("1", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Dot);
        Assert.AreEqual("1.", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Nine);
        Assert.AreEqual("1.9", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Minus);
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("0.9", engine.GetDisplay());
    }

    [Test]
    public void Op2Dot()
    {
        engine.Reset();
        engine.ProcessKey(CalcKey.One);
        engine.ProcessKey(CalcKey.Add);
        engine.ProcessKey(CalcKey.Three);
        Assert.AreEqual("3", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Dot);
        Assert.AreEqual("3.", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Seven);
        Assert.AreEqual("3.7", engine.GetDisplay());
        engine.ProcessKey(CalcKey.Equal);
        Assert.AreEqual("4.7", engine.GetDisplay());
    }
}