namespace ConsoleApp1
{
    /// <summary>
    /// Analog <see cref="Action{T}"/>.
    /// </summary>
    /// <typeparam name="T">Parameter of Invoke.</typeparam>
    public interface IAction<in T>
    {
        /// <summary>
        /// Handler.
        /// </summary>
        /// <param name="parameter">Parameter.</param>
        void Invoke(T parameter);
    }
}
