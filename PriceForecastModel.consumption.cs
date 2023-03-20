﻿// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.ML.Transforms.TimeSeries;

namespace NodeBlock_Plugin_MachineLearning
{
    public partial class PriceForecastModel
    {
        /// <summary>
        /// model input class for PriceForecastModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"Price")]
            public float Price { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for PriceForecastModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Price")]
            public float[] Price { get; set; }

            [ColumnName(@"Price_LB")]
            public float[] Price_LB { get; set; }

            [ColumnName(@"Price_UB")]
            public float[] Price_UB { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath(@"H:\Projects\GraphLinq\GraphLinq.MachineLearning\PriceForecastModel.zip");

        public static readonly Lazy<TimeSeriesPredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<TimeSeriesPredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput? input = null, int? horizon = null)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input, horizon);
        }

        private static TimeSeriesPredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var schema);
            return mlModel.CreateTimeSeriesEngine<ModelInput, ModelOutput>(mlContext);
        }
    }
}
