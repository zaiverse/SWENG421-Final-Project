# SWENG421-Final-Project
<h1>Description</h1>
The idea for developing this system comes from the growing desire to have websites for selling various products. New products are created every day and the making of a mock retail website will be a real-world application. There are several types of these systems. Some work well and others not so much. We want to design a system that can handle the addition of products and ease of interaction for the user. We want to make the system flexible and convenient for the system manager to add various classes without extensive code changes.

The functional features of the system will include features such as creating an order, product filtering, handling a transaction, and managing the state of an order. These features are useful as the order management will be able to store and perform calculations on groups of objects, while the product filtering will add ease of use to the system for the client. The transaction handling and state order tracking are luxuries that will help the client be able to pay for and get information about the purchased products. The nonfunctional features that the system will include will be features such as high levels of scalability, usability, and maintainability. 

The concept of completing the project with the selected 5 designs is to allow the system to remain flexible for the system manager. This flexibility will allow for the easy inclusion of new products and filters. If the system is separated properly, it should be easier for a new member to understand the code and fix errors as well. The design should also have the benefit of good usability as the customer that interacts with it should not need to have any additional information to be able to use the product with a positive experience.

The design patterns chosen for this project are outlined as follows: 

<h3>Creational Pattern: Builder</h3>
We will employ the Builder pattern to construct products, selecting different builders based on the product category. This approach enables modular construction and customization of products according to their specific attributes and requirements. 

<h3>Partitioning Pattern: Filter </h3>
The Filter pattern facilitates the search for products based on various criteria, such as category, price, and range. This pattern is particularly beneficial for us as it supports the dynamic chaining of filters, allowing for the application of multiple criteria to refine the list of products effectively. 

<h3>Structural Pattern: Decorator </h3>
The Decorator will allow for the user to order a product that via the builder but use a decorator to apply a design to the product. This will give the user full control over the customizable features of the program. This has the added benefit of keeping the designs separated, so newly created designs can be added with ease. 

<h3>Behavioral Pattern: State </h3>
The State pattern is adept at managing the state transitions of orders within the retail system, such as order placement, payment, and delivery statuses. By allowing the order object to change its behavior in response to changes in its internal state, the system can more accurately reflect and manage the lifecycle of an order.

<h3>Concurrency Pattern: Future </h3>
The Future pattern is designed to handle asynchronous operations, such as checking inventory levels or processing payments. This pattern enables the system to remain responsive and continue operating while waiting for these operations to be completed. 

<h3>Language that will be implemented: C# </h3>
C# is a versatile programming language supported by the .NET framework, which offers a comprehensive environment for developing various applications, including graphical user interfaces (GUIs). Among its many libraries, .NET includes Windows Presentation Foundation (WPF), a powerful toolset specifically designed for creating sophisticated and responsive UIs. WPF leverages XAML (Extensible Application Markup Language) to separate the UI design from the backend logic, enabling a more modular and manageable development process. 
