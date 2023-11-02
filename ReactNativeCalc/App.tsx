import { StatusBar } from "expo-status-bar";
import { useState } from "react";
import { Pressable, StyleSheet, Text, SafeAreaView, View, Dimensions } from "react-native";
import { getDisplay, processKey, CalcKey } from "./CalcEngine";

var display: string;
var setDisplay: React.Dispatch<React.SetStateAction<string>>;

function renderItem(item: CalcButton): JSX.Element {
  return (
    <Pressable
      style={[styles.pressable, 
        item.style == StylingOverride.Top ? stylesTop.pressable : {},
        item.style == StylingOverride.Right ? stylesRight.pressable : {},
        item.style == StylingOverride.Zero ? stylesZero.pressable : {}
      ]}
      onPress={() => {
        processKey(item.key);
        setDisplay(getDisplay());
      }}
      key={item.text}
    >
        <Text 
          style={[styles.pressableText,
            item.style == StylingOverride.Top ? stylesTop.pressableText : {}
          ]}
          allowFontScaling={true}
          adjustsFontSizeToFit={true}
          numberOfLines={1}
          >{item.text}</Text>
    </Pressable>
  );
}

export default function App() {
  [display, setDisplay] = useState(getDisplay());

  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.displayContainer}>
        <Text style={styles.display}>{display}</Text>
      </View>
      <View style={styles.buttonsContainer}>
        {
          buttons.map(button => renderItem(button))
        }
      </View>
      <StatusBar style="auto" />
      <View style={styles.footer} />
    </SafeAreaView>
  );
}

const buttonSize = (Dimensions.get("window").width * 0.8) / 4;
const displaySize = (Dimensions.get("window").height * 0.9) * 0.15;

const styles = StyleSheet.create({
  container: {
    flexDirection: "column",
    backgroundColor: "black"
  },
  displayContainer: {
    height: displaySize * 2.2,
    justifyContent: "flex-end"
  },
  display: {
    fontSize: displaySize,
    color: "white",
    textAlign: "right",
    marginHorizontal: 20
  },
  buttonsContainer: {
    marginTop: 10,
    flexDirection: "row",
    flexWrap: "wrap",
    justifyContent: "space-evenly"
  },
  pressable: {
    alignItems: "center",
    width: buttonSize,
    height: buttonSize,
    backgroundColor: "dimgrey",
    margin: 5,
    // max radius
    borderRadius: buttonSize,
    justifyContent: "space-evenly"
  },
  pressableText: {
    fontSize: buttonSize * 0.6,
    color: "white"
  },
  footer: {
    // extra long
    height: displaySize * 5
  },
});

const stylesTop = StyleSheet.create({
  pressable: {
    backgroundColor: "lightgrey",
  },
  pressableText: {
    color: "black"
  }
});

const stylesRight = StyleSheet.create({
  pressable: {
    backgroundColor: "orange",
  }
});

const stylesZero = StyleSheet.create({
  pressable: {
    // plus margin * 2
    width: buttonSize * 2 + 10
  }
});

interface CalcButton {
  text: string
  key: CalcKey
  style?: StylingOverride
}

enum StylingOverride {
  Top,
  Right,
  Zero
}

const buttons: CalcButton[] = [
  { text: "AC", key: CalcKey.AC, style: StylingOverride.Top },
  { text: "+/-", key: CalcKey.FlipSign, style: StylingOverride.Top },
  { text: "%", key: CalcKey.Percent, style: StylingOverride.Top },
  { text: "/", key: CalcKey.Divide, style: StylingOverride.Right },
  { text: "7", key: CalcKey.Seven },
  { text: "8", key: CalcKey.Eight },
  { text: "9", key: CalcKey.Nine },
  { text: "*", key: CalcKey.Multiply, style: StylingOverride.Right },
  { text: "4", key: CalcKey.Four },
  { text: "5", key: CalcKey.Five },
  { text: "6", key: CalcKey.Six },
  { text: "-", key: CalcKey.Minus, style: StylingOverride.Right },
  { text: "1", key: CalcKey.One },
  { text: "2", key: CalcKey.Two },
  { text: "3", key: CalcKey.Three },
  { text: "+", key: CalcKey.Add, style: StylingOverride.Right },
  { text: "0", key: CalcKey.Zero, style: StylingOverride.Zero },
  { text: ".", key: CalcKey.Dot },
  { text: "=", key: CalcKey.Equal, style: StylingOverride.Right }
];
