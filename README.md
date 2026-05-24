# 🍕 Pizza Shop - VB.NET Windows Forms Application

A Windows Forms application built with VB.NET that simulates a pizza ordering system, allowing customers to customize and place pizza orders with real-time cost calculation.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Pizza Options & Pricing](#pizza-options--pricing)
- [How to Use](#how-to-use)
- [Project Structure](#project-structure)
- [Requirements](#requirements)
- [Getting Started](#getting-started)

---

## Overview

PizzaShop2 is a desktop GUI application developed in Visual Basic .NET using Windows Forms. It provides an interactive interface for selecting pizza size, base type, extra toppings, and a supreme option — then calculates the total cost including 6% tax.

---

## Features

- **Pizza Size Selection** — Choose from Small, Medium, or Large using radio buttons
- **Base Pizza Selection** — Choose between Plain or Sauce (mutually exclusive checkboxes)
- **Extra Toppings** — Add individual toppings with size-based pricing
- **Supreme Pizza Option** — Locks out individual toppings; applies a fixed premium price
- **Auto Cost Calculation** — Calculates pizza cost, 6% tax, and total on order placement
- **Input Validation** — Sauce base adds a flat $2 charge; Supreme disables topping selection

---

## Pizza Options & Pricing

### Size Base Price

| Size   | Base Price | Supreme Price |
|--------|-----------|---------------|
| Small  | $10.00    | $15.00        |
| Medium | $12.00    | $21.00        |
| Large  | $15.00    | $27.00        |

### Extra Toppings (per topping)

| Size   | Topping Cost |
|--------|-------------|
| Small  | $1.00       |
| Medium | $1.50       |
| Large  | $2.25       |

Available toppings: **Mushroom, Sausage, Onions, Green Pepper**

### Additional Charges

| Item         | Charge  |
|--------------|---------|
| Sauce Base   | +$2.00  |
| Tax          | 6%      |

---

## How to Use

1. **Select a pizza size** — Small, Medium, or Large
2. **Choose a base** — Plain (no extra charge) or Sauce (+$2.00)
3. **Add toppings** — Check any combination of Mushroom, Sausage, Onions, or Green Pepper
4. **OR select Supreme** — Automatically disables and clears individual toppings; applies supreme pricing
5. Click **Place Order** to calculate and display:
   - Pizza Cost
   - Tax (6%)
   - Total Amount
6. Click **Exit** to close the application

---

## Project Structure

```
PizzaShop2/
│
├── Form1.vb              # Main form logic (event handlers & calculations)
├── Form1.vb [Design]     # Windows Forms UI designer
├── ApplicationEvents.vb  # Application-level event handling
├── App.config            # Application configuration
└── My Project/           # Project settings and resources
```

### Key Controls

| Control Name     | Type        | Purpose                          |
|-----------------|-------------|----------------------------------|
| `rdoSmall`       | RadioButton | Select Small pizza               |
| `rdoMedium`      | RadioButton | Select Medium pizza              |
| `rdoLarge`       | RadioButton | Select Large pizza               |
| `chkPlain`       | CheckBox    | Select Plain base                |
| `chkSauce`       | CheckBox    | Select Sauce base (+$2)          |
| `chkMushroom`    | CheckBox    | Add Mushroom topping             |
| `chkSausage`     | CheckBox    | Add Sausage topping              |
| `chkOnions`      | CheckBox    | Add Onions topping               |
| `chkGreenPepper` | CheckBox    | Add Green Pepper topping         |
| `chkSupreme`     | CheckBox    | Select Supreme pizza (locks toppings) |
| `btnOrder`       | Button      | Calculate and display order cost |
| `btnExit`        | Button      | Close the application            |
| `lblCost`        | Label       | Displays pizza cost              |
| `lblTax`         | Label       | Displays tax amount              |
| `lblTotal`       | Label       | Displays total amount            |

---

## Requirements

- **IDE:** Visual Studio 2019 or later
- **Framework:** .NET Framework 4.x (Windows Forms)
- **Language:** Visual Basic .NET (VB.NET)
- **OS:** Windows

---

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/your-username/PizzaShop2.git
```

### Open in Visual Studio

1. Open Visual Studio
2. Go to **File → Open → Project/Solution**
3. Navigate to the cloned folder and open `PizzaShop2.sln`

### Run the Application

- Press **F5** or click the **Start** button in the toolbar to build and run
- The Pizza Shop form will launch and be ready to use

---

## Business Logic Summary

```
If Supreme selected:
    cost = Supreme price for selected size
    Toppings disabled and cleared

Else:
    cost = Base price for selected size
    If Sauce selected: cost += $2
    For each topping selected: cost += toppingCost (size-dependent)

tax   = cost × 0.06
total = cost + tax
```

---


## License

This project is created for educational and learning purposes.


## Contact
- **Nidhi** - https://github.com/Nid-hex - nidhi07290@gmail.com
- **Project Link** - # 🍕 Pizza Shop - VB.NET Windows Forms Application

A Windows Forms application built with VB.NET that simulates a pizza ordering system, allowing customers to customize and place pizza orders with real-time cost calculation.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Pizza Options & Pricing](#pizza-options--pricing)
- [How to Use](#how-to-use)
- [Project Structure](#project-structure)
- [Requirements](#requirements)
- [Getting Started](#getting-started)

---

## Overview

PizzaShop2 is a desktop GUI application developed in Visual Basic .NET using Windows Forms. It provides an interactive interface for selecting pizza size, base type, extra toppings, and a supreme option — then calculates the total cost including 6% tax.

---

## Features

- **Pizza Size Selection** — Choose from Small, Medium, or Large using radio buttons
- **Base Pizza Selection** — Choose between Plain or Sauce (mutually exclusive checkboxes)
- **Extra Toppings** — Add individual toppings with size-based pricing
- **Supreme Pizza Option** — Locks out individual toppings; applies a fixed premium price
- **Auto Cost Calculation** — Calculates pizza cost, 6% tax, and total on order placement
- **Input Validation** — Sauce base adds a flat $2 charge; Supreme disables topping selection

---

## Pizza Options & Pricing

### Size Base Price

| Size   | Base Price | Supreme Price |
|--------|-----------|---------------|
| Small  | $10.00    | $15.00        |
| Medium | $12.00    | $21.00        |
| Large  | $15.00    | $27.00        |

### Extra Toppings (per topping)

| Size   | Topping Cost |
|--------|-------------|
| Small  | $1.00       |
| Medium | $1.50       |
| Large  | $2.25       |

Available toppings: **Mushroom, Sausage, Onions, Green Pepper**

### Additional Charges

| Item         | Charge  |
|--------------|---------|
| Sauce Base   | +$2.00  |
| Tax          | 6%      |

---

## How to Use

1. **Select a pizza size** — Small, Medium, or Large
2. **Choose a base** — Plain (no extra charge) or Sauce (+$2.00)
3. **Add toppings** — Check any combination of Mushroom, Sausage, Onions, or Green Pepper
4. **OR select Supreme** — Automatically disables and clears individual toppings; applies supreme pricing
5. Click **Place Order** to calculate and display:
   - Pizza Cost
   - Tax (6%)
   - Total Amount
6. Click **Exit** to close the application

---

## Project Structure

```
PizzaShop2/
│
├── Form1.vb              # Main form logic (event handlers & calculations)
├── Form1.vb [Design]     # Windows Forms UI designer
├── ApplicationEvents.vb  # Application-level event handling
├── App.config            # Application configuration
└── My Project/           # Project settings and resources
```

### Key Controls

| Control Name     | Type        | Purpose                          |
|-----------------|-------------|----------------------------------|
| `rdoSmall`       | RadioButton | Select Small pizza               |
| `rdoMedium`      | RadioButton | Select Medium pizza              |
| `rdoLarge`       | RadioButton | Select Large pizza               |
| `chkPlain`       | CheckBox    | Select Plain base                |
| `chkSauce`       | CheckBox    | Select Sauce base (+$2)          |
| `chkMushroom`    | CheckBox    | Add Mushroom topping             |
| `chkSausage`     | CheckBox    | Add Sausage topping              |
| `chkOnions`      | CheckBox    | Add Onions topping               |
| `chkGreenPepper` | CheckBox    | Add Green Pepper topping         |
| `chkSupreme`     | CheckBox    | Select Supreme pizza (locks toppings) |
| `btnOrder`       | Button      | Calculate and display order cost |
| `btnExit`        | Button      | Close the application            |
| `lblCost`        | Label       | Displays pizza cost              |
| `lblTax`         | Label       | Displays tax amount              |
| `lblTotal`       | Label       | Displays total amount            |

---

## Requirements

- **IDE:** Visual Studio 2019 or later
- **Framework:** .NET Framework 4.x (Windows Forms)
- **Language:** Visual Basic .NET (VB.NET)
- **OS:** Windows

---

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/your-username/PizzaShop2.git
```

### Open in Visual Studio

1. Open Visual Studio
2. Go to **File → Open → Project/Solution**
3. Navigate to the cloned folder and open `PizzaShop2.sln`

### Run the Application

- Press **F5** or click the **Start** button in the toolbar to build and run
- The Pizza Shop form will launch and be ready to use

---

## Business Logic Summary

```
If Supreme selected:
    cost = Supreme price for selected size
    Toppings disabled and cleared

Else:
    cost = Base price for selected size
    If Sauce selected: cost += $2
    For each topping selected: cost += toppingCost (size-dependent)

tax   = cost × 0.06
total = cost + tax
```

---


## License

This project is created for educational and learning purposes.


## Contact
- **Nidhi** - https://github.com/Nid-hex - nidhi07290@gmail.com
- **Project Link** - https://github.com/Nid-hex/PizzaShop




