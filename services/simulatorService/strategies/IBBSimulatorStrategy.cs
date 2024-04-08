using Simulator.Interfaces;

namespace Simulator.Strategy;

public class IBBSimulatorStrategy : ISimulatorStrategy
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
        return [3, line];
    }
}

