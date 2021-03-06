This tutorial will be updated soon

# How to make Studio Mods

## Basic Requirement

- Nice above-average IQ
- basic knowledge of 3D Modeling
- basic knowledge of Unity Editor
- 3D Tools like blender or 3dsmax
- Untiy Editor 2018.2.21f
- Photoshop or GIMP
- [hooh Modding Tool Project](https://github.com/hooh-hooah/ModdingTool)

## Steps

### Prepare GameObjects

##### Put Everything on the scene.

![image-20200101045012558](./images/image-20200101045012558.png)

##### Adjust Transform

Everything should be in Position 0,0,0 and since AI shoujo's scale is weirdly big so you need to scale it about 5-9 times larger than original. Check `Asset/Character Scale Measurement` to check the size of your asset.

![image-20200101045057896](./images/image-20200101045057896.png)

##### Go to folder to make mod.xml 

![image-20200101045148819](./images/image-20200101045148819.png)

##### Process GameObject

Root gameobject should be Position 0,0,0 and Rotation 0,0,0 and Scale 1,1,1 or the scaling will not get applied

Wrapping gameobject will be pain in the ass if you do that all by hands so we'll use tool's feature, Wrap Object with new GameObject.

![image-20200101045206224](./images/image-20200101045206224.png)

![image-20200101045239133](./images/image-20200101045239133.png)

##### Make Everything in Layer 11 (Map)

![image-20200101044239224](./images/image-20200101044239224.png)

Everything should be in Layer 11 to get properly lighted in-game. 

### Register as Prefab

You can register prefabs by drag and drop but that will be so annoying to do.

Let's go with one button solution, Create Prefab from Selected Objects.

![image-20200101045308402](./images/image-20200101045308402.png)

![image-20200101045331260](./images/image-20200101045331260.png)

### Make mod.xml

Make your own mod.xml. Here is [example](https://github.com/hooh-hooah/ModdingTool/blob/master/Assets/%40MAPS/ExampleStudioItems/modbuilder/mod.xml)

You can easily generate items and assets list with Element Generator and put them in like an example above. The result will be generated in generated.txt

![image-20200101045735600](./images/image-20200101045735600.png)

![image-20200101045817869](./images/image-20200101045817869.png)

### Build Mod

![image-20200101043650642](./images/image-20200101043650642.png)

Specify Zipmod Destination and click build Studio Mod.

Remember, you need to install [Bandizip](https://kr.bandisoft.com/bandizip/) in C: Drive at this moment to pack zipmods. I will change this later.

### Test In-Game

Test your clothes working in-game.

### Trouble Shooting

#### I can't build my mod!

Check [here](https://github.com/hooh-hooah/ModdingTool#trouble-shooting)

#### I can't see my mod.

Check if your id and name is properly named. or Check [here](https://github.com/hooh-hooah/ModdingTool#trouble-shooting)

#### Items does not takes any lightings

Check if the map is in Layer 11 (Map)

#### I can't color them!

It's normal. I'll give you another instructions soon.
