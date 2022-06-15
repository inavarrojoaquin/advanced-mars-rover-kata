# SimpleMarsRover kata
Develop an API that moves the rovers around on the plateu.
The plateu is represented as a 10x10 grid, and a rover has state consisting of two parts

**its position on the grid (represented by an X,Y coordinate pair)
**the compass direction it's facing (represented by a letter, one of N,S,E,W)
**the starting position of the rover is 0:0:N

Rules:

The rover receives a char array of commands e.g. RMMLM and returns the finishing point after the moves e.g. 2:1:N

Scenarios
-> The starting position 0:0:N
-> Movement (M)
-> Turns direction to Left (L)
-> Turns direction to Right (R)
-> Movement and Turn to any Direction
-> Turn to any Direction and Movement

-> North direction (N)
-> South direction (S)
-> East direction  (E)
-> West direction  (W)

### Example

**Input:** RMMLM -> **output:** 2:1:N 
**Input:** MMRMMLM -> **output:** 2:3:N 
**Input:** MMMMMMMMMM -> **output:** 0:0:N (due to wrap-around)