



# How to make Body Paint

don't forget to watch, star and share the repository to not miss further instructions. 

## Requirement
- Nice above-average IQ
- basic knowledge of 2D Painting
- basic knowledge of Unity Engine
- Untiy Editor 2018.2.21f
- Photoshop or GIMP
- ###### [hooh Modding Tool Project](https://github.com/hooh-hooah/ModdingTool)

## Steps

### Make A Texture

First, fill whole layer with white and go to channel and make an alpha texture.

Here all all that matters. Alpha channel is the most important thing in order to make a bodypaint/partial pant texture.

 ![image-20200214072029064](D:\ggg\mods\images\image-20200214072029064.png)

### Save Textures with Import

After making textures, place all textures inside of one folder. don't forget to make dummy mod.xml folder. (or use example's one)

![image-20200214072443472](D:\ggg\mods\images\image-20200214072443472.png)

Import Textures with this option. It's very important to apply Transparency on to your texture.

![image-20200214072527660](D:\ggg\mods\images\image-20200214072527660.png)

### Setup mod.xml

Check [this file](https://github.com/hooh-hooah/ModdingTool/blob/release/Assets/%40BODY_PARTS/facepaint/mod.xml) and copy and paste it.

You need to remember that guid, bundle name, build name should be **unique** and you can only refer files in assetbundles in build.xml.

### Pack and Test

Unfortunately, There is no preview tools yet. but since this is just pack of texture, it won't be that messy to work on.

## Troubleshooting

#### SB3Utility Fails

- Failed to find external texture

  Please refer all textures in material file that you're packing with.

- Invalid Index

  Your mod.xml is not including all textures.

#### I can't build my mod!

Check [here](https://github.com/hooh-hooah/ModdingTool#trouble-shooting)
