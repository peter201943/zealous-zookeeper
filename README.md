







# Zealous Zookeeper









## Discussion
- Experimental Endless-Waves Top-Down 2-Player Split-Control Game for Drexel University
- [See the Trailer on YouTube]() (FIXME)
- Project 2 Team 2, `2021-02-08` to `2021-02-22`
- [Peter Mangelsdorf](https://github.com/peter201943/)
- [Erjun ]() (FIXME)
- [Dawei Chi]() (FIXME)
- Various ideas for this Project
- Attempting new style, very fundamental
- Started `2021-02-10T17:00:00-05:00`
- [GitHub Repository at **Zealous Zookeeper*](https://github.com/peter201943/zealous-zookeeper)









## Installation
- Check the [Releases tab](https://github.com/peter201943/zealous-zookeeper/releases/) for standalone executables









## Contributing
- Install [**Unity `2019.4 LTS`**](https://unity.com/releases/2019-lts)
- Install [**Git**](https://git-scm.com/)









## Architecture
- Examine the FileStructure
```
├───Assets
│   ├───Animal
│   ├───Bear
│   ├───Deer
│   ├───Eagle
│   ├───Food
│   ├───Forest
│   ├───Game
│   ├───Player
│   │   ├───Mover
│   │   └───Shooter
│   ├───Rabbit
│   └───Scenes
```
- Each Folder contains the **Sounds**, **Images**, **Scripts**, **Models**, and **Prefabs** for a single Entity
- (Only the script is in each folder)
- **Animal**
  - The Enemy Template and Damageable
  - Expects to be fed Nothing
  - None Attack
- **Bear**
  - An Enemy
  - Expects to be fed Honey
  - Surprise-Slashing Attack
- **Deer**
  - An Enemy
  - Expects to be fed Cracker
  - Charging Attack
- **Eagle**
  - An Enemy
  - Expects to be fed Fish
  - Swooping-Strafe Attack
- **Monkey**
  - An Enemy
  - Expects to be fed Banana
  - Throwing Attack
- **Rabbit**
  - An Enemy
  - Expects to be fed Carrot
  - Swarming Attack
- **Food**
  - Types: Honey, Cracker, Fish, Banana, Carrot
- **Forest**
  - **FoodSpawner**
    - Controls spawning food for a particular location based off of time
  - **FoodSpawnerSpawner**
    - Controls spawning of food spawners
    - Uses pre-defined prefabs and turns their invisibility on/off based off of groups
  - **AnimalSpawner**
    - Controls spawning of enemies in the level
- **Game**
  - Controls Scoring, Winning, Losing
- **Player**
  - **Mover**
    - HUD
      - Enemy directions
      - Food directions
      - Health Bar
    - WASD Keys Input
    - Health/Damageable
  - **Shooter**
    - HUD
      - Aiming Reticle
      - Ammo Bars
    - Mouse Input
    - 1,2,3,4,5 Keys Input
    - HoneyAmmo Amount
    - CrackerAmmo Amount
    - FishAmmo Amount
    - BananaAmmo Amount
    - CarrotAmmo Amount
- **Scenes**
  - Where we put the level and associated NavMeshes
  - **NavMeshes**
    - Each NavMesh is considered is own level
    - Hence we store them in this folder










## Relevant Snack-Attack Files
- [`AntiChocolateAttack.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Player/Gun/AntiChocolate/AntiChocolateAttack.cs)
- [`PlayerMovement.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Player/Character/PlayerMovement.cs)
- [`PlayerInventory.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Player/Character/PlayerInventory.cs)
- [`PlayerAttack.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Player/Character/PlayerAttack.cs)
- [`AmmoPickup.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Ammo/AmmoPickup.cs)
- [`GameManager.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Game/GameManager.cs)
- [`MainMenu.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Game/MainMenu.cs)
- [`PauseGame.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Game/PauseGame.cs)
- [`MonsterSpawn.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Game/MonsterSpawn.cs)
- [`MonsterAttack.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Monsters/MonsterAttack.cs)
- [`MonsterHealth.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Monsters/MonsterHealth.cs)
- [`MonsterMovement.cs`](https://github.com/peter201943/Snack-Attack/blob/master/Assets/Monsters/MonsterMovement.cs)
- Debug Material
- Animators













## List
- [Discussion](#discussion)
- [Installation](#installation)
- [Contributing](#contributing)
- [Architecture](#architecture)
- [Relevant Snack-Attack Files](#relevant-snack-attack-files)
- [List](#list)
- [Definitions](#definitions)
- [Differentiating the Player Discussion](#differentiating-the-player-discussion)
- [Differentiating the Player Definitions](#differentiating-the-player-definitions)
- [Split Screen Discussion](#split-screen-discussion)
- [Split Screen References List](#split-screen-references-list)
- [Activities Discussion](#activities-discussion)
- [Activities List](#activities-list)
- [3D with 2D Assets Discussion](#3d-with-2d-assets-discussion)
- [Game Names List](#game-names-list)
- [Enemy Sounds Discussion](#enemy-sounds-discussion)
- [Enemy Sounds List](#enemy-sounds-list)
- [On Screen Hints Discussion](#on-screen-hints-discussion)
- [On Screen Hints List](#on-screen-hints-list)
- [Enemy Differentiation List](#enemy-differentiation-list)
- [Ammo Selection Discussion](#ammo-selection-discussion)
- [Ammo Selection List](#ammo-selection-list)
- [Asset Selection Discussion](#asset-selection-discussion)
- [Asset Selection List](#asset-selection-list)
- [Asset Reference List](#asset-reference-list)







## Definitions

### P1
- Player One
- Shooter

### P2
- Player Two
- Movement

### List
- Lists out things as names

### Discussion
- Lists out thoughts on a thing; conversational

### Definitions
- Lists out examples of a thing using subsections







## Differentiating the Player Discussion

### Goals
- Give each of the players
- Unique and Different and Specific
- Tasks, Abilities, Visions
- Want P1 and P2 to spend a significant amount of timing just communicating

### Planning
- Both P1 and P2 need to think about what to do next to react to enemies

### Aiming
- P1 has to aim at specific enemies
- P1 vision is narrow and detailed
- P1 has to choose the right kind of ammo

### Moving
- P2 must move the player around
- P2 vision is broad and peripheral

### Reloading
- P1 must perform

### Dodging
- P2 has to avoid incoming attacks

### Collecting
- P2 has to find more ammo







## Differentiating the Player Definitions

### Unique, Different, Specific
- Unique: Task A is significantly different from Task B
- Different: P1 does Task A, P2 does Task B
- Specific: Task have many steps to make them specific

### Tasks, Abilities, Visions
- Task: Sequence of Actions to fulfill an Ability's Effect
- Ability:
- Vision: What a Player can see/know







## Split Screen Discussion
- Instead of both players seeing the same thing, we can differ what each sees
- Advantage is to tailor their perspective and make their part of the game more specific
- This means hints can be specific, as can tasks







## Split Screen References List
- [Tutorial - Easy Split Screen Camera in Unity using the New Input System](https://www.youtube.com/watch?v=HcP8_dR-kqU)
- [How To Make A Split Screen for Multiplayer in Unity!](https://www.youtube.com/watch?v=DBHLgrR60F0)







## Activities Discussion
- TODO







## Activities List
- TODO







## 3D with 2D Assets Discussion
- TODO







## Game Names List
- Forest Fling
- Zealous Zookeeper







## Enemy Sounds Discussion
- TODO







## Enemy Sounds List
- TODO







## On Screen Hints Discussion
- TODO







## On Screen Hints List
- TODO







## Enemy Differentiation List
- TODO







## Ammo Selection Discussion
- TODO







## Ammo Selection List
- TODO







## Asset Selection Discussion







## Asset Selection List
- TODO







## Asset Reference List

### Music
- [Kevin Macleod](https://incompetech.com/music/royalty-free/)
- Google "royalty free music"

### Topdown Shooter Code
- [TOP DOWN SHOOTING in Unity - YouTube](https://www.youtube.com/watch?v=LNLVOjbrQj4)
- [Unity 3D Top Down Character Controller](https://sharpcoderblog.com/blog/top-down-character-controller-example)

### Forest Models
- [Nature Starter Kit 2](https://assetstore.unity.com/packages/3d/environments/nature-starter-kit-2-52977) FREE

### Assets in General
- [Free Sound](https://freesound.org/)
  - requires time to search and evaluate
- [Open Game Art](https://opengameart.org/)
  - requires time to search and evaluate
- [Itch IO](https://itch.io/game-assets/free)

### Food Sprites

### Food Sounds

### Animal Sprites

### Animal Sounds

### Topdown Shooter Bots
- [Unity Top Down Shooter #5 - Making Enemies](https://www.youtube.com/watch?v=2LQ27NV_bpQ)
- [Unity NavMesh Tutorial - Making it Dynamic](https://www.youtube.com/watch?v=FkLJ45Pt-mY)
- [TopDown AI](https://assetstore.unity.com/packages/templates/topdown-ai-54579)
  - Ready-to-go asset
  - [Linked Tutorial](https://codeartist.mx/hotline-miami/)

### Topdown Shooter Weapons
- (Not needed, we will just use my old projectile code)

### Misc Code
- [How to make a HEALTH BAR in Unity!](https://www.youtube.com/watch?v=BLfNP4Sc_iA)
- [START MENU in Unity](https://www.youtube.com/watch?v=zc8ac_qUXQY)












