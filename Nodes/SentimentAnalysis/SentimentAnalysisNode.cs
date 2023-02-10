using NodeBlock.Engine;
using NodeBlock.Engine.Attributes;
using NodeBlock_Plugin_MachineLearning;


namespace NodeBlock.Plugin.MachineLearning.Nodes.SentimentAnalysis
{

    [NodeDefinition("SentimentAnalysisNode", "Sentiment Analysis", NodeTypeEnum.Function, "Machine Learning")]
    [NodeGraphDescription("Predict if the text has a positive or negative sentiment")]
    public class SentimentAnalysisNode : Node
    {
        public SentimentAnalysisNode(string id, BlockGraph graph)
                : base(id, graph, typeof(SentimentAnalysisNode).Name)
        {
            InParameters.Add("testString", new NodeParameter(this, "testString", typeof(string), true));

            OutParameters.Add("output", new NodeParameter(this, "output", typeof(bool), false));
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

            OutParameters["output"].SetValue((result.PredictedLabel == 1) ? true : false);

            return true;
        }
    }
}
