using Simulator.Interfaces;

namespace Simulator.Strategy;

public class NBASimulatorStrategy : ISimulatorStrategy
{
    public int[] generateOutcomeVector(int[] simResult)
    {
        return simResult;
    }

    public void publishResult(int[] result)
    {
        Console.WriteLine("[{0}]", string.Join(", ", result));
    }

    public int[] runSimulation(int line)
    {
        return [1, line];
    }
}

