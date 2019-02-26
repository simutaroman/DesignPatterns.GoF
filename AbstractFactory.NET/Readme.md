##### Frequency: high (+++++)

# Definition

Provides an interface for creating families of related or dependent objects (products)
without specifying their concrete classes. 

# Participants ("Real world adopted to .NET" example)

### AbstractFactory (IFurnitureFactory)
Declares an interface for operations which create abstract products.

### ConcreteFactory (ModernFurnitureFactory, ProvenceFurnitureFactory)
Implements the operations to create concrete product objects.

### AbstractProduct (ISofa, IChair)
Declares an interface for a type of product object.

### ConcreteProduct (ModernSofa, ProvenceSofa, ModernChair, ProvenceChair)
Defines a product object to be created by the corresponding concrete factory.
Implements corresponded **AbstractProduct** interface

### Client (FurnitureSeller)
Uses interfaces declared by **AbstractFactory** and **AbstractProduct** classes.

