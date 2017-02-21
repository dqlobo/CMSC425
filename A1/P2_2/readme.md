#Name: David LoBosco
#Assignment Name: Programming Assignment 1, Part I
 
##The format of this document comes from a post on Piazza here: https://piazza.com/class/ixyg5h0fpdg2r4?cid=16

------------------------------------------------------------------------
##A. Required elements
 My game follows the following instructions, which I quote from the Piazza post: 
     - Use either the arrow keys or "WASD" to tilt the board
     - Maneuver the ball into the [navy blue] circle to win
     - Hit 'Q' or ESC to quit
     - Hit 'R' to restart
     - I allow a maximum tilt of [15] degrees
     
------------------------------------------------------------------------
##B. Additional elements
 
I added the pretty wood texture and messed around with the particle generator! I also did this without referencing the "Tilt Maze" tutorial.

------------------------------------------------------------------------
##C. Known issues
 
Sometimes, if you catch the ground at a strange angle, the ball can burst through. (This could be a problem with collision detection and speed in Unity, as discussed in lecture.) I have accommodated to this problem by reducing the speed/depth of the tilt. I also played around with making the ground a bouncy material; This made the game more fun, but increased occurrences of the bug.

------------------------------------------------------------------------
##D. External resources

Unity Roll-a-Ball tutorial: https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/collecting-pick-objects?playlist=17141

Unity Documentation: https://docs.unity3d.com/ScriptReference/Rigidbody.MoveRotation.html

wood texture: https://freestocktextures.com/texture/closeup-wood-grain-plank,315.html
