namespace DiamondKata.Exceptions
{
    /// <summary>
    /// Describes exception occured during validation for diamond generation.
    /// </summary>
    public class DiamondValidationException : Exception
    {
        /// <summary>
        /// Creates new instance of class <see cref="DiamondValidationException"/>.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public DiamondValidationException(string message) : base(message)
        {
        }
    }
}
