using NodeBlock.Engine;
using NodeBlock.Engine.Attributes;
using NodeBlock.Plugin.MachineLearning;
using NodeBlock_Plugin_MachineLearning;
using System;
using System.Collections.Generic;
using System.Text;


namespace NodeBlock.Plugin.MachineLearning.Nodes.SentimentAnalysis
{

    [NodeDefinition("MachineLearnSampleNode", "Machine Learn Sample", NodeTypeEnum.Function, "ML.NET")]
    [NodeGraphDescription("Predict if the text has a positive or negative sentiment")]
    public class MachineLearnSampleNode : Node
    {
        public MachineLearnSampleNode(string id, BlockGraph graph)
                : base(id, graph, typeof(MachineLearnSampleNode).Name)
        {
            this.InParameters.Add("testString", new NodeParameter(this, "testString", typeof(string), true));

            this.OutParameters.Add("outSent", new NodeParameter(this, "outSent", typeof(string), false));
        }
        
        public override bool CanBeExecuted => true;

        public override bool CanExecute => true;

        public override bool OnExecution()
        {
            var testString = this.InParameters["testString"].GetValue().ToString();
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = this.InParameters["testString"].GetValue().ToString(),
            };

            var result = SentimentModel.Predict(sampleData);

            this.OutParameters["outSent"].SetValue((result.PredictedLabel == 1) ? "Positive" : "Negative");

            return true;
        }
    }
}
