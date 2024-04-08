using Simulator.Enum;
using Simulator.Event;
using Simulator.Service;
using Simulator.Strategy;
using Strategy.Container;

// Initialise sample events
Event[] events = { new Event(Competation.IBB, 5), new Event(Competation.WNBA, 2), new Event(Competation.WNBA, 4), new Event(Competation.NBA, 8) };

var simulatorStrategyContainer = new SimulatorStrategyContainer();
simulatorStrategyContainer.addStrategy(Competation.NBA, new NBASimulatorStrategy());
simulatorStrategyContainer.addStrategy(Competation.WNBA, new WNBASimulatorStrategy());
simulatorStrategyContainer.addStrategy(Competation.IBB, new IBBSimulatorStrategy());

var simulatorService = new SimulatorService(new NBASimulatorStrategy());

foreach (Event ev in events)
{
    try
    {
        Console.WriteLine("Processing {0} event", ev.competation);
        var strategy = simulatorStrategyContainer.getStrategy(ev.competation);
        simulatorService.setSimulatorStrategy(strategy);
        simulatorService.processSimulatorEvent(ev.line);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Failed to hangle {0} event with line {0}", ev.competation, ev.line);
        Console.WriteLine(ex.ToString());
    }
}