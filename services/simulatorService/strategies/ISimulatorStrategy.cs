namespace Simulator.Interfaces;

public interface ISimulatorStrategy
{
    int[] runSimulation(int line);
    int[] generateOutcomeVector(int[] simResult);
    void publishResult(int[] result);
}

