using Microsoft.ML.Data;

public class NumberData
{
    public float Label { get; set; }

    [VectorType(10)]
    public float[] Features { get; set; }
}

public class RegressionPrediction
{
    [ColumnName("Score")]
    public float Score { get; set; }
}