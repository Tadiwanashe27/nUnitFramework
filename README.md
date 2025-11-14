# NUnit Automation Framework

A clean, scalable automation testing framework built using **C#**, **NUnit**, and **.NET**. Designed for both **UI automation** (Selenium) and **API testing**, with clear structure, reusable components, and support for parallel execution and reporting.

---

## 📌 Table of Contents
- Overview
- Architecture
- Tech Stack
- Folder Structure
- Setup Instructions
- Running Tests
- Writing Tests
- Test Reports
- CI/CD Integration
- Best Practices

---

## 🔍 Overview
This framework supports regression testing, smoke testing, and integration testing. It follows:
- **Page Object Model (POM)** for UI tests
- **Service/API Object Model** for API tests

Key features:
- Parallel test execution  
- Configurable environments  
- Data-driven tests  
- Rich reporting  
- Centralized driver + API client setup  

---

## 🧱 Architecture
- **NUnit** — Test runner & assertions  
- **Selenium WebDriver** — UI test automation  
- **RestSharp / HttpClient** — API testing  
- **POM & API Client abstraction** — Maintainability  
- **DriverFactory & ConfigManager** — Clean setup  
- **ExtentReports/Allure** — Reporting  

---

## 🛠 Tech Stack
| Component       | Technology |
|----------------|------------|
| Language       | C# (.NET 7/8) |
| Test Framework | NUnit |
| UI Tests       | Selenium WebDriver |
| API Tests      | RestSharp / HttpClient |
| Data Storage   | JSON test data files |
| Reporting      | ExtentReports or Allure |
| CI             | GitHub Actions / Azure DevOps / Jenkins |

---

## 📁 Folder Structure

---

## ⚙️ Setup Instructions

### Prerequisites
- .NET SDK 7 or later  
- Visual Studio / VS Code / Rider  
- ChromeDriver or WebDriverManager  

### Install Dependencies

---

## 🧪 Writing Tests

Example NUnit test:
using NUnit.Framework;

[TestFixture]
public class LoginTests : TestBase
{
[Test, Category("Smoke")]
public void ValidLogin_ShouldNavigateToHomePage()
{
loginPage.Navigate();
loginPage.Login("user", "password");


---

## ✨ Best Practices
- Keep test cases small, independent, and atomic  
- Reuse page objects and client classes  
- Avoid hard-coded waits (use WebDriverWait)  
- Store credentials & environment variables securely  
- Use `[Category]` attributes for organizing test suites  
- Follow a clear naming convention for tests and methods  
- Keep your framework DRY (Don’t Repeat Yourself)

---

Happy testing! 🚀

