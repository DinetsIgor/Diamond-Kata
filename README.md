This repository contains soltion for following coding test:
- Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Main logic of the solution is implemented with DiamondGenerator class.
This class contains method Generate, that accepts the char for generating the diamonmd and returns collection of strings, that represents diamond.
Also solution contains:
- Infrastracture code in Program.cs file that calls DiamondGenerator in console App
- Unit tests for DiamondGenerator class in DiamondKata.Tests project
- Exception DiamondValidationException that used for input parameters validation in DiamondGenerator class
- Example of exceptions hadling in Program.cs file
- Interface IDiamondGenerator that implemented in DiamondGenerator and demonstrates usage of Dependency inversion principle

To run the app build it and pass char for building the diamond as command line argument (for example: "diamond.exe T")
