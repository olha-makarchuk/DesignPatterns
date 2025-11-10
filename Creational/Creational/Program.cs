using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using Singleton;

SingletonProgram singletonProgram = new SingletonProgram();
singletonProgram.Start();

FactoryMethod factoryMethod = new FactoryMethod();
factoryMethod.Start();

AbstractFactory abstractFactory = new AbstractFactory();
abstractFactory.Start();

Builder builder = new Builder();
builder.Start();