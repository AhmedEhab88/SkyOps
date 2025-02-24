---

## **Flight Management System - Requirements Document**

---
### **Business Requirements**

#### **1. User Roles**
The system should support the following user roles:
1. **Admin**:
   - Manage flights, airports, and airlines.
   - View reports and analytics.
2. **Customer**:
   - Search for flights, book tickets, and manage reservations.
   - View booking history and payment receipts.

#### **2. Core Features**
1. **Flight Search**:
   - Customers should be able to search for flights based on:
     - Departure and arrival airports.
     - Date and time of travel.
     - Number of passengers.
   - Display available flights with details like:
     - Flight number, airline, departure/arrival times, duration, and price.
2. **Flight Booking**:
   - Customers should be able to:
     - Select a flight and book tickets for one or more passengers.
     - Choose seat preferences (e.g., window, aisle).
     - Add optional services (e.g., extra baggage, meals).
3. **Payment System**:
   - Customers should be able to pay for their bookings using multiple payment methods (e.g., credit card, PayPal).
   - Receive a confirmation email with booking details and ticket.
4. **Flight Management (Admin)**:
   - Admins should be able to:
     - Add, update, and remove flights.
     - Manage flight schedules, including departure/arrival times and routes.
     - View all bookings for a specific flight.
5. **Reporting and Analytics**:
   - Admins should be able to generate reports on:
     - Total bookings per flight.
     - Revenue generated.
     - Most popular routes.

#### **3. Non-Functional Requirements**
1. **Scalability**:
   - The system should handle a large number of users and flights without performance degradation.
2. **Security**:
   - Sensitive user data (e.g., passwords, payment information) must be encrypted.
   - Implement role-based access control (e.g., users vs. admins).
3. **Usability**:
   - The system should have an intuitive and user-friendly interface.
4. **Maintainability**:
   - The codebase should be modular, well-documented, and easy to extend.

---

### **Technical Requirements**

#### **1. Programming Language and Framework**
- Use **C#** and **.NET** for development.
- Use **Entity Framework Core** for database interactions.

#### **2. Database**
- Use a relational database (e.g., SQL Server, MySQL) to store data.
- Design a normalized database schema to support the system’s requirements.

#### **3. User Interface**
- Develop a **console-based interface** for simplicity, with the option to extend to a web or desktop UI in the future.

#### **4. Logging**
- Implement logging to track system events (e.g., bookings, errors).

#### **5. Testing**
- Write unit tests for core functionalities (e.g., flight search, booking).

---

### **OOP and Design Pattern Requirements**

#### **1. OOP Principles**
- **Encapsulation**:
  - Hide internal implementation details (e.g., flight pricing logic, seat availability).
- **Inheritance**:
  - Use inheritance to model different types of users (e.g., `User`, `Admin`) and flights (e.g., `DomesticFlight`, `InternationalFlight`).
- **Polymorphism**:
  - Implement polymorphic behavior for payment methods (e.g., `CreditCardPayment`, `PayPalPayment`).
- **Abstraction**:
  - Use abstract classes or interfaces to define common behaviors (e.g., `IPaymentMethod`, `IBookingService`).

#### **2. Design Patterns**
- **Singleton**:
  - Use the Singleton pattern for logging or database connection management.
- **Factory Method**:
  - Use the Factory pattern to create different types of flights or payment methods.
- **Observer**:
  - Use the Observer pattern to notify users about flight status updates (e.g., delays, cancellations).
- **Strategy**:
  - Use the Strategy pattern to implement different pricing strategies (e.g., discounts for students, seniors).
- **Decorator**:
  - Use the Decorator pattern to add optional services (e.g., extra baggage, meals) to a booking.

---

### **Deliverables**

1. **Core System**:
   - A fully functional flight management system with user and admin functionalities.
2. **Documentation**:
   - A detailed design document explaining the OOP principles and design patterns used.
   - A user manual for the system.
3. **Source Code**:
   - Well-structured, modular, and documented code.
4. **Test Cases**:
   - Unit tests for all major functionalities.

---

### **Timeline**

- **Phase 1**: Requirements gathering and system design (1 week).
- **Phase 2**: Core system development (3 weeks).
- **Phase 3**: Testing and bug fixing (1 week).
- **Phase 4**: Documentation and final delivery (1 week).

---

### **Success Criteria**

The project will be considered successful if:
1. All functional and non-functional requirements are met.
2. The system demonstrates a strong understanding of OOP principles and design patterns.
3. The code is clean, modular, and well-documented.
4. The system is tested and free of critical bugs.

---

This project will challenge you to think critically about system design, apply OOP principles effectively, and use design patterns to solve real-world problems. Good luck! ✈️🚀