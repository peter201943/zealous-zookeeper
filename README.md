







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
- [GitHub Repository at **Zealous Zookeeper**](https://github.com/peter201943/zealous-zookeeper)









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


