<div align="center">

# 🌍 Travel Booking System

### A full-featured travel booking web application built with ASP.NET & MySQL

[![.NET](https://img.shields.io/badge/.NET-Visual%20Studio%202022-512BD4?style=for-the-badge&logo=dotnet)](https://visualstudio.microsoft.com/)
[![MySQL](https://img.shields.io/badge/MySQL-XAMPP-4479A1?style=for-the-badge&logo=mysql&logoColor=white)](https://www.apachefriends.org/)
[![Groq AI](https://img.shields.io/badge/AI-Groq%20API-F55036?style=for-the-badge&logo=openai&logoColor=white)](https://console.groq.com/)
[![Google Auth](https://img.shields.io/badge/Auth-Google%20Login-4285F4?style=for-the-badge&logo=google&logoColor=white)](https://console.cloud.google.com/)

<br/>

**Developed by [Rishan Rajapaksha](https://github.com/RishanRajapaksha)**

</div>

---

## 📸 Screenshots

<div align="center">

<img src="screenshots/ss 0.png" alt="Screenshot 1" width="80%"/>
<br/><sub>Overview</sub>

<br/><br/>

<img src="screenshots/ss 1.png" alt="Screenshot 2" width="80%"/>
<br/><sub>Home Page</sub>

<br/><br/>

<img src="screenshots/ss 2.png" alt="Screenshot 3" width="80%"/>
<br/><sub>Login / Register</sub>

<br/><br/>

<img src="screenshots/ss 3.png" alt="Screenshot 4" width="80%"/>
<br/><sub>Dashboard</sub>

<br/><br/>

<img src="screenshots/ss 4.png" alt="Screenshot 5" width="80%"/>
<br/><sub>Booking Page</sub>

<br/><br/>

<img src="screenshots/ss 5.png" alt="Screenshot 6" width="80%"/>
<br/><sub>AI Chat Assistant</sub>

<br/><br/>

<img src="screenshots/ss 6.png" alt="Screenshot 7" width="80%"/>
<br/><sub>Search & Filter</sub>

<br/><br/>

<img src="screenshots/ss 7.png" alt="Screenshot 8" width="80%"/>
<br/><sub>Booking Confirmation</sub>

<br/><br/>

<img src="screenshots/ss 8.png" alt="Screenshot 9" width="80%"/>
<br/><sub>Admin Panel</sub>

<br/><br/>

<img src="screenshots/ss 9.png" alt="Screenshot 10" width="80%"/>
<br/><sub>User Profile</sub>

<br/><br/>

<img src="screenshots/ss 10.png" alt="Screenshot 11" width="80%"/>
<br/><sub>Database View</sub>

<br/><br/>

<img src="screenshots/ss 11.png" alt="Screenshot 12" width="80%"/>
<br/><sub>Settings</sub>

<br/><br/>

<img src="screenshots/ss 12.png" alt="Screenshot 13" width="80%"/>
<br/><sub>Final View</sub>

</div>

---

## ✨ Features

- 🤖 **AI Chat Assistant** — Powered by Groq API (LLaMA)
- 🔐 **Google OAuth Login** — Secure social login
- 🗄️ **MySQL Database** — Full data persistence via XAMPP
- 📋 **Booking Management** — Create, view & manage travel bookings
- 👤 **User Profiles** — Personalized user accounts
- 🛡️ **Admin Dashboard** — Full backend control panel

---

## ⚙️ Setup Guide

### Prerequisites

Before you begin, make sure you have the following installed:

| Tool | Version | Download |
|------|---------|----------|
| Visual Studio | 2022 (Recommended) | [Download](https://visualstudio.microsoft.com/) |
| XAMPP | Latest | [Download](https://www.apachefriends.org/) |
| Git | Latest | [Download](https://git-scm.com/) |

---

### 🚀 Step-by-Step Installation

**Step 1 — Clone the Repository**

```bash
git clone https://github.com/RishanRajapaksha/<your-repo-name>.git
cd <your-repo-name>
```

---

**Step 2 — Install Visual Studio 2022**

> ⚠️ **Important:** Visual Studio **2022** is strongly recommended. Some features may not work correctly on older versions.

Download and install Visual Studio 2022 from [visualstudio.microsoft.com](https://visualstudio.microsoft.com/).
Make sure to include the **ASP.NET and web development** workload during installation.

---

**Step 3 — Install & Start XAMPP**

1. Download XAMPP from [apachefriends.org](https://www.apachefriends.org/)
2. Install and open the **XAMPP Control Panel**
3. Start the **MySQL** service

---

**Step 4 — Set Up Groq API Key**

This project uses **Groq API** to power the AI chat assistant.

1. Visit 👉 [https://console.groq.com/keys](https://console.groq.com/keys)
2. Sign in and generate a new API key
3. Copy the key — you'll need it in Step 6

---

**Step 5 — Set Up Google Login** *(Optional)*

> 💡 If you skip this step, Google Login will be disabled but the rest of the app will work fine.

1. Go to [Google Cloud Console](https://console.cloud.google.com/)
2. Create a new project → Enable **Google+ API**
3. Create **OAuth 2.0 Credentials**
4. Copy your `GOOGLE_LOGIN_CLIENT_ID` and `GOOGLE_CLIENT_SECRET`
5. *(If unsure, follow a guide on ChatGPT or YouTube)*

---

**Step 6 — Configure Environment Variables**

1. Open **Environment Variables** on your PC:
   - Press `Win + S` → Search `"Environment Variables"` → Click **"Edit the system environment variables"**
2. Under **"User variables for [your username]"**, click **New** and add the following:

| Variable Name | Value |
|--------------|-------|
| `GROQ_API_KEY` | *(Your Groq API Key)* |
| `GOOGLE_LOGIN_CLIENT_ID` | *(Your Google Client ID)* |
| `GOOGLE_CLIENT_SECRET` | *(Your Google Client Secret)* |

> 🔒 **Security Note:** Never share or commit these values to GitHub.

---

**Step 7 — Create the Database**

1. Open your browser and go to `http://localhost/phpmyadmin`
2. Create a new database named exactly:

```
travelDB
```

---

**Step 8 — Restore the Database Backup**

1. In the cloned repository, open the **`MySQL Database`** folder
2. Find the **latest `.sql` backup file**
3. In phpMyAdmin → Select `travelDB` → Click **Import** → Choose the `.sql` file → Click **Go**

---

**Step 9 — Run the Application**

1. In the cloned repository, find and **double-click** `Test.sln`
2. It will open automatically in **Visual Studio 2022**
3. Press **`F5`** or click the ▶️ **Run** button
4. The app will launch in your default browser 🎉

---

## 🔑 Environment Variables Summary

| Variable | Required | Description |
|----------|----------|-------------|
| `GROQ_API_KEY` | ✅ Yes | AI Chat Assistant |
| `GOOGLE_LOGIN_CLIENT_ID` | ⚡ Optional | Google Login |
| `GOOGLE_CLIENT_SECRET` | ⚡ Optional | Google Login |

---

## 🛠️ Tech Stack

- **Backend** — ASP.NET (C#), Visual Studio 2022
- **Database** — MySQL via XAMPP
- **AI** — Groq API (LLaMA)
- **Authentication** — Google OAuth 2.0
- **Frontend** — HTML, CSS, JavaScript

---

## 👨‍💻 Author

<div align="center">

**Rishan Rajapaksha**

[![GitHub](https://img.shields.io/badge/GitHub-RishanRajapaksha-181717?style=for-the-badge&logo=github)](https://github.com/RishanRajapaksha)

</div>

---

<div align="center">
  <sub>⭐ If you found this project helpful, please give it a star!</sub>
</div>
