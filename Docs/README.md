# enemy-wave-system

## Requirements
* Generic Object Pooling Repo - www.github.com/laurenlizardo/generic-object-pooling

## Setup

### EnemyPrefab
1. In the Hierarchy, create an empty game object and rename it (ex: EnemyA)
2. In the Inspector with the empty game object selected in the Hierarchy, right-click on the empty game object's Transform component and select Reset
3. In the Hierarchy, right-click on the empty game object and create a 3D game object as a child
4. In the scene, position the 3D game object so that the bottom of the object aligns with the position of the empty game object parent
5. In the Project window, create a new script and name it the same name you gave the 3D object (EnemyA.cs)
6. In a text editor, inherit from the Enemy class rather than MonoBehaviour (ex: public class EnemyA : Enemy)
7. Implement the NextPoolObject method; leave empty for now (ex: public override GameObject NextPoolObject() { })
8. In the Inspector, attach the script to the 3D object
9. Drag the 3D object from the Hierarchy to the Project window to convert it into a prefab (EnemyA.prefab)
10. Remove the 3D object from the scene
11. Repeat for as many enemies or objects as desired

### EnemyPool
1. In the Hierarchy, create an empty game object and rename it (EnemyAPool)
2. In the Inspector with the empty game object selected in the Hierarchy, right-click on the empty game object's Transform component and select Reset
3. In the Project window, create a new script and name it the same name as the empty game object (EnemyAPool.cs)
4. In a text editor, inherit from the GenericObjectPool class (ex: public class EnemyAPool : GenericObjectPool<>)
5. Insert the component you wish to pool as the argument for the inherited class (ex: public class EnemyAPool : GenericObjectPool<EnemyA>)
6. In the Hierarchy, attach the script to the empty game object
7. Repeat for as many enemy or object pools as desired


### WaveFormation
1. In the Hierarchy, create an empty game object and rename it (ex: WaveFormation01)
2. In the Inspector with the empty game object selected in the Hierarchy, right-click on the empty game object's Transform component and select Reset
3. In the Hierarchy, right-click on the empty game object and create empty game object as a child
4. Name the empty game object child (ex: Spawnpoint01)
5. In the scene, place the empty game object child somewhere in the scene for an object to be spawned
6. Repeat 3-5 for as many spawnpoints as desired
7. In the Inspector, attach the WaveFormation component located in the Project window to the empty game object parent in the Hierarchy
8. Drag the empty game object parent from the Hierarchy to the Project window to convert it into a prefab (WaveFormation01.prefab)
9. Remove the empty game object parent from the scene
10. Repeat for as many wave formations as desired

### Wave
1. In the Project window with nothing selected, right-click and select Create New Enemy Wave
2. Rename the Enemy Wave (ex: EnemyWave01.cs)
3. With the Enemy Wave selected in the Project window, fill in the necessary fields
  * Wave Formation - A prefab that contains spawnpoints (retrieve from the Project window)
  * Spawn Delay - The time in seconds between each spawned object
  * Wave Elements - A collection of prefabs to be spawned (retrieve from the Project window)
  Note: Leaving any of these fields empty will cause an exception. Make sure the number of Wave Elements does not exceed the number of Spawnpoints inside the Wave Formation or this too will cause an excpetion.
4. Repeat 1-3 for as many waves as desired


### WaveController
1. In the Hierarchy, create an empty game object and rename it (EnemyWaveController)
2. In the Inspector with the empty game object selected in the Hierarchy, right-click on the empty game object's Transform component and select Reset
3. In the Project window, create a new script  and name it the same name as the empty game object (EnemyWaveController.cs)
4. In a text editor, inherit from the WaveController class (ex: public class EnemyWaveController : WaveController<>)
5. Insert the class you wish to spawn as the argument for the inherited class (ex: public class EnemyWaveController : WaveController<EnemyWave>)
6. Implement the coroutine SpawnWave from WaveController (see the provided EnemyWaveController as an example)
7. For testing purposes, add the Update function and call the coroutine SpawnWave() everytime a key is pressed down
8. In the Inspector, add the WaveController component to the empty game object
9. With the empty game object selected in the Hierarchy, fill in the necessary fields
  * Enemy Waves/Size - The amount of waves desired
  * Element n - The list of waves to occur in order