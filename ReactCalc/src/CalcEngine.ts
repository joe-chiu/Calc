export enum CalcKey {
    AC = 0,
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

enum CalcState {
    DisplayResult,
    EnterOp1,
    EnterOp2
}

enum CalcOps {
    None,
    Divide,
    Multiply,
    Minus,
    Add
}

var decimalPlace: number = 0;
var isDecimalPoint: boolean = false;
var state: CalcState = CalcState.DisplayResult;
var opsMode: CalcOps = CalcOps.None;

// null is the error state for divide by zero
var result: number | null = 0;
var op1: number = 0;
// null means op2 has not been entered yet and will display op1
var op2: number | null = null;

interface Dictionary<Type> {
    [key: string]: Type;
}

var numberKeyMap: Dictionary<number> = {
    Zero: 0,
    One: 1,
    Two: 2,
    Three: 3,
    Four: 4,
    Five: 5,
    Six: 6,
    Seven: 7,
    Eight: 8,
    Nine: 9
};

var opsKeyMap: Dictionary<CalcOps> = {
    Add: CalcOps.Add,
    Minus: CalcOps.Minus,
    Multiply: CalcOps.Multiply,
    Divide: CalcOps.Divide,
};

export function processKey(key: CalcKey) {
    if (key === CalcKey.AC) {
        reset();
        return;
    }

    if (state === CalcState.DisplayResult) {
        // when entering op1 or op2 from this state, we should make sure
        // op1 and op2 are in a well defined state
        if (CalcKey[key] in numberKeyMap) {
            state = CalcState.EnterOp1;
            op1 = 0;
            // retain op2
            clearDecimalPointMode();
            updateOperands(key);
        } else if (CalcKey[key] in opsKeyMap) {
            opsMode = opsKeyMap[CalcKey[key]];
            state = CalcState.EnterOp2;
            op1 = result ?? 0;
            op2 = null;
            clearDecimalPointMode();
        }
        else if (key === CalcKey.FlipSign) {
            state = CalcState.EnterOp1;
            op1 = -1 * (result ?? 0);
        }
        else if (key === CalcKey.Percent) {
            state = CalcState.EnterOp1;
            op1 = (result ?? 0) / 100;
        }
        else if (key === CalcKey.Dot) {
            state = CalcState.EnterOp1;
            isDecimalPoint = true;
            decimalPlace = 1;
            op1 = 0;
        }
        // offer this option to keep apply op2 from result
        else if (key === CalcKey.Equal) {
            if (op2 !== null && opsMode !== CalcOps.None) {
                op1 = result ?? 0;
                performOps();
            }
        }
    }
    else if (state === CalcState.EnterOp1) {
        if (CalcKey[key] in numberKeyMap) {
            updateOperands(key);
        } else if (CalcKey[key] in opsKeyMap) {
            opsMode = opsKeyMap[CalcKey[key]];
            state = CalcState.EnterOp2;
            op2 = null;
            clearDecimalPointMode();
        }
        else if (key === CalcKey.FlipSign) {
            op1 *= -1;
        }
        else if (key === CalcKey.Percent) {
            op1 /= 100;
        }
        else if (key === CalcKey.Dot) {
            if (!isDecimalPoint) {
                isDecimalPoint = true;
                decimalPlace = 1;
            }
        }
        else if (key === CalcKey.Equal) {
            if (op2 !== null && opsMode !== CalcOps.None) {
                performOps();
            }
        }
    }
    else if (state === CalcState.EnterOp2) {
        if (CalcKey[key] in numberKeyMap) {
            updateOperands(key);
        }
        else if (key === CalcKey.FlipSign) {
            op2 = (op2 ?? 0) * -1;
        }
        else if (key === CalcKey.Percent) {
            op2 = (op2 ?? 0) / 100;
        }
        else if (key === CalcKey.Dot) {
            if (!isDecimalPoint) {
                isDecimalPoint = true;
                decimalPlace = 1;
            }
        }
        else if (key === CalcKey.Equal) {
            if (op2 != null && opsMode !== CalcOps.None) {
                performOps();
            }
        }
    }
}

export function getDisplay(): string {
    var valueToDisplay: number = 0;
    if (state === CalcState.DisplayResult && result === null) {
        return "ERROR";
    }

    if (state === CalcState.DisplayResult) {
        valueToDisplay = result ?? 0;
    }
    else if (state === CalcState.EnterOp1) {
        valueToDisplay = op1;
    }
    else if (state === CalcState.EnterOp2 && op2 === null) {
        valueToDisplay = op1;
    }
    else if (state === CalcState.EnterOp2 && op2) {
        valueToDisplay = op2;
    }

    return valueToDisplay.toLocaleString("en-US", {maximumFractionDigits: 8});
}

function reset() {
    isDecimalPoint = false;
    decimalPlace = 0;
    state = CalcState.DisplayResult;
    opsMode = CalcOps.None;
    result = 0;
    op1 = 0;
    op2 = null;
}

function updateOperands(key: CalcKey)
{
    var currentValue: number = 0;
    if (state === CalcState.EnterOp1) {
        currentValue = op1;
    }
    else if (state === CalcState.EnterOp2) {
        currentValue = op2 ?? 0;
    }

    if (isDecimalPoint) {
        currentValue += numberKeyMap[CalcKey[key]] / Math.pow(10, decimalPlace);
        decimalPlace++;
    } else {
        currentValue = currentValue * 10 + numberKeyMap[CalcKey[key]];
    }

    if (state === CalcState.EnterOp1) {
        op1 = currentValue;
    }
    else if (state === CalcState.EnterOp2) {
        op2 = currentValue;
    }
}

function performOps()
{
    state = CalcState.DisplayResult;
    if (opsMode === CalcOps.Add) {
        result = op1 + (op2 ?? 0);
    }
    else if (opsMode === CalcOps.Minus) {
        result = op1 - (op2 ?? 0);
    }
    else if (opsMode === CalcOps.Multiply) {
        result = op1 * (op2 ?? 0);
    }
    else if (opsMode === CalcOps.Divide) {
        if (op2 === null || op2 === 0) {
            // divide by zero error state
            result = null;
        }
        else {
            result = op1 / (op2 ?? 0);
        }
    }
}

function clearDecimalPointMode()
{
    isDecimalPoint = false;
    decimalPlace = 0;
}
