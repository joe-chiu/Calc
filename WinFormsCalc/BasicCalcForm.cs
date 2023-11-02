using CalcEngineNet;

namespace WinFormsCalc;

public partial class BasicCalcForm : Form
{
    private CalcEngine engine;

    public BasicCalcForm()
    {
        InitializeComponent();
        engine = new CalcEngine();
        richTextBox1.DataBindings.Add(
            nameof(richTextBox1.Text), engine, nameof(engine.Result));
    }

    private void button1_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.AC);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.FlipSign);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Percent);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Divide);
    }

    private void button8_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Seven);
    }

    private void button7_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Eight);
    }

    private void button6_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Nine);
    }

    private void button5_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Multiply);
    }

    private void button12_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Four);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Five);
    }

    private void button10_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Six);
    }

    private void button9_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Minus);
    }

    private void button16_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.One);
    }

    private void button15_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Two);
    }

    private void button14_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Three);
    }

    private void button13_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Add);
    }

    private void button20_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Zero);
    }

    private void button18_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Dot);
    }

    private void button17_Click(object sender, EventArgs e)
    {
        engine.ProcessKey(CalcKey.Equal);
    }
}
