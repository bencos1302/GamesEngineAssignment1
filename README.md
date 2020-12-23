# Procedural Mountain Exploration
Student Name: Ben Cosgrave<br>
Student Number: C17445274<br>
Class: TU856/4 (DT228/4)

# Project Description
This project focused on the implementation of a procedurally generated explorable terrain. A sub-goal was to facilitate the implementation of a near-infinite world, which was achieved with thanks to research and reference to existing work within the realm of procedural terrain generation. The player controls an arcade-styled car, which navigates the terrain in play-mode. There is also the option to preview a terrain tile in scene view, where the style of map generation can be changed to various different landscapes such as flat or mountaineous terrain.

# How it works?
The main technical aspect of the project is in using a perlin noise texture generator, which is then fed to a mesh creation class in order to generate terrain chunks. Several concepts were adopted from Sebastian Lague's YouTube series on procedural generation such as level-of-detail adjustment and chunk rendering in order to improve performance of the program.

# Demonstration
[https://youtu.be/qbrCwJExKuc](https://youtu.be/qbrCwJExKuc)

# References
Sebastian Lague, https://www.youtube.com/c/SebastianLague 

# What I am most proud of in this assignment
I'm most proud of managing to implement an infinite procedural world generation. Growing up I was a huge fan of the popular open-world survival game Minecraft and was always stumped at how the infinite world generation in that game works. I also learned quite a bit of fun concepts within Unity in undertaking this project, most enjoyably in using the relatively new ShaderGraph for creating materials and cool visual effects, which provided the terrain textures for my procedural mountain exploration game. Obviously the project's direction shifted into a more terrain-based procedural generation implementation as opposed to a city, but regardless I was very happy with the outcome and satisfied in seeing the capabilities of Unity.

# Proposal (Submitted Earlier)

For this assignment, I plan to create a procedurally generated city with a road on which you can drive a vehicle.
The general design for the city will be based on a layout of modular blocks, similar to the likes of Barcelona or New York City.
As of now, the goal is to implement the system of a procedurally generated road / city, however if all goes to plan I will extend the features of the game to some more exciting things.

As for building models, I think it would be a good idea to create some basic low-poly designs in Blender to capture the kind of style I would like. However, if this is too much of a commitment, I'll refer to the Unity Asset store for them in the meantime. Also, the idea of making each block "float" up to meet the previous end of the road is interesting to me and I feel like it would be a great implementation for the overall feel of the game.

The game manager will control the instantiation of new city blocks based on the car's proximity to the end of the road. If the car is driving fast, then the generation will keep up with it, similarly if it is driving slowly the city generation won't go ahead of it. Perhaps I could design different city areas modules, where different districs of the city stay to the theme of industrial, commericial or residential.

I think this will be quite a challenge to implement efficiently, but it sounds like a very enjoyable project and look forward to seeing how it will end up.
