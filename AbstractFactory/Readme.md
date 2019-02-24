##### Frequency: high (+++++)

# Definition

Provides an interface for creating families of related or dependent objects (products)
without specifying their concrete classes.

# Participants

### AbstractFactory
Declares an interface for operations which create abstract products.

### ConcreteFactory (Factory1, Factory2)
Implements the operations to create concrete product objects.

### AbstractProduct (AbstractProductA, AbstractProductB)
Declares an interface for a type of product object.

### ConcreteProduct (ProductA1, ProductB2, ProductA2, ProductB2)
Defines a product object to be created by the corresponding concrete factory.
Implements the **AbstractProduct** interface

### Client
Uses interfaces declared by **AbstractFactory** and **AbstractProduct** classes.

