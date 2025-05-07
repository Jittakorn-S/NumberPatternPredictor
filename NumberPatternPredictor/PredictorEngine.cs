using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;

public class PredictorEngine
{
    private readonly MLContext _mlContext;

    public PredictorEngine()
    {
        _mlContext = new MLContext();
    }

    // --- AI Prediction (ML.NET Sdca Regression) ---
    public float PredictWithAI(List<int> numbers)
    {
        var data = new List<NumberData>();
        for (int i = 10; i < numbers.Count; i++)
        {
            var features = numbers.Skip(i - 10).Take(10).Select(n => (float)n).ToArray();
            if (features.Length != 10) continue;

            data.Add(new NumberData
            {
                Label = (float)numbers[i],
                Features = features
            });
        }

        if (!data.Any()) return -1;

        var dataView = _mlContext.Data.LoadFromEnumerable(data);

        var pipeline = _mlContext.Transforms.Concatenate("Features", "Features")
            .Append(_mlContext.Transforms.NormalizeMinMax("Features"));

        var trainer = _mlContext.Regression.Trainers.Sdca(labelColumnName: "Label", featureColumnName: "Features");
        var trainingPipeline = pipeline.Append(trainer);

        var trainedModel = _mlContext.Model.CreatePredictionEngine<NumberData, RegressionPrediction>(trainingPipeline.Fit(dataView));

        var last10 = numbers.Skip(Math.Max(0, numbers.Count - 10)).Take(10).Select(n => (float)n).ToArray();
        var prediction = trainedModel.Predict(new NumberData { Features = last10 });

        return prediction.Score;
    }
}