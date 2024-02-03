using DiamondKata.Exceptions;
using DiamondKata.Generators.Interfaces;
using System.Text;

namespace DiamondKata.Generators
{
    /// <summary>
    /// Provides functionality for generating diamond based on the specified character.
    /// </summary>
    public class DiamondGenerator : IDiamondGenerator
    {
        private const char DiapasonCharacterStart = 'A';

        private const char DiapasonCharacterEnd = 'Z';

        private const char EmptySpaceChar = ' ';

        /// <inheritdoc/>
        public IEnumerable<string> Generate(char character)
        {
            throw new NotImplementedException();
        }
    }
}
