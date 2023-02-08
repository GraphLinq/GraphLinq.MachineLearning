<!--
*** This README used the Best-README-Template (https://github.com/othneildrew/Best-README-Template).
-->

<a name="readme-top"></a>

<!-- PROJECT SHIELDS -->

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/GraphLinq/GraphLinq.MachineLearning">
    <img src="img/project-logo-full.png" alt="Logo" width="830">
  </a>

  <h3 align="center">GraphLinq.MachineLearning</h3>

  <p align="center">
    {Description}
    <br />
    <a target="_blank" href="https://docs.graphlinq.io"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/GraphLinq/GraphLinq.MachineLearning/issues">Report Bug</a>
    ·
    <a href="https://github.com/GraphLinq/GraphLinq.MachineLearning/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About The Project</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

{About}

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->
## Contributing

If you have a suggestion that would make this repository better, please fork the repo and create a pull request. You can also simply open an issue. Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->
## Contact

GraphLinq Protocol - [@graphlinq_proto](https://twitter.com/graphlinq_proto)

Project Home: [https://graphlinq.io](https://graphlinq.io)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<a href="https://github.com/GraphLinq/GraphLinq.MachineLearning/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=GraphLinq/GraphLinq.MachineLearning" />
</a>

Made with [contributors-img](https://contrib.rocks).

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

<!-- GitHub -->
[contributors-shield]: https://img.shields.io/github/contributors/GraphLinq/GraphLinq.MachineLearning.svg?style=for-the-badge
[contributors-url]: https://github.com/GraphLinq/GraphLinq.MachineLearning/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/GraphLinq/GraphLinq.MachineLearning.svg?style=for-the-badge
[forks-url]: https://github.com/GraphLinq/GraphLinq.MachineLearning/network/members
[stars-shield]: https://img.shields.io/github/stars/GraphLinq/GraphLinq.MachineLearning.svg?style=for-the-badge
[stars-url]: https://github.com/GraphLinq/GraphLinq.MachineLearning/stargazers
[issues-shield]: https://img.shields.io/github/issues/GraphLinq/GraphLinq.MachineLearning.svg?style=for-the-badge
[issues-url]: https://github.com/GraphLinq/GraphLinq.MachineLearning/issues
[license-shield]: https://img.shields.io/github/license/GraphLinq/GraphLinq.MachineLearning.svg?style=for-the-badge
[license-url]: https://github.com/GraphLinq/GraphLinq.MachineLearning/blob/master/LICENSE.txt














































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
