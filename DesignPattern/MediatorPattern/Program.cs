// See https://aka.ms/new-console-template for more information
using MediatorPattern;
using MediatorPattern.LandLady;
using MediatorPattern.Tentant;

//迪米特法则  类知道的其他类越少越好

ALandLady landLadyA = new LandLadyA();
landLadyA.SendMessage();


ALandLady landLadyB = new LandLadyB();
landLadyB.SendMessage();


ATenant tenantA = new TenantA();
tenantA.SendMessage();

ATenant tenantB = new TenantB();
tenantB.SendMessage();



