using Simulator.Enum;
using Simulator.Interfaces;
using Strategy.Interfaces;

namespace Strategy.Container;

public class SimulatorStrategyContainer : ISimulatorStrategyContainer
{
    private readonly Dictionary<Competation, ISimulatorStrategy> StrategyMap;

    public SimulatorStrategyContainer()
    {
        StrategyMap = new Dictionary<Competation, ISimulatorStrategy>();
    }
    public void addStrategy(Competation competation, ISimulatorStrategy strategy)
    {
        StrategyMap.Add(competation, strategy);
    }

    public ISimulatorStrategy getStrategy(Competation competation)
    {
        return StrategyMap[competation];
    }
}