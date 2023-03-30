using Newtonsoft.Json;
using NodeBlock.Engine;
using NodeBlock.Engine.Attributes;
using NodeBlock_Plugin_MachineLearning;
using System;

namespace NodeBlock.Plugin.MachineLearning.Nodes.PriceForecast
{

    [NodeDefinition("PriceForecastNode", "Price Forecast", NodeTypeEnum.Function, "Machine Learning")]
    [NodeGraphDescription("Forecast price based on time series historical data")]
    [NodeIDEParameters(Hidden = true)]
    public class PriceForecastNode : Node
    {
        public PriceForecastNode(string id, BlockGraph graph)
                : base(id, graph, typeof(PriceForecastNode).Name)
        {
            OutParameters.Add("output", new NodeParameter(this, "output", typeof(string), false));
        }

        public override bool CanBeExecuted => true;

        public override bool CanExecute => true;

        public override bool OnExecution()
        {

            var result = PriceForecastModel.Predict();

            OutParameters["output"].SetValue(result.Price[0].ToString());

            return true;
        }
    }
}
