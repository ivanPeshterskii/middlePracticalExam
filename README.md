# 🧠 Programming Exercises – C# Basics

This repository contains three training tasks written in C#. Each task focuses on basic programming logic, conditional statements, loops, and list manipulation.

---

## 🧑‍🍳 1. Cooking Masterclass

Help George prepare supplies for his cooking class.

### 📝 Task Description:
Each student requires:
- 1 package of **flour**
- 10 **eggs**
- 1 **apron**

George:
- Buys **20% more aprons**, rounded **up** to the next integer.
- Gets **every 5th flour package for free**.

You are given:
- George's **budget**
- The **number of students**
- Price of each item

### 🎯 Goal:
Determine if George’s budget is enough. If not, print how much more he needs.

---

## 👥 2. Friend List Maintenance

Maintain a list of usernames using commands.

### 📝 Input:
- Line 1: Friends list, separated by `", "`
- Next lines: Commands until `"Report"`

### 🛠️ Commands:

- **`Blacklist {name}`**  
  → Change `{name}` to `"Blacklisted"` and print a message.  
  → If not found, print that it was not found.

- **`Error {index}`**  
  → If valid index and name is neither `"Blacklisted"` nor `"Lost"`, change it to `"Lost"` and print a message.

- **`Change {index} {new name}`**  
  → If index is valid, update the name and print a message.

- **`Report`**  
  → Stop processing and print stats.

---

## 💬 3. Chat Logger

Simulate a chat interface that handles multiple message operations.

### 🛠️ Commands:

- **`Chat {message}`**  
  → Add message at the end of the chat.

- **`Delete {message}`**  
  → Remove message if it exists.

- **`Edit {message} {editedVersion}`**  
  → Replace message with `editedVersion` if it exists.

- **`Pin {message}`**  
  → Move message to the end of the list if found.

- **`Spam {message1} {message2} ... {messageN}`**  
  → Add all messages to the end of the chat.

- **`end`**  
  → Stop input and print all chat messages (one per line).

---

📁 Each task can be found in its respective `.cs` file.

Feel free to fork, test, and improve the logic! 😄
