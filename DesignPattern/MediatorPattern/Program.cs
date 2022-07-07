// See https://aka.ms/new-console-template for more information
using MediatorPattern.LandLady;
using MediatorPattern.Tentant;

ITenant tenantA = new TenantA();
tenantA.SendMessage();

ITenant tenantB = new TenantB();
tenantB.SendMessage();

LandLadyA landLady = new LandLadyA();
landLady.SendMessage();



