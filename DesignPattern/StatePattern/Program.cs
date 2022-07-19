// See https://aka.ms/new-console-template for more information

using StatePattern;
using StatePattern.Observers;
using StatePattern.State;

var traficLamp = new TraficLampContext();
traficLamp.AddObserver(new TrafficPolice());
traficLamp.AddObserver(new Driver());


ITrafficLampState redState = new RedState();
redState.DoAction(traficLamp);

ITrafficLampState yellowState = new YellowState();
yellowState.DoAction(traficLamp);

ITrafficLampState greenState = new GreenState();
greenState.DoAction(traficLamp);

