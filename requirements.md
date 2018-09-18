Requirements for
  Part 1 of Project, due 09/20


**Definitions, Acronyms, and Abbreviations**<br>
Zombie Battle Box: the current name of the game being developed<br>
     (ZBB: acronym for Zombie Battle Box)<br>
Raycast teleportation: a line visible to the player in the game from the controller will indicate where the player will be teleported<br>
Raycast shooting: a line visible to the player in the game from the controller will indicate where the shot will land<br>
Zombie spawn: the creation of a new enemy<br>
OpenVR functionality: The plugin used to make VR work in Unity<br>

**Functional Requirements**
1. Walls may be used to the player's advantage<br>
  1.1 The player should be able to build walls the zombies cannot pass through<br>
  1.2 Their will be some limitation on how often a player can build walls<br>
2. The game should have sounds<br>
  2.1 When the player dies, play a death sound<br>
  2.2 When a zombie spawns, a small sound (like a ding) should indicate that<br>
  2.3 For guns, shooting should make a sound<br>
3. Raycast teleportation<br>
  3.1 When the player wants to move, it can use the controller to teleport to the desired location<br>
  3.2 A line from the controller will show the player where it will land<br>
4. Raycast shooting<br>
  4.1 When the player wants to shoot, it can use the controller to shoot towards the desired location<br>
  4.2 A line from the controller will show the player where it will land<br>
5. Implement OpenVR functionality<br>
  5.1 Install and integrate OpenVR Plugin so the game works on VR headsets<br>
6. Zombies are the antagonist of the game<br>
  6.1 Zombies will spawn at decreasing intervals (increasing the difficulty of the game as the player progresses)<br>
  6.2 Zombies will have finite health<br>
  6.3 The player can decrease a zombie’s health with its weapon<br>
  6.4 When a zombie’s health hits 0, it dies<br>
7. The player has the ability to die<br>
  7.1 Collision with a zombie decreases the player’s health at a linear rate<br>
  7.2 When the player health hits 0, the player dies and loses the current round in the game<br>
8. The game must be able to run without bugs that crash the game<br>
  8.1 The experience cannot be destroyed by bugs<br>
  8.2 The code behind the game should not have any compiler errors<br>
  <br><br>

**Use Case Diagram**
![usecasediagramp1](https://user-images.githubusercontent.com/38480615/45655648-f60a2e80-baa6-11e8-96dc-d87812edf646.png)
