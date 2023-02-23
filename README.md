# Terrain Generator

This project houses a terrain generator created in Unity.

How it works:
- Generate a mesh of a specific size
- use the min and max height values to adjust each vertex of the mesh to form basic terrain

Next steps:
- Update the Y so that only values close to the current value can be chosen for the next vertex (create smoother terrain)
- Select 'chunks' of the mesh to be 'hills' or 'valleys' creating specific types of terrain using that chunk of vertices
- Take terrain, iterate over it to create a colour map which can be used to generate more detailed aspects
- Take this colour map and and apply transformations to the terrain that correspond to the map (water, rock, grass, etc...)
