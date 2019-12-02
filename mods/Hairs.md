# How to make hairs

don't forget to watch, star and share the repository to not miss further instructions. Idaf about stars but people who want to create new hairs need to watch this so yeah.

## Requirement
- Nice above-average IQ
- basic knowledge of 3D Modeling
- basic knowledge of Unity Engine
- 3D Tools like blender or 3dsmax
- Untiy Editor 2018.2.21f
- Photoshop or GIMP
- Latest SB3Utility 

## Prepare

### Import Assets

If you setup your own modding project in unity editor then you need to import assets to get started. 

You can get nice small prepared assets here.

### Prepare Scene

Now you need to prepare your scene

## Repeat

### Test Hairs

![image-20191203003152198](img\image-20191203003152198.png)

Place hair object and adjust and scale the hair mesh to fit on the head. You'll get where to put it when you get the example scenes.

Example scenes contains 5 different example hairs. After setting up the mesh and objects on the head, you need to following things:

- Set hair layer to 10 (A)
- Setup CmpHair.cs
- Setup DynamicBones (you can buy it or do something bad but I purchased one before.)

### Test Textures

set texture has actual transparency in alpha.

### Build Assetbundles

you need to build two assetbundles

- hair asset bundle (name.unity3d)
- hair "texture" asset bundle (name_tex.unity3d)

### Change shaders and assign materials

We don't have hair shader replica atm, so we need to replace the shader to make it work nicely in game. I have example material .unity3d file in here (Click?)

Follow this step.

1. Open Hair Asset Bundle, Hair Texture Asset Bundle, Material Asset Bundle

2. Switch to texture asset bundle and Click all Textures.

3. Switch to material asset bundle and mark for copy 'hairmat'

4. Switch to Hair Asset Bundle and paste hairmat

5. change mesh material to hairmat

6. change material texture

### Add to List

You can add your hair to list by using this template.

### Pack up 

Pack it into sideloader mod!

### Checklist

- Did you marked your prefab and textures in assetbundle?
- Did you added CmpHair Component?
- Did you setup CmpHair properly?
- Did you setup Dynmaic Bones?
- Did you setup Dynamic Bones properly?
- Did you make nice textures?
- Did you changed hair material's shader to ILLUSION's nice hair shader?
- Did you made it into a siderloader mod?

- <u>**Did fucking you re-zipped the mod to update?**</u>

## FAQ

- Bruh dithering
  
  embrace it or make your own shader you coomer
  
- What the hell? I can only use ONE MATERIAL?

  yes and it's not my fault. blame ILLUSION
  
- Do i have to change shader every sigle fucking time?

  atm, yes. Expect me to make new hair shader replica or you can just keep doing it.

## Troubleshooting

- Oh noes, my model's normal is god damn fugly

  Try "Set Normal" in blender.

- Why is my mod is not updating?

  <u>**Did fucking you re-zipped the mod to update?**</u>
  
- Hair texture is not transparent/is flat

  Did you referenced hair texture in prefab assetbundle from list? then please. separate the assetbundle.
