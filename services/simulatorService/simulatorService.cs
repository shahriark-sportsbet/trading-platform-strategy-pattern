using Simulator.Interfaces;
using Simulator.Strategy;

namespace Simulator.Service;

public interface ISimulatorService
{
    void processSimulatorEvent(int line);
    void setSimulatorStrategy(ISimulatorStrategy SimulatorStrategy);

}

public class SimulatorService : ISimulatorService
{
    private ISimulatorStrategy SimulatorStrategy = new NBASimulatorStrategy();

    public SimulatorService(ISimulatorStrategy SimulatorStrategy)
    {
        this.SimulatorStrategy = SimulatorStrategy;
    }

    public void processSimulatorEvent(int line)
    {
        var simResult = SimulatorStrategy.runSimulation(line);

        var outcomeVector = SimulatorStrategy.generateOutcomeVector(simResult);

        SimulatorStrategy.publishResult(outcomeVector);
    }

    public void setSimulatorStrategy(ISimulatorStrategy SimulatorStrategy)
    {
        this.SimulatorStrategy = SimulatorStrategy;
    }
}
