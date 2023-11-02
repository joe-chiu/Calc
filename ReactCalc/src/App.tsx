import React from 'react';
import './App.css';
import { CalcKey, getDisplay, processKey } from './CalcEngine';

function App() {
    const [display, setDisplay] = React.useState(getDisplay());

    function handleClick(key: CalcKey) {
        processKey(key);
        setDisplay(getDisplay());
    }

    return (
        <div className="App">
            <div className="container">
                <div className="item itemNumber">
                    <input value={display} />
                </div>
                <div className="item itemTop">
                    <button onClick={() => handleClick(CalcKey.AC)}>AC</button>
                </div>
                <div className="item itemTop">
                    <button onClick={() => handleClick(CalcKey.FlipSign)}>+/-</button>
                </div>
                <div className="item itemTop">
                    <button onClick={() => handleClick(CalcKey.Percent)}>%</button>
                </div>
                <div className="item itemOps">
                    <button onClick={() => handleClick(CalcKey.Divide)}>/</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Seven)}>7</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Eight)}>8</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Nine)}>9</button>
                </div>
                <div className="item itemOps">
                    <button onClick={() => handleClick(CalcKey.Multiply)}>*</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Four)}>4</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Five)}>5</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Six)}>6</button>
                </div>
                <div className="item itemOps">
                    <button onClick={() => handleClick(CalcKey.Minus)}>-</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.One)}>1</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Two)}>2</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Three)}>3</button>
                </div>
                <div className="item itemOps">
                    <button onClick={() => handleClick(CalcKey.Add)}>+</button>
                </div>
                <div className="item itemNum itemZero">
                    <button onClick={() => handleClick(CalcKey.Zero)}>0</button>
                </div>
                <div className="item itemNum">
                    <button onClick={() => handleClick(CalcKey.Dot)}>.</button>
                </div>
                <div className="item itemOps">
                    <button onClick={() => handleClick(CalcKey.Equal)}>=</button>
                </div>
            </div>
        </div>
    );
}

export default App;
