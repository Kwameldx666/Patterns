# 🎨 Design Patterns in C# / Паттерны Проектирования на C#

[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![C# Version](https://img.shields.io/badge/C%23-12.0-green)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)]()

> **English** | [Русский](#русская-версия)

A comprehensive collection of **Design Patterns** implemented in **C# (.NET 8.0)**. This repository serves as an educational resource for developers learning object-oriented design principles and software architecture patterns.

## 📋 Table of Contents

- [🎯 Overview](#-overview)
- [🏗️ Project Structure](#️-project-structure)
- [🔧 Getting Started](#-getting-started)
- [📚 Design Patterns](#-design-patterns)
  - [🏭 Creational Patterns](#-creational-patterns)
  - [🏛️ Structural Patterns](#️-structural-patterns)
  - [⚡ Behavioral Patterns](#-behavioral-patterns)
  - [🎯 SOLID Principles](#-solid-principles)
- [💻 Usage Examples](#-usage-examples)
- [🚀 How to Run](#-how-to-run)
- [🤝 Contributing](#-contributing)

## 🎯 Overview

This project demonstrates the implementation of **23 classic Gang of Four (GoF) design patterns** plus additional patterns and **SOLID principles** in C#. Each pattern is implemented with clear, documented code examples that showcase real-world applications.

### ✨ Features

- ✅ **Complete GoF Pattern Collection** - All 23 classic design patterns
- ✅ **SOLID Principles** - Comprehensive examples of clean code principles
- ✅ **Two Learning Paths** - Organized educational examples and practice implementations
- ✅ **Modern C#** - Uses .NET 8.0 with latest language features
- ✅ **Clean Code** - Well-documented, readable implementations
- ✅ **Real-world Examples** - Practical scenarios and use cases

## 🏗️ Project Structure

```
📁 Patterns/
├── 📁 Educate/                    # 📚 Educational Examples
│   ├── 📁 Creational patterns/    # 🏭 Object creation patterns
│   ├── 📁 Structural Patterns/    # 🏛️ Object composition patterns
│   ├── 📁 Behavior Patterns/      # ⚡ Object interaction patterns
│   └── 📁 SOLID/                  # 🎯 SOLID principles
├── 📁 Repeat/                     # 🔄 Practice Implementations
│   ├── 📁 Abstract Factory(2)/
│   ├── 📁 Builder/
│   ├── 📁 Chain of Responsibility/
│   └── ... (additional implementations)
├── 📄 Program.cs                  # 🚀 Main entry point
├── 📄 Patterns.csproj            # ⚙️ Project configuration
└── 📄 README.md                  # 📖 This documentation
```

## 🔧 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or VS Code
- Basic knowledge of C# and OOP principles

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Kwameldx666/Patterns.git
   cd Patterns
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

## 📚 Design Patterns

### 🏭 Creational Patterns
*Patterns that deal with object creation mechanisms*

| Pattern | Description | Implementation |
|---------|-------------|----------------|
| 🏗️ **Abstract Factory** | Creates families of related objects | ✅ Multiple implementations |
| 👷 **Builder** | Constructs complex objects step by step | ✅ Implemented |
| 🏭 **Factory Method** | Creates objects without specifying exact classes | ✅ Multiple versions |
| 📋 **Prototype** | Creates objects by cloning existing instances | ✅ Implemented |

### 🏛️ Structural Patterns
*Patterns that deal with object composition*

| Pattern | Description | Implementation |
|---------|-------------|----------------|
| 🔌 **Adapter** | Allows incompatible interfaces to work together | ✅ Implemented |
| 🌉 **Bridge** | Separates abstraction from implementation | ✅ Multiple versions |
| 📦 **Composite** | Composes objects into tree structures | ✅ Multiple implementations |
| 🎨 **Decorator** | Adds behavior to objects dynamically | ✅ Multiple versions |
| 🏢 **Facade** | Provides simplified interface to complex subsystem | ✅ Implemented |
| 🔮 **Proxy** | Provides placeholder or surrogate for another object | ✅ Implemented |

### ⚡ Behavioral Patterns
*Patterns that focus on communication between objects*

| Pattern | Description | Implementation |
|---------|-------------|----------------|
| ⛓️ **Chain of Responsibility** | Passes requests along chain of handlers | ✅ Multiple implementations |
| 📋 **Command** | Encapsulates requests as objects | ✅ Implemented |
| 🗃️ **Memento** | Captures and restores object state | ✅ Multiple versions |
| 📡 **Observer** | Notifies multiple objects about state changes | ✅ Implemented |
| 🔄 **State** | Allows object to alter behavior when state changes | ✅ Multiple implementations |
| 🎯 **Strategy** | Defines family of algorithms and makes them interchangeable | ✅ Multiple versions |
| 🚶 **Visitor** | Separates algorithms from object structure | ✅ Multiple implementations |
| 📢 **Mediator** | Defines how objects interact with each other | ✅ Implemented |
| 🪶 **Flyweight** | Minimizes memory usage by sharing data | ✅ Implemented |

### 🎯 SOLID Principles
*Fundamental principles of object-oriented design*

| Principle | Description | Implementation |
|-----------|-------------|----------------|
| **S** - Single Responsibility | Class should have only one reason to change | ✅ Examples |
| **O** - Open/Closed | Open for extension, closed for modification | ✅ Examples |
| **L** - Liskov Substitution | Subtypes must be substitutable for base types | ✅ Examples |
| **I** - Interface Segregation | Many specific interfaces vs one general interface | ✅ Examples |
| **D** - Dependency Inversion | Depend on abstractions, not concretions | ✅ Examples |

## 💻 Usage Examples

### Composite Pattern Example
```csharp
// Create graphics components
Graphic box = new Box("MainContainer");
Graphic box2 = new Box("SubContainer");
Graphic product1 = new Product("Document");
Graphic product2 = new Product("Image");

// Compose the structure
box2.Add(product1);
box2.Add(product2);
box.Add(box2);

// Display the entire structure
box.ShowGraphic();
```

### Factory Method Example
```csharp
// Create different types of employees using factory
EmployeeFactory factory = new ConcreteEmployeeFactory();
IEmployee developer = factory.CreateEmployee("Developer");
IEmployee manager = factory.CreateEmployee("Manager");

developer.Work(); // Output: Developer is coding...
manager.Work();   // Output: Manager is managing...
```

## 🚀 How to Run

1. **Navigate to the project directory**
   ```bash
   cd Patterns
   ```

2. **Run the application**
   ```bash
   dotnet run
   ```

3. **Or run specific examples**
   ```bash
   # Modify Program.cs to test different patterns
   dotnet run --project Patterns
   ```

## 🤝 Contributing

Contributions are welcome! Please feel free to submit pull requests or create issues for bugs and feature requests.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## Русская Версия

# 🎨 Паттерны Проектирования на C#

Полная коллекция **паттернов проектирования**, реализованных на **C# (.NET 8.0)**. Этот репозиторий служит образовательным ресурсом для разработчиков, изучающих принципы объектно-ориентированного проектирования и архитектурные паттерны.

## 🎯 Обзор

Данный проект демонстрирует реализацию **23 классических паттернов "Банды четырех" (GoF)** плюс дополнительные паттерны и **принципы SOLID** на языке C#. Каждый паттерн реализован с четким, документированным кодом, демонстрирующим применение в реальных сценариях.

### ✨ Особенности

- ✅ **Полная коллекция GoF паттернов** - Все 23 классических паттерна проектирования
- ✅ **Принципы SOLID** - Исчерпывающие примеры принципов чистого кода
- ✅ **Два пути обучения** - Организованные образовательные примеры и практические реализации
- ✅ **Современный C#** - Использует .NET 8.0 с новейшими возможностями языка
- ✅ **Чистый код** - Хорошо документированные, читаемые реализации
- ✅ **Реальные примеры** - Практические сценарии и случаи использования

## 📚 Категории Паттернов

### 🏭 Порождающие Паттерны
Паттерны, которые работают с механизмами создания объектов:
- 🏗️ Abstract Factory (Абстрактная фабрика)
- 👷 Builder (Строитель)  
- 🏭 Factory Method (Фабричный метод)
- 📋 Prototype (Прототип)

### 🏛️ Структурные Паттерны
Паттерны, которые работают с композицией объектов:
- 🔌 Adapter (Адаптер)
- 🌉 Bridge (Мост)
- 📦 Composite (Компоновщик)
- 🎨 Decorator (Декоратор)
- 🏢 Facade (Фасад)
- 🔮 Proxy (Заместитель)

### ⚡ Поведенческие Паттерны
Паттерны, которые фокусируются на взаимодействии между объектами:
- ⛓️ Chain of Responsibility (Цепочка обязанностей)
- 📋 Command (Команда)
- 🗃️ Memento (Хранитель)
- 📡 Observer (Наблюдатель)
- 🔄 State (Состояние)
- 🎯 Strategy (Стратегия)
- 🚶 Visitor (Посетитель)
- 📢 Mediator (Посредник)
- 🪶 Flyweight (Приспособленец)

## 🚀 Как Запустить

1. **Клонируйте репозиторий**
   ```bash
   git clone https://github.com/Kwameldx666/Patterns.git
   cd Patterns
   ```

2. **Восстановите зависимости**
   ```bash
   dotnet restore
   ```

3. **Соберите проект**
   ```bash
   dotnet build
   ```

4. **Запустите приложение**
   ```bash
   dotnet run
   ```

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- Gang of Four for the foundational design patterns
- Microsoft for the excellent .NET ecosystem
- The C# community for continuous inspiration

---

*Made with ❤️ for the developer community*