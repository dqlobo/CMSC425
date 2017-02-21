###Name: David LoBosco
###Assignment Name: Programming Assignment I, Part II

#Download instructions:
Since this project is in the nested repo of an entire semester's projects, it is more practical to download via svn:

`svn export https://github.com/dqlobo/CMSC425.git/trunk/A1/P2_2`

From there, you can open the `P2_2/A1P2` folder in Unity and open the MainScene found in the `Scenes` folder. 
------------------------------------------------------------------------
##A. Required elements

My game implements all features specified in the following document:
https://www.cs.umd.edu/class/spring2017/cmsc425/Handouts/prog1.pdf

------------------------------------------------------------------------
##B. Additional elements

New to Part II: 
 - Improved resilience to the ball breaking through the board by changing the ball size and changing its collision capsule
 - Walls rotate a bit faster than specified in the document for more challenging gameplay.
 - Each pickup gets assigned a random color, and is also a small light source.
 - The goal circle also emits some light to indicate that the player should take notice.
 
From Part I:
 - I added the pretty wood texture and messed around with the particle generator! I also did this without referencing the "Tilt Maze" tutorial.

------------------------------------------------------------------------
##C. Known issues

New to Part II:
 - A slight under or overrotation of the walls sometimes occurs that is exacerbated over time. I suspect this relates to the deltaTime\*rotation being greater than 90 degrees. I added a fix for this, but the problem still appears sometimes.
 
From Part I:
 - Sometimes, if you catch the ground at a strange angle, the ball can burst through. (This could be a problem with collision detection and speed in Unity, as discussed in lecture.) I have accommodated to this problem by reducing the speed/depth of the tilt. I also played around with making the ground a bouncy material; This made the game more fun, but increased occurrences of the bug.

------------------------------------------------------------------------
##D. External resources

Unity Roll-a-Ball tutorial: https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/collecting-pick-objects?playlist=17141

Unity Documentation: https://docs.unity3d.com/ScriptReference/Rigidbody.MoveRotation.html

wood texture: https://freestocktextures.com/texture/closeup-wood-grain-plank,315.html

*The format of this document comes from a post on Piazza here: https://piazza.com/class/ixyg5h0fpdg2r4?cid=16*
