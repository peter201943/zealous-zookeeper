







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






## Licensing
- See each asset's respective `LICENSE` file
- Any code created for this project is MIT licensed






## Image Credits

### [Animal Pack Redux](https://kenney.nl/assets/animal-pack-redux)
- Sprites (Image)
- [Kenney Game Assets](https://kenney.nl/)
- [CC0 1.0 Universal License](https://creativecommons.org/publicdomain/zero/1.0/)

### [Fish Pack](https://kenney.nl/assets/fish-pack)
- Sprites (Image)
- [Kenney Game Assets](https://kenney.nl/)
- [CC0 1.0 Universal License](https://creativecommons.org/publicdomain/zero/1.0/)

### [Fruit icons redo](https://opengameart.org/content/fruit-icons-redo)
- Sprites (Image)
- [Game Developer Studio](https://opengameart.org/users/game-developer-studio)
- [CC-BY 3.0 License](http://creativecommons.org/licenses/by/3.0/)

### [Toon Characters 1](https://kenney.nl/assets/toon-characters-1)
- Sprites (Image)
- [Kenney Game Assets](https://kenney.nl/)
- [CC0 1.0 Universal License](https://creativecommons.org/publicdomain/zero/1.0/)
- ADDME






## Audio Credits

### [Le Grand Chase](https://incompetech.filmmusic.io/song/4670-le-grand-chase)
- Looped-Audio
- [Kevin MacLeod](https://incompetech.filmmusic.io/artists/kevin-macleod)
- [Simplified Filmmusic.io Standard License](https://incompetech.filmmusic.io/standard-license)

### [Run Amok](https://incompetech.filmmusic.io/song/4311-run-amok)
- Looped-Audio
- [Kevin MacLeod](https://incompetech.filmmusic.io/artists/kevin-macleod)
- [Simplified Filmmusic.io Standard License](https://incompetech.filmmusic.io/standard-license)
- ADDME







## Sound Credits

### [Creature Sounds » Monkey Imitation 1](https://freesound.org/people/AntumDeluge/sounds/417817/)
- Oneshot-Audio
- [AntumDeluge](https://freesound.org/people/AntumDeluge/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Monkey.Spawn()`
- File Name `MonkeySpawn.ogg`
- ADDME

### [Monkeyz » Gorillaschrei.wav](https://freesound.org/people/J0ck0/sounds/397054/)
- Oneshot-Audio
- [J0ck0](https://freesound.org/people/J0ck0/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Monkey.Attack()`
- File Name `MonkeyAttack.ogg`
- ADDME

### [Throw/Swipe](https://freesound.org/people/mrickey13/sounds/515625/)
- Oneshot-Audio
- [mrickey13](https://freesound.org/people/mrickey13/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Player.Attack()`
- File Name `PlayerAttack.ogg`
- ADDME

### [Generic Jungle, Costa Rica#1.wav](https://freesound.org/people/TRAVELcandies/sounds/423398/)
- Looped-Audio
- [TRAVELcandies](https://freesound.org/people/TRAVELcandies/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Forest.Spawn()`
- File Name `ForestSpawn.ogg`
- ADDME

### [TEC Bird Chirps and Phrases » brd_hawk.wav](https://freesound.org/people/tec_studio/sounds/362426/)
- Oneshot-Audio
- [tec_studio](https://freesound.org/people/tec_studio/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Eagle.Attack()`
- File Name `EagleAttack.ogg`
- ADDME

### [Eagle Cry.wav](https://freesound.org/people/kaydinhamby/sounds/381200/)
- Oneshot-Audio
- [kaydinhamby](https://freesound.org/people/kaydinhamby/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Eagle.Spawn()`
- File Name `EagleSpawn.ogg`
- ADDME

### [Bird Flaps » BirdFlap2.wav](https://freesound.org/people/AgentDD/sounds/246224/)
- Oneshot-Audio
- [AgentDD](https://freesound.org/people/AgentDD/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Eagle.Move()`
- File Name `EagleMoveOnce.ogg`
- ADDME

### [video game » Angry Ram](https://freesound.org/people/ReadeOnly/sounds/186921/)
- Oneshot-Audio
- [ReadeOnly](https://freesound.org/people/ReadeOnly/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Deer.Attack()`
- File Name `DeerAttack.ogg`
- ADDME

### [GrassSteps.wav](https://freesound.org/people/The120thwhisper/sounds/463852/)
- Oneshot-Audio
- [The120thwhisper](https://freesound.org/people/The120thwhisper/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Deer.Move()`, `Player.Move()`, `Bear.Move()`, `Monkey.Move()`
- File Name `GroundMove.ogg`
- ADDME

### [Crow Caw](https://freesound.org/people/josepharaoh99/sounds/361470/)
- Oneshot-Audio
- [josepharaoh99](https://freesound.org/people/josepharaoh99/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Eagle.DeSpawn()`
- File Name `EagleDeSpawn.ogg`
- ADDME

### [For players » Die8.wav](https://freesound.org/people/Far_Box_creature/sounds/469567/)
- Oneshot-Audio
- [Far_Box_creature](https://freesound.org/people/Far_Box_creature/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Player.DeSpawn()`
- File Name `PlayerDeSpawn.ogg`
- ADDME

### [Sounds of random » Cartoon Boing.wav](https://freesound.org/people/reelworldstudio/sounds/161122/)
- Oneshot-Audio
- [reelworldstudio](https://freesound.org/people/reelworldstudio/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Rabbit.Move()`
- File Name `RabbitMove.ogg`
- ADDME

### [angry-squirrel1.wav](https://freesound.org/people/echobones/sounds/122261/)
- Oneshot-Audio
- [echobones](https://freesound.org/people/echobones/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Rabbit.Spawn()`
- File Name `RabbitSpawn.ogg`
- ADDME

### [Beast Snarling](https://freesound.org/people/Christopherderp/sounds/342204/)
- Oneshot-Audio
- [Christopherderp](https://freesound.org/people/Christopherderp/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Bear.Spawn()`
- File Name `BearSpawn.ogg`
- ADDME

### [GrowlSnarl.wav](https://freesound.org/people/Jamius/sounds/41526/)
- Oneshot-Audio
- [Jamius](https://freesound.org/people/Jamius/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Bear.Attack()`
- File Name `BearAttack.ogg`
- ADDME

### [Animal » Animal_Snarl_1.wav](https://freesound.org/people/D001447733/sounds/464596/)
- Oneshot-Audio
- [D001447733](https://freesound.org/people/D001447733/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Rabbit.Attack()`
- File Name `RabbitAttack.ogg`
- ADDME

### [Monster 4.wav](https://freesound.org/people/Sea%20Fury/sounds/48688/)
- Oneshot-Audio
- [Sea Fury](https://freesound.org/people/Sea%20Fury/)
- [CC-BY 3.0](http://creativecommons.org/licenses/by-nc/3.0/)
- Used By `Bear.DeSpawn()`
- File Name `BearDeSpawn.ogg`
- ADDME

### [ TheBigSqueak » The Big Squeak (8) Break ](https://freesound.org/people/Fantozzi/sounds/214874/)
- Oneshot-Audio
- [Fantozzi](https://freesound.org/people/Fantozzi/)
- [CC-0 1.0 Universal License](http://creativecommons.org/publicdomain/zero/1.0/)
- Used By `Rabbit.DeSpawn()`
- File Name `RabbitDeSpawn.ogg`
- ADDME



