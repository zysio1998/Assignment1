
# Procedural City Generator

Name: Arkadiusz Rybicki

Student Number: C17337523 

Class Group: DT282/4

YouTube Video :

[![YouTube](http://img.youtube.com/watch?v=CUSXBBhUEfc/0.jpg)](https://www.youtube.com/watch?v=CUSXBBhUEfc&ab_channel=ArkadiuszRybicki)

# Description of the project

The program generates a city with skyscrappers and smaller bulidings. The are cars that drive themselves in straight lines and fields of grass, bushes and flowers. Each street has a lines of trees generated within.

# Instructions for use

You simply walk around and enjoy the city

There is a FPS character camera included.

W - forward

A - left

S - backwards

D - right

Shift - sprint

Space - jump

# How it works

To begin with, we gather the data of the size of the city we are generating. We also use the PerlinNoise to function to calculate the mapgrid. diffLocation is used to swithc up the seed of the map each time the city is generated. PerlinNoise returns values of 0 to 1. Therefore, for easy maths we multiply by 10 and cast it as an integer.

Then the streets are built. The street on the X axis and Z axis are calculated and their distances between one another is chosen at random from the sepecified range of values. For the Z axis street, if the function detects an X axis street crossing through it, it will mark it as -3 for later use. -3 uses a crossroad prefab.

We generate the city with a simple function, using values. All according to teh mapWidth and mapHeight.

The cars use a simple deltaTime function to smoothly run in straight lines.

To prevent the user going off the map I have added boxcolliders and all around the map and added cubes with a translucent colour to make it look better.


# What I am most proud of in the assignment

The way the skyscrappers look is pretty cool in my opinion. It took me a good while to make them look cool. All the other buildings look cool aswel. I am also proud of the cars moving.

