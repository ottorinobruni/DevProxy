# DevProxy: Enhancing Client-Side API Reliability through Simulated Errors, Responses, and Postman Mock Servers
This repository contains the source code for the DevProxy project. DevProxy is a command-line tool provided by Microsoft aimed at enhancing the reliability of applications by simulating API interactions and identifying errors. With the latest addition of the mockserver branch, this project now includes an example showcasing how to use Postman Mock Servers to simulate API responses, enabling frontend developers to start building features without waiting for backend APIs to be fully implemented.

## Contents
- [Project Description](#project-description)
- [How to Use](#how-to-use)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Contributions](#contributions)
- [License](#license)

## Project Description

DevProxy facilitates the testing of applications by simulating API behaviors and identifying potential issues before they impact production environments. This repository includes the source code for DevProxy, along with documentation and examples demonstrating its usage.

## How to Use

- **DevProxy:** Command-line tool for simulating APIs and testing application reliability.
- **Postman Mock Server** (mockserver branch): Example of using Postman to mock API responses for frontend development

## Project Structure

The project structure is organized as follows:
- **DevProxy.WebApp:** Contains the source code for the DevProxy web application, which displays weather forecasts.
- **DevProxy.API:** Includes the web service for weather data, utilized by the web application.
- **DevProxy.sln:** Main solution file connecting both the web application and API projects.
- **mockserver branch**: Contains an example of how to integrate Postman Mock Servers to simulate API responses for faster frontend development.

## Article
For more information on how to use DevProxy and its integration with your projects, please refer to the article: [Dev Proxy: Enhancing Client-Side API Reliability through Simulated Errors and Responses](https://www.ottorinobruni.com/devproxy-enhancing-client-side-api-reliability-through-simulated-errors-responses/) and [Simplify Blazor Frontend Development with Postman Mock Servers: Start Work Without Waiting for Backend](https://www.ottorinobruni.com/simplify-blazor-frontend-development-with-postman-mock-servers-start-work-without-waiting-for-backend/)).
.

## Getting Started

To run DevProxy locally on your machine, follow these steps:
1. Clone the repository: `git clone https://github.com/ottorinobruni/DevProxy.git`
2. Navigate to the project directory: `cd DevProxy`
3. Build the project.
4. Run WebApp and API projects.

## Contributions

Contributions are welcome! If you'd like to improve this project, open a pull request or report an issue.

## License

This project is licensed under the [MIT License](LICENSE).
