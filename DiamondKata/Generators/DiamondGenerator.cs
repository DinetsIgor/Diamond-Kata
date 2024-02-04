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
            if (character < DiapasonCharacterStart || character > DiapasonCharacterEnd)
            {
                throw new DiamondValidationException($"Invalid character '{character}'.");
            }

            var charsCount = character - DiapasonCharacterStart + 1;
            var linesCount = charsCount * 2 - 1;
            var diamondLines = new string[linesCount];

            for (char currentChar = DiapasonCharacterStart; currentChar < DiapasonCharacterStart + charsCount; currentChar++)
            {
                var lineIndexOpening = currentChar - DiapasonCharacterStart;
                var lineIndexClosing = linesCount - lineIndexOpening - 1;
                var edgeCharsCount = charsCount + DiapasonCharacterStart - currentChar - 1;
                var innerCharsCount = lineIndexOpening * 2 - 1;

                var diamondLine = new StringBuilder();
                diamondLine.Append(EmptySpaceChar, edgeCharsCount)
                            .Append(currentChar);

                if (innerCharsCount > 0)
                {
                    diamondLine.Append(EmptySpaceChar, innerCharsCount)
                                .Append(currentChar);
                }

                diamondLine.Append(EmptySpaceChar, edgeCharsCount);

                diamondLines[lineIndexOpening] = diamondLine.ToString();
                if (lineIndexOpening != lineIndexClosing)
                {
                    diamondLines[lineIndexClosing] = diamondLines[lineIndexOpening];
                }
            }

            return diamondLines;
        }
    }
}
