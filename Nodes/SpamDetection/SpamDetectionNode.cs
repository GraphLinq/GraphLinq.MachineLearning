using NodeBlock.Engine;
using NodeBlock.Engine.Attributes;
using NodeBlock_Plugin_MachineLearning;
using System;

namespace NodeBlock.Plugin.MachineLearning.Nodes.SpamDetection
{

    [NodeDefinition("SpamDetectionNode", "Spam Detection", NodeTypeEnum.Function, "Machine Learning")]
    [NodeGraphDescription("Predict if the text is spam or not")]
    public class SpamDetectionNode : Node
    {
        public SpamDetectionNode(string id, BlockGraph graph)
                : base(id, graph, typeof(SpamDetectionNode).Name)
        {
            InParameters.Add("testString", new NodeParameter(this, "testString", typeof(string), true));

            OutParameters.Add("output", new NodeParameter(this, "output", typeof(bool), false));
        }

        public override bool CanBeExecuted => true;

        public override bool CanExecute => true;

        public override bool OnExecution()
        {
            string testString = InParameters["testString"].GetValue().ToString();
            SpamModel.ModelInput sampleData = new SpamModel.ModelInput()
            {
                Col0 = InParameters["testString"].GetValue().ToString(),
            };

            SpamModel.ModelOutput result = SpamModel.Predict(sampleData);

            OutParameters["output"].SetValue((int.Parse(result.PredictedLabel) == 1) ? true : false);

            return true;
        }
    }
}
