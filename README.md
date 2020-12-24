# C17337523 Arkadiusz Rybicki Assignment1

Procedural City Generator 

The program generates a city with skyscrappers and smaller bulidings. The are cars that drive themselves in straight lines and fields of grass, bushes and flowers. Each street has a lines of trees generated within.

The YouTube link is below:

[![YouTube](http://img.youtube.com/CUSXBBhUEfc/0.jpg)](https://www.youtube.com/watch?v=CUSXBBhUEfc)


To begin with, we gather the data of the size of the city we are generating. We also use the PerlinNoise to function to calculate the mapgrid. diffLocation is used to swithc up the seed of the map each time the city is generated. PerlinNoise returns values of 0 to 1. Therefore, for easy maths we multiply by 10 and cast it as an integer.

Then the streets are built. The street on the X axis and Z axis are calculated and their distances between one another is chosen at random from the sepecified range of values. For the Z axis street, if the function detects an X axis street crossing through it, it will mark it as -3 for later use. -3 uses a crossroad prefab.

We generate the city with a simple function, using values. All according to teh mapWidth and mapHeight.


