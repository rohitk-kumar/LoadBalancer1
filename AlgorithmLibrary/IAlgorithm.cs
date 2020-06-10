using System.Collections.Generic;

namespace AlgorithmLibrary
{
    public interface IAlgorithm
    {
        IList<T> RunAlgorithm<T, U>(IList<T> list, Dictionary<string, U> dict);
        IList<T> RunAlgorithm<T>(IList<T> list);
    }
}