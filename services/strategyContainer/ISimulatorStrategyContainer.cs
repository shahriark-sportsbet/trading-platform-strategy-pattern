using Simulator.Enum;
using Simulator.Interfaces;

namespace Strategy.Interfaces;

public interface ISimulatorStrategyContainer
{
    void addStrategy(Competation competation, ISimulatorStrategy strategy);
    ISimulatorStrategy getStrategy(Competation competation);
}
