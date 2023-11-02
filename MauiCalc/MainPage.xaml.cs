using CalcEngineNet;

namespace MauiCalc;

public partial class MainPage : ContentPage
{
	CalcEngine engine = null;
	Dictionary<Button, CalcKey> buttonKeyMapping = new Dictionary<Button, CalcKey>();
	public MainPage()
	{
		InitializeComponent();
		engine = new CalcEngine();

        numberEntry.Text = engine.GetDisplay();

        buttonKeyMapping[this.clearBtn] = CalcKey.AC;
        buttonKeyMapping[this.FlipSignBtn] = CalcKey.FlipSign;
        buttonKeyMapping[this.PercentBtn] = CalcKey.Percent;
        buttonKeyMapping[this.DivideBtn] = CalcKey.Divide;
        buttonKeyMapping[this.SevenBtn] = CalcKey.Seven;
        buttonKeyMapping[this.EightBtn] = CalcKey.Eight;
        buttonKeyMapping[this.NineBtn] = CalcKey.Nine;
        buttonKeyMapping[this.MultiplyBtn] = CalcKey.Multiply;
        buttonKeyMapping[this.FourBtn] = CalcKey.Four;
        buttonKeyMapping[this.FiveBtn] = CalcKey.Five;
        buttonKeyMapping[this.SixBtn] = CalcKey.Six;
        buttonKeyMapping[this.MinusBtn] = CalcKey.Minus;
        buttonKeyMapping[this.OneBtn] = CalcKey.One;
        buttonKeyMapping[this.TwoBtn] = CalcKey.Two;
        buttonKeyMapping[this.ThreeBtn] = CalcKey.Three;
        buttonKeyMapping[this.PlusBtn] = CalcKey.Add;
        buttonKeyMapping[this.ZeroBtn] = CalcKey.Zero;
        buttonKeyMapping[this.DotBtn] = CalcKey.Dot;
        buttonKeyMapping[this.EqualBtn] = CalcKey.Equal;
    }

    private void OnButtonClicked(object sender, EventArgs e)
	{
        Button key = sender as Button;
        if (key != null && buttonKeyMapping.ContainsKey(key))
        {
            engine.ProcessKey(buttonKeyMapping[key]);
            numberEntry.Text = engine.GetDisplay();
        }
    }
}

