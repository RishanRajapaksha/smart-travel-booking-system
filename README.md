<div align="center">

#  AI Based Travel and Hotel Booking System

[![.NET](https://img.shields.io/badge/.NET-Visual%20Studio%202022-512BD4?style=for-the-badge&logo=dotnet)](https://visualstudio.microsoft.com/)
[![MySQL](https://img.shields.io/badge/MySQL-XAMPP-4479A1?style=for-the-badge&logo=mysql&logoColor=white)](https://www.apachefriends.org/)
[![Groq AI](https://img.shields.io/badge/AI-Groq%20API-F55036?style=for-the-badge&logo=openai&logoColor=white)](https://console.groq.com/)
[![Google Auth](https://img.shields.io/badge/Auth-Google%20Login-4285F4?style=for-the-badge&logo=google&logoColor=white)](https://console.cloud.google.com/)

<br/>

**Developed by [Rishan Rajapaksha](https://github.com/RishanRajapaksha)**

</div>

---

## ⚙️ How To Setup The Enviorment



<br/><br/>
**<h3> Step 1 :- Clone the Repository** </h3>

```bash
git clone https://github.com/RishanRajapaksha/.git
```
<img src="screenshots/ss 0.png" alt="Screenshot 1" width="80%"/>


<br/><br/>
**<h3> Step 2 — Install Visual Studio 2022** </h3>
Download and install Visual Studio 2022 from [visualstudio.microsoft.com](https://visualstudio.microsoft.com/).
Make sure to include the **ASP.NET and web development** workload during installation.
> ⚠️ **Important:** Visual Studio **2022** is strongly recommended. Some features may not work correctly on older versions.
<img src="screenshots/ss 1.png" alt="Screenshot 1" width="80%"/>


<br/><br/>
**<h3> Step 3 — Install & Start XAMPP** </h3>
1. Download XAMPP from [apachefriends.org](https://www.apachefriends.org/)
2. Install and open the **XAMPP Control Panel**
3. Start the **MySQL** service <br/>
<img src="screenshots/ss 2.png" alt="Screenshot 3" width="80%"/>


<br/><br/>
**<h3> Step 4 — Set Up Groq API Key** </h3>
This project uses **Groq API** to power the AI chat assistant.

1. Visit 👉 [https://console.groq.com/keys](https://console.groq.com/keys)
2. Sign in and generate a new API key
3. Copy the key — you'll need it in Step 6
<img src="screenshots/ss 3.png" alt="Screenshot 4" width="80%"/>

<br/><br/>
**<h3> Step 5 — Set Up Google Login ** </h3>

> 💡 If you skip this step, Google Login will be disabled but the rest of the app will work fine.

1. Go to [Google Cloud Console](https://console.cloud.google.com/)
2. Create a new project → Enable **Google+ API**
3. Create **OAuth 2.0 Credentials**
4. Copy your `GOOGLE_LOGIN_CLIENT_ID` and `GOOGLE_CLIENT_SECRET`
5. *(If unsure, follow a guide on ChatGPT or YouTube)*

<img src="screenshots/ss 3.png" alt="Screenshot 4" width="80%"/>


</div>



<br/><br/>
**<h3> ** </h3>

<img src="screenshots/ss 3.png" alt="Screenshot 4" width="80%"/>


</div>




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

## ✨ Features

- 🤖 **AI Chat Assistant** — Powered by Groq API (LLaMA)
- 🔐 **Google OAuth Login** — Secure social login
- 🗄️ **MySQL Database** — Full data persistence via XAMPP
- 📋 **Booking Management** — Create, view & manage travel bookings
- 👤 **User Profiles** — Personalized user accounts
- 🛡️ **Admin Dashboard** — Full backend control panel


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
