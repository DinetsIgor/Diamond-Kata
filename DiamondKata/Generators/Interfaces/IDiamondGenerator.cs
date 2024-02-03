using DiamondKata.Exceptions;

namespace DiamondKata.Generators.Interfaces
{
    /// <summary>
    /// Provides functionality for generating diamond based on the character.
    /// </summary>
    public interface IDiamondGenerator
    {
        /// <summary>
        /// Generates diamond for the specific character.
        /// </summary>
        /// <param name="character">Character for generating the diamond.</param>
        /// <returns>Collection of strings that represents diamond.</returns>
        /// <exception cref="DiamondValidationException">Validation exception that occurs during params validation.</exception>
        IEnumerable<string> Generate(char character);
    }
}
