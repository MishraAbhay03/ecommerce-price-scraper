# 🛒 E-Commerce Price Scraper

![ASP.NET](https://img.shields.io/badge/ASP.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Python](https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white)
![CSS](https://img.shields.io/badge/CSS-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![Amazon](https://img.shields.io/badge/Amazon-FF9900?style=for-the-badge&logo=amazon&logoColor=white)
![Flipkart](https://img.shields.io/badge/Flipkart-2874F0?style=for-the-badge&logoColor=white)

> Live price scraper for Amazon & Flipkart — competitor pricing dashboard with trend analysis and real-time insights.

---

## 📌 Overview

This project scrapes live product pricing data from Amazon and Flipkart, stores it, and surfaces insights through a competitor pricing dashboard. It enables price trend tracking, best-deal detection, and market analysis.

---

## ✨ Key Features

- ✅ Scrapes **live prices** from Amazon & Flipkart
- ✅ Side-by-side **price comparison** dashboard
- ✅ **Price trend** tracking over time
- ✅ Best deal detection across platforms
- ✅ SQL Server database backend (`.bak` backup included)
- ✅ Built with **ASP.NET** web framework

---

## 📁 Project Structure

```
ecommerce-price-scraper/
├── Ecommerce_Part18/                    # ASP.NET web application
├── dbMyOnlineShopping_BackUp_Latest.bak # SQL Server database backup
├── .gitignore
└── README.md
```

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019+
- SQL Server / SQL Server Express
- .NET Framework 4.7+

### Setup

```bash
git clone https://github.com/MishraAbhay03/ecommerce-price-scraper.git
cd ecommerce-price-scraper
```

1. Open `Ecommerce_Part18/` in Visual Studio
2. Restore the SQL database from `dbMyOnlineShopping_BackUp_Latest.bak`
3. Update the connection string in `Web.config`
4. Run the project (`F5`)

---

## 📊 Dashboard Features

| Feature | Description |
|---|---|
| Price Comparison | Amazon vs Flipkart side-by-side |
| Trend Chart | Historical price movements |
| Best Deal Alert | Highlights lowest current price |
| Product Search | Search by product name/category |

---

## 🛠️ Tech Stack

| Category | Tools |
|---|---|
| Backend | ASP.NET, C# |
| Database | SQL Server |
| Scraping | Python / Web Scraping |
| Frontend | HTML, CSS, JavaScript |

---

## 👤 Author

**Abhaykumar Mishra** — [GitHub](https://github.com/MishraAbhay03) · [LinkedIn](https://linkedin.com/in/YOUR_LINKEDIN)

---

## 📄 License

MIT License — see [LICENSE](LICENSE) for details.
