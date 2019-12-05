# SimpleDrive.cs
A (very simple) driving script for unity. Simply attach the script to an object and set speed and handling values to make it drive.

# Control
By default, you can use the arrow keys and WASD to control the veichle. To tweak those, adjust your input settings in unity. There is currently no way to control 2 different veichles with different sets of keys baked into the script. Depending on the possibility, that may happen.

# Handling and acceleration
The acceleration cannot be tweaked, but the top speed can.
The handling is currently just the car rotating, though we are going to try and make a more realistic handling mode if we can keep it simple. The speed of the rotation can be adjusted. 

# Creating a Driveable Veichle
Assuming you already have a plane to drive on (create a cube and set the scale to 1000, 1, 1000), it's easy to make your own drivable veichle:
1) Create a new object (whether a model or just a simple cube)
2) In inspector, add component > physics > Rigidbody
3) Set mass to 100 as an example
4) Drag the SimpleDrive script into the inspector
5) Set speed and handling values to something greater than 0 (for example, 30 and 50 work fine)
6) Add camera if needed
7) Enter play mode
