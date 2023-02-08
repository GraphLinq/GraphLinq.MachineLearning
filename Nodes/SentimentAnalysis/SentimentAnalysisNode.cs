using NodeBlock.Engine;
using NodeBlock.Engine.Attributes;
using NodeBlock_Plugin_MachineLearning;


namespace NodeBlock.Plugin.MachineLearning.Nodes.SentimentAnalysis
{

    [NodeDefinition("MachineLearnSampleNode", "Machine Learn Sample", NodeTypeEnum.Function, "ML.NET")]
    [NodeGraphDescription("Predict if the text has a positive or negative sentiment")]
    public class MachineLearnSampleNode : Node
    {
        public MachineLearnSampleNode(string id, BlockGraph graph)
                : base(id, graph, typeof(MachineLearnSampleNode).Name)
        {
            InParameters.Add("testString", new NodeParameter(this, "testString", typeof(string), true));

            OutParameters.Add("outSent", new NodeParameter(this, "outSent", typeof(string), false));
        }

        public override bool CanBeExecuted => true;

        public override bool CanExecute => true;

        public override bool OnExecution()
        {
            string testString = InParameters["testString"].GetValue().ToString();
            SentimentModel.ModelInput sampleData = new SentimentModel.ModelInput()
            {
                Col0 = InParameters["testString"].GetValue().ToString(),
            };

            SentimentModel.ModelOutput result = SentimentModel.Predict(sampleData);

            OutParameters["outSent"].SetValue((result.PredictedLabel == 1) ? "Positive" : "Negative");

            return true;
        }
    }
}
