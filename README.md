# Calc
This is a client UX framework learning exercise for myself where I built a simple Calculator modeled after iPhone's built in calculator using various .Net and web-based UI frameworks. Building the same exact app across different frameworks allowed me to compare their ease of use and how soon I get to the same desired results. I also use this to compare the development experience using Visual Studio 2022 (WinForms and MAUI) and Visual Studio Code (the rest).
* C# calc engine: using a simple 3-state state machine to model the simple calculator input and result output flow. The use of the state machine made the code easier to understand and easier to debug and ensure correctness.
* Typescript calc engine: a simple port of the C# version, the similarity between the two languages made it very easy to port. A future topic of investigation is how to transpile C# business logic directly into something typescript can consume.
* Console Calculator: A good test on the versatility of the calc engine.
* .Net MAUI: the latest in the modern .Net XAML-based UI framework, now crossplatform. I tested on Windows as I don't have a Mac HW new enough to run the Mac port.
* .Net WinForms: an old favorite UI framework of mine. C# + WinForms is the closest proximation to the beloved Visual Basic development experience. But the layout is really clunky comparing to markup based methods. It took more efforts to make the UI scale correctly to windows sizes.
* React: very simple React app, and HTML5 + CSS is really enjoyable and very easy to get expected results.
* React Native: it works great but only if you work within its sweet spot. My experience was that the UI code (such as component layout and styling attributes) often don't work as you would expect in the first try. You could fall back to its extensive community and good documentaion to find out how to accomplish the desired results. There is inherent impedance mismatch between the often more expressive web styling and native UI compoennt capabilities, so there is a long list of things that you can express but don't actually work. CSS is so familiar yet there are many gotcha that "it only works if you do it this specific way". That said, using Expo + hot reload on real device is such a pleasant and frictionless dev experience.

# WinForm Calc
<img width="183" alt="image" src="https://github.com/joe-chiu/Calc/assets/14063642/71b260f2-820c-4ce9-afde-2994484844cc">

# MAUI Calc
<img width="219" alt="image" src="https://github.com/joe-chiu/Calc/assets/14063642/081e0648-1213-478d-b564-1cd0ca8fb582">

# React Calc
<img width="218" alt="image" src="https://github.com/joe-chiu/Calc/assets/14063642/254df694-5e3c-4f10-bdbe-9c08c9c04cc2">

# React Native (running on iOS)
<img width="220" alt="image" src="https://github.com/joe-chiu/Calc/assets/14063642/d6d57cbf-18d7-41de-9d48-f6d48f8fee30">
