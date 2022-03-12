# GraphLinq.MachineLearning

Plugin of the GraphLinq Engine using ML.NET

## Experimental / Proof-Of-Concept

This plugin will allow a graph to consume data, create a dataset, train a model, and make predictions. (Or possibly only allow making predictions and the dataset and model will be provided by us.)

Sample data currently includes sentiment analysis trained from Yelp comments. The goal would be to build a model around crypto sentiment to predict news or twitter comment sentiment.

TODO: Add a Telegram/Discord chat bot data for spam detection.

Additional use cases to follow.

## Example

- Add the sample block to a graph
- Add a string to the input of the comments you want to try and predict
- Output string will return `Positive` or `Negative`

## Tests

- Input
  - "I had a terrible time. Never going again..."
- Result
  - `Negative`

- Input
  - "I love this place. I go there all the time"
- Result
  - `Positive`
