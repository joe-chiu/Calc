using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEngineNet
{
    internal enum CalcState
    {
        /// <summary>
        /// Initial state and the state after ops are committed
        /// </summary>
        DisplayResult,
        /// <summary>
        /// Entering operand 1
        /// </summary>
        EnterOp1,
        /// <summary>
        /// Entering operand 2
        /// </summary>
        EnterOp2
    }

    /// <summary>
    /// These operations requirs a second operand to be entered
    /// </summary>
    internal enum CalcOps
    {
        None,
        Divide,
        Multiply,
        Minus,
        Add
    }

    public enum CalcKey
    {
        AC,
        FlipSign,
        Percent,
        Divide,
        Multiply,
        Minus,
        Add,
        Equal,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Zero,
        Dot
    }

    public class CalcEngine : INotifyPropertyChanged
    {
        // 0 => 0, 1 => 0.1, 2 => 0.01, etc
        private int decimalPlace = 0;
        private bool isDecimalPoint = false;
        private CalcState state = CalcState.DisplayResult;
        private CalcOps opsMode = CalcOps.None;

        // null is the error state for divide by zero
        private double? result = 0;
        private double op1 = 0;
        private double? op2 = null;

        private Dictionary<CalcKey, int> numberKeyMap = new Dictionary<CalcKey, int>()
        {
            { CalcKey.Zero, 0 },
            { CalcKey.One, 1 },
            { CalcKey.Two, 2 },
            { CalcKey.Three, 3 },
            { CalcKey.Four, 4 },
            { CalcKey.Five, 5 },
            { CalcKey.Six, 6 },
            { CalcKey.Seven, 7 },
            { CalcKey.Eight, 8 },
            { CalcKey.Nine, 9 }
        };

        private Dictionary<CalcKey, CalcOps> opsKeyMap = new Dictionary<CalcKey, CalcOps>()
        {
            { CalcKey.Add, CalcOps.Add },
            { CalcKey.Minus, CalcOps.Minus },
            { CalcKey.Multiply, CalcOps.Multiply },
            { CalcKey.Divide, CalcOps.Divide }
        };

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Result
        {
            get 
            {
                return this.GetDisplay();
            }
        }

        public void ProcessKey(CalcKey key)
        {
            if (key == CalcKey.AC)
            {
                Reset();
                return;
            }

            if (state == CalcState.DisplayResult)
            {
                // when entering op1 or op2 from this state, we should make sure
                // op1 and op2 are in a well defined state
                if (numberKeyMap.Keys.Contains(key))
                {
                    state = CalcState.EnterOp1;
                    this.op1 = 0;
                    // retain op2
                    this.ClearDecimalPointMode();
                    this.UpdateOperands(key);
                }
                else if (opsKeyMap.Keys.Contains(key))
                {
                    opsMode = opsKeyMap[key];
                    state = CalcState.EnterOp2;
                    this.op1 = this.result ?? 0;
                    this.op2 = null;
                    this.ClearDecimalPointMode();
                }
                else if (key == CalcKey.FlipSign)
                {
                    state = CalcState.EnterOp1;
                    this.op1 = -1 * (this.result ?? 0); 
                }
                else if (key == CalcKey.Percent)
                {
                    state = CalcState.EnterOp1;
                    this.op1 = (this.result ?? 0) / 100;
                }
                else if (key == CalcKey.Dot)
                {
                    state = CalcState.EnterOp1;
                    this.isDecimalPoint = true;
                    this.decimalPlace = 1;
                    this.op1 = 0;
                }
                // offer this option to keep apply op2 from result
                else if (key == CalcKey.Equal)
                {
                    if (op2 != null && opsMode != CalcOps.None)
                    {
                        this.op1 = this.result ?? 0;
                        this.PerformOps();
                    }
                }
            }
            else if (state == CalcState.EnterOp1)
            {
                if (numberKeyMap.Keys.Contains(key))
                {
                    this.UpdateOperands(key);
                }
                else if (opsKeyMap.Keys.Contains(key))
                {
                    opsMode = opsKeyMap[key];
                    state = CalcState.EnterOp2;
                    this.op2 = null;
                    this.ClearDecimalPointMode();
                }
                else if (key == CalcKey.FlipSign)
                {
                    this.op1 *= -1;
                }
                else if (key == CalcKey.Percent)
                {
                    this.op1 /= 100;
                }
                else if (key == CalcKey.Dot)
                {
                    if (!this.isDecimalPoint)
                    {
                        this.isDecimalPoint = true;
                        this.decimalPlace = 1;
                    }
                }
                else if (key == CalcKey.Equal)
                {
                    if (op2 != null && opsMode != CalcOps.None)
                    {
                        this.PerformOps();
                    }
                }
            }
            else if (state == CalcState.EnterOp2)
            {
                if (numberKeyMap.Keys.Contains(key))
                {
                    this.UpdateOperands(key);
                }
                else if (key == CalcKey.FlipSign)
                {
                    this.op2 *= -1;
                }
                else if (key == CalcKey.Percent)
                {
                    this.op2 /= 100;
                }
                else if (key == CalcKey.Dot)
                {
                    if (!this.isDecimalPoint)
                    {
                        this.isDecimalPoint = true;
                        this.decimalPlace = 1;
                    }
                }
                else if (key == CalcKey.Equal)
                {
                    if (op2 != null && opsMode != CalcOps.None)
                    {
                        this.PerformOps();
                    }
                }
            }

            // this interface allows the result to be cleanly data bound to UI controls
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(this.Result)));
            }
        }

        public string GetDisplay()
        {
            double valueToDisplay;
            if (state == CalcState.DisplayResult && result == null)
            {
                return "ERROR";
            }

            if (state == CalcState.DisplayResult)
            {
                valueToDisplay = result ?? 0;
            }
            else if (state == CalcState.EnterOp1)
            {
                valueToDisplay = op1;
            }
            else if (state == CalcState.EnterOp2 && this.op2 == null)
            {
                valueToDisplay = op1;
            }
            else if (state == CalcState.EnterOp2 && this.op2.HasValue)
            {
                valueToDisplay = op2.Value;
            }
            else
            {
                throw new InvalidOperationException($"unknown state {state}");
            }

            if (double.IsInteger(valueToDisplay))
            {               
                return valueToDisplay.ToString("N0", CultureInfo.InvariantCulture) + 
                    (this.isDecimalPoint ? "." : "");
            }
            else
            {
                return valueToDisplay.ToString("N10", CultureInfo.InvariantCulture).TrimEnd('0');
            }
        }

        public void Reset()
        {
            isDecimalPoint = false;
            decimalPlace = 0;
            state = CalcState.DisplayResult;
            opsMode = CalcOps.None;
            result = 0;
            op1 = 0;
            op2 = null;
        }

        private void UpdateOperands(CalcKey key)
        {
            double currentValue = 0;
            if (state == CalcState.EnterOp1)
            {
                currentValue = this.op1;
            }
            else if (state == CalcState.EnterOp2)
            {
                currentValue = this.op2 ?? 0;
            }
            else
            {
                throw new InvalidOperationException($"unexpected state {state}");
            }

            if (this.isDecimalPoint)
            {
                currentValue += numberKeyMap[key] / Math.Pow(10, this.decimalPlace);
                this.decimalPlace++;
            }
            else
            {
                currentValue = currentValue * 10 + numberKeyMap[key];
            }

            if (state == CalcState.EnterOp1)
            {
                this.op1 = currentValue;
            }
            else if (state == CalcState.EnterOp2)
            {
                this.op2 = currentValue;
            }
        }

        private void PerformOps()
        {            
            state = CalcState.DisplayResult;
            if (opsMode == CalcOps.Add)
            {
                this.result = this.op1 + (this.op2 ?? 0);
            }
            else if (opsMode == CalcOps.Minus)
            {
                this.result = this.op1 - (this.op2 ?? 0);
            }
            else if (opsMode == CalcOps.Multiply)
            {
                this.result = this.op1 * (this.op2 ?? 0);
            }
            else if (opsMode == CalcOps.Divide)
            {
                if (this.op2 == null || this.op2 == 0)
                {
                    // divide by zero error state
                    this.result = null;
                }
                else
                {
                    this.result = this.op1 / (this.op2 ?? 0);
                }
            }
            else
            {
                throw new InvalidOperationException($"unknown or no ops: {opsMode}");
            }
        }

        private void ClearDecimalPointMode()
        {
            this.isDecimalPoint = false;
            this.decimalPlace = 0;
        }
    }
}
