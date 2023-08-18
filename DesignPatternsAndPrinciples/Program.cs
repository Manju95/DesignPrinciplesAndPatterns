// See https://aka.ms/new-console-template for more information
using DesignPatternsAndPrinciples.DesignPatterns.BehaviouralPatterns;
using DesignPatternsAndPrinciples.DesignPatterns.StructuralPatterns;
using DotnetTraining.DesignPatterns.CreationalPatterns;
using DotnetTraining.DesignPrinciples.SOLID;

// SOLID Examples
SOLIDService solid = new SOLIDService();

// SRP
//solid.SRPExample();

// OCP
//solid.OCPExample();

// LSP
//solid.LSPExample();

// ISP
//solid.ISPExample();

// DIP
//solid.DIPExample();

/*--------------------------------------------------------------------------- */

// Design Patterns
CreationalPatternsConsumer cp = new CreationalPatternsConsumer();

// Abstract Factory invocation
//cp.RunAbstractFactory();

// Builder pattern
//cp.RunBuilderPattern();

// Factory Method Pattern
//cp.RunFactoryMethod();

StructuralPatternService sp = new StructuralPatternService();

// Proxy
//sp.RunProxy();


BehaviroalPatternService bp = new BehaviroalPatternService();

// ChainOfResponsiblity
//bp.RunChainOfResponsiblity();

// Command Pattern
//bp.RunCommandPattern();

// Interpreter Pattern
//bp.RunInterpreter();

// Iterator Pattern
//bp.RunIterator();

// Mediator Pattern
//bp.RunMediator();


Console.ReadLine();