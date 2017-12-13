# VectorSwizzles

Inspired by [Bunny83's answer](https://answers.unity.com/questions/1441682/create-custom-constructors-for-monobehaviors-vecto.html) to my question at the Unity forums.

[According to Wikipedia](https://en.wikipedia.org/wiki/Swizzling_%28computer_graphics%29)
A swizzle is simply rearranging the rows of a matrix/vector. 
For example, if A = {1,2,3,4}, where the components are x, y, z, and w respectively, you could compute B = A.wwxy, whereupon B would equal {4,4,1,2}.

Are you tired of having to constantly call a vector's individual X, Y, or Z component to make a new Vector3 with just one difference in Unity?

Is this a common site in your scripting files?

```
transform.position = new Vector3(transform.position.x, transform.position.y, 10);
```
Cut that tedium with these simple "swizzle" extended methods for Unity Vectors.
```
transform.position = transform.position.XY_(10);
```

Simply pick a file for you to place in anywhere in your Unity project, and the appropriate method extensions should appear.

# Using the Swizzles

All functions extend the Vector3 value type and take in either a Vector2 or Vector3.

The method names simply represent the layout of the next Vector and what components of the original vector go to what positions. For example;
```
Vector2 vect = new Vector2(1, 2);
Vector2 example = vect._YX(5);	// example will be (5, 2) as it will implicitly convert to a Vector2. Be careful here!
Vector3 another = vect._YX(5);  // example will be (5, 2, 1)
```
An underscore ("\_") indicates a user defined component, defaulting to 0 if nothing is passed in.

```
Vector2 2Dvector = new Vector2(1, 2);
Vector3 3Dvector = new Vector3(3, 4, 5);

// Create a new Vector3 out of 2Dvector
Vector3 someVector = 2Dvector.XY_();		// (
Vector3 another = 3Dvector.ZY_().X_Y(26).YYZ();		// (5, 4, 0) -> (5, 26, 4) -> (26, 26, 4)
```

# Files

VectorSwizzles.cs - contains all the swizzle functions for both Vector2 and Vector3

Feel free to remove any extraneous functions you feel you don't need. 
