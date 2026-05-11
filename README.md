# ☕ KeepAwake

A lightweight Windows utility that prevents your computer and screen from automatically turning off, running completely hidden in the System Tray.

## 🌟 Introduction

Annoyed by your PC screen turning off after just 1 minute of inactivity? KeepAwake is the "small but mighty" solution to this problem. 

Instead of opening Windows Settings to tweak the screen timeout every time you need to go AFK, KeepAwake runs super lightly in the background on your Taskbar's right corner, allowing you to instantly toggle the keep-awake mode with just a click.

## 📸 Screenshot

<img width="261" height="115" alt="image" src="https://github.com/user-attachments/assets/abb180aa-40c5-47b4-8d7f-15d44d9fcdc3" />

## 🚀 Key Features

* **Keep the screen awake:** Prevents the display from turning off and stops Windows from going into Sleep mode.
* **Minimalist UI:** No bulky application windows; operates 100% via the System Tray icon.
* **Code-drawn UI:** Intuitive icon that changes based on status (⚪ Gray Dot: OFF | 🟢 Green Dot: ON).
* **Self-contained:** Runs immediately as a single `.exe` file without requiring users to pre-install the .NET Runtime.

## 📥 Download & Installation

**[⬇️ CLICK HERE TO DOWNLOAD KEEPAWAKE (Latest Version)](https://github.com/khangdang12324/Tool_Turn-on-off-sleep-for-PC/releases/tag/v1)**

**Quick Setup Guide:**
1. Click the link above to download the `KeepAwake.zip` file.
2. Extract the downloaded folder.
3. Run `KeepAwake.exe` directly to use it instantly (you can right-click and choose *Send to > Desktop* to create a shortcut).

## 💡 Usage

* After running, the app will appear as a small dot in the System Tray (bottom right corner of your screen).
* **Double-click** the icon to toggle between the 2 states:
    * ⚪ **Gray Icon:** KeepAwake is **OFF**. The screen will turn off according to your default Windows settings.
    * 🟢 **Green Icon:** KeepAwake is **ON**. Your screen will be kept awake indefinitely.
* **Right-click** the icon to open the context menu, allowing you to toggle the state or select "Exit" to completely close the app.

## 🛠️ Technologies Used

* **Language:** C#
* **Framework:** .NET 10 (Publish Single File & Self-contained)
* **UI:** Windows Forms (TrayApplicationContext)
* **System API:** Win32 API (`SetThreadExecutionState` from `kernel32.dll`)

---

## 👨‍💻 Author

Developed to solve a minor annoyance in daily workflow.
🌐 Check out my other projects on my personal portfolio: [dangnguyenphuckhang.id.vn](https://dangnguyenphuckhang.id.vn)
