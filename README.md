# 🧮 Number Prediction Engine

A simple yet powerful Windows Forms application that predicts numbers using a trained machine learning model. Built with C# and ML.NET, this project demonstrates how to integrate predictive analytics into a user-friendly desktop interface.

---

## 📁 Project Structure

| File           | Description |
|----------------|-------------|
| `Program.cs`     | Entry point of the application. Initializes and runs the main form. |
| `MainForm.cs`    | Windows Form UI for interacting with the prediction engine. |
| `PredictorEngine.cs` | Core logic for loading the ML model and making predictions. |
| `NumberDataModel.cs` | Defines the input and output schema used by the ML model. |

---

## 🚀 Features

- 🔍 Predicts numerical values based on input features
- 🧠 Uses ML.NET for model training and inference
- 🖥️ Simple Windows Forms UI for easy interaction
- 📊 Clean and modular architecture for extensibility

---

## 🛠 Requirements

To run or develop this project, ensure you have:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (recommended)
- ML.NET NuGet packages (`Microsoft.ML`)
- Windows OS (for running WinForms)

---

## 📦 Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/NumberPredictionApp.git
```

2. Navigate to the project directory:
```bash
cd NumberPredictionApp
```

3. Restore dependencies:
```bash
dotnet restore
```

4. Build the project:
```bash
dotnet build
```

5. Run the application:
```bash
dotnet run
```

> Alternatively, open the `.csproj` file in Visual Studio and hit **Start**!

---

## 🧪 Usage

1. Launch the application.
2. Enter the required numerical input(s) in the form fields.
3. Click the **Predict** button.
4. View the predicted result displayed below.

---

## 📈 Example Input Schema

```csharp
public class NumberData
{
    public float Feature1 { get; set; }
    public float Feature2 { get; set; }
}
```

## 💡 Output Schema

```csharp
public class NumberPrediction
{
    public float PredictedValue { get; set; }
}
```

---

## 🧩 Extending the Project

This project is designed to be easily extendable. You can:

- Add more input features
- Integrate different ML models
- Improve the UI layout
- Add data visualization (charts, graphs)

---

## 📝 License

This project is licensed under the MIT License – see the [LICENSE](LICENSE) file for details.

---
