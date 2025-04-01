# Firewalls

A console program that simulates a firewall management system, focusing on the use of inheritance, polymorphism, and method overloading to represent different types of firewalls, with advanced features that allow for greater customization and flexibility in management.

## Class Diagram

<img src="Img/diaClass.png" alt="Diagram" width="500">

## Features
- The program is designed using OOP concepts such as encapsulation, inheritance, and polymorphism to ensure modularity and scalability.
- The Firewall base class defines common attributes and methods, while derived classes (FirewallHardware, FirewallSoftware, FirewallAvanzado, and FirewallInteligente) extend its functionality.
- Methods like Activar() and MostrarEstado() are overridden in derived classes to provide specialized behavior for each firewall type.
- FirewallAvanzado contains instances of FirewallHardware and FirewallSoftware, integrating both functionalities.
- The system adapts based on the type of firewall, demonstrating polymorphic method execution.

## How to Use
* The menu shows the options of "Firewall Management"

<img src="Img/menu.png" alt="Principal" width="500">

1. Here you can create a Firewall type: Hardware, Software, Advanced or Intelligent.

<img src="Img/menu1.1.png" alt="Create" width="500">

- Enter the hardware firewall information

<img src="Img/CreaHard.png" alt="Create Hardware" width="500">

- Enter the software firewall information

<img src="Img/CreaSoft.png" alt="Create Software" width="500">

- Enter the hardware Advanced information

<img src="Img/CreaAdva.png" alt="Create Advanced" width="500">

- Enter the hardware Intelligent information

<img src="Img/CreaIntel.png" alt="Create Intelligent" width="500">

2. Toggle the firewall status between on and off.

<img src="Img/menu2.1.png" alt="Activate or deativate" width="500">

3. Add a rule for hardware firewall

<img src="Img/menu3.1.png" alt="Add a rule" width="500">

4. Shows the status of the Firewalls

<img src="Img/menu4.1.png" alt="Status" width="500">

## Built With
- C#


## 👨‍💻 Author
- **CalalpaGus** - [GitHub](https://github.com/CalalpaGus/)
